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
        public UserManagement()
        {
            InitializeComponent();
            GetAccount();//init user table
        }

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

            for(int i=0;i< UserDataGrid.RowCount;i++)
                UserDataGrid["select", i].Tag = 0;
        }

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
            Console.WriteLine(UserDataGrid.SelectedRows.Count);
            foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
            {
                try
                {
                    UserDataGrid.Rows.Remove(row);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Cannot delete the new line", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

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
                }
                else
                {
                    UserDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    UserDataGrid["select", e.RowIndex].Tag = 0;
                    UserDataGrid.Rows[e.RowIndex].Selected = false;
                    Console.WriteLine("unchecked");
                }
            }

            if (e.ColumnIndex == UserDataGrid.Columns["lockAcc"].Index)
            {
                DialogResult choose;
                if (Convert.ToInt32(UserDataGrid["lockAcc", e.RowIndex].Tag) == 1)
                {
                    //unlock account
                    choose = MessageBox.Show("Do you really want to unlock the " + UserDataGrid["userName", e.RowIndex].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choose == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                        {
                            try
                            {
                                uc.UnlockAccount((string)UserDataGrid["id", row.Index].Value);
                                MessageBox.Show("The " + UserDataGrid.SelectedRows.Count + "account(s) have been unlocked!", "Unlock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetAccount();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Cannot unlock the account(s)", "Unlock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
                else
                {
                    // lock account
                    choose = MessageBox.Show("Do you really want to lock the " + UserDataGrid.Rows[e.RowIndex].Cells["userName"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (choose == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                        {
                            try
                            {
                                uc.LockAccount((string)UserDataGrid["id", row.Index].Value);
                                MessageBox.Show("The " + UserDataGrid.SelectedRows.Count + "account(s) have been locked!", "Lock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetAccount();
                            }
                            catch (InvalidOperationException ex)
                            {
                                MessageBox.Show("Cannot connect to the server", "Lock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }

            }

            if (e.ColumnIndex == UserDataGrid.Columns["edit"].Index)
            {
                foreach (DataGridRow row in UserDataGrid.SelectedRows)
                {

                    MessageBox.Show("You have selected row " + row + " cell");
                }

            }

            if (e.ColumnIndex == UserDataGrid.Columns["delete"].Index)
            {
                UserDataGrid.Rows.RemoveAt(e.RowIndex);
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

        /**
         * search bar text changed event
         */
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetAccount();
        }

        /**
         * Get 
         */
        private void GetAccount()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                bs.DataSource = uc.GetAllAccount();
            }
            else
            {
                string str = "_StaffId:" + this.SearchBarTxt.Texts + "|emailAddress:" + this.SearchBarTxt.Texts
                            + "|userName:" + this.SearchBarTxt.Texts + "|emailAddress:" + this.SearchBarTxt.Texts;
                bs.DataSource = uc.GetSpecificAccount(str);
            }
            UserDataGrid.DataSource = bs;
            InitializeDataGridView();
        }
    }
}
