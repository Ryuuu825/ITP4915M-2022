using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited.Models;
using TheBetterLimited.Properties;

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
            OnMessageReceived.Invoke();


            var messages = JObject.Parse(res.Content)["messages"].ToString();
            JArray messageList = JArray.Parse(messages);

            Console.WriteLine(res.Content);


            if (messageList.Count > 1)
            {
                prompt.BalloonTipTitle = "You receive few new messages!";
                prompt.Visible = true;
                prompt.Text = "";
                prompt.ShowBalloonTip(1000);
            }
            else if (messageList.Count == 1)
            {
                prompt.BalloonTipTitle = "You receive one new messages!";
                prompt.Visible = true;
                prompt.Text = "";
                prompt.ShowBalloonTip(1000);
            }

        }

        public void ReceiveUnreadMessage()
        {
            Console.WriteLine("ReceiveUnreadMessage");

            var req = new RestSharp.RestRequest("/api/message/unread", RestSharp.Method.Get)
                                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            var res = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            OnMessageReceived.Invoke();



           
        }




    }
}
