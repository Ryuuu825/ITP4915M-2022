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
    public partial class InboundGoods : Form
    {
        private BindingSource bs = new BindingSource();
        private DataTable dt = new DataTable();
        private List<JObject> goodsList = new List<JObject>();
        private DialogResult choose;
        private RestResponse response;
        private BackgroundWorker bw = new BackgroundWorker();
        private ControllerBase cbPO = new ControllerBase("purchase/order");
        private ControllerBase cbStock = new ControllerBase("inventory/sgs");

        private bool loadAll = true;
        private string suplierId = String.Empty;
        private string QryString = String.Empty;

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
            dt.Columns.Add("qty");
            dt.Columns.Add("isNew");
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
            GoodsDataGrid.AutoGenerateColumns = false;
            GoodsDataGrid.DataSource = bs;
            for (int i = 0; i < GoodsDataGrid.RowCount; i++)
                GoodsDataGrid["select", i].Tag = 0;
        }

        //Get Goods
        private void GetGoods()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                response = cbPO.GetById(SearchBarTxt.Texts);
            }else
            {
                MessageBox.Show("You have not input any things");
            }
        }

        private void InitList()
        {
            try
            {
                JArray goodsData = JArray.Parse(response.Content);
                foreach (JObject o in goodsData["items"])
                {
                    goodsList.Add(o);
                    var row = dt.NewRow();
                    row["goodsId"] = o["_supplierGoodsid"].ToString();
                    row["goodsName"] = o["GoodsName"].ToString();
                    row["qty"] = o["quantity"].ToString();
                    if ((bool)o["isNewItem"])
                    {
                        row["isNew"] = new ImageConverter().ConvertTo(Properties.Resources.check24, System.Type.GetType("System.Byte[]"));
                    }
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
                list.Add(new { goodsId = item["_supplierGoodsid"].ToString(), quantity = GoodsDataGrid["recQty", idx] });
                idx++;
            }
            try
            {
                response = cbStock.Update("bound", list);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Goods Inbounded successfully");
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
                MessageBox.Show("Goods Inbounded Unsuccessfully");
            }

        }
    }
}
