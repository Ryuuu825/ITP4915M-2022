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
        private UserController uc = new UserController();
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();
        private DialogResult choose;
        private RestResponse result;
        private bool isEditing = false;
        private List<JObject> goods = new List<JObject>();
        private List<OrderItem> orderItems = new List<OrderItem>();
        private ControllerBase cbCatalogue = new ControllerBase("Catalogue");
        private ControllerBase cbGoods = new ControllerBase("Goods");
        private GoodsController gc = new GoodsController();
        private System.Windows.Controls.Control ctl = null;
        private int selectedProduct = -1;
        private Bitmap selectedProductImg = null;

        public POS()
        {
            InitializeComponent();
            this.CartItemGrid.Columns["Price"].HeaderText = "Price("+ NumberFormatInfo.CurrentInfo.CurrencySymbol + ")";
            this.CartItemGrid.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //GetAll();
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
            CalculateTotal();
            this.Invalidate();
        }

        private void AddItem()
        {
            bool isExist = false;
            if (orderItems.Count == 0)
            {
                orderItems.Add(GlobalsData.orderitem);
            }else
            {
                for (int i=0; i < orderItems.Count;i++)
                {
                    //Check if an order item exists in the shopping cart
                    if (orderItems[i].SupplierGoodsStockId == GlobalsData.orderitem.SupplierGoodsStockId)
                    {
                        orderItems[i].Quantity += 1;
                        isExist = true;
                        break;
                    }
                }
                if (isExist == false)
                {
                    orderItems.Add(GlobalsData.orderitem);
                }
            }
            GlobalsData.orderitem = null;
            InitializeCartGridView();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form addUser = Application.OpenForms["Usermanagement_Add"];
            if (addUser == null || addUser.IsDisposed)
            {
                Usermanagement_Add userAdd = new Usermanagement_Add();
                userAdd.Show();
                userAdd.TopLevel = true;
            }
            else
            {
                addUser.Activate();
                addUser.WindowState = FormWindowState.Normal;
            }
        }

        private void ChangeCheckedBtn_Style(RoundButton sender)
        {
            sender.BorderColor = Color.SeaGreen;
            sender.ForeColor = Color.SeaGreen;
        }
        private void ResetBtn_Style(RoundButton sender)
        {
            if (sender.IsChecked == false)
            {
                sender.BorderColor = Color.LightGray;
                sender.ForeColor = Color.LightGray;
            }
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

        private void HoldBtn_Click(object sender, EventArgs e)
        {

        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void POS_Load(object sender, EventArgs e)
        {
            
        }

        private void POS_Resize(object sender, EventArgs e)
        {
            
        }

        private void AddLabelBtn_Click(object sender, EventArgs e)
        {
            if (selectedProduct == -1)
            {
                MessageBox.Show("You have not selected a product!");
                return;
            }
            Form goodsDetauks = Application.OpenForms["GoodsDetails"];
            if (goodsDetauks == null || goodsDetauks.IsDisposed)
            {
                GoodsDetails gd = new GoodsDetails();
                gd.goodsData = goods[selectedProduct];
                gd.Show();
                gd.TopLevel = true;
                gd.OnExit += AddItem;
            }
            else
            {
                goodsDetauks.Activate();
                goodsDetauks.WindowState = FormWindowState.Normal;
            }
        }

        private void CartItemGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CartItemGrid.Columns["plus"].Index)
            {
                int qty = Convert.ToInt32(CartItemGrid["qty", e.RowIndex].Value);
                if(qty >= orderItems[e.RowIndex].Stock)
                {
                    MessageBox.Show("Product is out of stock! \n Do you need to pre-order this product?");
                }
                CartItemGrid["qty", e.RowIndex].Value = ++qty;
                orderItems[e.RowIndex].Quantity = qty;
            }
            else if(e.ColumnIndex == CartItemGrid.Columns["sub"].Index)
            {
                int qty = Convert.ToInt32(CartItemGrid["qty", e.RowIndex].Value);
                if(qty <= 1)
                {
                    qty = 1;
                    MessageBox.Show("Quantity is at least one!");
                    return;
                }
                CartItemGrid["qty", e.RowIndex].Value = --qty;
                orderItems[e.RowIndex].Quantity = qty;
            }
            CalculateTotal();
            this.Invalidate();
        }

        private void HoldBtn_MouseHover(object sender, EventArgs e)
        {
            HoldBtn.ForeColor = Color.White;
        }

        private void HoldBtn_MouseLeave(object sender, EventArgs e)
        {
            HoldBtn.ForeColor = HoldBtn.BorderColor;
        }

        private void CancelBtn_MouseHover(object sender, EventArgs e)
        {
            CancelBtn.ForeColor = Color.White;
        }

        private void CancelBtn_MouseLeave(object sender, EventArgs e)
        {
            CancelBtn.ForeColor = CancelBtn.BorderColor;
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
            TotalAmountTxt.Text = String.Format("{0:C2}", total);
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
            if(CatalogueCombox.SelectedIndex != 0)
            {
                GetByQry(CatalogueCombox.SelectedIndex);
            }
            else
            {
                GetAll();
            }
        }

        private void CatalogueCombox_Load(object sender, EventArgs e)
        {
            var response = cbCatalogue.GetAll();
            if (response.StatusCode == System.Net.HttpStatusCode.OK){
                var catalogues = JArray.Parse(response.Content);
                CatalogueCombox.Items.Add("All");
                foreach (var c in catalogues)
                {
                    CatalogueCombox.AutoCompleteCustomSource.Add(c["Name"].ToString());
                    CatalogueCombox.Items.Add(c["Name"].ToString());
                }
            }
        }

        private void ProductActionBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetAll()
        {
            ProductInfoContainer.Controls.Clear();
            goods.Clear();
            var response = cbGoods.GetAll();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                InitList(response.Content);
            }
        }
        private void GetByQry(int catalogueId)
        {
            ProductInfoContainer.Controls.Clear();
            goods.Clear();
            var response = cbGoods.GetByQueryString($"_catalogueId:{catalogueId}");
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

        private void roundButton2_MouseHover(object sender, EventArgs e)
        {

        }

        private void TotalAmountTxt_Click(object sender, EventArgs e)
        {

        }

        private void CartItemGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
