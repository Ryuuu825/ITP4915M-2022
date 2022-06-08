using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class OrderManagement : Form
    {
        private UserController uc = new UserController();
        private DataTable dt = new DataTable();
        private BindingSource bs = new BindingSource();
        private List<string> selecteOrderId = new List<string>();
        private DialogResult choose;
        private RestResponse response;
        private bool isSawDetails = false;
        private ControllerBase cbOrder = new ControllerBase("Order");
        private string _storeId;
        private List<JObject> orderList = new List<JObject>();
        private BackgroundWorker bgWorker = new BackgroundWorker();

        public OrderManagement()
        {
            InitializeComponent();
            InitDataTable();
            GetOrder();//init table
        }

        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedOrder();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetOrder();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (OrderDataGrid.Columns[e.ColumnIndex].Name == "status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (e.Value.Equals("Canceled"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                }
                else if(e.Value.Equals("Completed"))
                {
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.SelectionForeColor = Color.SeaGreen;
                }
                else if (e.Value.Equals("Booking"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(19, 115, 235);
                }
                else if (e.Value.Equals("Refunded"))
                {
                    e.CellStyle.ForeColor = Color.DimGray;
                    e.CellStyle.SelectionForeColor = Color.DimGray;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(250, 182, 99);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(250, 182, 99);
                }
            }
        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(OrderDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    OrderDataGrid["select", e.RowIndex].Value = Properties.Resources.check24;
                    OrderDataGrid["select", e.RowIndex].Tag = 1;
                    OrderDataGrid.Rows[e.RowIndex].Selected = true;
                    selecteOrderId.Add(OrderDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    OrderDataGrid["select", e.RowIndex].Value = Properties.Resources.square24;
                    OrderDataGrid["select", e.RowIndex].Tag = 0;
                    OrderDataGrid.Rows[e.RowIndex].Selected = false;
                    selecteOrderId.Remove(OrderDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == OrderDataGrid.Columns["details"].Index)
            {
                Form order = Application.OpenForms["OrderDetails"];
                if (order != null)
                {
                    order.Close();
                    order.Dispose();
                }
                OrderDetails od = new OrderDetails();
                Console.WriteLine(orderList[e.RowIndex].ToString());
                od.SetOrderData(orderList[e.RowIndex]);
                od.Show();
                od.TopLevel = true;
                od.OnExit += GetOrder;
            }

            if (e.ColumnIndex == OrderDataGrid.Columns["print"].Index)
            {
                try
                {
                    WaitResult waitResult = new WaitResult();
                    waitResult.Show();
                    waitResult.TopMost = true;
                    bgWorker.RunWorkerAsync(response = cbOrder.GetById(OrderDataGrid["id", e.RowIndex].Value.ToString()));
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        waitResult.Close();
                        waitResult.Dispose();
                        Receipt receipt = new Receipt(response.Content);
                        receipt.ShowDialog();
                        Form appointment = Application.OpenForms["POS"];
                        ((POS)appointment).ClearOrder();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Unsuccessful");
                }

            }

            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                DeleteOrder(e);
            }
        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetOrder();
        }

        private void InitDataTable()
        {
            dt.Columns.Add("orderID");
            dt.Columns.Add("store");
            dt.Columns.Add("creator");
            dt.Columns.Add("operator");
            dt.Columns.Add("createAt");
            dt.Columns.Add("updateAt");
            dt.Columns.Add("total");
            dt.Columns.Add("paid");
            dt.Columns.Add("status");
        }

        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = bs;

            for (int i = 0; i < OrderDataGrid.RowCount; i++)
                OrderDataGrid["select", i].Tag = 0;

            selecteOrderId.Clear();
        }

        //Get Order
        public void GetOrder()
        {
            dt.Clear();
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                response = cbOrder.GetAll();
            }
            else
            {
                string str = "ID:" + this.SearchBarTxt.Texts + "|_creatorId:" + this.SearchBarTxt.Texts
                            + "|Status:" + this.SearchBarTxt.Texts + "|createdAt:" + this.SearchBarTxt.Texts;
                response = cbOrder.GetByQueryString(str);
            }
            try
            {
                JArray orders = JArray.Parse(response.Content);
                foreach (JObject o in orders)
                {
                    orderList.Add(o);
                    var row = dt.NewRow();
                    row["orderID"] = o["id"].ToString();
                    row["store"] = o["store"]["location"]["name"].ToString();
                    row["creator"] = o["_creatorId"].ToString();
                    row["operator"] = o["_operatorId"].ToString();
                    row["createAt"] = ((DateTime)o["createAt"]).ToString("g");
                    row["updateAt"] = ((DateTime)o["updateAt"]).ToString("g");
                    row["total"] = String.Format("{0:C2}",o["total"]);
                    row["paid"] = String.Format("{0:C2}", o["paid"]); ;
                    row["status"] = o["status"].ToString();
                    dt.Rows.Add(row);
                }
                bs.DataSource = dt;
                OrderDataGrid.AutoGenerateColumns = false;
                OrderDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Delete Selected Order
        private void DeleteSelectedOrder()
        {
            if (selecteOrderId.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to delete the " + selecteOrderId.Count + " Order(s)?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        int countDeleted = 0;
                        foreach (string uid in selecteOrderId)
                        {
                            response = cbOrder.Delete(uid);
                            if(response.StatusCode != System.Net.HttpStatusCode.OK)
                            {
                                throw new Exception(response.ErrorMessage);
                            }
                        }
                        MessageBox.Show("The " + selecteOrderId.Count + " order(s) have been deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetOrder();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("You had not selected an order.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }

        //Delete Order
        public void DeleteOrder(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    response = cbOrder.Delete(OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The order " + OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value + " have been deleted!", "Delete Order ScbOrdercessful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetOrder();
                    }else
                    {
                        MessageBox.Show("The order has been delivered. \n Cannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GetOrder();
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
