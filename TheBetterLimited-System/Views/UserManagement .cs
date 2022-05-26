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

        public UserManagement()
        {
            InitializeComponent();
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
                Usermanagement_Edit usa = new Usermanagement_Edit(UserDataGrid["id", e.RowIndex].Value.ToString());
                usa.Show();
            }

            if (e.ColumnIndex == UserDataGrid.Columns["delete"].Index)
            {
                DeleteAccount(e);
            }
        }

        private void SearchBarTxt_Enter(object sender, EventArgs e)
        {
            if (this.SearchBarTxt.Texts == "Search")
            {
                SearchBarTxt.Texts = "";
            }
            this.SearchBarTxt.ForeColor = Color.Black;
        }

        private void SearchBarTxt_Leave(object sender, EventArgs e)
        {
            this.SearchBarTxt.ForeColor = Color.LightGray;
            if (this.SearchBarTxt.Texts == "")
            {
                SearchBarTxt.Texts = "Search";
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

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            UserDataGrid.AutoGenerateColumns = false;
            UserDataGrid.DataSource = bs;
            UserDataGrid.Columns["id"].HeaderText = "ID";
            UserDataGrid.Columns["userName"].HeaderText = "User Name";
            UserDataGrid.Columns["staffName"].HeaderText = "Staff Name";
            UserDataGrid.Columns["emailAddress"].HeaderText = "Email Address";
            UserDataGrid.Columns["status"].HeaderText = "Status";
            UserDataGrid.Columns["_staffId"].HeaderText = "Staff ID";
            UserDataGrid.Columns["remarks"].HeaderText = "Remark";

            for (int i = 0; i < UserDataGrid.RowCount; i++)
                UserDataGrid["select", i].Tag = 0;

            selecteUserId.Clear();
        }

        //Get Account
        public void GetAccount()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
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
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(result.Content, (typeof(DataTable)));
                bs.DataSource = dataTable;
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
                            res = result.Content;
                            Console.WriteLine(res);
                            if (res == "\"" + uid + "\"")
                                countDeleted++;
                        }
                        MessageBox.Show("The " + countDeleted + " account(s) have been deleted!", "Delete Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
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
                        string res = JObject.Parse(result.Content).ToString();
                        MessageBox.Show("The " + res + " have been deleted!", "Delete Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete the account", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Usermanagement_Add userAdd = new Usermanagement_Add();
            userAdd.Show();
            userAdd.OnExit += GetAccount;
        }
    }
}
