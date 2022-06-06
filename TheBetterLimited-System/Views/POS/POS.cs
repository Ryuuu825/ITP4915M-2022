using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class POS : Form
    {
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();
        private DialogResult choose;
        private RestResponse result;
        private List<JObject> goods = new List<JObject>();
        private List<object> orderItems = new List<object>();
        private ControllerBase cbCatalogue = new ControllerBase("Catalogue");
        private ControllerBase cbGoods = new ControllerBase("pos/Goods");
        private int selectedProduct = -1;
        private Bitmap selectedProductImg = null;
        private OrderItem oi = null;
        private CustomerInfo cusInfo = null;
        private List<object> appointments = null;
        private double totalAmount;
        private int discount;
        private BackgroundWorker bgWorker = new BackgroundWorker();

        public POS()
        {
            InitializeComponent();
            GetAll();
        }
        /*
         * Dom Style/Event Process
         */

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            selectedProduct = -1;
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                GetAll();
            }
            else
            {
                string str = "";
                str = "GTINCode:" + this.SearchBarTxt.Texts;
                if (CatalogueCombox.SelectedIndex != 0)
                {
                    str += $"|_catalogueId:{CatalogueCombox.SelectedIndex}";
                }
                GetByQry(str);
            }
        }


        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeCartGridView()
        {
            //Main data column
            dt = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(orderItems));
            bs.DataSource = dt;
            CartItemGrid.AutoGenerateColumns = false;
            CartItemGrid.DataSource = dt;
            DiscountValue.Texts = discount.ToString();
            CalculateTotal();
            this.Invalidate();
        }

        private void AddItem()
        {
            bool isExist = false;
            if (orderItems.Count == 0)
            {
                orderItems.Add(oi);
            }
            else
            {
                for (int i = 0; i < orderItems.Count; i++)
                {
                    //Check if an order item exists in the shopping cart
                    if (((OrderItem)orderItems[i]).SupplierGoodsStockId == oi.SupplierGoodsStockId)
                    {
                        ((OrderItem)orderItems[i]).Quantity += 1;
                        isExist = true;
                        break;
                    }
                }
                if (isExist == false)
                {
                    orderItems.Add(oi);
                }
            }
            oi = null;
            InitializeCartGridView();
        }

        private void ChangeCheckedBtn_Style(RoundButton sender)
        {
            sender.BorderColor = Color.SeaGreen;
            sender.ForeColor = Color.SeaGreen;
        }
        private void ResetBtn_Style(RoundButton sender)
        {

            sender.BorderColor = Color.LightGray;
            sender.ForeColor = Color.LightGray;

        }

        private void roundButton4_MouseLeave(object sender, EventArgs e)
        {
            ResetBtn_Style((RoundButton)sender);
        }

        private void AddToCart(List<OrderItem> cartList)
        {
            foreach (OrderItem cart in cartList)
            {
                CartItemGrid.Rows.Add(cart.Name, Properties.Resources.minus, cart.Quantity, Properties.Resources.plus24, cart.Price, cart.Remark);
            }
        }

        private void AddLabelBtn_Click(object sender, EventArgs e)
        {
            if (selectedProduct == -1)
            {
                MessageBox.Show("You have not selected a product!");
                return;
            }
            Form goodsDetails = Application.OpenForms["GoodsDetails"];
            if (goodsDetails != null)
            {
                goodsDetails.Close();
                goodsDetails.Dispose();
            }
            GoodsDetails gd = new GoodsDetails();
            gd.goodsData = goods[selectedProduct];
            gd.Show();
            gd.TopLevel = true;
            oi = (OrderItem)gd.oi;
            gd.OnExit += AddItem;
        }

        private void CartItemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CartItemGrid.Columns["plus"].Index)
            {
                int qty = Convert.ToInt32(CartItemGrid["qty", e.RowIndex].Value);
                if (qty >= ((OrderItem)orderItems[e.RowIndex]).Stock && ((OrderItem)orderItems[e.RowIndex]).NeedBooking == false)
                {
                    MessageBox.Show("Product is out of stock! \n You should click the booking button to \n create a booking order.");
                    return;
                }
                CartItemGrid["qty", e.RowIndex].Value = ++qty;
                ((OrderItem)orderItems[e.RowIndex]).Quantity = qty;
            }
            else if (e.ColumnIndex == CartItemGrid.Columns["sub"].Index)
            {
                int qty = Convert.ToInt32(CartItemGrid["qty", e.RowIndex].Value);
                if (qty <= 1)
                {
                    qty = 1;
                    MessageBox.Show("Quantity is at least one!");
                    return;
                }
                CartItemGrid["qty", e.RowIndex].Value = --qty;
                ((OrderItem)orderItems[e.RowIndex]).Quantity = qty;
            }
            else if (e.ColumnIndex == CartItemGrid.Columns["delete"].Index)
            {
                orderItems.RemoveAt(e.RowIndex);
                InitializeCartGridView();
                return;
            }
            CalculateTotal();
        }

        private void HoldBtn_MouseHover(object sender, EventArgs e)
        {
            HoldBtn.TextColor = Color.White;
        }

        private void HoldBtn_MouseLeave(object sender, EventArgs e)
        {
            HoldBtn.TextColor = HoldBtn.BorderColor;
        }

        private void CancelBtn_MouseHover(object sender, EventArgs e)
        {
            ClearBtn.TextColor = Color.White;
        }

        private void CancelBtn_MouseLeave(object sender, EventArgs e)
        {
            ClearBtn.TextColor = ClearBtn.BorderColor;
        }

        private void CalculateTotal()
        {
            int qty = 1;
            double price = 0.0;
            double total = 0.0;
            double subTotal = 0.0;
            foreach (DataGridViewRow row in CartItemGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == CartItemGrid.Columns["qty"].Index)
                    {
                        qty = Convert.ToInt32(cell.Value);
                    }
                    if (cell.ColumnIndex == CartItemGrid.Columns["price"].Index)
                    {
                        price = Convert.ToDouble(cell.Value);
                    }
                    subTotal = qty * price;
                }
                total += subTotal;
            }
            if (DiscountValue.Texts != "")
            {
                Console.WriteLine(discount);
                total *= (100.0 - discount) / 100;
                Console.WriteLine(total);
            }
            totalAmount = total;
            TotalAmountTxt.Text = String.Format("{0:C2}", totalAmount);
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OrderManagement od = new OrderManagement();
            od.TopLevel = false;
            od.Dock = DockStyle.Fill;
            this.Controls.Add(od);
            this.Tag = od;
            od.BringToFront();
            od.Show();
        }

        private void CatalogueCombox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = -1;
            if (CatalogueCombox.SelectedIndex != 0)
            {
                GetByQry($"_catalogueId:{CatalogueCombox.SelectedIndex}");
            }
            else
            {
                GetAll();
            }
        }

        private void CatalogueCombox_Load(object sender, EventArgs e)
        {
            var response = cbCatalogue.GetAll();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var catalogues = JArray.Parse(response.Content);
                CatalogueCombox.Items.Add("All");
                foreach (var c in catalogues)
                {
                    CatalogueCombox.AutoCompleteCustomSource.Add(c["Name"].ToString());
                    CatalogueCombox.Items.Add(c["Name"].ToString());
                }
            }
        }

        private void GetAll()
        {
            ProductInfoContainer.Controls.Clear();
            goods.Clear();
            RestResponse response;
            bgWorker.RunWorkerAsync(response = cbGoods.GetAll());
            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                InitList(response.Content);
            }
        }
        private void GetByQry(string str)
        {
            ProductInfoContainer.Controls.Clear();
            goods.Clear();
            var response = cbGoods.GetByQueryString(str);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                InitList(response.Content);
            }
        }

        private void InitList(string json)
        {
            var list = JArray.Parse(json);
            foreach (JObject c in list)
            {
                JToken storeStock = c["StockLevel"]["inStoreStock"];
                JToken warehouseStock = c["StockLevel"]["warehouseStock"];
                if (storeStock.Type == JTokenType.Null && warehouseStock.Type == JTokenType.Null)
                {
                    continue;
                }
                if ((int)c["GoodsStatus"] == 2)
                {
                    continue;
                }
                goods.Add(c);
                Bitmap img = null;
                JToken token = c["Photo"];
                if (token.Type != JTokenType.Null)
                {
                    byte[] byteBuffer = Convert.FromBase64String(c["Photo"].ToString());
                    MemoryStream memoryStream = new MemoryStream(byteBuffer);
                    img = new Bitmap(memoryStream);
                    memoryStream.Close();
                }
                else
                {
                    img = Properties.Resources.product;
                }
                ProductInfo productBox = new ProductInfo();
                productBox.Title = c["GoodsName"].ToString();
                productBox.ProductPrice = (double)c["Price"];
                productBox.Image = img;
                productBox.BorderSelectedColor = Color.SeaGreen;
                productBox.PicInfoClicked += new EventHandler(PictureBox_Click);
                ProductInfoContainer.Controls.Add(productBox);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (selectedProduct != -1)
            {
                ((ProductInfo)ProductInfoContainer.Controls[selectedProduct]).IsSelected = false;
            }
            selectedProduct = ProductInfoContainer.Controls.IndexOf(((System.Windows.Forms.Control)sender).Parent);
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            bool isBook = false;
            bool isDelivery = false;
            bool isInstall = false;
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Shopping Cart is empty!");
                return;
            }

            // check book
            foreach (OrderItem item in orderItems)
            {
                // if an item need to book
                if (item.NeedBooking == true)
                {
                    //search whether all items need to book
                    foreach (OrderItem item1 in orderItems)
                    {
                        //not all -> show error message
                        if (item1.NeedBooking == false)
                        {
                            MessageBox.Show("Unable to combine current sale items and pre-order items in one order. \nPlease orders them to divide into 2 orders.");
                            return;
                        }
                    }
                    isBook = true;
                    break;
                }
            }

            // check delivery
            foreach (OrderItem item in orderItems)
            {
                // if an item need to book
                if (item.NeedDelivery == true)
                {
                    //search whether all items need to book
                    foreach (OrderItem item1 in orderItems)
                    {
                        //not all -> show error message
                        if (item1.NeedDelivery == false)
                        {
                            MessageBox.Show("Unable to combine the goods that need to \nbe picked up and delivered in one order. \nPlease orders them to divide into 2 orders.");
                            return;
                        }
                    }
                    isDelivery = true;
                    break;
                }
            }

            // check install
            foreach (OrderItem item in orderItems)
            {
                Console.WriteLine(item.NeedInstall);
                // if an item need to book
                if (item.NeedInstall == true)
                {
                    isDelivery = true;
                    isInstall = true;
                    break;
                }
            }

            if (isBook && isDelivery) //need book and delivery
            {
                DialogResult dialogResult = MessageBox.Show("Since the item(s) is/are out of stock in warehouse." +
                    "\nUnable to predict the arrival time. \nDo you want to continue to place the order?", "Warming", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenBooking();
                }
            }
            else if (isBook) //need book but not need to deliver
            {
                DialogResult dialogResult = MessageBox.Show("Since the item(s) is/are out of stock in store." +
                    "\nUnable to predict the arrival time. \nDo you want to continue to place the order?", "Warming", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenBooking();
                }
            }
            else if (isDelivery)//need to deliver but not book
            {
                DialogResult dialogResult = MessageBox.Show("The item(s) should be delivered from the warehouse." +
                    "\nPlease enter the customer information.", "Warming");
                OpenAppointment(isInstall);
            }
            else
            {
                OpenPaymentMethod();
            }
        }

        public void OpenBooking()
        {
            Booking book = new Booking();
            book.totalAmount = totalAmount;
            book.ShowDialog();
        }

        public void OpenAppointment(bool isInstall)
        {
            Appointment_Add appointment = new Appointment_Add();
            appointment.SetNeedInstall(isInstall);
            appointment.ShowDialog();
            appointment.goodsList = orderItems;
        }

        public void OpenPaymentMethod()
        {
            PaymentMethod payment = new PaymentMethod();
            payment.data = CombineData();
            payment.totalAmount = totalAmount;
            payment.ShowDialog();
        }

        private Dictionary<string, object> CombineData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("salesOrderItems", orderItems);
            if (appointments != null)
            {
                data.Add("appointments", appointments);
            }
            if (cusInfo != null)
            {
                data.Add("customer", cusInfo);
            }
            return data;
        }

        private void DiscountValue__TextChanged(object sender, EventArgs e)
        {
            string discountTxt = DiscountValue.Texts;
            if (discountTxt.Trim() == "") return;
            for (int i = 0; i < discountTxt.Length; i++)
            {
                if (!char.IsNumber(discountTxt[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    DiscountValue.Texts = "";
                    return;
                }
            }
            try
            {
                discount = Convert.ToInt32(DiscountValue.Texts);
                if (discount > 100)
                {
                    MessageBox.Show("Discount cannot more than 100!");
                    DiscountValue.Texts = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number");
                DiscountValue.Texts = "";
                return;
            }
        }

        private void DiscountValue__Leave(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        public void ClearOrder()
        {
            discount = 0;
            totalAmount = 0;
            orderItems.Clear();
            goods.Clear();
            cusInfo = null;
            oi = null;
            Form payment = Application.OpenForms["PaymentMethod"];
            if (payment != null)
            {
                payment.Close();
                payment.Dispose();
            }

            Form appointment = Application.OpenForms["Appointment_Add"];
            if (appointment != null)
            {
                appointment.Close();
                appointment.Dispose();
            }

            Form booking = Application.OpenForms["Booking"];
            if (booking != null)
            {
                booking.Close();
                booking.Dispose();
            }
            InitializeCartGridView();
            GetAll();
            GC.Collect();
        }

        public void SetCusInfo(object customer)
        {
            this.cusInfo = (CustomerInfo)customer;
        }
        public void SetAppointments(List<object> appointments)
        {
            this.appointments = appointments;
        }

        private void defectItemBtn_MouseHover(object sender, EventArgs e)
        {
            defectItemBtn.TextColor = Color.White;
        }

        private void defectItemBtn_MouseLeave(object sender, EventArgs e)
        {
            defectItemBtn.TextColor = defectItemBtn.BorderColor;
        }

        private void OrderBtn_MouseHover(object sender, EventArgs e)
        {
            OrderBtn.TextColor = Color.White;
        }

        private void OrderBtn_MouseLeave(object sender, EventArgs e)
        {
            OrderBtn.TextColor = OrderBtn.BorderColor;
        }

        private void settleAccBtn_MouseHover(object sender, EventArgs e)
        {
            settleAccBtn.TextColor = Color.White;
        }

        private void settleAccBtn_MouseLeave(object sender, EventArgs e)
        {
            settleAccBtn.TextColor = OrderBtn.BorderColor;
        }
    }
}
