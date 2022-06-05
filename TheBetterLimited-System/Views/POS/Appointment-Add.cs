using Newtonsoft.Json;
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
        private RestResponse response = new RestResponse();
        private SessionController cbSession = new SessionController("pos/session");
        private bool isUpload = false;
        private Bitmap icon = null;
        public JObject goodsData { get; set; }
        public List<object> goodsList { get; set; }
        public bool needInstall;
        private string deliverySessionId = null;
        private string installSessionId = null;
        List<Session> deliverySessions = new List<Session>();
        List<Session> installSessions = new List<Session>();

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
                MessageBox.Show("Please select delivery session");
                return;
            }

            if (InstallSessionCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select installation session");
                return;
            }

            CustomerInfo cusInfo = new CustomerInfo(name, phone, address);
            List<object> list = new List<object>();
            list.Add(new { sessionId = deliverySessionId, _departmentId = "300"});
            if(installSessionId != null)
            {
                list.Add(new { sessionId = installSessionId, _departmentId = "700" });
            }
            Form pos = Application.OpenForms["POS"];
            ((POS)pos).SetCusInfo(cusInfo);
            ((POS)pos).SetAppointments(list);
            ((POS)pos).OpenPaymentMethod();
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
            DeliveryDatePicker.MaxDate = DateTime.Now.AddMonths(1);
            InstallDatePicker.MaxDate = DateTime.Now.AddMonths(1);
        }

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            InstallDatePicker.MinDate = DeliveryDatePicker.Value;
            ResetDeliveryComboBox();
            ResetInstallComboBox();
            deliverySessions.Clear();
            installSessions.Clear();
            deliverySessions = InitSession(DeliveryDatePicker.Value.Month, DeliveryDatePicker.Value.Day, "300");
            foreach (Session item in deliverySessions)
            {
                DeliverySessionCombo.Items.Add(item.StartTime1.ToString("HH:mm") + " - " + item.EndTime1.ToString("HH:mm"));
            }
            DeliveryDatePicker.MaxDate = deliverySessions.Last().Date1.AddDays(10);
        }

        private void DeliverySessionCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            InitInstallComboBox();
            deliverySessionId = deliverySessions[DeliverySessionCombo.SelectedIndex].ID1;
        }

        //init session form server
        private List<Session> InitSession(int month, int day, string departmentId)
        {
            response = cbSession.GetAll(month, day, departmentId);
            Console.WriteLine(response.StatusCode);
            List<Session> sessions = new List<Session>();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
                sessions = JsonConvert.DeserializeObject<List<Session>>(response.Content);
            }
            return sessions;
        }

        private void ResetDeliveryComboBox()
        {
            DeliverySessionCombo.Items.Clear();
            DeliverySessionCombo.SelectedIndex = -1;
            DeliverySessionCombo.Texts = "Delivery Session";
            deliverySessionId = null;
        }
        private void ResetInstallComboBox()
        {
            InstallSessionCombo.Items.Clear();
            InstallSessionCombo.SelectedIndex = -1;
            InstallSessionCombo.Texts = "Installation Session";
            installSessionId = null;
        }

        private void InitInstallComboBox()
        {
            ResetInstallComboBox();
            installSessions.Clear();
            installSessions = InitSession(InstallDatePicker.Value.Month, InstallDatePicker.Value.Day, "700");
            for (int i = 0; i < installSessions.Count; i++)
            {
                Console.WriteLine(DeliveryDatePicker.Value);
                Console.WriteLine(installSessions[i].Date1);
                if (i <= DeliverySessionCombo.SelectedIndex && installSessions[i].Date1 == DeliveryDatePicker.Value.Date)
                {
                    continue;
                }
                if (installSessions[i].NumOfAppointments1 > 0)
                {
                    InstallSessionCombo.Items.Add(installSessions[i].StartTime1.ToString("HH:mm") + " - " + installSessions[i].EndTime1.ToString("HH:mm"));
                }
            }
        }

        private void InstallDatePicker_ValueChanged(object sender, EventArgs e)
        {
            InitInstallComboBox();
        }

        private void InstallSessionCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            installSessionId = installSessions[InstallSessionCombo.SelectedIndex].ID1;
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
