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
    public partial class PONote : Form
    {
        private ControllerBase cbSup = new ControllerBase("Supplier");
        private Bitmap memoryImage;
        private Timer timer = new Timer();
        private JObject data;
        public PONote()
        {
            InitializeComponent();
        }

        public PONote(JObject data)
        {
            this.data = data;
            InitializeComponent();
            InitReceipt();
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
        private void InitReceipt()
        {
            JObject info = data;
            Console.WriteLine(info.ToString());
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            orderId.Text = info["id"].ToString();
            barcode.Image = b.Encode(BarcodeLib.TYPE.CODE39, info["id"].ToString(), Color.Black, Color.White, 248, 67);
            JArray orderItems = (JArray)info["items"];
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            dt.Columns.Add("goodsId");
            dt.Columns.Add("goodsName");
            dt.Columns.Add("qty");
           
            foreach (JObject orderItem in orderItems)
            {
                var row = dt.NewRow();
                row["goodsId"] = orderItem["goods"]["GoodsId"].ToString();
                row["goodsName"] = orderItem["goods"]["GoodsName"].ToString();
                row["qty"] = orderItem["quantity"];
                dt.Rows.Add(row);
            }
            bs.DataSource = dt;
            OrderItemDataGrid.AutoGenerateColumns = false;
            OrderItemDataGrid.DataSource = bs;
            printDate.Text = DateTime.Now.ToString("G");
            warehouseId.Text = info["_warehouseId"].ToString();
            warehouseAddress.Text = "59 Tai Yip Street Kowloon Bay Kolwoon, Hong Kong";

            var res = cbSup.GetById(info["_supplierId"].ToString());
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var sup = JObject.Parse(res.Content);
                supName.Text = sup["Name"].ToString();
                tel.Text = sup["Phone"].ToString();
                contact.Text = sup["Contact"].ToString();
                supAddress.Text = sup["Address"].ToString(); ;
            }
        }
        private void OrderItemDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrderItemDataGrid.Columns["qty"].HeaderText = "數量\nQTY";
            OrderItemDataGrid.Columns["goodsName"].HeaderText = "貨品\nProduct";
            OrderItemDataGrid.Columns["goodsID"].HeaderText = "識別編號\nID No.";
        }
    }
}
