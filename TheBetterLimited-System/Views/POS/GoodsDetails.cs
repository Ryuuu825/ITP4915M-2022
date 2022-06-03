﻿using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class GoodsDetails : Form
    {
        private GoodsController uc = new GoodsController();
        private ControllerBase cbSupplierGoodsStock = new ControllerBase("Supplier_Goods_Stock");
        private ControllerBase cbSupplierGoods = new ControllerBase("Supplier_Goods");
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public JObject goodsData { get; set; }
        private OrderItem oi = new OrderItem();
        private int stock;
        private int stockLevel;
        private string goodsId;

        public GoodsDetails()
        {
            InitializeComponent();
        }

        public void InitInfo()
        {
            //init icon
            JToken token = goodsData["Photo"];
            if (token.Type != JTokenType.Null)
            {
                byte[] byteBuffer = Convert.FromBase64String(goodsData["Photo"].ToString());
                MemoryStream memoryStream = new MemoryStream(byteBuffer);
                IconPic.Image = new Bitmap(memoryStream);
                memoryStream.Close();
            }
            else
            {
                IconPic.Image = Properties.Resources.product;
            }

            GoodsIDTxt.Texts = goodsData["GoodsId"].ToString();
            GTINCodeTxt.Texts = goodsData["GTINCode"].ToString();
            DescriptionTxt.Texts = goodsData["Description"].ToString();
            PriceTxt.Texts = String.Format("{0:C2}", goodsData["Price"]);
            Console.WriteLine(goodsData["StockLevel"]["inStoreStock"]);
            JToken jt = goodsData["StockLevel"]["inStoreStock"];
            if (jt.Type != JTokenType.Null)
            {
                LocTxt.Texts = "In Store";
                stock = (int)goodsData["StockLevel"]["inStoreStock"]["inStoreStock"];
                StockTxt.Texts = stock.ToString();
                stockLevel = (int)goodsData["StockLevel"]["inStoreStock"]["status"];
                ShowStockLevel(stockLevel);
                goodsId = goodsData["StockLevel"]["inStoreStock"]["_supplier_Goods_Stock_Id"].ToString();
            }
            else
            {
                LocTxt.Texts = "In Warehouse";
                StockTxt.Texts = goodsData["StockLevel"]["warehouseStock"]["stock"].ToString();
                stockLevel = (int)goodsData["StockLevel"]["warehouseStock"]["status"];
                ShowStockLevel(stockLevel);
                goodsId = goodsData["StockLevel"]["warehouseStock"]["_supplier_Goods_Stock_Id"].ToString();
            }
            CatalogueTxt.Texts = goodsData["Catalogue"].ToString();
            ((RadioButton)SizeRadioGroup.Controls[(int)goodsData["GoodsSize"]]).Checked = true;
            ((RadioButton)SizeRadioGroup.Controls[(int)goodsData["GoodsSize"]]).ForeColor = Color.SeaGreen;
            ((RadioButton)StatusRadioGroup.Controls[(int)goodsData["GoodsStatus"]]).Checked = true;
            ((RadioButton)StatusRadioGroup.Controls[(int)goodsData["GoodsStatus"]]).ForeColor = Color.SeaGreen;
            Info.Text = goodsData["GoodsName"].ToString();
        }

        private void ShowStockLevel(int status)
        {
            switch (status)
            {
                case 0:
                    StockLevelTxt.Texts = "Out of Stock";
                    StockLevelTxt.ForeColor = Color.FromArgb(203, 32, 39);
                    break;
                case 1:
                    StockLevelTxt.Texts = "Re-oder";
                    StockLevelTxt.ForeColor = Color.Gold;
                    break;
                case 2:
                    StockLevelTxt.Texts = "Normal";
                    break;
            }
        }

        private void NormalStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            sellRadio.Checked = true;
            phaseOutRadio.Checked = false;
        }

        private void LockStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            sellRadio.Checked = false;
            phaseOutRadio.Checked = true;
        }

        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void GoodsDetails_Load(object sender, EventArgs e)
        {
            InitInfo();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (stockLevel == 0)
            {
                DialogResult result = MessageBox.Show("Current product is out of stock! \n Are you need to book this product?", "Warming", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            GlobalsData.orderitem = new OrderItem();
            GlobalsData.orderitem.SupplierGoodsStockId = goodsId;
            GlobalsData.orderitem.Name = goodsData["GoodsName"].ToString();
            GlobalsData.orderitem.Price = (double)goodsData["Price"];
            GlobalsData.orderitem.Stock = stock;
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }
    }
}
