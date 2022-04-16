using System.Windows.Forms;
using TheBetterLimited_ManagementSystem.Lib.Toolkit.Colour;
using System.Text;
using System.Drawing;

namespace TheBetterLimited_ManagementSystem.Lib.Toolkit.Font
{
    public class HeaderTwo : Label
    {
        public HeaderTwo()
        {
            this.Font = new System.Drawing.Font(StandardFont.FontFamily, 24, FontStyle.Bold);
            this.Text = "Default";
        }

        public void SetText(string text)
        {
            this.Text = text;
        }

        public void ChangeColor()
        {
            this.ForeColor = Colour.StandardColour.MainColour;
        }

        public void ChangeColor(Color c)
        {
            this.ForeColor = c;
        }
    }
}
