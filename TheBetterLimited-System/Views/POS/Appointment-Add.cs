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
        private bool needInstall = false;
        private string deliverySessionId = null;
        private string installSessionId = null;
        List<Session> deliverySessions = new List<Session>();
        List<Session> installSessions = new List<Session>();

        public Appointment_Add()
        {
            InitializeComponent();
        }

        public void SetNeedInstall(bool install)
        {
            needInstall = install;
            Console.WriteLine(needInstall);
            if (!needInstall)
            {
                InstallSessionCombo.Enabled = false;
                InstallDatePicker.Enabled = false;
            }
        }

        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
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
            var name = NameTxt.Texts;

            if (PhoneTxt.Texts.Equals(String.Empty) || PhoneTxt.Texts.Equals(PhoneTxt.Placeholder))
            {
                PhoneTxt.IsError = true;
                return;
            }
            var phone = PhoneTxt.Texts;

            if (AddressTxt.Texts.Equals(String.Empty) || AddressTxt.Texts.Equals(AddressTxt.Placeholder))
            {
                AddressTxt.IsError = true;
                return;
            }
            var address = AddressTxt.Texts;

            if (DeliverySessionCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select delivery session");
                return;
            }

            Console.WriteLine(needInstall);
            if (needInstall == true && InstallSessionCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select installation session");
                return;
            }

            CustomerInfo cusInfo = new CustomerInfo(name, phone, address);
            List<object> list = new List<object>();
            list.Add(new { sessionId = deliverySessionId, departmentId = "300" });
            if (needInstall == true)
            {
                list.Add(new { sessionId = installSessionId, departmentId = "700" });
            }
            Form pos = Application.OpenForms["POS"];
            ((POS)pos).SetCusInfo(cusInfo);
            ((POS)pos).SetAppointments(list);
            ((POS)pos).OpenPaymentMethod(false);
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
            DeliveryDatePicker.MinDate = DateTime.Now.AddDays(1);
            InstallDatePicker.MinDate = DateTime.Now.AddDays(1);
            DeliveryDatePicker.MaxDate = DeliveryDatePicker.MinDate.AddDays(29);
            InstallDatePicker.MaxDate = InstallDatePicker.MinDate.AddDays(29);
            if (DeliveryDatePicker.MinDate.DayOfWeek == DayOfWeek.Sunday) return;
            InitDeliveryComboBox();
        }

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DeliveryDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) return;
            InitDeliveryComboBox();
            InstallDatePicker.MinDate = DeliveryDatePicker.Value;
        }

        private void DeliverySessionCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            deliverySessionId = deliverySessions[DeliverySessionCombo.SelectedIndex].ID1;
            InitInstallComboBox();
        }

        //init session form server
        private List<Session> InitSession(int month, int day, string departmentId)
        {
            response = cbSession.GetAll(month, day, departmentId);
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

        private void InitDeliveryComboBox()
        {
            ResetDeliveryComboBox();
            ResetInstallComboBox();
            deliverySessions.Clear();
            installSessions.Clear();
            if (DeliveryDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) return;
            deliverySessions = InitSession(DeliveryDatePicker.Value.Month, DeliveryDatePicker.Value.Day, "300");
            List<Session> removeSession = new List<Session>();
            foreach (Session session in deliverySessions)
            {
                if (session.NumOfAppointments1 <= 0)
                {
                    removeSession.Add(session);
                }
            }

            foreach (Session session in removeSession)
            {
                deliverySessions.Remove(session);
            }
            removeSession.Clear();

            foreach (Session session in deliverySessions)
            {
                DeliverySessionCombo.Items.Add(session.StartTime1.ToString("HH:mm") + " - " + session.EndTime1.ToString("HH:mm"));
            }
        }

        private void InitInstallComboBox()
        {
            ResetInstallComboBox();
            installSessions.Clear();
            if (InstallDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) return;
            installSessions = InitSession(InstallDatePicker.Value.Month, InstallDatePicker.Value.Day, "700");
            List<Session> removeSession = new List<Session>();
            if (InstallDatePicker.Value.Date == DeliveryDatePicker.Value.Date)
            {
                Console.WriteLine(DeliverySessionCombo.SelectedIndex);
                if (DeliverySessionCombo.SelectedIndex != -1)
                {
                    foreach (Session session in installSessions)
                    {
                        if (session.EndTime1 <= deliverySessions[DeliverySessionCombo.SelectedIndex].EndTime1)
                        {
                            removeSession.Add(session);
                        }
                    }
                }
            }

            foreach (Session session in removeSession)
            {
                installSessions.Remove(session);
            }

            foreach (Session session in installSessions)
            {
                if (session.NumOfAppointments1 <= 0)
                {
                    removeSession.Add(session);
                }
            }

            foreach (Session session in removeSession)
            {
                installSessions.Remove(session);
            }
            removeSession.Clear();

            foreach (Session session in installSessions)
            {
                InstallSessionCombo.Items.Add(session.StartTime1.ToString("HH:mm") + " - " + session.EndTime1.ToString("HH:mm"));
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
            Form pos = Application.OpenForms["POS"];
            ((POS)pos).SetCusInfo(null);
            ((POS)pos).SetAppointments(null);
            this.Close();
            this.Dispose();
        }

        private void PhoneTxt__TextChanged(object sender, EventArgs e)
        {
            string discountTxt = PhoneTxt.Texts;
            if (discountTxt.Trim() == "") return;
            for (int i = 0; i < discountTxt.Length; i++)
            {
                if (!char.IsNumber(discountTxt[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    return;
                }
            }
            try
            {
                Convert.ToInt64(PhoneTxt.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }
        }

        private void PhoneTxt__Leave(object sender, EventArgs e)
        {
            if (PhoneTxt.Texts.Length == 8 || PhoneTxt.Texts.Length == 11)
            {
            }
            else
            {
                PhoneTxt.IsError = true;
                MessageBox.Show("The phone number should have 8 or 11 digits");
                return;
            }
        }
    }
}
