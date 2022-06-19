﻿using Newtonsoft.Json;
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
    public partial class DefectiveItem : Form
    {
        private UserController uc = new UserController();
        private DataTable dt = new DataTable();
        private BindingSource bs = new BindingSource();
        private List<string> selecteOrderId = new List<string>();
        private DialogResult choose;
        private RestResponse response;
        private bool isSawDetails = false;
        private ControllerBase cbDefect = new OrderController("DefectItem");
        private string _storeId;
        private List<JObject> defectList = new List<JObject>();
        private BackgroundWorker bgWorker = new BackgroundWorker();

        public DefectiveItem()
        {
            InitializeComponent();
            InitDataTable();
            GetDefectItem();//init table
        }

        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Form option = Application.OpenForms["DefectUpdateOption"];
            if (option != null)
            {
                option.Close();
                option.Dispose();
            }
            DefectUpdateOption dfo = new DefectUpdateOption();
            dfo.Show();
            dfo.TopLevel = true;
            dfo.OnExit += GetDefectItem;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetDefectItem();
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
                else if (e.Value.Equals("Completed"))
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
                Form defect = Application.OpenForms["DefectiveItem_Details"];
                if (defect != null)
                {
                    defect.Close();
                    defect.Dispose();
                }
                DefectiveItem_Details df = new DefectiveItem_Details();
                Console.WriteLine(defectList[e.RowIndex].ToString());
                //df.SetOrderData(defectList[e.RowIndex]);
                df.Show();
                df.TopLevel = true;
                df.OnExit += GetDefectItem;
            }

            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                DeleteOrder(e);
            }
        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetDefectItem();
        }

        private void InitDataTable()
        {
            dt.Columns.Add("id");
            dt.Columns.Add("collectAddress");
            dt.Columns.Add("creator");
            dt.Columns.Add("operator");
            dt.Columns.Add("createAt");
            dt.Columns.Add("updateAt");
            dt.Columns.Add("goodsName");
            dt.Columns.Add("qty");
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
        public void GetDefectItem()
        {
            dt.Clear();
            defectList.Clear();
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                response = cbDefect.GetAll();
            }
            /*else
            {
                string str = "ID:" + this.SearchBarTxt.Texts + "|_creatorId:" + this.SearchBarTxt.Texts
                            + "|Status:" + this.SearchBarTxt.Texts + "|createdAt:" + this.SearchBarTxt.Texts;
                response = cbDefect.GetByQueryString(str);
            }*/
            try
            {
                JArray orders = JArray.Parse(response.Content);
                foreach (JObject o in orders)
                {
                    defectList.Add(o);
                    var row = dt.NewRow();
                    row["id"] = o["Id"].ToString();
                    row["collectAddress"] = o["CollectAddress"].ToString();
                    row["creator"] = o["_creatorId"].ToString();
                    row["operator"] = o["_operatorId"].ToString();
                    row["createAt"] = ((DateTime)o["CreateAt"]).ToString("g");
                    row["updateAt"] = ((DateTime)o["OperatedAt"]).ToString("g");
                    row["goodsName"] = o["GoodsName"].ToString();
                    //row["paid"] = String.Format("{0:C2}", o["paid"]); ;
                    row["status"] = o["Status"].ToString();
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
                            response = cbDefect.Delete(uid);
                            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                            {
                                throw new Exception(response.ErrorMessage);
                            }
                        }
                        MessageBox.Show("The " + selecteOrderId.Count + " order(s) have been deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetDefectItem();
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
            if (OrderDataGrid.Rows[e.RowIndex].Cells["status"].Value.Equals("Pending Delivery"))
            {
                choose = MessageBox.Show("Do you really want to cancel the " + OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        response = cbDefect.Delete(OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The order " + OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value + " have been deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                            GetDefectItem();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Cannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }else if ((OrderDataGrid.Rows[e.RowIndex].Cells["status"].Value.Equals("Completed")))
            {
                MessageBox.Show("The order has completed. \n Cannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                MessageBox.Show("The order has been processed. \nCannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}