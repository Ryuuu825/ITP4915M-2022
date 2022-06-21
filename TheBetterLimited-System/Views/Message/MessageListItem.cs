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

        string title;
        string message;
        string sender;
        string date;
        bool Readed;
        public MessageListItem(string title, string message, string sender, string date, bool isRead)
        {
            InitializeComponent();

            this.title = title;
            this.message = message;
            this.sender = sender;
            this.date = date;
            this.Readed = isRead;

            this.Title.Text = title;
            this.Sender.Text = sender;
            this.Time.Text = date;

            if (Readed)
                this.isRead.Visible = false;
        }
    }
}
