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
using Newtonsoft.Json.Linq;

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
        public ResetPwdResult(string username, string email, string m)
        {
            JObject msgObj = JObject.Parse(m);
            this.username = username;
            this.email = email;
            this.msg = msgObj["message"].ToString();
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
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Msg.Text = "Email has been resent! \n Please check your mail box (or junk box also).";
                if (System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "zh")
                {
                    Msg.Text = "邮件已重新发送! \n请检查您的邮箱(或垃圾邮件)。";
                }
                resendTimer.Start();
            }
            else
            {
                string str = result.Content;
                MessageBox.Show(str, "Resend Email Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resendTimer_Tick(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                resendTimer.Stop();
                resendBtn.Text = "Resent Email";
                if (System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "zh")
                {
                    resendBtn.Text = "重发邮件";
                }
                resendBtn.Enabled = true;
                resendBtn.BackColor = Color.SeaGreen;
                duration = 60;
            }
            else if (duration > 0)
            {
                resendBtn.Text = "Try again after " + duration + "s";

                if(System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "zh")
                {
                    resendBtn.Text = "在" + duration + "秒后重试";
                }
                resendBtn.BackColor = Color.Gray;
                resendBtn.Enabled = false;
                duration--;
            }
        }
    }
}
