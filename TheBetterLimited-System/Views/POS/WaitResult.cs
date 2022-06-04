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
    public partial class WaitResult : Form
    {
        private GoodsController uc = new GoodsController();
        private ControllerBase cbSupplierGoodsStock = new ControllerBase("Supplier_Goods_Stock");
        private ControllerBase cbSupplierGoods = new ControllerBase("Supplier_Goods");
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public JObject goodsData { get; set; }
        private OrderItem oi = new OrderItem();

        public event Action OnExit;
        Timer timer = new Timer();

        public WaitResult()
        {
            InitializeComponent();
            this.TopLevel = true;
            timer.Interval = 3000;
            timer.Tick += new System.EventHandler(OnTimerEvent);
            timer.Start();
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            timer.Stop();
            Receipt receipt = new Receipt();
            this.Hide();
            receipt.ShowDialog();
        }
    }
}
