using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited.Utils;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Stock : Form
    {
        private BindingSource bs = new BindingSource();
        private List<string> selectStockID = new List<string>();
        private List<JObject> stocks = new List<JObject>();
        private List<JObject> selectStock = new List<JObject>();
        private DialogResult choose;
        private RestResponse result;
        private ControllerBase cbStore = new ControllerBase("Store");
        private ControllerBase cbWarehouse = new ControllerBase("cbWarehouse");
        private ControllerBase cbLoc = new ControllerBase("Location");
        private StockController cbStockGoods = new StockController("inventory/sgs");
        private GoodsController gc = new GoodsController();
        private DataTable dataTable;
        private BackgroundWorker bw = new BackgroundWorker();
        private bool loadAll = true;
        private string QryString = "";
        private string qryLoc = "";


        public Stock()
        {
            dataTable = new DataTable();
            InitializeComponent();
            AccessControl();
            InitialzeDataTable();
            locCombo.SelectedIndex = 0;
            locCombo.Enabled = false;
            pictureBox1.Enabled = false;
            initBackgroundWorker();
            showLoading();
            bw.RunWorkerAsync();
        }

        private void AccessControl()
        {
            switch (GlobalsData.currentUser["department"].ToString())
            {
                case "Sales":
                    outBtn.Hide();
                    if (!GlobalsData.currentUser["position"].ToString().Contains("Manager"))
                    {
                        RestockBtn.Hide();
                    }
                    break;
                case "Accounting":
                    outBtn.Hide();
                    RestockBtn.Hide();
                    inBtn.Hide();
                    DeleteBtn.Hide();
                    AddBtn.Hide();
                    StockDataGrid.Columns["delete"].Visible = false;
                    StockDataGrid.Columns["edit"].Visible = false;
                    break;
            }
        }

        private void initBackgroundWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
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

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            GetStock();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InitList();
            loadPic.Hide();
            loadPic.Controls.Clear();
            locCombo.Enabled = true;
            pictureBox1.Enabled = true;
        }
        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedStock();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            showLoading();
            try
            {
                locCombo.Enabled = false;
                pictureBox1.Enabled = false;
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock records are loading.\nPlease wait a moment!");
            }
        }

        public event Action OnExit;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        private void StockDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (StockDataGrid.Columns[e.ColumnIndex].Name == "Status")
            {
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                if (e.Value.ToString().Equals("OutOfStock"))
                {
                    // the width of text increase
                    e.CellStyle.Font = new Font("Segoe UI", 10.10084F, FontStyle.Bold);
                    e.Value = "Out of Stock";
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                }
                if (e.Value.ToString().Equals("LowStock"))
                {
                    e.Value = "Re-order";
                    e.CellStyle.ForeColor = Color.FromArgb(250, 182, 99);
                    e.CellStyle.Font = new Font("Segoe UI", 10.10084F, FontStyle.Bold);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(250, 182, 99);
                }
                if (e.Value.ToString().Equals("InStock"))
                {
                    e.Value = "Normal";
                    e.CellStyle.ForeColor = Color.SeaGreen;
                }
                if (e.Value.ToString().Equals("Danger"))
                {
                    e.Value = "Danger";
                    e.CellStyle.Font = new Font("Segoe UI", 10.10084F, FontStyle.Bold);
                    e.CellStyle.ForeColor = Color.FromArgb(221, 73, 96);
                }
            }
        }

        private void EditStock(DataGridViewCellEventArgs e)
        {
            string id = StockDataGrid["Id", e.RowIndex].Value.ToString();
            Stock_Edit edit = new Stock_Edit(id);
            edit.OnExit += () =>
            {
                try
                {
                    locCombo.Enabled = false;
                    pictureBox1.Enabled = false;
                    showLoading();
                    bw.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stock records are loading.\nPlease wait a moment!");
                }
            };
            edit.Show();
        }

        private void StockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StockDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(StockDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    StockDataGrid["select", e.RowIndex].Value = Properties.Resources.check24;
                    StockDataGrid["select", e.RowIndex].Tag = 1;
                    StockDataGrid.Rows[e.RowIndex].Selected = true;
                    selectStockID.Add(StockDataGrid["id", e.RowIndex].Value.ToString());
                    selectStock.Add(stocks[e.RowIndex]);
                }
                else
                {
                    StockDataGrid["select", e.RowIndex].Value = Properties.Resources.square24;
                    StockDataGrid["select", e.RowIndex].Tag = 0;
                    StockDataGrid.Rows[e.RowIndex].Selected = false;
                    selectStockID.Remove(StockDataGrid["id", e.RowIndex].Value.ToString());
                    selectStock.Remove(stocks[e.RowIndex]);
                }
            }

            if (e.ColumnIndex == StockDataGrid.Columns["edit"].Index)
            {
                EditStock(e);
            }


            if (e.ColumnIndex == StockDataGrid.Columns["delete"].Index)
            {
                DeleteStock(e);
            }

        }

        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column

            for (int i = 0; i < StockDataGrid.RowCount; i++)
                StockDataGrid["select", i].Tag = 0;

            selectStockID.Clear();
        }
        private void InitialzeDataTable()
        {
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("loc");
            dataTable.Columns.Add("goodsName");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("MaxLimit");
            dataTable.Columns.Add("MinLimit");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("ReorderLevel");
        }


        //Get Stock
        private void GetStock()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                result = cbStockGoods.GetAll(loc: qryLoc, lang: CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
            }
            /*else
            {
                string str = "id:" + this.SearchBarTxt.Texts
                            + "|ReorderLevel:" + this.SearchBarTxt.Texts + "|_locationId:" + this.SearchBarTxt.Texts;
                result = cbStockGoods.GetByQueryString(str);
            }*/
        }
        private void InitList()
        {
            dataTable.Clear();
            stocks.Clear();
            var res = JArray.Parse(result.Content.ToString());
            foreach (JObject row in res)
            {
                // is not soft Deleted
                if (!row["isDeleted"].ToObject<bool>())
                {
                    DataRow dr = dataTable.NewRow();
                    dr["Id"] = row["Id"].ToString();
                    dr["loc"] = row["LocName"].ToString();
                    dr["goodsName"] = row["GoodsName"].ToString();
                    dr["Quantity"] = row["Quantity"].ToString();
                    dr["MaxLimit"] = row["MaxLimit"].ToString();
                    dr["MinLimit"] = row["MinLimit"].ToString();
                    dr["ReorderLevel"] = row["ReorderLevel"].ToString();
                    dr["Status"] = row["Status"].ToString();
                    stocks.Add(row);
                    dataTable.Rows.Add(dr);
                }
            }
            bs.DataSource = dataTable;
            StockDataGrid.AutoGenerateColumns = false;
            StockDataGrid.DataSource = bs;
            InitializeDataGridView();
        }

        private bool DeleteRecord(string id)
        {
            RestRequest req = new RestRequest("/api/inventory/sgs/" + id, Method.Delete);
            result = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            return result.StatusCode == System.Net.HttpStatusCode.OK;
        }

        //Delete Selected Stock
        private void DeleteSelectedStock()
        {
            if (selectStockID.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to delete the " + selectStockID.Count + " stock records??", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        int countDeleted = 0;
                        string res;
                        foreach (string uid in selectStockID)
                        {
                            DeleteRecord(uid);
                        }
                        MessageBox.Show(selectStockID.Count + " records have been deleted!", "Delete stock records Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete the stock records.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You had not selected a stock records.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            try
            {
                locCombo.Enabled = false;
                pictureBox1.Enabled = false;
                showLoading();
                bw.RunWorkerAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show("Stock records are loading.\nPlease wait a moment!");
            }
        }

        //Delete stock records
        private void DeleteStock(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + StockDataGrid["id", e.RowIndex].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    DeleteRecord(StockDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The " + StockDataGrid["id", e.RowIndex].Value + " have been deleted!", "Delete stock records Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        try
                        {
                            locCombo.Enabled = false;
                            pictureBox1.Enabled = false;
                            showLoading();
                            bw.RunWorkerAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Stock records are loading.\nPlease wait a moment!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Cannot delete the stock records", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Stock_Add goodsAdd = new Stock_Add();
            goodsAdd.OnExit += () =>
            {
                locCombo.Enabled = false;
                pictureBox1.Enabled = false;
                showLoading();
                bw.RunWorkerAsync();
            };
            goodsAdd.Show();
        }

        private void RestockBtn_Click(object sender, EventArgs e)
        {
            if (selectStockID.Count <= 0)
            {
                MessageBox.Show("You have not select any goods");
                return;
            }
            else
            {
                foreach (var stock in selectStock)
                {
                    var i = (int)stock["MaxLimit"] - (int)stock["Quantity"];
                    if (i == 0)
                    {
                        MessageBox.Show(stock["Id"] + " has reached the maximum limit");
                        return;
                    }
                }
            }

            Form rs = Application.OpenForms["RestockRequest_Add"];
            if (rs != null)
            {
                rs.Close();
                rs.Dispose();
            }
            RestockRequest_Add gd = new RestockRequest_Add(selectStockID);
            gd.Show();
            gd.TopLevel = true;
            gd.OnExit += GetStock;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                locCombo.Enabled = false;
                pictureBox1.Enabled = false;
                showLoading();
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock records are loading.\nPlease wait a moment!");
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            InboundGoods inbound = new InboundGoods();
            inbound.Show();
            inbound.OnExit += () =>
            {
                locCombo.Enabled = false;
                pictureBox1.Enabled = false;
                showLoading();
                bw.RunWorkerAsync();
            };
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            OutboundGoods outbound = new OutboundGoods();
            outbound.Show();
            outbound.OnExit += () =>
            {
                locCombo.Enabled = false;
                pictureBox1.Enabled = false;
                showLoading();
                bw.RunWorkerAsync();
            };
        }

        private void loc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (locCombo.SelectedIndex)
            {
                case 1:
                    qryLoc = "003";
                    break;
                case 2:
                    qryLoc = "004";
                    break;
                case 3:
                    qryLoc = "005";
                    break;
                default:
                    qryLoc = "";
                    break;
            }
            locCombo.Enabled = false;
            pictureBox1.Enabled = false;
            showLoading();
            bw.RunWorkerAsync();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            CustomizeControl.Loading progress = new CustomizeControl.Loading();
            progress.Show();
            progress.Update("Fetch data from server ...", 10);


            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;

            //Add the Header row for CSV file.
            string WriteFilePath = AppDomain.CurrentDomain.BaseDirectory + "/tmp/Stock.csv";
            foreach (DataGridViewColumn column in StockDataGrid.Columns)
            {
                csv += column.HeaderText + ',';
            }

            progress.Update("Formatting ...", 30);

            //Add new line.
            csv += "\r\n";

            Console.WriteLine(selectStock.Count);

            if (selectStock.Count <= 0)
            {
                foreach (DataGridViewRow row in StockDataGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value is string || cell.Value is int)
                            //Add the Data rows.
                            csv += cell.Value.ToString().Replace(",", ";") + ',';

                    }

                    //Add new line.
                    csv += "\r\n";
                }
            }
            else
            {
                foreach (var row in selectStock)
                {
                    foreach (var cell in row)
                    {
                        csv += cell.Value.ToString().Replace(",", ";") + ',';
                    }

                    //Add new line.
                    csv += "\r\n";
                }
            }
            
            //Adding the Rows
           

            progress.Update("Writing File ...", 60);

            File.WriteAllText(WriteFilePath, csv);

            choose = MessageBox.Show(
                   "Open in File Explorer?", "", MessageBoxButtons.YesNo);
            if (choose == DialogResult.Yes)
            {

                if (WriteFilePath == null)
                    throw new ArgumentNullException("filePath");

                Process.Start(AppDomain.CurrentDomain.BaseDirectory + "/tmp/");
            }
            else
            {
                MessageBox.Show("Saved at" + WriteFilePath);
            }

            progress.End();
        }
    }
}
