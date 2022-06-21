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
using Newtonsoft.Json.Linq;
using RestSharp;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views.Message
{
    public partial class Message : Form, OnMessageItemClick
    {
        TheBetterLimited_System.Controller.ControllerBase controller = new TheBetterLimited_System.Controller.ControllerBase("message");


        public Message()
        {
            InitializeComponent();
            ReceiveMessage();
            this.Timer.Start();
        }

        public void ReceiveMessage()
        {
            this.MessageList.Controls.Clear();
            var result = controller.GetAll();
            SetMessage(result);

        }

        public void SetMessage(RestSharp.RestResponse result, bool isNewMessage = false) // isReverse mean add the message to the front
        {
            var messages = JObject.Parse(result.Content)["messages"].ToString();
            JArray messageList = JArray.Parse(messages);
            foreach (var message in messageList)
            {
                /*
                        "senderName": "system",
                        "sentDate": "21/6/2022",
                        "title": "Low Stock Warning",
                        "content": "The quantity of 100000041 is less than the minimum limit. Please check the stock."
                */
                // string title , string message, string sender, string date
                var msg = new MessageListItem(
                    new MessageModel
                    {
                        Title = message["title"].ToString(),
                        content = message["content"].ToString(),
                        senderName = message["senderName"].ToString(),
                        sendDate = message["sentDate"].ToString() ,
                        id = message["id"].ToString(),
                        isRead = message["isRead"].ToObject<bool>()
                    },
                    this
                   );

                this.MessageList.Controls.Add(msg);
                if (isNewMessage)
                {
                    this.MessageList.Controls.SetChildIndex(msg, 0);
                }

            }

        }

        public void ReceiveNewMessage()
        {
            var req = new RestSharp.RestRequest("/api/message/unreceived", RestSharp.Method.Get)
                                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            SetMessage(res, true);
        }

        public void ReceiveUnreadMessage()
        {
            var req = new RestSharp.RestRequest("/api/message/unread", RestSharp.Method.Get)
                                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            SetMessage(res, true);
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            this.ReceiveNewMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessageForm send = new SendMessageForm();
            send.Show();
        }

        private void isUnreadOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (isUnreadOnly.Checked)
            {
                this.MessageList.Controls.Clear();
                ReceiveUnreadMessage();
            }
            else
            {
                ReceiveMessage();
            }
        }

        private void Message_Load(object sender, EventArgs e)
        {

        }

        void OnMessageItemClick.Click(string id , string sender, string title, string message)
        {
            this.senderText.Text = sender;
            this.titleText.Text = title;
            this.contentText.Text = message;
            RestRequest req = new RestSharp.RestRequest("/api/message/read/" + id , Method.Put )
                                    .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            if (res.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                MessageBox.Show(res.Content);
            }
            Console.WriteLine(res.Content);
            Console.WriteLine(res.StatusCode);
            Console.WriteLine("/api/message/read/" + id);
        }

    }
}
