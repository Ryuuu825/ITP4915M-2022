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
        private RestResponse response = new RestResponse();
        private ControllerBase cbSession = new ControllerBase("pos/session");
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

            CustomerInfo cusInfo = new CustomerInfo(name, phone, address);
            Appointment appointment = new Appointment();
        }

        private void NameTxt_Click(object sender, EventArgs e)
        {
            NameTxt.IsError = false;
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
            List<string> sessions = new List<string>();
            sessions = InitSession(DeliveryDatePicker.Value.Month, DeliveryDatePicker.Value.Day, "300");
            foreach (var item in sessions)
            {
                DeliverySessionCombo.Items.Add(item);
            }
        }

        private void DeliverySessionCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> sessions = new List<string>();
            InstallSessionCombo.Items.Clear();
            InstallSessionCombo.SelectedIndex = -1;
            InstallSessionCombo.Texts = "Installation Session";
            
            sessions = InitSession(InstallDatePicker.Value.Month, InstallDatePicker.Value.Day, "700");
            foreach (var item in sessions)
            {
                InstallSessionCombo.Items.Add(item);
            }
        }

        //init session form server
        private List<string> InitSession(int month, int day, string departmentId)
        {
            var items = new List<string>();
            response = cbSession.GetByQueryString($"month:{month}&day:{day}&departmentId:{departmentId}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
                JArray session = JArray.Parse(response.Content);
                foreach (JObject sessionItem in session)
                {
                    session.Add(sessionItem);
                    string item = $"{sessionItem["StartTime"]["hour"]}:{sessionItem["StartTime"]["minute"]} - {sessionItem["EndTime"]["hour"]}:{sessionItem["EndTime"]["minute"]}";
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
