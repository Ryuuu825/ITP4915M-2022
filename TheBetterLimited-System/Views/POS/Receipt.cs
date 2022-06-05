using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TheBetterLimited.Views
{
    public partial class Receipt : Form
    {
        private Bitmap memoryImage;
        private Timer timer = new Timer();
        public object data;
        public Receipt()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }


        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            timer.Stop();
            print();
        }

        private void print()
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
        public event Action OnExit;
        private void printDocument2_EndPrint(object sender, PrintEventArgs e)
        {
            this.Close();
        }

        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form appointment = Application.OpenForms["POS"];
            ((POS)appointment).ClearOrder();
        }

        private void InitReceipt()
        {
            printDate.Text = DateTime.Now.ToString("G");
            storeId.Text = ((JObject)data)["store"]["id"].ToString();
            salesId.Text = ((JObject)data)["_creatorId"].ToString();
            storeAddress.Text = ((JObject)data)["store"]["location"]["loc"].ToString();
            transcationDate.Text = ((DateTime)((JObject)data)["createAt"]).ToString("G");
            cusName.Text = "";
            tel.Text = "";
            area.Text = "";
            deliveryAddress.Text = "";
            deliveryDate.Text = "";
            deposit.Text = String.Format("{0,C2}", ((JObject)data)["paid"].ToString());
            totalAmount.Text = String.Format("{0,C2}", ((JObject)data)["total"].ToString());
            paid.Text = String.Format("{0,C2}",((JObject)data)["paid"].ToString());
            paymentMethod.Text = "";
            final.Text = String.Format("{0,C2}", ((int)((JObject)data)["paid"]));
        }
    }
}
