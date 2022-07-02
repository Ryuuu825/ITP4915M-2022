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
        private RestResponse response;
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
        private BackgroundWorker bw = new BackgroundWorker();
        private bool loadAll = true;
        private string QryString = "";

        public POS()
        {
            InitializeComponent();
            showLoading();
            initBackgroundWorker();
            bw.RunWorkerAsync();
        }
        /*
         * Dom Style/Event Process
         */

        private void initBackgroundWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void showLoading()
        {
            Loading load = new Loading();
            load.TopLevel = false;
            load.Dock = DockStyle.Fill;
            loadPic.Controls.Add(load);
            loadPic.Tag = load;
            loadPic.BringToFront();
            load.Show();
            loadPic.Show();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (loadAll)
            {
                response = cbGoods.GetAll(lang:CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
            }else
            {
                response = cbGoods.GetByQueryString(QryString, lang: CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GetAll();
            loadPic.Hide();
            loadPic.Controls.Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadAllGoods()
        {
            showLoading();
            loadAll = true;
            try
            {
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Goods are loading.\nPlease wait a moment!");
            }
        }

        public void LoadQryGoods()
        {
            showLoading();
            loadAll = false;
            try
            {
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The goods are loading.\nPlease wait a moment!");
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
            if (orderItems is null || orderItems.Count == 0)
            {
                orderItems = new List<object>();
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

        private void CartItemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CartItemGrid.Columns["plus"].Index)
            {
                int qty = Convert.ToInt32(CartItemGrid["qty", e.RowIndex].Value);
                if (qty >= ((OrderItem)orderItems[e.RowIndex]).Stock && ((OrderItem)orderItems[e.RowIndex]).NeedBooking == false)
                {
                    MessageBox.Show("Quantity reaches the stock maximum.");
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
                total *= (100.0 - discount) / 100;
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
            if (CatalogueCombox.SelectedIndex > 0)
            {
                QryString = $"_catalogueId:{CatalogueCombox.SelectedIndex}";
                LoadQryGoods();
            }
            else
            {
                LoadAllGoods();
            }
        }

        private void CatalogueCombox_Load(object sender, EventArgs e)
        {
            var response = cbCatalogue.GetAll(lang: CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
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
                if (c["StockLevel"]["inStoreStock"].Type == JTokenType.Null && c["StockLevel"]["warehouseStock"].Type == JTokenType.Null)
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

                RestRequest req = new RestRequest("/api/pos/goods/" + c["GoodsId"] + "/image", Method.Get)
                                    .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"]);

                var photo = Utils.RestClientUtils.client.DownloadDataAsync(req).GetAwaiter().GetResult();
                try
                {
                    using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
                    {

                        ms.Write(photo, 0, photo.Length);

                        // convert image to bitmap
                        img = new Bitmap(ms);
                        ms.Close();
                    }
                }
                catch (Exception ex)
                {
                    img = Properties.Resources.product1;
                }

                ProductInfo productBox = new ProductInfo();
                productBox.Title = c["GoodsName"].ToString();
                productBox.ProductPrice = (double)c["Price"];
                productBox.Image = img;
                productBox.BorderSelectedColor = Color.SeaGreen;
                productBox.PicInfoClicked += new EventHandler(PictureBox_Click);
                ProductInfoContainer.Controls.Add(productBox);
                response = null;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (selectedProduct != -1)
            {
                ((ProductInfo)ProductInfoContainer.Controls[selectedProduct]).IsSelected = false;
            }
            selectedProduct = ProductInfoContainer.Controls.IndexOf(((System.Windows.Forms.Control)sender).Parent);
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

        private void PayBtn_Click(object sender, EventArgs e)
        {
            bool isBook = false;
            bool isDelivery = false;
            bool isInstall = false;
            cusInfo = null;
            appointments = null;
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
                    "\nUnable to predict the arrival time. \nDo you want to continue to place the order?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenBooking();
                }
            }
            else if (isBook) //need book but not need to deliver
            {
                DialogResult dialogResult = MessageBox.Show("Since the item(s) is/are out of stock in store." +
                    "\nUnable to predict the arrival time. \nDo you want to continue to place the order?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenBooking();
                }
            }
            else if (isDelivery)//need to deliver but not book
            {
                DialogResult dialogResult = MessageBox.Show("The item(s) should be delivered from the warehouse." +
                    "\nPlease enter the customer information.", "Warning");
                OpenAppointment(isInstall);
            }
            else
            {
                OpenPaymentMethod(false);
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

        public void OpenPaymentMethod(bool isBook)
        {
            PaymentMethod payment = new PaymentMethod();
            payment.SetNeedBook(isBook);
            payment.data = CombineData();
            payment.totalAmount = totalAmount;
            payment.ShowDialog();
        }

        private Dictionary<string, object> CombineData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            foreach (OrderItem item in orderItems)
            {
                item.Price *= (100.0 - discount) / 100;
            }
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
            loadAll = true;
            discount = 0;
            totalAmount = 0;
            orderItems = null;
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
        }

        public void SetCusInfo(object customer)
        {
            this.cusInfo = (CustomerInfo)customer;
        }
        public void SetAppointments(List<object> appointments)
        {
            this.appointments = appointments;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBtn.Focus();
            selectedProduct = -1;
            CatalogueCombox.Texts = "Catalogue";
            ProductInfoContainer.Controls.Clear();
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                this.SearchBarTxt.Texts = SearchBarTxt.Placeholder;
                LoadAllGoods();
            }
            else
            {
                QryString = "GTINCode:" + this.SearchBarTxt.Texts;
                LoadQryGoods();
            }
        }

        private void settleAccBtn_Click(object sender, EventArgs e)
        {
            SettleAccount st = new SettleAccount();
            st.Show();
        }

        private void OrderDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (CartItemGrid.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void OrderDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Quantity value is invaild");
            CartItemGrid.CancelEdit();
        }

        private void OrderDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qty = Convert.ToInt32(CartItemGrid["qty", e.RowIndex].Value);
            if (qty > ((OrderItem)orderItems[e.RowIndex]).Stock && ((OrderItem)orderItems[e.RowIndex]).NeedBooking == false)
            {
                MessageBox.Show("Quantity exceeds the stock maximum.");
                CartItemGrid["qty", e.RowIndex].Value = ((OrderItem)orderItems[e.RowIndex]).Quantity;
                return;
            }
            if (qty <= 0)
            {
                MessageBox.Show("Quantity is at least one.");
                CartItemGrid["qty", e.RowIndex].Value = ((OrderItem)orderItems[e.RowIndex]).Quantity;
                return;
            }
            ((OrderItem)orderItems[e.RowIndex]).Quantity = Convert.ToInt32(CartItemGrid["qty", e.RowIndex].Value);
        }
    }
}
