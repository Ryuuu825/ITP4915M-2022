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

        private List<string> receiver = new List<string>();
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
            if (this.receiverList.Text.Equals(String.Empty) || this.receiverList.Text.Equals(receiverName.Placeholder))
            {
                receiverName.IsError = true;
                return;
            }
            var name = receiverName.Texts;

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

            /*
             * 
              {
                  "receiver": [
                    "admin"
                  ],
                  "title": "Hello From Server",
                  "content": "string"
                }
             */

            RestRequest req = new RestRequest("/api/message", Method.Post)
                                    .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                                    .AddBody(new { receiver = this.receiver, title = PhoneTxt.Texts, content = CusAddressTxt.Texts });
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            this.Close();
            this.Dispose();
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

        private void plusBtn_Click(object sender, EventArgs e)
        {


            if ( receiver.Contains(this.receiverName.Texts))
            {
                MessageBox.Show(this.receiverName.Texts + " already inserted");
                return;
            }

            RestRequest req = new RestRequest("api/message/user/" + this.receiverName.Texts, Method.Get);
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            Console.Write(res.Content);
            if (res.StatusCode == System.Net.HttpStatusCode.OK )
            {
                receiver.Add(this.receiverName.Texts);
                this.receiverList.Text = this.receiverName.Texts + "\r\n" + this.receiverList.Text;
                this.receiverName.Texts = "";
            }
            else
                MessageBox.Show("No user found");
        }

        private void BottomBtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
