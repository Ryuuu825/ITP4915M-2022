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
    public partial class Receipt : Form
    {
        private Bitmap memoryImage;
        private Timer timer = new Timer();
        private string data;
        public Receipt()
        {
            InitializeComponent();
        }

        public Receipt(string data)
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

        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form appointment = Application.OpenForms["POS"];
            ((POS)appointment).ClearOrder();
        }

        private void InitReceipt()
        {
            JObject info = JObject.Parse(data);
            Console.WriteLine(info.ToString());
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            orderId.Text = info["Id"].ToString();
            barcode.Image = b.Encode(BarcodeLib.TYPE.CODE39, info["Id"].ToString(), Color.Black, Color.White, 248, 67);
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
            foreach (JObject orderItem in orderItems)
            {
                var row = dt.NewRow();
                row["goodsId"] = orderItem["supplierGoodsStockId"].ToString();
                row["goodsName"] = orderItem["name"].ToString();
                row["price"] = orderItem["price"];
                row["qty"] = orderItem["quantity"];
                row["amount"] = (((int)orderItem["quantity"])*((double)orderItem["price"]));
                isBooking = ((bool)orderItem["needBooking"]);
                /*if (((JToken)orderItem["quantity"]).Type != JTokenType.Null && ((bool)orderItem["quantity"]) == false)
                {
                    row["display"] = Properties.Resources.check24;
                }else
                {
                    row["display"] = Properties.Resources.square24;
                }*/
                if ((bool)orderItem["needInstall"])
                {
                    row["isInstall"] = new ImageConverter().ConvertTo(Properties.Resources.check24, System.Type.GetType("System.Byte[]"));
                }
                else
                {
                    row["isInstall"] = new ImageConverter().ConvertTo(Properties.Resources.square24, System.Type.GetType("System.Byte[]"));
                }
                dt.Rows.Add(row);
            }
            bs.DataSource = dt;
            OrderItemDataGrid.AutoGenerateColumns = false;
            OrderItemDataGrid.DataSource = bs;
            printDate.Text = DateTime.Now.ToString("G");
            storeId.Text = info["store"]["id"].ToString();
            salesId.Text = info["_creatorId"].ToString();
            storeAddress.Text = info["store"]["location"]["loc"].ToString();
            transcationDate.Text = ((DateTime)info["createAt"]).ToString("G");
            if (((JToken)info["Customer"]).Type != JTokenType.Null) //check cus info
            {
                cusName.Text = info["Customer"]["name"].ToString();
                tel.Text = info["Customer"]["phone"].ToString();
                area.Text = "";
                if (((JToken)info["Delivery"]).Type != JTokenType.Null) //check need delivery
                {
                    deliveryAddress.Text = info["Customer"]["address"].ToString();
                    deliveryDate.Text = ((DateTime)info["Delivery"]["date"]).ToString("d") + " "
                        + ((DateTime)info["Delivery"]["startTime"]).ToString("t") + " - "
                        + ((DateTime)info["Delivery"]["endTime"]).ToString("t");
                    if (((JToken)info["Installation"]).Type != JTokenType.Null) //check need delivery
                    {
                        installDate.Text = ((DateTime)info["Installation"]["date"]).ToString("d") + " "
                                        + ((DateTime)info["Installation"]["startTime"]).ToString("t") + " - "
                                        + ((DateTime)info["Installation"]["endTime"]).ToString("t");

                    }
                    else
                    {
                        installDate.Text = "";
                    }
                }
                else
                {
                    deliveryAddress.Text = "";
                    deliveryDate.Text = "";
                }
            }
            else
            {
                cusName.Text = "";
                tel.Text = "";
            }

            var deposit = 0.0;
            if (isBooking)
            {
                deposit = (double)info["total"] * 0.2;
            }
            depositTxt.Text = String.Format("{0:C2}", deposit);
            totalAmount.Text = String.Format("{0:C2}", info["total"]);
            paid.Text = String.Format("{0:C2}", info["paid"]);
            paymentMethod.Text = "Cash";
            final.Text = String.Format("{0:C2}", ((double)info["total"]-(double)info["paid"]));
        }

        private void UserInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderItemDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrderItemDataGrid.Columns["isInstall"].HeaderText = "是否安裝\nNeed Install";
            OrderItemDataGrid.Columns["isDisplay"].HeaderText = "展示商品\nDisplay Item";
            OrderItemDataGrid.Columns["amount"].HeaderText = "金額\nAmount";
            OrderItemDataGrid.Columns["price"].HeaderText = "單價\nUnit Price";
            OrderItemDataGrid.Columns["qty"].HeaderText = "數量\nQTY";
            OrderItemDataGrid.Columns["goodsName"].HeaderText = "貨品\nProduct";
            OrderItemDataGrid.Columns["goodsID"].HeaderText = "識別編號\nID No.";
        }
    }
}
