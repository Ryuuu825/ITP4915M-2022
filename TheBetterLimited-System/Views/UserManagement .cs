using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBetterLimited.Views
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                UserDataGrid.Rows.Add(++k, "jam", "jyuban@outlook.com", "S0001", "Ben", "Normal");
                UserDataGrid.Rows.Add(++k, "Ben", "jyuban@outlook.com", "S0001", "Ben", "Locked");
                UserDataGrid.Rows.Add(++k, "ken", "jyuban@outlook.com", "S0001", "Ben", "Useless");
            }
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

        private void UserDataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void UserDataGrid_CancelRowEdit(object sender, QuestionEventArgs e)
        {
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.Header.ClientRectangle, Color.FromArgb(232, 232, 232), ButtonBorderStyle.Solid);
        }

        private void Bottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Action_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.Action.ClientRectangle, Color.FromArgb(232, 232, 232), ButtonBorderStyle.Solid);
        }

        private void ActionContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ActionContainer.ClientRectangle, Color.FromArgb(232, 232, 232), ButtonBorderStyle.Solid);
        }

        private void UserDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (UserDataGrid.Columns[e.ColumnIndex].Name == "Status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (e.Value == "Locked")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(203, 32, 39);
                }
                else if (e.Value == "Useless")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(254, 161, 35);
                    e.CellStyle.SelectionBackColor = Color.FromArgb(254, 161, 35);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.SelectionBackColor = Color.SeaGreen;
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
    }
}
