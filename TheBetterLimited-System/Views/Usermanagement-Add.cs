using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBetterLimited.Views
{
    public partial class Usermanagement_Add : Form
    {
        public Usermanagement_Add()
        {
            InitializeComponent();
        }

        private void Usermanagement_Add_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIconPic.ClientRectangle);
            Region region = new Region(gp);
            UserIconPic.Region = region;
            gp.Dispose();
            region.Dispose();
        }

        private void UserIconPic_MouseHover(object sender, EventArgs e)
        {
            UserIconPic.Image = Properties.Resources.photo_upload;
        }

        private void UserIconPic_MouseLeave(object sender, EventArgs e)
        {
            UserIconPic.Image = Properties.Resources.avatar;
        }
    }
}
