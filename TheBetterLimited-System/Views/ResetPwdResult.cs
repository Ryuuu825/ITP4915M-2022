using TheBetterLimited.Controller;
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
    public partial class ResetPwdResult : Form
    {
        private string username;
        private string email;
        private int duration = 60;
        private string msg;

        public ResetPwdResult()
        {
            InitializeComponent();
        }
        public ResetPwdResult(string username, string email, string msg)
        {
            this.username = username;
            this.email = email;
            this.msg = msg;
            Console.WriteLine(username + " " + email);
            InitializeComponent();
            Msg.Text = msg;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void resendBtn_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            var result = loginController.ResetPassword(username, email);
            if (result.Code.Equals("200"))
            {
                Msg.Text = "An email has been resent.";
                resendTimer.Start();
            }
            else
            {
                string str = result.ToString();
                MessageBox.Show(str, "Resend Email Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resendTimer_Tick(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                resendTimer.Stop();
                resendBtn.Text = "Resent Email";
                resendBtn.Enabled = true;
                resendBtn.BackColor = Color.SeaGreen;
                duration = 60;
            }
            else if (duration > 0)
            {
                resendBtn.Text = "Try again after " + duration + "s";
                resendBtn.BackColor = Color.Gray;
                resendBtn.Enabled = false;
                duration--;
            }
        }
    }
}
