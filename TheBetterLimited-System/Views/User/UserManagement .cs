using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.Models;

namespace TheBetterLimited.Views
{
    public partial class UserManagement : Form
    {
        private UserController uc = new UserController();
        private BindingSource bs = new BindingSource();
        private List<string> selecteUserId = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private bool isEditing = false;
        private DataTable dataTable = new DataTable();

        public UserManagement()
        {
            InitializeComponent();
            InitialzeDataTable();
            GetAccount();//init user table
        }

        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedAccount();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetAccount();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (UserDataGrid.Columns[e.ColumnIndex].Name == "status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (e.Value.Equals("L"))
                {
                    e.Value = "Locked";
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                    UserDataGrid.Columns[e.ColumnIndex].ToolTipText = "Unlock";
                    UserDataGrid.Rows[e.RowIndex].Cells["lockAcc"].Value = Properties.Resources.unlock;
                    UserDataGrid.Rows[e.RowIndex].Cells["lockAcc"].Tag = 1;
                }
                else
                {
                    e.Value = "Normal";
                    e.CellStyle.ForeColor = Color.SeaGreen;
                }

            }
        }

        private void UserDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UserDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(UserDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    UserDataGrid["select", e.RowIndex].Value = Properties.Resources.check;
                    UserDataGrid["select", e.RowIndex].Tag = 1;
                    UserDataGrid.Rows[e.RowIndex].Selected = true;
                    selecteUserId.Add(UserDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    UserDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    UserDataGrid["select", e.RowIndex].Tag = 0;
                    UserDataGrid.Rows[e.RowIndex].Selected = false;
                    selecteUserId.Remove(UserDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == UserDataGrid.Columns["lockAcc"].Index)
            {
                DivideLockAccount(e);
            }

            if (e.ColumnIndex == UserDataGrid.Columns["edit"].Index)
            {
                Form EditUser = Application.OpenForms["Usermanagement_Edit"];
                if (EditUser != null)
                {
                    EditUser.Close();
                }
                Usermanagement_Edit usa = new Usermanagement_Edit();
                usa._uid = UserDataGrid["id", e.RowIndex].Value.ToString();
                usa.Show();
                usa.TopLevel = true;
                usa.OnExit += GetAccount;

            }

            if (e.ColumnIndex == UserDataGrid.Columns["delete"].Index)
            {
                DeleteAccount(e);
            }
        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetAccount();
        }


        /*
        * Dom Event Handler
        */
        //Initialize DataTable
        private void InitialzeDataTable()
        {
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("userName");
            dataTable.Columns.Add("staffName");
            dataTable.Columns.Add("emailAddress");
            dataTable.Columns.Add("status");
            dataTable.Columns.Add("_StaffId");
            dataTable.Columns.Add("remarks");
        }


        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            UserDataGrid.AutoGenerateColumns = false;
            UserDataGrid.DataSource = bs;
            /*UserDataGrid.Columns["id"].HeaderText = "ID";
            UserDataGrid.Columns["userName"].HeaderText = "User Name";
            UserDataGrid.Columns["staffName"].HeaderText = "Staff Name";
            UserDataGrid.Columns["emailAddress"].HeaderText = "Email Address";
            UserDataGrid.Columns["status"].HeaderText = "Status";
            UserDataGrid.Columns["_staffId"].HeaderText = "Staff ID";
            UserDataGrid.Columns["remarks"].HeaderText = "Remark";*/

            for (int i = 0; i < UserDataGrid.RowCount; i++)
                UserDataGrid["select", i].Tag = 0;

            selecteUserId.Clear();
        }

        //Get Account
        public void GetAccount()
        {
            dataTable.Clear();
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                result = uc.GetAllAccount();
            }
            else
            {
                string str = "_StaffId:" + this.SearchBarTxt.Texts + "|emailAddress:" + this.SearchBarTxt.Texts
                            + "|userName:" + this.SearchBarTxt.Texts + "|status:" + this.SearchBarTxt.Texts;
                result = uc.GetAccountByQry(str);
            }
            try
            {
                var data = JArray.Parse(result.Content.ToString());
                foreach (var rowData in data)
                {
                    var row  = dataTable.NewRow();
                    row["id"] = rowData["id"].ToString();
                    row["userName"] = rowData["userName"].ToString();
                    row["staffName"] = rowData["staff"]["firstName"].ToString() + " "+ rowData["staff"]["lastName"].ToString();
                    row["emailAddress"] = rowData["emailAddress"].ToString();
                    row["status"] = rowData["status"].ToString();
                    row["_StaffId"] = rowData["_StaffId"].ToString();
                    row["remarks"] = rowData["remarks"].ToString();
                    dataTable.Rows.Add(row);
                }
                bs.DataSource = dataTable;
                UserDataGrid.AutoGenerateColumns = false;
                UserDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Divide between lock and unlock account
        private void DivideLockAccount(DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(UserDataGrid["lockAcc", e.RowIndex].Tag) == 1)
            {
                //unlock account
                UnlockAccount(e);
            }
            else
            {
                // lock account
                LockAccount(e);
            }
        }

        //Lock Account
        private void LockAccount(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to lock the " + UserDataGrid["userName", e.RowIndex].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    string res = "";
                    result = uc.LockAccount((string)UserDataGrid["id", e.RowIndex].Value);
                    if (result != null)
                    {
                        MessageBox.Show("The " + UserDataGrid["id", e.RowIndex].Value + " account have been locked!", "lock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot lock the account", "Lock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Unlock Account
        private void UnlockAccount(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to unlock the " + UserDataGrid["userName", e.RowIndex].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    string res = "";
                    result = uc.UnlockAccount((string)UserDataGrid["id", e.RowIndex].Value);
                    if (result != null)
                    {
                        MessageBox.Show("The " + UserDataGrid["id", e.RowIndex].Value + " account have been unlocked!", "Unlock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot unlock the account.", "Unlock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Delete Selected Account
        private void DeleteSelectedAccount()
        {
            if (selecteUserId.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to delete the " + selecteUserId.Count + " account(s)?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        int countDeleted = 0;
                        string res;
                        foreach (string uid in selecteUserId)
                        {
                            result = uc.DeleteAccount(uid);
                        }
                        MessageBox.Show("The " + selecteUserId.Count + " account(s) have been deleted!", "Delete Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete the account.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("You had not selected a user account.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }

        //Delete Account
        private void DeleteAccount(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + UserDataGrid.Rows[e.RowIndex].Cells["userName"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    result = uc.DeleteAccount(UserDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (result != null)
                    {
                        string res = result.Content;
                        MessageBox.Show("The user " + res + " have been deleted!", "Delete Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Cannot delete the account", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form addUser = Application.OpenForms["Usermanagement_Add"];
            if (addUser == null || addUser.IsDisposed)
            {
                Usermanagement_Add userAdd = new Usermanagement_Add();
                userAdd.Show();
                userAdd.TopLevel = true;
                userAdd.OnExit += GetAccount;
            }
            else
            {
                addUser.Activate();
                addUser.WindowState = FormWindowState.Normal;
            }

        }

    }
}
