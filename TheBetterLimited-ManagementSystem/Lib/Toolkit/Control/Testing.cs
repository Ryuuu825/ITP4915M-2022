using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace TheBetterLimited_ManagementSystem.Lib.Toolkit.Control
{
    public class Testing : System.Windows.Forms.Control
    {
        
        private Rectangle rect;
        

        public Testing()
        {
            rect = new Rectangle(0,0,10,10);
            this.Paint += Init_Paint;
            this.Text = "Texting";

        }

        protected void Init_Paint(object sender, PaintEventArgs e)
        {
            Render.instance.DrawRect(this.rect, e.Graphics, Colour.StandardColour.SecondaryColour).FillRect(this.rect, e.Graphics, Colour.StandardColour.MainColour);
            Render.instance.DrawString(this.Text, e.Graphics, 18, Color.White, this.rect);
            Render.instance.DrawCircle( e.Graphics, Color.Red , 10, 10, 5);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            rect = new Rectangle(0,0,this.Width,this.Height);
            this.Refresh();
        }
    }
}
