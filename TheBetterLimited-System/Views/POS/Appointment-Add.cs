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
    public partial class Appointment_Add : Form
    {
        private GoodsController uc = new GoodsController();
        private ControllerBase cbSupplierGoodsStock = new ControllerBase("Supplier_Goods_Stock");
        private ControllerBase cbSupplierGoods = new ControllerBase("Supplier_Goods");
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public JObject goodsData { get; set; }
        private OrderItem oi = new OrderItem();
        private object cusInfo;

        public Appointment_Add()
        {
            InitializeComponent();
        }


        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<object> updatedData = new List<object>();
            
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            if (NameTxt.Texts.Equals(String.Empty) || NameTxt.Texts.Equals(NameTxt.Placeholder))
            {
                NameTxt.IsError = true;
                return;
            }
            var name = NameTxt.Text;

            if (PhoneTxt.Texts.Equals(String.Empty) || PhoneTxt.Texts.Equals(NameTxt.Placeholder))
            {
                PhoneTxt.IsError = true;
                return;
            }
            var phone = PhoneTxt.Text;

            if (AddressTxt.Texts.Equals(String.Empty) || AddressTxt.Texts.Equals(NameTxt.Placeholder))
            {
                AddressTxt.IsError = true;
                return;
            }
            var address = AddressTxt.Text;

            if (DelieverySessionCombo.SelectedIndex == null)
            {
                DelieverySessionCombo.Focus();
                return;
            }

            if (InstallSessionCombo.SelectedIndex == null)
            {
                InstallSessionCombo.Focus();
                return;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void NameTxt_Click(object sender, EventArgs e)
        {
            NameTxt.IsError=false;
        }

        private void PhoneTxt_Click(object sender, EventArgs e)
        {
            PhoneTxt.IsError = false;
        }

        private void AddressTxt_Click(object sender, EventArgs e)
        {
            AddressTxt.IsError = false;
        }

        private void Appointment_Add_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;
            
        }

        private void GetSession()
        {
            
        }
    }
}
