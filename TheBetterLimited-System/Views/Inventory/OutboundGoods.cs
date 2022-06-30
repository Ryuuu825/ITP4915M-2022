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
    public partial class OutboundGoods : Form
    {
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();
        private List<JObject> goodsList = new List<JObject>();
        private DialogResult choose;
        private RestResponse response;
        private BackgroundWorker bw = new BackgroundWorker();
        private ControllerBase cbRS = new ControllerBase("restock");
        private StockController cbStock = new StockController("inventory/sgs");

        private bool loadAll = true;
        private string suplierId = String.Empty;
        private string QryString = String.Empty;
        private string restockId = String.Empty;

        public OutboundGoods()
        {
            InitializeComponent();
            InitDataTable();
            InitializeDataGridView();
            if (GlobalsData.currentUser["department"].ToString().Equals("Sales"))
            {
                SearchBarTxt.Placeholder = "Enter the Restock Request ID";
            }
        }

        public OutboundGoods(List<JObject> goods)
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
            dt.Columns.Add("outQty");
            dt.Columns.Add("catalogue");
        }

        /*
         * Dom Style/Event Process
         */

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
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
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                MessageBox.Show("Please "+ SearchBarTxt.Placeholder.ToLower());
                return;
            }
            else if (SearchBarTxt.Texts.Length < 10)
            {
                MessageBox.Show("Input invalid!");
                return;
            }
            else
            {
                response = cbRS.GetById(SearchBarTxt.Texts.ToString());
                restockId = SearchBarTxt.Texts.ToString();
                InitList();
            }
        }

        private void InitList()
        {
            dt.Clear();
            goodsList.Clear();
            try
            {
                JObject goodsData = JObject.Parse(response.Content);
                foreach (JObject o in goodsData["items"])
                {
                    goodsList.Add(o);
                    var row = dt.NewRow();
                    row["goodsId"] = o["goods"]["GoodsId"].ToString();
                    row["goodsName"] = o["goods"]["GoodsName"].ToString();
                    row["expQty"] = o["quantity"].ToString();
                    row["outQty"] = o["quantity"].ToString();
                    row["catalogue"] = o["goods"]["Catalogue"].ToString();
                    dt.Rows.Add(row);
                }
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Input invalid!");
            }
        }

        public event Action OnExit;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetGoods();
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
                list.Add(new { _goodsId = item["goods"]["GoodsId"].ToString(), qty = -(Convert.ToInt32(GoodsDataGrid["outQty", idx].Value)) });
                idx++;
            }
            try
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("_purchaseOrderId", String.Empty);
                dict.Add("_restockRequestId", restockId);
                dict.Add("items", list);
                Console.WriteLine("Request: " + JsonConvert.SerializeObject(dict));
                response = cbStock.Update("bound", dict);
                Console.WriteLine(response.Content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Goods Outbounded successfully");
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
                MessageBox.Show("Goods Outbounded Unsuccessfully.");
            }
        }
    }
}
