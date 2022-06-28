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
        private bool needDelivery = false;

        public GoodsDetails()
        {
            InitializeComponent();
        }

        public void InitInfo()
        {
            //init icon
        
            RestRequest req = new RestRequest("/api/pos/goods/" + goodsData["GoodsId"] + "/image", Method.Get)
                                .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"]);

            var photo = Utils.RestClientUtils.client.DownloadDataAsync(req).GetAwaiter().GetResult();
            if (photo is null)
            {
                IconPic.Image = Properties.Resources.product;
            }
            else 
            {
                using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
                {
                            
                    ms.Write(photo, 0, photo.Length);

                    // convert image to bitmap
                    IconPic.Image = new Bitmap(ms);
                    ms.Close();
                }
            }

            GoodsIDTxt.Texts = goodsData["GoodsId"].ToString();
            GTINCodeTxt.Texts = goodsData["GTINCode"].ToString();
            DescriptionTxt.Texts = goodsData["Description"].ToString();
            PriceTxt.Texts = String.Format("{0:C2}", goodsData["Price"]);
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
                stock = (int)goodsData["StockLevel"]["warehouseStock"][0]["stock"];
                StockTxt.Texts = stock.ToString();
                stockLevel = (int)goodsData["StockLevel"]["warehouseStock"][0]["status"];
                ShowStockLevel(stockLevel);
                goodsId = goodsData["StockLevel"]["warehouseStock"][0]["_supplier_Goods_Stock_Id"].ToString();
                needDelivery = true;
            }
            CatalogueTxt.Texts = goodsData["Catalogue"].ToString();
            ((RoundPanel)SizeGroup.Controls[(int)goodsData["GoodsSize"]]).BorderColor = Color.DimGray;
            ((Label)SizeGroup.Controls[(int)goodsData["GoodsSize"]].Controls[0]).ForeColor = Color.DimGray;
            ((RoundPanel)StatusGroup.Controls[(int)goodsData["GoodsStatus"]]).BorderColor = ShowPanelColor((int)goodsData["GoodsStatus"]);
            ((Label)StatusGroup.Controls[(int)goodsData["GoodsStatus"]].Controls[0]).ForeColor = ShowPanelColor((int)goodsData["GoodsStatus"]);
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
                    StockLevelTxt.Texts = "Re-order";
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

        private Color ShowPanelColor(int index)
        {
            Color c = new Color();
            switch (index)
            {
                case 2:
                    c = Color.FromArgb(203, 32, 39);
                    break;
                case 1:
                    c = Color.FromArgb(250, 182, 99);
                    break;
                default:
                    c = Color.SeaGreen;
                    break;
            }
            return c;
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
                DialogResult result = MessageBox.Show("Product is out of stock! \nDo you need to book this product?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }else
                {
                    ((OrderItem)oi).NeedBooking = true;
                }
            }

            if(((int)goodsData["GoodsSize"]) == 2)
            {
                ((OrderItem)oi).NeedInstall = true;
            }
            ((OrderItem)oi).SupplierGoodsStockId = goodsId;
            ((OrderItem)oi).Name = goodsData["GoodsName"].ToString();
            ((OrderItem)oi).Price = (int)goodsData["Price"];
            ((OrderItem)oi).Stock = stock;
            ((OrderItem)oi).NeedDelivery = needDelivery;
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }
    }
}
