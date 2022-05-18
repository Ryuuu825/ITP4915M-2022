using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SDPTest.CustomizeControl;
using SDPTest.Models;

namespace SDPTest.Views
{
    public partial class ChangePwd : Form
    {
        private int responseCode;

        public ChangePwd()
        {
            InitializeComponent();
        }

        private void chgPwdBtn_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach(Control ctl in changeInfo.Controls)
            {

                if (ctl is CustomizeTextbox)
                {
                    if (((CustomizeTextbox)ctl).Texts.Length == 0)
                    {
                        var lable = changeInfo.Controls[i-1].Text;
                        var str = "Sorry! \nPlease enter "+ lable + ".";
                        MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctl.Focus();
                        return;
                    };
                    i+=2;
                }
            }

            if(firstNewPassword.Texts.Length < 6)
            {
                var str = "Sorry! \nNew password is too short. \nPlease enter agin.";
                MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNewPassword.Focus();
                return;
            }
            else if (firstNewPassword.Texts != secondNewPassword.Texts)
            {
                var str = "Sorry! \nPasswords do not match. \nPlease enter agin.";
                MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                secondNewPassword.Focus();
            }
            else 
            {
                var str = "Are you sure to change your password?";
                DialogResult dialogResult = MessageBox.Show(str, "Confirm change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    /**
                    * access Api to get the responseCode and msg
                    */
                    Controller.LoginController loginController = new Controller.LoginController();
                    string responseCode = loginController.ChangePassword(userName.Texts, originalPwd.Texts, firstNewPassword.Texts);
                    if (responseCode == "1")
                    {
                        this.Dispose();
                        ChangePwdResult chgMsg = new ChangePwdResult();
                        chgMsg.Show();

                    }
                    else
                    {
                        str = "Your password is incorret";
                        MessageBox.Show(str, "Change Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void displayTip(object sender, MouseEventArgs e)
        {

        }

        private void staffNoTip_Popup(object sender, PopupEventArgs e)
        {
            staffNoTip.SetToolTip((RoundTextbox)sender, "Enter staff number");
        }

        private void picReturn_MouseHover(object sender, EventArgs e)
        {
            picReturn.BackgroundImage = Properties.Resources._return;
        }
        private void picReturn_MouseLeave(object sender, EventArgs e)
        {
            picReturn.BackgroundImage = Properties.Resources._return;
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            lg.Show();
        }
    }
}
