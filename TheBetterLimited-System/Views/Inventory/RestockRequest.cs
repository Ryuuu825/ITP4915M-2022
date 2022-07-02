﻿using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class RestockRequest : Form
    {
        private DataTable dt = new DataTable();
        private BindingSource bs = new BindingSource();
        private List<string> selecteOrderId = new List<string>();
        private DialogResult choose;
        private RestResponse response;
        private ControllerBase cbOrder = new ControllerBase("restock");
        private List<JObject> orderList = new List<JObject>();
        private BackgroundWorker bgWorker = new BackgroundWorker();

        public RestockRequest()
        {
            InitializeComponent();
            InitDataTable();
            AccessControl();
        }

        private void AccessControl()
        {
            switch (GlobalsData.currentUser["department"].ToString())
            {
                case "Sales":
                    locCombo.SelectedIndex = 0;
                    locCombo.Hide();
                    break;
                case "Inventory":
                    locCombo.SelectedIndex = 1;
                    break;
                case "Purchase":
                    locCombo.SelectedIndex = 1;
                    locCombo.Hide();
                    break;
                case "Admin":
                    locCombo.SelectedIndex = 0;
                    locCombo.Hide();
                    break;
            }
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
        public event Action OnExit;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        private void OrderDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (OrderDataGrid.Columns[e.ColumnIndex].Name == "status")
            {
                e.Value = (RestockStatusEnum)(Convert.ToInt32(e.Value));
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (e.Value.Equals(RestockStatusEnum.Completed) || e.Value.Equals(RestockStatusEnum.Approved))
                {
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.SelectionForeColor = Color.SeaGreen;
                }
                else if (e.Value.Equals(RestockStatusEnum.PendingApproval))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(19, 115, 235);
                }
                else if (e.Value.Equals(RestockStatusEnum.Pending) || e.Value.Equals(RestockStatusEnum.Handling))
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionForeColor = Color.Orange;
                }
                else if (e.Value.Equals(RestockStatusEnum.Rejected))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                }
                else
                {
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
                if ((int)orderList[e.RowIndex]["status"] != (int)POStatus.Inbound)
                {
                    MessageBox.Show("The purchase order have not been inbounded.\nCannot complete the purechase order!");
                    return;
                }
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
                Form order = Application.OpenForms["RestockRequest_Details"];
                if (order != null)
                {
                    order.Close();
                    order.Dispose();
                }
                RestockRequest_Details od = new RestockRequest_Details(orderList[e.RowIndex]);
                od.Show();
                od.TopLevel = true;
                od.OnExit += GetOrder;
            }

            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                if ((int)orderList[e.RowIndex]["status"] != (int)POStatus.Pending && (int)orderList[e.RowIndex]["status"] != (int)POStatus.PendingApproval)
                {
                    MessageBox.Show("The purchase order has been proccessed");
                    return;
                }

                DialogResult result = MessageBox.Show("Do you really need to delete this restock request?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
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
            dt.Columns.Add("loc");
            dt.Columns.Add("creator");
            dt.Columns.Add("operator");
            dt.Columns.Add("createAt");
            dt.Columns.Add("updateAt");
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
                response = cbOrder.GetAll(lang: System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
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
                    if (GlobalsData.currentUser["department"].ToString().Equals("Inventory"))
                    {
                        if (locCombo.SelectedIndex == 1 && !o["location"]["Id"].ToString().Equals("003"))
                        {
                            continue;
                        }
                        else if(locCombo.SelectedIndex == 0 && o["location"]["Id"].ToString().Equals("003"))
                        {
                            continue;
                        }else if (locCombo.SelectedIndex == 0 && (int)o["status"] == (int)RestockStatusEnum.Pending)
                        {
                            continue;
                        }
                    }
                    if (GlobalsData.currentUser["department"].ToString() == "Purchase")
                    {
                        if ((int)o["status"] == (int)RestockStatusEnum.Pending)
                        {
                            continue;
                        }
                    }
                    var row = dt.NewRow();
                    row["loc"] = o["location"]["Name"].ToString();
                    row["orderID"] = o["id"].ToString();
                    row["creator"] = o["_creatorId"].ToString();
                    row["operator"] = o["_operatorId"].ToString();
                    row["createAt"] = ((DateTime)o["createAt"]).ToString("g");
                    row["updateAt"] = ((DateTime)o["updateAt"]).ToString("g");
                    row["status"] = o["status"];
                    orderList.Add(o);
                    dt.Rows.Add(row);
                }
                bs.DataSource = dt;
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
                    }
                    catch (Exception ex)
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

        private void locCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrder();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }

        private void exportBtn_Click_1(object sender, EventArgs e)
        {
            CustomizeControl.Loading progress = new CustomizeControl.Loading();
            progress.Show();
            progress.Update("Fetch data from server ...", 10);


            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;

            //Add the Header row for CSV file.
            string WriteFilePath = AppDomain.CurrentDomain.BaseDirectory + "/tmp/RestockRequest.csv";
            foreach (DataGridViewColumn column in OrderDataGrid.Columns)
            {
                csv += column.HeaderText + ',';
            }

            progress.Update("Formatting ...", 30);

            //Add new line.
            csv += "\r\n";

            //Adding the Rows
            foreach (DataGridViewRow row in OrderDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.GetType() != typeof(Bitmap) )
                        //Add the Data rows.
                        csv += cell.Value.ToString().Replace(",", ";") + ',';

                }

                //Add new line.
                csv += "\r\n";
            }

            progress.Update("Writing File ...", 60);

            System.IO.File.WriteAllText(WriteFilePath, csv);

            choose = MessageBox.Show(
                   "Open in File Explorer?", "", MessageBoxButtons.YesNo);
            if (choose == DialogResult.Yes)
            {

                if (WriteFilePath == null)
                    throw new ArgumentNullException("filePath");

                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "/tmp/");
            }
            else
            {
                MessageBox.Show("Saved at" + WriteFilePath);
            }

            progress.End();
        }
    }
}
