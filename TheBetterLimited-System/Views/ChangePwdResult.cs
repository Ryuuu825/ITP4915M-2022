using TheBetterLimited.Models;
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
    public partial class ChangePwdResult : Form
    {
        public ChangePwdResult()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ChangePwdResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Dispose();
            Login login = new Login();
            login.Show();
        }
    }
}
