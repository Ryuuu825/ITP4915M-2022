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
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;

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
        private List<OrderItem> oi = new List<OrderItem>();

        public POS()
        {
            InitializeComponent();
            this.CartItemGrid.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CartItemGrid.Rows.Add("SIEMENS WM12N270HK 7KG 1200RPM Front Load Washer", Properties.Resources.minus, "1", Properties.Resources.plus24, NumberFormatInfo.CurrentInfo.CurrencySymbol + "35.00", "none");
            CartItemGrid.Rows.Add("MIELE WCR860 W1 9KG 1600RPM Front Load WasherX", Properties.Resources.minus, "1", Properties.Resources.plus24, NumberFormatInfo.CurrentInfo.CurrencySymbol+"35.00", "");
            CartItemGrid.Rows.Add("MIELE WCA020 WCS Active 7KG 1400RPM Front Load Washer", Properties.Resources.minus, "1", Properties.Resources.plus24, NumberFormatInfo.CurrentInfo.CurrencySymbol+"35.00", "");
            CartItemGrid.Rows.Add("TOSHIBA TWBL85A2HWW 7.5KG 440mm Ultra Slim Inverter Front Loading Washing Machine Front Load Washer", Properties.Resources.minus, "1", Properties.Resources.plus24, NumberFormatInfo.CurrentInfo.CurrencySymbol+"35.00", "");
            for(int i=0; i < 100; i++)
            {
                ProductInfo productBox = new ProductInfo();
                productBox.Title = "SIEMENS WM12N270HK 7KG 1200RPM Front Load Washer";
                productBox.ProductPrice = 88.88;
                productBox.Image = Properties.Resources.product;
                productBox.BorderSelectedColor = Color.SeaGreen;
                ProductInfoContainer.Controls.Add(productBox);
            }
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

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            foreach (RoundButton rdb in CatalogBtnGroup.Controls)
            {
                Console.WriteLine("checked");
                if (rdb.IsChecked == true)
                {
                    Console.WriteLine("checked");
                    rdb.IsChecked = false;
                    ResetBtn_Style(rdb);
                    break;
                } 
            }
            ((RoundButton)sender).IsChecked = true;
            ChangeCheckedBtn_Style((RoundButton)sender);
        }

        private void CatalogBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeCheckedBtn_Style((RoundButton)sender);
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
                CartItemGrid.Rows.Add(cart.Name, Properties.Resources.minus, cart.Quantity, Properties.Resources.plus24, NumberFormatInfo.CurrentInfo.CurrencySymbol + cart.Price, cart.Remark);
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
            if(this.WindowState != FormWindowState.Maximized)
            {
                CatalogBtnGroup.Hide();
            }
        }

        private void POS_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                CatalogBtnGroup.Show();
            }
        }
    }
}
