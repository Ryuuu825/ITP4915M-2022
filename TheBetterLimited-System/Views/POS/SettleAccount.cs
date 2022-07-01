using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class SettleAccount : Form
    {
        private ControllerBase cb = new ControllerBase("Order/Myorder");
        private Bitmap memoryImage;
        private Timer timer = new Timer();
        private string data;
        private List<JObject> list = new List<JObject>();
        public SettleAccount()
        {
            InitializeComponent();
            InitReport();
        }

        public SettleAccount(string data)
        {
            this.data = data;
            InitializeComponent();
            InitReport();
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
            printDocument2.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 980, 1055);
            printDocument2.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();
        }
        public event Action OnExit;
        private void printDocument2_EndPrint(object sender, PrintEventArgs e)
        {
            this.Close();
        }

        private void InitReport()
        {
            var response = cb.GetAll(lang: System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
            JObject info = JObject.Parse(response.Content);
            JArray os = (JArray)info["Orders"];
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            dt.Columns.Add("orderID");
            dt.Columns.Add("createAt");
            dt.Columns.Add("total");
            dt.Columns.Add("qty");
            dt.Columns.Add("payment");
            dt.Columns.Add("status");
            var orders = os.Count;
            var totalQty = 0;
            var totalRevenue = 0.0;
            var deposit = 0.0;
            var orderQty = 0;
            var books = 0;
            foreach (JObject order in os)
            {
                list.Add(order);
                orderQty = 0;
                var row = dt.NewRow();
                foreach (JObject orderItem in (JArray)order["orderItems"])
                {
                    orderQty += (int)orderItem["quantity"];
                }
                row["orderID"] = order["id"].ToString();
                row["createAt"] = order["createAt"].ToString();
                row["total"] = order["total"];
                row["status"] = order["status"];
                row["payment"] = "Cash";
                if (order["status"].ToString().Equals("Booking"))
                {
                    books++;
                    if((int)order["total"] > 5000)
                    {
                        deposit += (int)order["total"] * 0.2;
                        totalRevenue += (int)order["total"] * 0.2;
                    }else
                    {
                        row["payment"] = "Free";
                    }
                }else
                {
                    totalRevenue += (int)order["total"];
                    totalQty += orderQty;
                }
                row["qty"] = orderQty;
                dt.Rows.Add(row);
            }
            bs.DataSource = dt;
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = bs;
            printDate.Text = DateTime.Now.ToString("G");
            salesId.Text = info["StaffInfo"]["id"].ToString();
            name.Text = info["StaffInfo"]["name"].ToString();
            storeId.Text = info["StaffInfo"]["storeId"].ToString();
            storename.Text = info["StaffInfo"]["storeName"].ToString();
            count.Text = totalQty.ToString();
            totalAmount.Text = String.Format("{0:C2}", info["total"]);
            this.books.Text = books.ToString();
            totalAmount.Text = String.Format("{0:C2}", totalRevenue);
            this.orders.Text = orders.ToString();
            this.deposit.Text = String.Format("{0:C2}", deposit);
        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["details"].Index)
            {
                Form order = Application.OpenForms["OrderDetails"];
                if (order != null)
                {
                    order.Close();
                    order.Dispose();
                }
                OrderDetails od = new OrderDetails();
                od.SetOrderData(list[e.RowIndex],"");
                od.Show();
                od.TopLevel = true;
            }
        }
    }
}
