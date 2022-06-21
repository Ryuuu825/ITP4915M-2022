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
using RestSharp;
using TheBetterLimited.Models;

namespace TheBetterLimited.Views.Message
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
            GetContent();
        }

        private void GetContent()
        {
            // contentBoard
            RestRequest req = new RestRequest("/api/v2/message/content"  , Method.Get)
                                .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();

            JArray list = JArray.Parse(res.Content);
            Console.WriteLine(list.Count());
            Console.WriteLine(res.Content);

            foreach (var item in list)
            {
                contentBoard.Controls.Add(
                    new ContentListItem(item["_staffId"].ToString() , item["name"].ToString())
                    );
            }
        }

        public bool isEnableChat = false;

        private void EnableChat(string id)
        {
            if (! isEnableChat)
            {
                this.icon.Visible = true;
                this.icon.Enabled = true;

                this.senderName.Visible = true;
                this.senderName.Enabled = true;

                this.MessageContent.Visible = true;
                this.MessageContent.Enabled = true;

                this.add.Visible = true;
                this.add.Enabled = true;

                this.MsgInput.Visible = true;
                this.MsgInput.Enabled = true;

                this.SendBtn.Visible = true;
                this.SendBtn.Enabled = true;

                this.isEnableChat = true;
            }
            else 
            {
                this.icon.Visible = false;
                this.icon.Enabled = false;

                this.senderName.Visible = false;
                this.senderName.Enabled = false;

                this.MessageContent.Visible = false;
                this.MessageContent.Enabled = false;

                this.add.Visible = false;
                this.add.Enabled = false;

                this.MsgInput.Visible = false;
                this.MsgInput.Enabled = false;

                this.SendBtn.Visible = false;
                this.SendBtn.Enabled = false;

                this.isEnableChat = false;
            }

        }
    }
}
