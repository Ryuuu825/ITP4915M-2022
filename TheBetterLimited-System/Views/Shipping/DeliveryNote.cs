using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TheBetterLimited.Views
{
    public partial class DeliveryNote : Form
    {
        private Bitmap memoryImage;
        private Timer timer = new Timer();
        private string data;
        public DeliveryNote()
        {
            InitializeComponent();
        }

        public DeliveryNote(string data)
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
            JObject info = JObject.Parse(data);
            Console.WriteLine(info.ToString());
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            if(info["status"].ToString().Contains("Deliver"))
            {
                AppointmentId.Text = info["delivery"]["appointmentId"].ToString();
                barcode.Image = b.Encode(BarcodeLib.TYPE.CODE39, info["delivery"]["appointmentId"].ToString(), Color.Black, Color.White, 248, 67);
            }
            else if (info["status"].ToString().Contains("Install"))
            {
                title.Text = "Installation Note";
                AppointmentId.Text = info["installation"]["appointmentId"].ToString();
                barcode.Image = b.Encode(BarcodeLib.TYPE.CODE39, info["installation"]["appointmentId"].ToString(), Color.Black, Color.White, 248, 67);
            }
            orderId.Text = info["id"].ToString();
            JArray orderItems = (JArray)info["orderItems"];
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            dt.Columns.Add("goodsId");
            dt.Columns.Add("goodsName");
            dt.Columns.Add("price");
            dt.Columns.Add("qty");
            dt.Columns.Add("amount");
            dt.Columns.Add("display");
            dt.Columns.Add("isInstall");
            dt.Columns["isInstall"].DataType = System.Type.GetType("System.Byte[]");
            var isBooking = false;
            List<string> needInstallItem = new List<string>();
            if (info["installation"].Type != JTokenType.Null)
            {
                foreach (var installItem in (JArray)info["installation"]["items"])
                {
                    needInstallItem.Add(installItem["itemNames"].ToString());
                }
            }
            foreach (JObject orderItem in orderItems)
            {
                var row = dt.NewRow();
                row["goodsId"] = orderItem["supplierGoodsStockId"].ToString();
                row["goodsName"] = orderItem["name"].ToString();
                row["price"] = orderItem["price"];
                row["qty"] = orderItem["quantity"];
                row["amount"] = (((int)orderItem["quantity"])*((double)orderItem["price"]));
                row["isInstall"] = new ImageConverter().ConvertTo(Properties.Resources.square24, System.Type.GetType("System.Byte[]"));
                foreach (var i in needInstallItem)
                {
                    if (orderItem["name"].ToString().Equals(i))
                    {
                        row["isInstall"] = new ImageConverter().ConvertTo(Properties.Resources.check24, System.Type.GetType("System.Byte[]"));
                    }
                }
                dt.Rows.Add(row);
            }
            bs.DataSource = dt;
            OrderItemDataGrid.AutoGenerateColumns = false;
            OrderItemDataGrid.DataSource = bs;
            printDate.Text = DateTime.Now.ToString("G");
            if (((JToken)info["customer"]).Type != JTokenType.Null) //check cus info
            {
                cusName.Text = info["customer"]["name"].ToString();
                tel.Text = info["customer"]["phone"].ToString();
                area.Text = "";
                if (((JToken)info["delivery"]).Type != JTokenType.Null) //check need delivery
                {
                    deliveryAddress.Text = info["customer"]["address"].ToString();
                    deliveryDate.Text = ((DateTime)info["delivery"]["date"]).ToString("d") + " "
                        + ((DateTime)info["delivery"]["startTime"]).ToString("t") + " - "
                        + ((DateTime)info["delivery"]["endTime"]).ToString("t");
                    if (((JToken)info["installation"]).Type != JTokenType.Null) //check need delivery
                    {
                        installDate.Text = ((DateTime)info["installation"]["date"]).ToString("d") + " "
                                        + ((DateTime)info["installation"]["startTime"]).ToString("HH:mm") + " - "
                                        + ((DateTime)info["installation"]["endTime"]).ToString("HH:mm");
                    }
                    else
                    {
                        installDate.Text = "";
                    }
                }
                else
                {
                    isBooking = true;
                    deliveryAddress.Text = "";
                    deliveryDate.Text = "";
                    installDate.Text = "";
                }
            }
            else
            {
                CustomerInfo.Visible = false;
            }

            var deposit = 0.0;
            
            if (isBooking)
            {
                deposit = (double)info["total"] * 0.2;
            }
        }

        private void OrderItemDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrderItemDataGrid.Columns["isInstall"].HeaderText = "是否安裝\nNeed Install";
            OrderItemDataGrid.Columns["qty"].HeaderText = "數量\nQTY";
            OrderItemDataGrid.Columns["goodsName"].HeaderText = "貨品\nProduct";
            OrderItemDataGrid.Columns["goodsID"].HeaderText = "識別編號\nID No.";
        }
    }
}
