﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SDPTest.Controller;
using SDPTest.CustomizeControl;
using SDPTest.Models;

namespace SDPTest.Views
{
    public partial class ResetPwd : Form
    {
        private int responseCode;

        public ResetPwd()
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

            /**
             * access Api to get the responseCode and msg
             */
            LoginController loginController = new LoginController();
            ResponseResult result = loginController.ResetPassword(userName.Texts, email.Texts);
            if (result.Code.Equals("200"))
            {
                ResetPwdResult resetResult = new ResetPwdResult(userName.Texts, email.Texts, result.Message);
                resetResult.Show();
                this.Dispose();
            }
            else
            {
                string str = result.Message;
                MessageBox.Show(str, "Reset Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
