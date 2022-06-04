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
        public List<object> goodsList { get; set; }
        private List<object> session = new List<object>();

        public Appointment_Add()
        {
            InitializeComponent();
            session.Add("09:00-12:00");
            session.Add("13:00-17:00");
            session.Add("18:00-22:00");
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
            if (NameTxt.Texts.Equals(String.Empty) || NameTxt.Texts.Equals(NameTxt.Placeholder))
            {
                NameTxt.IsError = true;
                return;
            }
            var name = NameTxt.Text;

            if (PhoneTxt.Texts.Equals(String.Empty) || PhoneTxt.Texts.Equals(PhoneTxt.Placeholder))
            {
                PhoneTxt.IsError = true;
                return;
            }
            var phone = PhoneTxt.Text;

            if (AddressTxt.Texts.Equals(String.Empty) || AddressTxt.Texts.Equals(AddressTxt.Placeholder))
            {
                AddressTxt.IsError = true;
                return;
            }
            var address = AddressTxt.Text;

            if (DeliverySessionCombo.SelectedIndex == -1)
            {
                DeliverySessionCombo.Focus();
                return;
            }
            var delieverySession = DeliverySessionCombo.SelectedIndex.ToString();

            if (InstallSessionCombo.SelectedIndex == -1)
            {
                InstallSessionCombo.Focus();
                return;
            }
            var installSession = DeliverySessionCombo.SelectedIndex.ToString();

            CustomerInfo cusInfo = new CustomerInfo(name,phone,address);
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
            DeliveryDatePicker.MinDate = DateTime.Now;
            InstallDatePicker.MinDate = DateTime.Now;
            
        }

        private void GetSession()
        {
            
        }

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            InstallDatePicker.MinDate = DeliveryDatePicker.Value;
        }

        private void DeliverySessionCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            InstallSessionCombo.Items.Clear();
            InstallSessionCombo.SelectedIndex = -1;
            InstallSessionCombo.Texts = "Installation Session";
            for (int i = DeliverySessionCombo.SelectedIndex+1; i < session.Count; i++)
            {
                InstallSessionCombo.Items.Add(session[i].ToString());
            }
        }
    }
}
