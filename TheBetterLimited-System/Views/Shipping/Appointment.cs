using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Appointment : Form
    {
        private BindingSource bs = new BindingSource();
        private List<string> selectAppointmentID = new List<string>();
        private DialogResult choose;
        private RestResponse response;
        private AppointmentController cbAppointment = new AppointmentController("_Appointment");
        private DataTable dt = new DataTable();
        private BackgroundWorker bgWorker = new BackgroundWorker();
        private ControllerBase cbOrder = new ControllerBase("Order");

        public Appointment()
        {
            InitializeComponent();
            InitialzeDataTable();
            GetAppointment();//init user table
        }

        /*
         * Dom Style/Event Process
         */
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetAppointment();
        }

        public event Action OnExit;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        private void AppointmentDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AppointmentDataGrid.Columns[e.ColumnIndex].Name == "status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
                if (e.Value.ToString().Equals("Delivered") || e.Value.ToString().Equals("Completed"))
                {
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.SelectionForeColor = Color.SeaGreen;
                }
                else if (e.Value.ToString().Equals("Installing") || e.Value.ToString().Equals("Delivering"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(19, 115, 235);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionForeColor = Color.Orange;
                }
                var reg = @"(?=[A-Z])";
                var status = Regex.Split(e.Value.ToString(), reg);
                var value = "";
                foreach (var item in status)
                {
                    value += item + " ";
                }
                e.Value = value;
            }
        }

        private void GoodsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AppointmentDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(AppointmentDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    DialogResult result = DialogResult.No;
                    if (AppointmentDataGrid["teamId", e.RowIndex].Value.ToString() != String.Empty)
                    {
                        result = MessageBox.Show("The appointment has been arrange to a team. Do you need to modify it?", "Waining", MessageBoxButtons.YesNo);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    AppointmentDataGrid["select", e.RowIndex].Value = Properties.Resources.check24;
                    AppointmentDataGrid["select", e.RowIndex].Tag = 1;
                    AppointmentDataGrid.Rows[e.RowIndex].Selected = true;
                    selectAppointmentID.Add(AppointmentDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    AppointmentDataGrid["select", e.RowIndex].Value = Properties.Resources.square24;
                    AppointmentDataGrid["select", e.RowIndex].Tag = 0;
                    AppointmentDataGrid.Rows[e.RowIndex].Selected = false;
                    selectAppointmentID.Remove(AppointmentDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == AppointmentDataGrid.Columns["print"].Index)
            {
                try
                {
                    WaitResult waitResult = new WaitResult();
                    waitResult.Show();
                    waitResult.TopMost = true;
                    bgWorker.RunWorkerAsync(response = cbOrder.GetById(AppointmentDataGrid["orderId", e.RowIndex].Value.ToString()));
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        waitResult.Close();
                        waitResult.Dispose();
                        DeliveryNote receipt = new DeliveryNote(response.Content);
                        receipt.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Unsuccessful");
                }
            }

            if (e.ColumnIndex == AppointmentDataGrid.Columns["details"].Index)
            {
                Form order = Application.OpenForms["OrderDetails"];
                if (order != null)
                {
                    order.Close();
                    order.Dispose();
                }
                OrderDetails od = new OrderDetails();
                response = cbOrder.GetById(AppointmentDataGrid["orderId", e.RowIndex].Value.ToString());
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    od.SetOrderData(JObject.Parse(response.Content), true);
                    od.Show();
                    od.TopLevel = true;
                }
            }

            if (e.ColumnIndex == AppointmentDataGrid.Columns["arrange"].Index)
            {
                Form arrangeForm = Application.OpenForms["Appointment_Arrange"];
                if (arrangeForm != null)
                {
                    arrangeForm.Close();
                    arrangeForm.Dispose();
                }
                Appointment_Arrange arrangeAppointment = new Appointment_Arrange();
                arrangeAppointment.Show();
                arrangeAppointment.TopLevel = true;
                arrangeAppointment.appointmentId = AppointmentDataGrid["id", e.RowIndex].Value.ToString();
                arrangeAppointment.OnExit += GetAppointment;
            }
        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetAppointment();
        }

        /*
        * Dom Event Handler
        */
        private void InitialzeDataTable()
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("time");
            dt.Columns.Add("address");
            dt.Columns.Add("orderId");
            dt.Columns.Add("teamId");
            dt.Columns.Add("status");
        }


        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            AppointmentDataGrid.AutoGenerateColumns = false;
            AppointmentDataGrid.DataSource = bs;
            for (int i = 0; i < AppointmentDataGrid.RowCount; i++)
                AppointmentDataGrid["select", i].Tag = 0;

            selectAppointmentID.Clear();
        }

        //Get Appointment
        private void GetAppointment()
        {
            dt.Clear();
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                response = cbAppointment.GetAll(DeliveryDatePicker.Value.Day,DeliveryDatePicker.Value.Month);
            }
            else
            {
                string str = "appointmentId:" + this.SearchBarTxt.Texts
                            + "|status:" + this.SearchBarTxt.Texts;
                response = cbAppointment.GetByQueryString(str);
            }
            try
            {
                JArray appointments = JArray.Parse(response.Content);
                foreach (JObject a in appointments)
                {
                    var row = dt.NewRow();
                    row["Id"] = a["appointmentId"].ToString();
                    row["time"] = ((DateTime)a["startTime"]).ToString("HH:mm") + " - " + ((DateTime)a["endTime"]).ToString("HH:mm");
                    row["address"] = a["customer"]["address"].ToString();
                    if(((JToken)a["team"]).Type != JTokenType.Null)
                    {
                        row["teamId"] = a["team"]["Name"];
                    }
                    row["orderId"] = a["orderId"];
                    row["status"] = a["salesOrderStatus"].ToString();
                    dt.Rows.Add(row);
                }
                bs.DataSource = dt;
                AppointmentDataGrid.AutoGenerateColumns = false;
                AppointmentDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Assign Appointment
        private void DeleteGoods(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + AppointmentDataGrid.Rows[e.RowIndex].Cells["name"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    response = cbAppointment.Delete(AppointmentDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The " + AppointmentDataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString() + " have been deleted!", "Delete Goods Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetAppointment();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete the goods", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            DeliveryDatePicker.MinDate = new DateTime(DateTime.Now.Year,1,1);
            DeliveryDatePicker.MaxDate = DateTime.Now.AddDays(29);
            DeliveryDatePicker.Value = DateTime.Now;
        }

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            GetAppointment();
        }

        //Arrange Selected Appointment
        private void MultiArrangeBtn_Click(object sender, EventArgs e)
        {
            if (selectAppointmentID.Count > 0)
            {
                Form arrangeForm = Application.OpenForms["Appointment_Arrange"];
                if (arrangeForm != null)
                {
                    arrangeForm.Close();
                    arrangeForm.Dispose();
                }
                Appointment_Arrange arrangeAppointment = new Appointment_Arrange();
                arrangeAppointment.Show();
                arrangeAppointment.TopLevel = true;
                arrangeAppointment.appointmentIds = selectAppointmentID;
                arrangeAppointment.OnExit += GetAppointment;
            }
            else
            {
                MessageBox.Show("You had not selected an appointment.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }
    }
}
