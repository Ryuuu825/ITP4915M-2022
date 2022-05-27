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
    public partial class Setting : Form
    {
        private UserController uc = new UserController();
        private BindingSource bs = new BindingSource();
        public Setting ()
        {
            InitializeComponent();
            bs.DataSource = uc.GetAllAccount();
            InitializeDataGridView();
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
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            UserDataGrid.ReadOnly = false;
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
            Console.WriteLine(UserDataGrid.SelectedRows);
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
            if (e.ColumnIndex == UserDataGrid.ColumnCount - 2)
            {
                
            }

            if (e.ColumnIndex == UserDataGrid.ColumnCount-1)
            {
                this.UserDataGrid.Rows.RemoveAt(e.RowIndex);
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

        private void LockBtn_Click(object sender, EventArgs e)
        {
            var choose = MessageBox.Show("Do you really want to lock the " + UserDataGrid.SelectedRows.Count + " account(s)?", "Confirmation Request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(choose == DialogResult.Yes) 
            { 
                foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                {
                    try
                    {
                        uc.LockAccount((string)UserDataGrid["id", row.Index].Value);
                        bs.DataSource = uc.GetAllAccount();
                        UserDataGrid.DataSource = bs;
                        InitializeDataGridView();
                        MessageBox.Show("The account(s) have been locked!", "Lock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Cannot connect to the server", "Lock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            var choose = MessageBox.Show("Do you really want to unlock the " + UserDataGrid.SelectedRows.Count + " account(s)?", "Confirmation Request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (choose == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in UserDataGrid.SelectedRows)
                {
                    try
                    {
                        uc.UnlockAccount((string)UserDataGrid["id", row.Index].Value);
                        bs.DataSource = uc.GetAllAccount();
                        UserDataGrid.DataSource = bs;
                        InitializeDataGridView();
                        MessageBox.Show("The account(s) have been unlocked!", "Unlock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot unlock the account(s)", "Unlock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            string str = "id:"+ this.SearchBarTxt.Texts + "|userName:" + this.SearchBarTxt.Texts + "|emailAddress:" + this.SearchBarTxt.Texts;
            Console.WriteLine(str);
            if(this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                bs.DataSource = uc.GetAllAccount();
            }else
            {
                bs.DataSource = uc.GetAccountByQry(str);
            }
            UserDataGrid.DataSource = bs;
            InitializeDataGridView();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
