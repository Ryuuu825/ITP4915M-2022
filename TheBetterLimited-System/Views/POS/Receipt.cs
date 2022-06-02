using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TheBetterLimited.Views
{
    public partial class PrintReceipt : Form
    {
        Bitmap memoryImage;
        public PrintReceipt()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        void printButton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            memoryImage = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(memoryImage);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printDocument2.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 750, 950);
            printDocument2.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
