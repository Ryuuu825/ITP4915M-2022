﻿using Newtonsoft.Json;
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
    public partial class InboundGoods : Form
    {
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();
        private List<JObject> goodsList = new List<JObject>();
        private DialogResult choose;
        private RestResponse response;
        private BackgroundWorker bw = new BackgroundWorker();
        private ControllerBase cbPO = new ControllerBase("purchase/order");
        private ControllerBase cbRQ = new ControllerBase("Restock");
        private StockController cbStock = new StockController("inventory/sgs");

        private bool loadAll = true;
        private string purchaseId = String.Empty;
        private string restockId = String.Empty;

        public InboundGoods()
        {
            InitializeComponent();
            InitDataTable();
            InitializeDataGridView();
            if (GlobalsData.currentUser["department"].ToString().Equals("Sales"))
            {
                SearchBarTxt.Placeholder = "Enter the Restock Request ID";
            }
        }

        public InboundGoods(List<JObject> goods)
        {
            this.goodsList = goods;
            InitializeComponent();
            InitDataTable();
            InitializeDataGridView();
        }

        private void InitDataTable()
        {
            dt.Columns.Add("goodsId");
            dt.Columns.Add("goodsName");
            dt.Columns.Add("expQty");
            dt.Columns.Add("recQty");
            dt.Columns.Add("isNew");
            dt.Columns.Add("catalogue");
            dt.Columns["isNew"].DataType = System.Type.GetType("System.Byte[]");
        }

        /*
         * Dom Style/Event Process
         */

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            SearchBarTxt.Texts = SearchBarTxt.Placeholder;
            SearchBarTxt.ForeColor = Color.LightGray;
            dt.Clear();
            InitializeDataGridView();
        }

        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            bs.DataSource = dt;
            GoodsDataGrid.AutoGenerateColumns = false;
            GoodsDataGrid.DataSource = bs;
        }

        //Get Goods
        private void GetGoods()
        {
            JObject goodsData = null;
            if (GlobalsData.currentUser["department"].ToString().Equals("Sales"))
            {
                try
                {
                    response = cbRQ.GetById(SearchBarTxt.Texts.ToString());
                    restockId = SearchBarTxt.Texts;
                    goodsData = JObject.Parse(response.Content);
                    if (((int)goodsData["status"]) == (int)RestockStatusEnum.Completed)
                    {
                        MessageBox.Show("The id " + SearchBarTxt.Texts + " has inbounded");
                        return;
                    }
                    if (((int)goodsData["status"]) != (int)RestockStatusEnum.Handling)
                    {
                        MessageBox.Show("Restock Request record not found");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record not found\nCheck if there are any new products");
                    return;
                }
            }
            else
            {
                try
                {
                    response = cbPO.GetById(SearchBarTxt.Texts.ToString(), lang: System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
                    purchaseId = SearchBarTxt.Texts;
                    goodsData = JObject.Parse(response.Content);
                    if (((int)goodsData["status"]) == (int)POStatus.Inbound || ((int)goodsData["status"]) == (int)POStatus.Completed)
                    {
                        MessageBox.Show("The id " + SearchBarTxt.Texts + " has inbounded");
                        return;
                    }
                    if (((int)goodsData["status"]) != (int)POStatus.SentToSupplier)
                    {
                        MessageBox.Show("Purchase order not found");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record not found\nCheck if there are any new products");
                    return;
                }
            }
            InitList(goodsData);
        }

        private void InitList(JObject goodsData)
        {
            dt.Clear();
            goodsList.Clear();
            try
            {
                foreach (JObject o in goodsData["items"])
                {
                    goodsList.Add(o);
                    var row = dt.NewRow();
                    row["goodsId"] = o["goods"]["GoodsId"].ToString();
                    row["goodsName"] = o["goods"]["GoodsName"].ToString();
                    row["expQty"] = o["quantity"].ToString();
                    row["recQty"] = o["quantity"].ToString();
                    row["catalogue"] = o["goods"]["Catalogue"].ToString();
                    if (o["isNewItem"] != null)
                    {
                        if ((bool)o["isNewItem"])
                        {
                            row["isNew"] = new ImageConverter().ConvertTo(Properties.Resources.check24, System.Type.GetType("System.Byte[]"));
                        }
                    }

                    dt.Rows.Add(row);
                }
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("");
            }
        }

        public event Action OnExit;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                MessageBox.Show("Please " + SearchBarTxt.Placeholder.ToLower());
                return;
            }
            else if (SearchBarTxt.Texts.Length < 10)
            {
                MessageBox.Show("Input invalid!");
                return;
            }
            else
            {
                GetGoods();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            int idx = 0;
            foreach (var item in goodsList)
            {
                list.Add(new { _goodsId = item["goods"]["GoodsId"].ToString(), qty = Convert.ToInt32(GoodsDataGrid["recQty", idx].Value) });
                idx++;
            }
            try
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("_purchaseOrderId", purchaseId);
                dict.Add("_restockRequestId", restockId);
                dict.Add("items", list);
                Console.WriteLine("Request: " + JsonConvert.SerializeObject(dict));
                response = cbStock.Update("bound", dict);
                Console.WriteLine(response.Content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Goods Inbounded successfully");
                    this.OnExit.Invoke();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    throw new Exception(response.Content.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Goods Inbounded Unsuccessfully.\nThe purchase order has new item(s),\nyou need to create a new stock record first.");
            }
        }

        private void SearchBarTxt_Click(object sender, EventArgs e)
        {
            SearchBarTxt.ForeColor = Color.Black;
        }
    }
}
