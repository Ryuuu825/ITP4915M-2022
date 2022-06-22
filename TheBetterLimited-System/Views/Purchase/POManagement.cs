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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class POManagement : Form
    {
        private UserController uc = new UserController();
        private DataTable dt = new DataTable();
        private BindingSource bs = new BindingSource();
        private List<string> selecteOrderId = new List<string>();
        private DialogResult choose;
        private RestResponse response;
        private bool isSawDetails = false;
        private POController cbOrder = new POController("Purchase/Order");
        private string _storeId;
        private List<JObject> orderList = new List<JObject>();
        private BackgroundWorker bgWorker = new BackgroundWorker();

        public POManagement()
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
                if (e.Value.Equals("2"))
                {
                    e.Value = "Inbounded";
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.SelectionForeColor = Color.SeaGreen;
                }
                else if (e.Value.Equals("1"))
                {
                    e.Value = "Processing";
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(19, 115, 235);
                }
                else if (e.Value.Equals("0"))
                {
                    e.Value = "Pending";
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionForeColor = Color.Orange;
                }
                else
                {
                    e.Value = "Unknown";
                    e.CellStyle.ForeColor = Color.DimGray;
                    e.CellStyle.SelectionForeColor = Color.DimGray;
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
                Form order = Application.OpenForms["PurchaseOrder_Details"];
                if (order != null)
                {
                    order.Close();
                    order.Dispose();
                }
                PurchaseOrder_Details od = new PurchaseOrder_Details(orderList[e.RowIndex]);
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
                        Receipt receipt = new Receipt(response.Content);
                        receipt.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Print Unsuccessful");
                }
            }

            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("Do you really need to delete this purchase order?", "Confirmation Request", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        bgWorker.RunWorkerAsync(response = cbOrder.Delete(OrderDataGrid["id", e.RowIndex].Value.ToString()));
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("Record Deleted Successfully");
                        }
                        GetOrder();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Deleted Unsuccessful");
                    }
                }
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
            dt.Columns.Add("warehouse");
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
            orderList.Clear();
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                response = cbOrder.GetAll();
            }
            /*else
            {
                string str = "ID:" + this.SearchBarTxt.Texts + "|_creatorId:" + this.SearchBarTxt.Texts
                            + "|Status:" + this.SearchBarTxt.Texts + "|createdAt:" + this.SearchBarTxt.Texts;
                response = cbOrder.GetByQueryString(str);
            }*/
            try
            {
                JArray orders = JArray.Parse(response.Content);
                foreach (JObject o in orders)
                {
                    orderList.Add(o);
                    var row = dt.NewRow();
                    row["orderID"] = o["id"].ToString();
                    row["warehouse"] = "Kolwoon Warehouse";
                    row["creator"] = o["_creatorId"].ToString();
                    row["operator"] = o["_operatorId"].ToString();
                    row["createAt"] = ((DateTime)o["createAt"]).ToString("g");
                    row["updateAt"] = ((DateTime)o["updateAt"]).ToString("g");
                    row["total"] = o["total"];
                    row["status"] = o["status"];
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
                            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                            {
                                throw new Exception(response.ErrorMessage);
                            }
                        }
                        MessageBox.Show("The " + selecteOrderId.Count + " order(s) have been deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetOrder();
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form po = Application.OpenForms["PurchaseOrder_Create"];
            if (po != null)
            {
                po.Close();
                po.Dispose();
            }
            PurchaseOrder_Create poc = new PurchaseOrder_Create();
            poc.Show();
            poc.TopLevel = true;
            poc.OnExit += GetOrder;
        }
    }
}
