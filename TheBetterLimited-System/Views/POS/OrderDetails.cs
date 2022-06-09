using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
    public partial class OrderDetails : Form
    {
        private RestResponse response = new RestResponse();
        private SessionController cbSession = new SessionController("pos/session");
        private DataTable orderTable = new DataTable();
        private BindingSource bs = new BindingSource();
        private JObject orderData = new JObject();
        private bool needInstall = false;
        private bool needDelivery = false;
        private bool isBooking = false;
        private string deliverySessionId = null;
        private string installSessionId = null;
        List<Session> deliverySessions = new List<Session>();
        List<Session> installSessions = new List<Session>();
        List<string> needInstallItem = new List<string>();
        private ControllerBase cbOrder = new ControllerBase("Order");
        private ControllerBase cbOrderItem = new ControllerBase("SalesOrderItem");

        public OrderDetails()
        {
            InitializeComponent();
        }

        public void SetOrderData(JObject orderData)
        {
            this.orderData = orderData;
            InitializeOrderInfo();
            InitializeOrderItemTable();
        }

        private void InitializeOrderItemTable()
        {
            orderTable.Columns.Add("goodsName");
            orderTable.Columns.Add("supplierGoodsStockId");
            orderTable.Columns.Add("quantity");
            orderTable.Columns.Add("price");
            orderTable.Columns.Add("delivery");
            orderTable.Columns.Add("install");
            orderTable.Columns.Add("booking");
            orderTable.Columns["install"].DataType = System.Type.GetType("System.Byte[]");
            //
            foreach (var item in ((JArray)orderData["orderItems"]))
            {
                var row = orderTable.NewRow();
                row["goodsName"] = item["name"].ToString();
                row["supplierGoodsStockId"] = item["supplierGoodsStockId"].ToString();
                row["quantity"] = item["quantity"].ToString();
                row["price"] = item["price"].ToString();
                if (needInstallItem.Count != 0)
                {
                    foreach (string installItem in needInstallItem)
                    {
                        if (item["name"].ToString().Equals(installItem))
                        {
                            row["install"] = new ImageConverter().ConvertTo(Properties.Resources.check24, System.Type.GetType("System.Byte[]"));
                        }
                        else
                        {
                            row["install"] = new ImageConverter().ConvertTo(Properties.Resources.square24, System.Type.GetType("System.Byte[]"));
                        }
                    }
                }else
                {
                    row["install"] = new ImageConverter().ConvertTo(Properties.Resources.square24, System.Type.GetType("System.Byte[]"));
                }
                orderTable.Rows.Add(row);
            }

            bs.DataSource = orderTable;
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = bs;

        }

        private void InitializeOrderInfo()
        {
            needDelivery = false;
            //Check whether booking record / delivery record
            if (((JToken)orderData["customer"]).Type == JTokenType.Null)
            {
                OrderInfoBox.Visible = false;
                OrderDataGrid.Columns["install"].Visible = false;
                OrderDataGrid.Columns["delete"].Visible = false;
                return;
            }

            //init customer info
            NameTxt.Texts = orderData["customer"]["name"].ToString();
            PhoneTxt.Texts = orderData["customer"]["phone"].ToString();
            if (!orderData["customer"]["address"].ToString().Equals(String.Empty))
            {
                AddressTxt.Texts = orderData["customer"]["address"].ToString();
                needDelivery = true;
            }

            if (((JToken)orderData["delivery"]).Type != JTokenType.Null)
            {
                //init appointment info
                initDelivery();

            }
            else
            {
                isBooking = true;
                if (needDelivery == true)
                {
                    AppointmentBox.Visible = false;
                    PickUpBox.Visible = true;
                }
            }

            if (((JToken)orderData["installation"]).Type != JTokenType.Null)
            {
                initInstall();
            }
            else
            {
                InstallDatePicker.Enabled = false;
                InstallSessionCombo.Enabled = false;
            }
        }

        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
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

            if (needDelivery == true)
            {
                if (AddressTxt.Texts.Equals(String.Empty) || AddressTxt.Texts.Equals(AddressTxt.Placeholder))
                {
                    AddressTxt.IsError = true;
                    return;
                }
            }
            var address = AddressTxt.Texts;

            if (DeliverySessionCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select delivery session");
                return;
            }

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

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ResetDeliveryComboBox();
            ResetInstallComboBox();
            deliverySessions.Clear();
            installSessions.Clear();
            InstallDatePicker.MinDate = DeliveryDatePicker.Value;
            if (DeliveryDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) return;
            deliverySessions = InitSession(DeliveryDatePicker.Value.Month, DeliveryDatePicker.Value.Day, "300");
            foreach (Session item in deliverySessions)
            {
                DeliverySessionCombo.Items.Add(item.StartTime1.ToString("HH:mm") + " - " + item.EndTime1.ToString("HH:mm"));
            }
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
            List<Session> sessions = new List<Session>();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
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
            if (InstallDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) return;
            installSessions = InitSession(InstallDatePicker.Value.Month, InstallDatePicker.Value.Day, "700");
            for (int i = 0; i < installSessions.Count; i++)
            {
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
            //installSessionId = installSessions[InstallSessionCombo.SelectedIndex].ID1;
        }


        private void initDelivery()
        {
            needDelivery = true;
            DeliveryDatePicker.MinDate = ((DateTime)orderData["delivery"]["date"]).Date;
            InstallDatePicker.MinDate = ((DateTime)orderData["delivery"]["date"]).Date;
            DeliveryDatePicker.MaxDate = DeliveryDatePicker.MinDate.AddDays(29);
            InstallDatePicker.MaxDate = InstallDatePicker.MinDate.AddDays(29);
            DeliveryDatePicker.Value = ((DateTime)orderData["delivery"]["date"]).Date;
            DeliverySessionCombo.SelectedItem = ((DateTime)orderData["delivery"]["startTime"]).ToString("HH:mm") + " - " + ((DateTime)orderData["delivery"]["endTime"]).ToString("HH:mm");
            Console.WriteLine(DeliverySessionCombo.SelectedIndex);
        }

        private void initInstall()
        {
            needInstall = true;
            InstallDatePicker.Value = ((DateTime)orderData["installation"]["date"]).Date;
            foreach (var item in ((JArray)orderData["installation"]["items"]))
            {
                needInstallItem.Add(item["itemNames"].ToString());
            }
            InstallSessionCombo.SelectedItem = ((DateTime)orderData["installation"]["startTime"]).ToString("HH:mm") + " - " + ((DateTime)orderData["installation"]["endTime"]).ToString("HH:mm");
            Console.WriteLine(InstallSessionCombo.SelectedIndex);
        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                if (orderData["status"].ToString().Equals("Booking") || orderData["status"].ToString().Equals("PendingDelivery"))
                {
                    if (OrderDataGrid.Rows.Count == 1)
                    {
                        DialogResult result = MessageBox.Show("The order only has one item.\nDo you really delete the item?\nSince then, the order will be canceled.", "Warninng", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                response = cbOrder.Delete(orderData["id"].ToString());
                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    this.Close();
                                    this.Dispose();
                                    this.OnExit.Invoke();
                                    MessageBox.Show("The order " + orderData["id"].ToString() + " have been deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Cannot delete the order.\n" + response.ErrorMessage, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Do you really delete the item?", "Warninng", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                response = cbOrder.Delete(orderData["orderItems"][e.RowIndex]["supplierGoodsStockId"].ToString());
                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    this.Close();
                                    this.Dispose();
                                    this.OnExit.Invoke();
                                    MessageBox.Show("The order " + orderData["orderItems"][e.RowIndex]["supplierGoodsStockId"].ToString() + " have been deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                                else
                                {
                                    MessageBox.Show("The order has been handled. \nCannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                MessageBox.Show("Cannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (orderData["status"].ToString().Equals("Booking"))
                {
                    MessageBox.Show("The order has completed.\nCannot delete the order item(s).");
                }
                else
                {
                    MessageBox.Show("The order has been handled.\nCannot delete the order item(s).");
                }
            }
        }
    }
}
