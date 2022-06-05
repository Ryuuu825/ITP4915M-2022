using Newtonsoft.Json.Linq;
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
        public object oi = new OrderItem();
        private int stock;
        private int stockLevel;
        private string goodsId;
        private bool needDelivery;

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
                needDelivery = false;
            }
            else
            {
                LocTxt.Texts = "In Warehouse";
                stock = (int)goodsData["StockLevel"]["warehouseStock"][0]["stock"];
                StockTxt.Texts = stock.ToString();
                stockLevel = (int)goodsData["StockLevel"]["warehouseStock"][0]["status"];
                ShowStockLevel(stockLevel);
                goodsId = goodsData["StockLevel"]["warehouseStock"][0]["_supplier_Goods_Stock_Id"].ToString();
                needDelivery = true;
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
                    StockLevelTxt.ForeColor = Color.FromArgb(250, 182, 99);
                    break;
                case 2:
                    StockLevelTxt.Texts = "Normal";
                    break;
                case 3:
                    StockLevelTxt.Texts = "Danger";
                    StockLevelTxt.ForeColor = Color.FromArgb(250, 182, 99);
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
                DialogResult result = MessageBox.Show("Product is out of stock! \nDo you need to book this product?", "Warming", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }else
                {
                    ((OrderItem)oi).NeedBooking = true;
                }
            }

            ((OrderItem)oi).SupplierGoodsStockId = goodsId;
            ((OrderItem)oi).Name = goodsData["GoodsName"].ToString();
            ((OrderItem)oi).Price = (double)goodsData["Price"];
            ((OrderItem)oi).Stock = stock;
            ((OrderItem)oi).NeedDelivery = needDelivery;
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }
    }
}
