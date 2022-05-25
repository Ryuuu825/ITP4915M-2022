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
        public UserManagement()
        {
            InitializeComponent();
            GetAccount();//init user table
        }

        /*
         * Dom Style/Event Process
         */
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            UserDataGrid.ReadOnly = true;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserDataGrid.ReadOnly = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedAccount();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
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
                MessageBox.Show("You have selected row " + selecteUserId[0] + " cell");
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
        }

        //Get Account
        private void GetAccount()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                bs.DataSource = uc.GetAllAccount();
            }
            else
            {
                string str = "_StaffId:" + this.SearchBarTxt.Texts + "|emailAddress:" + this.SearchBarTxt.Texts
                            + "|userName:" + this.SearchBarTxt.Texts + "|status:" + this.SearchBarTxt.Texts;
                bs.DataSource = uc.GetSpecificAccount(str);
            }
            UserDataGrid.DataSource = bs;
            InitializeDataGridView();
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
        private void LockAccount(DataGridViewCellEventArgs e) {
            choose = MessageBox.Show("Do you really want to unlock the " + UserDataGrid["userName", e.RowIndex].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                {
                    try
                    {
                        uc.UnlockAccount((string)UserDataGrid["id", row.Index].Value);
                        MessageBox.Show("The " + UserDataGrid.Rows[e.RowIndex].Cells["userName"].Value + "account have been unlocked!", "Unlock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot unlock the account(s)", "Unlock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        //Unlock Account
        private void UnlockAccount(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to unlock the " + UserDataGrid["userName", e.RowIndex].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                {
                    try
                    {
                        uc.UnlockAccount((string)UserDataGrid["id", row.Index].Value);
                        MessageBox.Show("The " + UserDataGrid.Rows[e.RowIndex].Cells["userName"].Value + " account have been unlocked!", "Unlock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot unlock the account(s)", "Unlock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        //Delete Selected Account
        private void DeleteSelectedAccount()
        {
            if (selecteUserId.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to lock the " + selecteUserId.Count + " account(s)?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        foreach (string uid in selecteUserId)
                        {
                            uc.DeleteAccount(uid);
                        }
                        MessageBox.Show("The " + selecteUserId.Count + " account(s) have been deleted!", "Delete Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAccount();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Cannot delete the new line", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    uc.DeleteAccount(UserDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    MessageBox.Show("The " + UserDataGrid.Rows[e.RowIndex].Cells["userName"].Value + " have been deleted!", "Delete Account Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    GetAccount();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Cannot delete the new line", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Usermanagement_Add userAdd = new Usermanagement_Add();
            userAdd.Show();
        }
    }
}
