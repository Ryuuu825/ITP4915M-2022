using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{

    public partial class SendMessageForm : Form
    {

        public SendMessageForm()
        {
            InitializeComponent();
            cbxType.Items.Add("Agent");
            cbxType.Items.Add("Warning");
            cbxType.Items.Add("Info");
        }


        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CusNameTxt.Texts.Equals(String.Empty) || CusNameTxt.Texts.Equals(CusNameTxt.Placeholder))
            {
                CusNameTxt.IsError = true;
                return;
            }
            var name = CusNameTxt.Texts;

            if (PhoneTxt.Texts.Equals(String.Empty) || PhoneTxt.Texts.Equals(PhoneTxt.Placeholder))
            {
                PhoneTxt.IsError = true;
                return;
            }
            var phone = PhoneTxt.Texts;

            string address;
            if (CusAddressTxt.Texts.Equals(String.Empty) || CusAddressTxt.Texts.Equals(CusAddressTxt.Placeholder))
            {
                address = String.Empty;
            }
            else
            {
                address = CusAddressTxt.Texts;
            }

        }

        private void CusNameTxt_Click(object sender, EventArgs e)
        {
        }

        private void CusPhoneTxt_Click(object sender, EventArgs e)
        {
        }

        private void CusAddressTxt_Click(object sender, EventArgs e)
        {
        }

        private void PhoneTxt__Leave(object sender, EventArgs e)
        {
        }

        private void PhoneTxt__TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxType_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
