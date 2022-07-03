using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
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
        private OrderController cbOrder = new OrderController("Order");
        private ControllerBase cbOrderItem = new ControllerBase("SalesOrderItem");
        private bool firstInit = false;
        private string appointmentId;

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

        public void SetOrderData(JObject orderData, string settle)
        {
            this.orderData = orderData;
            OrderInfoBox.Enabled = false;
            OrderDataGrid.ReadOnly = true;
            DeleteBtn.Visible = false;
            SaveBtn.Visible = false;
            BackBtn.Show();
            OrderDataGrid.Columns["defect"].Visible = false;
            InitializeOrderInfo();
            InitializeOrderItemTable();
        }

        public void SetOrderData(JObject orderData, bool appointment, string appointmentId)
        {
            this.orderData = orderData;
            OrderInfoBox.Enabled = false;
            OrderDataGrid.ReadOnly = true;
            DeleteBtn.Visible = false;
            this.appointmentId = appointmentId;
            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "zh")
            {
                SaveBtn.Text = "指派";
            }
            else
            {
                SaveBtn.Text = "Arrange";
            }
            if (orderData["status"].ToString().Equals("Completed"))
            {
                SaveBtn.Visible = false;
                CancelBtn.Location = new Point(484, 6);
            }
            OrderDataGrid.Columns["defect"].Visible = false;
            SaveBtn.Click -= new EventHandler(SaveBtn_Click);
            SaveBtn.Click += new EventHandler(ArrangeBtn_Click);
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
            orderTable.Columns.Add("status");
            orderTable.Columns.Add("defect");
            orderTable.Columns["install"].DataType = System.Type.GetType("System.Byte[]");
            orderTable.Columns["defect"].DataType = System.Type.GetType("System.Byte[]");
            //
            foreach (var item in ((JArray)orderData["orderItems"]))
            {
                var row = orderTable.NewRow();
                row["goodsName"] = item["name"].ToString();
                row["supplierGoodsStockId"] = item["supplierGoodsStockId"].ToString();
                row["quantity"] = (int)item["normalQuantity"];
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
                }
                else
                {
                    row["install"] = new ImageConverter().ConvertTo(Properties.Resources.square24, System.Type.GetType("System.Byte[]"));
                }
                row["defect"] = new ImageConverter().ConvertTo(Properties.Resources.exchange24, System.Type.GetType("System.Byte[]"));
                if ((int)item["normalQuantity"] > 0)
                {
                    orderTable.Rows.Add(row);
                }
                if (item["defectItemRecords"].Type != JTokenType.Null)
                {
                    foreach (var defectitem in ((JArray)item["defectItemRecords"]))
                    {
                        var row2 = orderTable.NewRow();
                        row2["goodsName"] = row["goodsName"];
                        row2["supplierGoodsStockId"] = row["supplierGoodsStockId"];
                        row2["quantity"] = row["quantity"];
                        row2["price"] = row["price"];
                        row2["install"] = row["install"];
                        if ((int)defectitem["qty"] > 0)
                        {
                            row2["quantity"] = defectitem["qty"];
                            row2["status"] = defectitem["handleStatus"];
                            orderTable.Rows.Add(row2);
                        }
                    }
                }
            }
            bs.DataSource = orderTable;
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = bs;
        }

        private void InitializeOrderInfo()
        {
            if (orderData["status"].ToString().Equals("Cancelled"))
            {
                DeleteBtn.Text = "Delete Order";
                DeleteBtn.Click -= new EventHandler(CancelOrderBtn_Click);
                DeleteBtn.Click += new EventHandler(DeleteOrderBtn_Click);
            }

            needDelivery = false;
            //Check whether booking record / delivery record
            if (((JToken)orderData["customer"]).Type == JTokenType.Null)
            {
                OrderInfoBox.Visible = false;
                OrderDataGrid.Columns["install"].Visible = false;
                CancelBtn.Hide();
                BackBtn.Show();
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
                initAppointment();
                initDelivery();
            }
            else
            {
                isBooking = true;
                OrderDataGrid.Columns["defect"].Visible = false;
                if (needDelivery == true)
                {
                    AppointmentBox.Visible = true;
                    PickUpBox.Visible = false;
                }
                else
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
            this.Close();
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            if (!orderData["status"].ToString().Equals("Placed") && !orderData["status"].ToString().Equals("Booking"))
            {
                MessageBox.Show("The order has been processed.\nYou cannot change anything.");
                return;
            }
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

            var address = "";
            if (needDelivery == true)
            {
                if (AddressTxt.Texts.Equals(String.Empty) || AddressTxt.Texts.Equals(AddressTxt.Placeholder))
                {
                    AddressTxt.IsError = true;
                    return;
                }
                address = AddressTxt.Texts;
                if (DeliverySessionCombo.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select delivery session");
                    return;
                }
                dict.Add("deliverySessionId", deliverySessionId);

                if (needInstall == true && InstallSessionCombo.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select installation session");
                    return;
                }else if(needInstall)
                {
                    dict.Add("installationtSessionId", installSessionId);
                }
            }

            dict.Add("orderId", orderData["id"].ToString());
            dict.Add("customerId", orderData["customer"]["id"].ToString());
            dict.Add("customerName", name);
            dict.Add("customerPhone", phone);
            dict.Add("customerAddress", address);
            try
            {
                var response = cbOrder.Modify(dict);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Order updated successfully");
                    this.Close();
                    this.Dispose();
                    this.OnExit.Invoke();
                }else
                {
                    throw new Exception();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Modify order error");
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


        private void initAppointment()
        {
            needDelivery = true;
            DeliveryDatePicker.MinDate = ((DateTime)orderData["createAt"]).Date.AddDays(1);
            InstallDatePicker.MinDate = ((DateTime)orderData["createAt"]).Date.AddDays(1);
            DeliveryDatePicker.MaxDate = DeliveryDatePicker.MinDate.AddDays(29);
            InstallDatePicker.MaxDate = InstallDatePicker.MinDate.AddDays(29);
        }

        private void initDelivery()
        {
            DeliveryDatePicker.Value = ((DateTime)orderData["delivery"]["date"]).Date;
            DeliverySessionCombo.SelectedItem = ((DateTime)orderData["delivery"]["startTime"]).ToString("HH:mm") + " - " + ((DateTime)orderData["delivery"]["endTime"]).ToString("HH:mm");
        }

        private void initInstall()
        {
            needInstall = true;
            InstallDatePicker.Value = ((DateTime)orderData["installation"]["date"]).Date;
            InstallSessionCombo.SelectedItem = ((DateTime)orderData["installation"]["startTime"]).ToString("HH:mm") + " - " + ((DateTime)orderData["installation"]["endTime"]).ToString("HH:mm");
            firstInit = true;
            foreach (var item in ((JArray)orderData["installation"]["items"]))
            {
                needInstallItem.Add(item["itemNames"].ToString());
            }
        }

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DeliveryDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) return;
            if (needInstall)
            {
                InstallDatePicker.MinDate = DeliveryDatePicker.Value;
            }
            if (needDelivery)
            {
                InitDeliveryComboBox();
            }
        }

        private void DeliverySessionCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            deliverySessionId = deliverySessions[DeliverySessionCombo.SelectedIndex].ID1;
            if (needInstall) InitInstallComboBox();
        }

        private void ArrangeBtn_Click(object sender, EventArgs e)
        {
            Form arrangeForm = Application.OpenForms["Appointment_Arrange"];
            if (arrangeForm != null)
            {
                arrangeForm.Close();
                arrangeForm.Dispose();
            }
            Appointment_Arrange arrangeAppointment = new Appointment_Arrange();
            arrangeAppointment.appointmentId = this.appointmentId;
            arrangeAppointment.Show();
            arrangeAppointment.TopLevel = true;
            arrangeAppointment.OnExit += () => { this.Close(); this.Dispose(); this.OnExit.Invoke(); };
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
        private void InitDeliveryComboBox()
        {
            ResetDeliveryComboBox();
            ResetInstallComboBox();
            deliverySessions.Clear();
            installSessions.Clear();
            if (DeliveryDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) return;
            deliverySessions = InitSession(DeliveryDatePicker.Value.Month, DeliveryDatePicker.Value.Day, "300");
            List<Session> removeSession = new List<Session>();
            if (DeliveryDatePicker.Value.Date == ((DateTime)orderData["delivery"]["date"]).Date)
            {
                foreach (Session session in deliverySessions)
                {
                    if (session.EndTime1.CompareTo((DateTime)orderData["delivery"]["endTime"]) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (session.NumOfAppointments1 <= 0)
                        {
                            removeSession.Add(session);
                        }
                    }
                }
            }
            else
            {
                foreach (Session session in deliverySessions)
                {

                    if (session.NumOfAppointments1 <= 0)
                    {
                        removeSession.Add(session);
                    }
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
                if (DeliverySessionCombo.SelectedIndex != -1)
                {
                    foreach (Session session in installSessions)
                    {
                        if (session.EndTime1.CompareTo(deliverySessions[DeliverySessionCombo.SelectedIndex].EndTime1) != 1)
                        {
                            removeSession.Add(session);
                        }
                    }
                }
                foreach (Session session in removeSession)
                {
                    installSessions.Remove(session);
                }
            }
            if (InstallDatePicker.Value.Date == ((DateTime)orderData["installation"]["date"]).Date)
            {
                foreach (Session session in installSessions)
                {
                    if (session.EndTime1.CompareTo((DateTime)orderData["installation"]["endTime"]) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (session.NumOfAppointments1 <= 0)
                        {
                            removeSession.Add(session);
                        }
                    }
                }
            }
            else
            {
                foreach (Session session in installSessions)
                {
                    if (session.NumOfAppointments1 <= 0)
                    {
                        removeSession.Add(session);
                    }
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



        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["defect"].Index)
            {
                Console.WriteLine(Convert.ToInt32(OrderDataGrid["defect", e.RowIndex].Tag));
                if (Convert.ToInt32(OrderDataGrid["defect", e.RowIndex].Tag) != 1)
                    DefectItem(e);
            }
        }

        private void DefectItem(DataGridViewCellEventArgs e)
        {
            DefectItem di = new DefectItem();
            di._salesOrderId = orderData["id"].ToString();
            if (orderData["customer"].Type != JTokenType.Null)
            {
                Console.WriteLine("create customer");
                di.customer = new CustomerInfo(orderData["customer"]["name"].ToString(), orderData["customer"]["phone"].ToString(), orderData["customer"]["address"].ToString());
            }
            di._supplierGoodsStockId = orderData["orderItems"][e.RowIndex]["supplierGoodsStockId"].ToString();
            DefectItem_Add defectAdd = new DefectItem_Add();
            defectAdd.defectItem = di;
            defectAdd.OnExit += () => { this.OnExit.Invoke(); this.Close(); this.Dispose(); };
            defectAdd.Show();
        }

        private void DeleteOrder(DataGridViewCellEventArgs e)
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
                                MessageBox.Show("The order " + orderData["id"].ToString() + " deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void OrderDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (OrderDataGrid.Columns[e.ColumnIndex].Name == "status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (e.Value.Equals("Refund"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                    OrderDataGrid.Rows[e.RowIndex].Cells["defect"].Tag = 1;
                }
                else if (e.Value.Equals("Exchange"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(19, 115, 235);
                    OrderDataGrid.Rows[e.RowIndex].Cells["defect"].Tag = 1;
                }
            }
        }

        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderData["status"].ToString().Equals("Placed") || orderData["status"].ToString().Equals("PendingDelivery") || orderData["status"].ToString().Equals("Booking"))
            {
                DialogResult choose = MessageBox.Show("Do you really want to cancel the order?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    CancelOrder();
                }
            }
            else if ((orderData["status"].ToString().Equals("Completed")))
            {
                DialogResult choose = MessageBox.Show("The order had completed. \n Do you really want to cancel the order?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (choose == DialogResult.Yes)
                {
                    CancelOrder();
                }
            }
            else
            {
                MessageBox.Show("The order had been processed. \nCannot cancel the order.", "Cancel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelOrder()
        {
            try
            {
                response = cbOrder.Cancel(orderData["id"].ToString());
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("The order " + orderData["id"].ToString() + " have been cancelled!", "Cancel Order Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.OnExit.Invoke();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    throw new Exception(response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Cannot cancel the order.", "Cancel Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you really want to delete the order " + orderData["id"].ToString() + "?\nWhen you confirm to delete the order,\nthe order will not be recovered.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    response = cbOrder.Delete(orderData["id"].ToString());
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The order " + orderData["id"].ToString() + " have been deleted!", "Delete Order Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.OnExit.Invoke();
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        throw new Exception(response.ErrorMessage);
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
}
