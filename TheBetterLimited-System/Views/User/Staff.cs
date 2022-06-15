using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited.Utils;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Staff : Form
    {
        private UserController uc = new UserController();
        private BindingSource bs = new BindingSource();
        private List<string> selectStaffID = new List<string>();
        private List<JObject> staffList = new List<JObject>();
        private DialogResult choose;
        private RestResponse response;
        private ControllerBase cbStaff = new ControllerBase("Staff");
        private DataTable dataTable = new DataTable();

        public Staff()
        {
            InitializeComponent();
            InitialzeDataTable();
            GetStaff();
        }

        /*
         * Dom Style/Event Process
         */
        private void InitialzeDataTable()
        {
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("firstName");
            dataTable.Columns.Add("lastName");
            dataTable.Columns.Add("department");
            dataTable.Columns.Add("gender");
            dataTable.Columns.Add("position");
            dataTable.Columns.Add("phone");
            dataTable.Columns.Add("age");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedStaff();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetStaff();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (StaffDataGrid.Columns[e.ColumnIndex].Name == "gender")
            {
                if (e.Value.ToString().Equals("F"))
                {
                    e.Value = "Female";
                }else
                {
                    e.Value = "Male";
                }
            }
            if(StaffDataGrid.Columns[e.ColumnIndex].Name == "Position")
            {
                var reg = @"(?=[A-Z])";
                var status = Regex.Split(e.Value.ToString(), reg);
                var value = "";
                foreach (var item in status)
                {
                    value = item;
                }
                e.Value = value;
            }
        }

        private void StaffDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StaffDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(StaffDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    StaffDataGrid["select", e.RowIndex].Value = Properties.Resources.check;
                    StaffDataGrid["select", e.RowIndex].Tag = 1;
                    StaffDataGrid.Rows[e.RowIndex].Selected = true;
                    selectStaffID.Add(StaffDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    StaffDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    StaffDataGrid["select", e.RowIndex].Tag = 0;
                    StaffDataGrid.Rows[e.RowIndex].Selected = false;
                    selectStaffID.Remove(StaffDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == StaffDataGrid.Columns["edit"].Index)
            {
                Staff_Edit editStaff = new Staff_Edit(staffList[e.RowIndex]);
                editStaff.Show();
                editStaff.OnExit += () => GetStaff();
            }

            if (e.ColumnIndex == StaffDataGrid.Columns["delete"].Index)
            {
                DeleteStaff(e);
            }

        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetStaff();
        }


        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            StaffDataGrid.AutoGenerateColumns = false;
            StaffDataGrid.DataSource = bs;

            for (int i = 0; i < StaffDataGrid.RowCount; i++)
                StaffDataGrid["select", i].Tag = 0;

            selectStaffID.Clear();
        }

        //Get Staff
        private void GetStaff()
        {
            dataTable.Clear();
            staffList.Clear();
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                response = cbStaff.GetAll();
            }
            else
            {
                string str = "id:" + this.SearchBarTxt.Texts
                            + "|FirstName:" + this.SearchBarTxt.Texts + "|LastName:" + this.SearchBarTxt.Texts
                            + "|Sex:" + this.SearchBarTxt.Texts;
                response = cbStaff.GetByQueryString(str);
            }
            try
            {
                JArray orders = JArray.Parse(response.Content);
                foreach (JObject s in orders)
                {
                    staffList.Add(s);
                    var row = dataTable.NewRow();
                    row["id"] = s["Id"].ToString();
                    row["firstName"] = s["FirstName"].ToString();
                    row["lastName"] = s["LastName"].ToString();
                    DepartmentEnum departmentEnum = ((DepartmentEnum)Convert.ToInt32(s["_departmentId"].ToString()));
                    row["department"] = departmentEnum;
                    row["gender"] = s["Sex"].ToString();
                    PositionEnum positionEnum = ((PositionEnum)Convert.ToInt32(s["_positionId"].ToString()));
                    row["position"] = positionEnum;
                    row["phone"] = s["Phone"].ToString();
                    row["age"] = s["Age"].ToString();
                    dataTable.Rows.Add(row);
                }
                bs.DataSource = dataTable;
                StaffDataGrid.AutoGenerateColumns = false;
                StaffDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Delete Selected Staff
        private void DeleteSelectedStaff()
        {
            if (selectStaffID.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to delete the " + selectStaffID.Count + " Staff?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        int countDeleted = 0;
                        string res;
                        foreach (string uid in selectStaffID)
                        {
                            response = cbStaff.Delete(uid);
                        }
                        MessageBox.Show(selectStaffID.Count + " records have been deleted!", "Delete Staff Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetStaff();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete the staff.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("You had not selected a staff.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }

        //Delete Staff
        private void DeleteStaff(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + StaffDataGrid.Rows[e.RowIndex].Cells["id"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    response = cbStaff.Delete(StaffDataGrid["id", e.RowIndex].Value.ToString());
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The " + StaffDataGrid["id", e.RowIndex].Value.ToString() + " is deleted",  "Delete Staff Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    GetStaff();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Cannot delete the staff", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Staff_Add staffAdd = new Staff_Add();
            staffAdd.OnExit += () => GetStaff();
            staffAdd.Show();
        }
        
    }
}
