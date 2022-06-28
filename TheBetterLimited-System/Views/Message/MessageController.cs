using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited.Models;
using TheBetterLimited.Properties;
using TheBetterLimited.Utils;

namespace TheBetterLimited.Views.Message
{
    public class MessageDelegate
    {
        public Action OnMessageReceived = null;
        public Action Delegate = null;
        public System.Windows.Forms.NotifyIcon prompt;
        public System.Timers.Timer timer;
        public MessageDelegate(Action onMessageReceived, int Interval, Action Delegate , System.Windows.Forms.NotifyIcon prompt)
        {
            this.prompt = prompt;

            this.OnMessageReceived = onMessageReceived;
            this.Delegate = Delegate;
            this.timer = new System.Timers.Timer();
            this.timer.Interval = Interval;
            this.timer.Elapsed += (o,s) => { ReceiveNewMessage(); };
            this.timer.Elapsed += (o, s) => this.Delegate();
            this.timer.Start();
            prompt.Visible = true;
            prompt.Text = "";
            if (MultiLanguage.DefaultLanguage == "zh")
                prompt.BalloonTipText = "打开消息中心查看它";
            else
                prompt.BalloonTipText = "Open Message Center to see it";

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ReceiveNewMessage()
        {

            var req = new RestSharp.RestRequest("/api/message/unreceived", RestSharp.Method.Get)
                                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();


            var messages = JObject.Parse(res.Content)["messages"].ToString();
            JArray messageList = JArray.Parse(messages);
            if (messageList.Count > 1)
            {
                if (MultiLanguage.DefaultLanguage == "zh")
                    prompt.BalloonTipTitle = "您收到的数则新消息！";
                else
                    prompt.BalloonTipTitle = "You receive new messages!";
                prompt.ShowBalloonTip(1000);
            }
            else if (messageList.Count == 1)
            {
                
                if (MultiLanguage.DefaultLanguage == "zh")
                    prompt.BalloonTipTitle = $"您收到一封来自{messageList[0]["senderName"].ToString()}的新消息！";
                else
                    prompt.BalloonTipTitle = $"You receive one new messages from {messageList[0]["senderName"].ToString()}";
                prompt.ShowBalloonTip(1000);
            }
            OnMessageReceived.Invoke();
        }

        public void ReceiveUnreadMessage()
        {
            Console.WriteLine("ReceiveUnreadMessage");

            var req = new RestSharp.RestRequest("/api/message/unread", RestSharp.Method.Get)
                                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            OnMessageReceived.Invoke();
        }


        public void Start()
        {
            this.timer.Start();
        }

        public void Stop()
        {
            this.timer.Stop();
        }



    }
}
