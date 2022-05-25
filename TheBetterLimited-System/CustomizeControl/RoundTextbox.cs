using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBetterLimited.CustomizeControl
{
    public partial class RoundTextbox : UserControl
    {
        private Color borderC;
        private Color fucusColor = Color.SeaGreen;
        public RoundTextbox()
        {
            InitializeComponent();
            this.borderC = this.roundPanel1.BorderColor;
        }



        public object Texts { get; internal set; }
        public Color FucusColor
        {
            get => fucusColor;
            set
            {
                fucusColor = value;
                this.Invalidate();
            }
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.roundPanel1.BorderColor = fucusColor;
        }

        private void textbox_Leave(object sender, EventArgs e)
        {
            this.roundPanel1.BorderColor = this.borderC;
        }
    }
}
