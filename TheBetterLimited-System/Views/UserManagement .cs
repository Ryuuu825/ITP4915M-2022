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
            bs.DataSource = uc.GetAllAccount();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            /**
             * Select column
             */
            DataGridViewImageColumn dvSelect = new DataGridViewImageColumn();
            dvSelect.Width = 6;
            dvSelect.Image = Properties.Resources.square_free_icon_font;
            dvSelect.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dvSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            UserDataGrid.Columns.Add(dvSelect);

            UserDataGrid.AutoGenerateColumns = true;
            UserDataGrid.DataSource = bs;
            UserDataGrid.Columns["id"].HeaderText = "ID";
            UserDataGrid.Columns["userName"].HeaderText = "User Name";
            UserDataGrid.Columns["staffName"].HeaderText = "Staff Name";
            UserDataGrid.Columns["emailAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserDataGrid.Columns["emailAddress"].HeaderText = "Email Address";
            UserDataGrid.Columns["emailAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserDataGrid.Columns["status"].HeaderText = "Status";
            UserDataGrid.Columns["_staffId"].HeaderText = "Staff ID";
            UserDataGrid.Columns["remarks"].HeaderText = "Remark";

            DataGridViewImageColumn dvEdit = new DataGridViewImageColumn();
            dvEdit.Width = 6;
            dvEdit.Image = Properties.Resources.pencil_free_icon_font;
            dvEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dvEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            UserDataGrid.Columns.Add(dvEdit);

            DataGridViewImageColumn dvDelete = new DataGridViewImageColumn();
            dvDelete.Width = 6;
            dvDelete.Image = Properties.Resources.trash_free_icon_font;
            dvDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dvDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            UserDataGrid.Columns.Add(dvDelete);
        }

        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            UserDataGrid.ReadOnly = false;


        }

        private void confirmBtnContainer_Paint(object sender, PaintEventArgs e)
        {

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

        private void UserDataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
            if (e.ColumnIndex == 6)
            {
                
            }
            else if (e.ColumnIndex == 7)
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
            if (this.SearchBarTxt.Texts != "Search")
            {
                bs.DataSource = uc.GetSpecificAccount(this.SearchBarTxt.Texts);
                UserDataGrid.DataSource = bs;
                this.Invalidate();
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
                        Console.WriteLine((string)UserDataGrid["ID", row.Index].Value);
                        MessageBox.Show(uc.LockAccount((string)UserDataGrid["id", row.Index].Value), "Lock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Console.WriteLine((string)UserDataGrid["ID", row.Index].Value);
                        MessageBox.Show(uc.UnlockAccount((string)UserDataGrid["id", row.Index].Value), "Unlock Account Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot unlock the account(s)", "Unlock Account Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
