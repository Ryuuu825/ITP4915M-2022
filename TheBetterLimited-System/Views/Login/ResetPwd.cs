using System;
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
using Newtonsoft.Json.Linq;
using RestSharp;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;

namespace TheBetterLimited.Views
{
    public partial class ResetPwd : Form
    {
        private LoginController loginController = new LoginController();
        private BackgroundWorker bw = new BackgroundWorker();
        private RestResponse result;
        public ResetPwd()
        {
            InitializeComponent();
            initBackgroundWorker();
        }

        private void initBackgroundWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            result = loginController.ResetPassword(userName.Texts, email.Texts);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            showResult();
        }

        private void chgPwdBtn_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void ResetPassword()
        {
            int i = 1;
            foreach (Control ctl in changeInfo.Controls)
            {

                if (ctl is CustomizeTextbox)
                {
                    if (((CustomizeTextbox)ctl).Texts.Length == 0)
                    {
                        var lable = changeInfo.Controls[i - 1].Text;
                        var str = "Sorry! \nPlease enter " + lable + ".";
                        MessageBox.Show(str, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctl.Focus();
                        return;
                    };
                    i += 2;
                }
            }

            /**
             * access Api to get the responseCode and msg
             */
            bw.RunWorkerAsync();

        }

        private void showResult()
        {
            if (result == null)
            {
                MessageBox.Show("Cannot connect to server!", "Reset Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                JObject res = JObject.Parse(result.Content);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ResetPwdResult resetResult = new ResetPwdResult(userName.Texts, email.Texts, result.Content);
                    resetResult.Show();
                    this.Dispose();
                }
                else
                {
                    string str = res["message"].ToString();
                    MessageBox.Show(str, "Reset Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset Error.\nPlease check your inputted value.", "Reset Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            lg.Show();
        }

        private void ResetPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ResetPassword();
            }
        }
    }
}
