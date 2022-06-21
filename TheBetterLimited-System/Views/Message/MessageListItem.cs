using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBetterLimited.Views.Message
{
    public partial class MessageListItem : UserControl
    {
        public MessageListItem(string v)
        {
            InitializeComponent();
        }

        string id;
        string title;
        string message;
        string sender;
        string date;
        bool Readed;
        OnMessageItemClick Delegate;

        public MessageListItem(MessageModel model, OnMessageItemClick Delegate)
        {
            InitializeComponent();

            this.title = model.Title;
            this.message = model.content;
            this.sender = model.senderName;
            this.date = model.sendDate;
            this.Readed = model.isRead;
            this.id = model.id;


            this.Title.Text = title;
            this.Sender.Text = sender;
            this.Time.Text = date;

            if (Readed)
                this.isRead.Visible = false;

            this.Delegate = Delegate;

            this.Title.MouseEnter += (e, arg) => { ChangeBgColor(); };
            this.Title.MouseLeave += (e, arg) => { ChangeBackToNormal(); };
            this.Title.Click += (e, args) => Delegate.Click(id, sender, title, message);

            this.Sender.MouseEnter += (e, arg) => { ChangeBgColor(); };
            this.Sender.MouseLeave += (e, arg) => { ChangeBackToNormal(); };
            this.Sender.Click += (e, args) => Delegate.Click(id, sender, title, message);


            this.Time.MouseEnter += (e, arg) => { ChangeBgColor(); };
            this.Time.MouseLeave += (e, arg) => { ChangeBackToNormal(); };
            this.Time.Click += (e, args) => Delegate.Click(id, sender, title, message);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            ChangeBgColor();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            ChangeBackToNormal();
            base.OnMouseLeave(e);
        }

        public void ChangeBgColor()
        {
            this.BackColor = Color.SeaGreen;
        }

        public void ChangeBackToNormal()
        {
            BackColor = Color.LightGray;
        }

        private void MessageListItem_Click(object sender, EventArgs e)
        {
            Delegate.Click(id , this.sender, title, message);
            this.isRead.Visible = false;

        }
    }
}
