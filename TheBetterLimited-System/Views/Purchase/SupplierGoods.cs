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
    public partial class SupplierGoods : Form
    {
        private BindingSource bs = new BindingSource();
        private List<object> selectGoods = new List<object>();
        private List<JObject> supGoods = new List<JObject>();
        private DialogResult choose;
        private RestResponse result;
        private BackgroundWorker bw = new BackgroundWorker();
        private ControllerBase cbCatalogue = new ControllerBase("Catalogue");
        private ControllerBase gc = new ControllerBase("psg");

        private bool loadAll = true;
        private string suplierId = String.Empty;
        private string QryString = String.Empty;

        public SupplierGoods()
        {
            InitializeComponent();
            initBackgroundWorker();
            showLoading();
            bw.RunWorkerAsync();
        }

        public SupplierGoods(string supplierId)
        {
            this.suplierId = supplierId;
            Console.WriteLine(supplierId);
            InitializeComponent();
            initBackgroundWorker();
            showLoading();
            bw.RunWorkerAsync();
        }

        public void InitTable(string supplierId)
        {
            this.suplierId = supplierId;
            initBackgroundWorker();
            showLoading();
            try
            {
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Goods are loading.");
            }
        }

        private void showLoading()
        {
            Loading load = new Loading();
            load.TopLevel = false;
            load.Dock = DockStyle.Fill;
            loadPic.Controls.Add(load);
            loadPic.Tag = load;
            loadPic.BringToFront();
            load.Show();
            loadPic.Show();
        }

        private void initBackgroundWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            GetGoods();//init
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InitList();
            loadPic.Hide();
        }
        /*
         * Dom Style/Event Process
         */

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            try
            {
                showLoading();
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Goods are loading.\nPlease wait a moment!");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void GoodsDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (GoodsDataGrid.Columns[e.ColumnIndex].Name == "Status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold);
                if (e.Value.ToString().Equals("0"))
                {
                    e.Value = "Selling";
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.SelectionForeColor = Color.SeaGreen;
                }
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "Phasing Out";
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionForeColor = Color.Orange;
                }
                if (e.Value.ToString().Equals("2"))
                {
                    e.Value = "Stop Selling";
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                }
            }
        }

        private void GoodsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GoodsDataGrid.Columns["select"].Index)
            {
                Console.WriteLine(GoodsDataGrid["Status", e.RowIndex].Value);
                if (GoodsDataGrid["Status", e.RowIndex].Value.ToString().Equals("2"))
                {
                    MessageBox.Show(GoodsDataGrid["id", e.RowIndex].Value.ToString() + " is no longer be sold!");
                    return;
                }

                if (GoodsDataGrid["Status", e.RowIndex].Value.ToString().Equals("1"))
                {
                    DialogResult result = MessageBox.Show(GoodsDataGrid["id", e.RowIndex].Value.ToString() + " is being phase out!\nAre you sure to purchase this goods?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                if (Convert.ToInt32(GoodsDataGrid["select", e.RowIndex].Tag) == 0)
                {

                    GoodsDataGrid["select", e.RowIndex].Value = Properties.Resources.check24;
                    GoodsDataGrid["select", e.RowIndex].Tag = 1;
                    GoodsDataGrid.Rows[e.RowIndex].Selected = true;
                    var item = new PurchaseItem(supGoods[e.RowIndex]["Id"].ToString(), supGoods[e.RowIndex]["Name"].ToString(), (int)supGoods[e.RowIndex]["Price"], 1,0);
                    selectGoods.Add(item);
                }
                else
                {
                    GoodsDataGrid["select", e.RowIndex].Value = Properties.Resources.square24;
                    GoodsDataGrid["select", e.RowIndex].Tag = 0;
                    GoodsDataGrid.Rows[e.RowIndex].Selected = false;
                    var item = selectGoods.Single(x => ((PurchaseItem)x)._goodsId == GoodsDataGrid["id", e.RowIndex].Value.ToString());
                    selectGoods.Remove(item);
                }
            }
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
            GoodsDataGrid.Columns["id"].HeaderText = "ID";
            GoodsDataGrid.Columns["catalogue"].HeaderText = "Catalogue";
            GoodsDataGrid.Columns["name"].HeaderText = "Goods Name";
            GoodsDataGrid.Columns["price"].HeaderText = "Price";
            GoodsDataGrid.Columns["status"].HeaderText = "Status";
            for (int i = 0; i < GoodsDataGrid.RowCount; i++)
                GoodsDataGrid["select", i].Tag = 0;

            selectGoods.Clear();
        }

        //Get Goods
        private void GetGoods()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                result = gc.GetById(suplierId);
            }
            /* else
             {
                 string str = "id:" + this.SearchBarTxt.Texts
                             + "|gtincode:" + this.SearchBarTxt.Texts + "|size:" + this.SearchBarTxt.Texts
                             + "|status:" + this.SearchBarTxt.Texts;
                 result = gc.GetGoodsByQry(str);
             }*/
        }
        private void InitList()
        {
            supGoods.Clear();
            try
            {
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(result.Content, (typeof(DataTable)));
                var res = JArray.Parse(result.Content.ToString());
                foreach (JObject row in res)
                {
                    supGoods.Add(row);
                }
                List<string> list = new List<string>();
                dataTable.Columns.Add("Catalogue");
                foreach (var ctgID in res)
                {
                    list.Add(ctgID["_catalogueId"].ToString());
                }
                int index = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    row["Catalogue"] = JObject.Parse(cbCatalogue.GetById(list[index].ToString()).Content)["Name"].ToString();
                    index++;
                }
                bs.DataSource = dataTable;
                GoodsDataGrid.AutoGenerateColumns = false;
                GoodsDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public event Action OnExit;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (selectGoods.Count == 0)
            {
                MessageBox.Show("You have not selected any goods");
                return;
            }

            Form po = Application.OpenForms["PurchaseOrder_Create"];
            if (po != null)
            {
                ((PurchaseOrder_Create)po).AddItem(selectGoods);
            }else
            {
                po = Application.OpenForms["PurchaseOrder_Details"];
                ((PurchaseOrder_Details)po).AddItem(selectGoods);
            }
            
            this.Close();
            this.Dispose();
        }
    }
}
