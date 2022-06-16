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
    public partial class Stock : Form
    {
        private BindingSource bs = new BindingSource();
        private List<string> selectStockID = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private ControllerBase cbStore = new ControllerBase("Store");
        private ControllerBase cbWarehouse = new ControllerBase("cbWarehouse");
        private ControllerBase cbLoc = new ControllerBase("Location");
        private ControllerBase cbStockGoods = new ControllerBase("inventory/sgs");
        private GoodsController gc = new GoodsController();
        private DataTable dataTable;
        private BackgroundWorker bw = new BackgroundWorker();
        private bool loadAll = true;
        private string QryString = "";


        public Stock()
        {
            dataTable = new DataTable();
            InitializeComponent();
            InitialzeDataTable();
            initBackgroundWorker();
            loadPic.Show();
            bw.RunWorkerAsync();
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
            GetStock();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InitList();
            loadPic.Hide();
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
            loadPic.Show();
            try
            {
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock records are loading.\nPlease wait a moment!");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
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
                    e.Value = "Re-oder";
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
                    loadPic.Show();
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
                }
                else
                {
                    StockDataGrid["select", e.RowIndex].Value = Properties.Resources.square24;
                    StockDataGrid["select", e.RowIndex].Tag = 0;
                    StockDataGrid.Rows[e.RowIndex].Selected = false;
                    selectStockID.Remove(StockDataGrid["id", e.RowIndex].Value.ToString());
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
                result = cbStockGoods.GetAll();
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
            var res = JArray.Parse(result.Content.ToString());
            foreach (var row in res)
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
                            loadPic.Show();
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
                loadPic.Show();
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                loadPic.Show();
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock records are loading.\nPlease wait a moment!");
            }
        }

        // Export stock records PDF
        /* private void exportBtn_Click(object sender, EventArgs e)
         {
             Loading progress = new Loading();
             progress.Show();
             progress.Update("Fetch data from server ...", 10);
             byte[] response = cbStock.GetPDF();
             string WriteFilePath = AppDomain.CurrentDomain.BaseDirectory + "/tmp/test.pdf";
             progress.Update("Generating PDF ...", 30);
             progress.Update("Writing File ...", 60);
             System.IO.File.WriteAllBytes(WriteFilePath, response);
             progress.Update("Finish", 99);

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
                 MessageBox.Show("Saved at");
             }

             progress.End();*/

        // BackgroundWorker bgw = new BackgroundWorker();
        // CustomizeControl.Loading process = new Loading();
        // process.Show();
        // bgw.DoWork += new DoWorkEventHandler(((o, args) =>
        // {
        //     
        // }));
        // bgw.ProgressChanged += new ProgressChangedEventHandler(((o, args) =>
        // {
        // }));
        // bgw.RunWorkerCompleted += (o, args) =>
        // { 
        // };
        // bgw.RunWorkerAsync();
        // get "application/pdf"
    }
}
