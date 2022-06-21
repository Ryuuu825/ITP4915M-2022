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
    public partial class ContentListItem : UserControl
    {
        string _staffId;
        string senderName;

        public ContentListItem(string id , string senderName)
        {
            InitializeComponent();
            this._staffId = id;
            this.senderName = senderName;

            this.SenderName.Text = senderName;
            this.SenderName.MouseEnter += (s,args) => {this.BackColor = Color.SeaGreen;};
            
            this.pictureBox1.MouseEnter += (s,args) => {this.BackColor = Color.SeaGreen;};
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = Color.SeaGreen;
            base.OnClick(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnClick(e);
        }
    }
}
