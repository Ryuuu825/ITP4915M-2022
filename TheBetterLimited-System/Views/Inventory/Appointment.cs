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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Appointment : Form
    {
        private UserController uc = new UserController();
        private BindingSource bs = new BindingSource();
        private List<string> selectAppointmentID = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private ControllerBase cbAppointment = new ControllerBase("_Appointment");

        public Appointment()
        {
            InitializeComponent();
            GetGoods();//init user table
        }

        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedGoods();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetGoods();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoodsDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AppointmentDataGrid.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value.ToString().Equals("0"))
                {
                    e.Value = "Selling";
                }
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "PhasingOut";
                }
                if (e.Value.ToString().Equals("2"))
                {
                    e.Value = "StopSelling";
                }
            }

            if (AppointmentDataGrid.Columns[e.ColumnIndex].Name == "Size")
            {

                if (e.Value.ToString().Equals("0"))
                {
                    e.Value = "Small";
                }
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "Medium";
                }
                if (e.Value.ToString().Equals("2"))
                {
                    e.Value = "Large";
                }
            }

        }

        private void GoodsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AppointmentDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(AppointmentDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    AppointmentDataGrid["select", e.RowIndex].Value = Properties.Resources.check;
                    AppointmentDataGrid["select", e.RowIndex].Tag = 1;
                    AppointmentDataGrid.Rows[e.RowIndex].Selected = true;
                    selectAppointmentID.Add(AppointmentDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    AppointmentDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    AppointmentDataGrid["select", e.RowIndex].Tag = 0;
                    AppointmentDataGrid.Rows[e.RowIndex].Selected = false;
                    selectAppointmentID.Remove(AppointmentDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == AppointmentDataGrid.Columns["edit"].Index)
            {
                MessageBox.Show("You have selected row " + selectAppointmentID[0] + " cell");
            }

            if (e.ColumnIndex == AppointmentDataGrid.Columns["delete"].Index)
            {
                DeleteGoods(e);
            }

        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetGoods();
        }


        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            AppointmentDataGrid.AutoGenerateColumns = true;
            AppointmentDataGrid.DataSource = bs;

            for (int i = 0; i < AppointmentDataGrid.RowCount; i++)
                AppointmentDataGrid["select", i].Tag = 0;

            selectAppointmentID.Clear();
        }

        //Get Goods
        private void GetGoods()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                result = cbAppointment.GetAll();
            }
            else
            {
                string str = "appointmentId:" + this.SearchBarTxt.Texts
                            + "|status:" + this.SearchBarTxt.Texts;
                result = cbAppointment.GetByQueryString(str);
            }
            try
            {
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(result.Content, (typeof(DataTable)));
                var res = JArray.Parse(result.Content.ToString());
                int index = 0;
                bs.DataSource = dataTable;
                AppointmentDataGrid.AutoGenerateColumns = false;
                AppointmentDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Delete Selected Goods
        private void DeleteSelectedGoods()
        {
            if (selectAppointmentID.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to delete the " + selectAppointmentID.Count + " goods?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        int countDeleted = 0;
                        string res;
                        foreach (string uid in selectAppointmentID)
                        {
                            result = cbAppointment.Delete(uid);
                        }
                        MessageBox.Show(selectAppointmentID.Count + " records have been deleted!", "Delete Goods Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetGoods();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete the goods.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("You had not selected a goods.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }

        //Delete Goods
        private void DeleteGoods(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + AppointmentDataGrid.Rows[e.RowIndex].Cells["name"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    result = cbAppointment.Delete(AppointmentDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The " + AppointmentDataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString() + " have been deleted!", "Delete Goods Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetGoods();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete the goods", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void curdAction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            DeliveryDatePicker.MinDate = new DateTime(DateTime.Now.Year,1,1);
            DeliveryDatePicker.MaxDate = DateTime.Now.AddDays(29);
            DeliveryDatePicker.Value = DateTime.Now;
        }
    }
}
