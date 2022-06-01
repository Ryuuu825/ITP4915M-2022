using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private List<string> selecteUserId = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private bool isEditing = false;
        private List<object> goods = new List<object>();
        private ControllerBase cbCatalogue = new ControllerBase("Catalogue");
        private ControllerBase cbGoods = new ControllerBase("Goods");
        private GoodsController gc = new GoodsController();
        private System.Windows.Controls.Control ctl = null;
        private int selectedProduct;

        public POS()
        {
            InitializeComponent();
            this.CartItemGrid.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CartItemGrid.Rows.Add("SIEMENS WM12N270HK 7KG 1200RPM Front Load Washer", Properties.Resources.minus, "1", Properties.Resources.plus24, "35.00", "none");
            CartItemGrid.Rows.Add("MIELE WCR860 W1 9KG 1600RPM Front Load WasherX", Properties.Resources.minus, "1", Properties.Resources.plus24, "35.00", "");
            CartItemGrid.Rows.Add("MIELE WCA020 WCS Active 7KG 1400RPM Front Load Washer", Properties.Resources.minus, "1", Properties.Resources.plus24, "35.00", "");
            CartItemGrid.Rows.Add("TOSHIBA TWBL85A2HWW 7.5KG 440mm Ultra Slim Inverter Front Loading Washing Machine Front Load Washer", Properties.Resources.minus, "1", Properties.Resources.plus24, "35.00", "");
            GetAllGoods();
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
        private void InitializeDataGridView()
        {
            //Main data column
            selecteUserId.Clear();
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
            Form goodsDetauks = Application.OpenForms["GoodsDetails"];
            if (goodsDetauks == null || goodsDetauks.IsDisposed)
            {
                GoodsDetails gd = new GoodsDetails();
                gd.Show();
                gd.GoodsInfo(goods[se]);
                gd.TopLevel = true;
                //goodsDetauks.OnExit += Refresh;
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
                CartItemGrid["qty", e.RowIndex].Value = ++qty;
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
            double total = 0;
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
                    total += qty * price;
                }
            }
            TotalAmountTxt.Text = total.ToString();
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
            GetGoodsByCatalogue(CatalogueCombox.SelectedIndex);
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

        private void GetAllGoods()
        {
            ProductInfoContainer.Controls.Clear();
            var response = cbGoods.GetAll();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                InitGoodsList(response.Content);
            }
        }
        private void GetGoodsByCatalogue(int catalogueId)
        {
            ProductInfoContainer.Controls.Clear();
            var response = cbGoods.GetByQueryString($"_catalogueId:{catalogueId}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                InitGoodsList(response.Content);
            }
        }

        private void InitGoodsList(string json)
        {
            var goodsList = JArray.Parse(json);
            foreach (var c in goodsList)
            {
                ProductInfo productBox = new ProductInfo();
                productBox.Title = c["Name"].ToString();
                productBox.ProductPrice = (double)c["Price"];
                productBox.Image = gc.GetGoodsImage(c["Id"].ToString());
                productBox.BorderSelectedColor = Color.SeaGreen;
                productBox.PicInfoClicked += new EventHandler(PictureBox_Click);
                ProductInfoContainer.Controls.Add(productBox);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ((ProductInfo)ProductInfoContainer.Controls[selectedProduct]).IsSelected = false;
            selectedProduct = ProductInfoContainer.Controls.IndexOf(((System.Windows.Forms.Control)sender).Parent);

        }
    }
}
