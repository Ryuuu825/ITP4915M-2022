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
        private ControllerBase cbStockGoods = new ControllerBase("Supplier_Goods_Stock");
        private GoodsController gc = new GoodsController();
        private DataTable dataTable = new DataTable();

        public Stock()
        {
            InitializeComponent();
            GetStock();//init 
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
            GetStock();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (StockDataGrid.Columns[e.ColumnIndex].Name == "StoreLevel")
            {
                if (e.Value.ToString().Equals("0"))
                {
                    e.Value = "Out of Stock";
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                }
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "Re-oder";
                    e.CellStyle.ForeColor = Color.FromArgb(250, 182, 99);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(250, 182, 99);
                }
                if (e.Value.ToString().Equals("2"))
                {
                    e.Value = "Normal";
                    e.CellStyle.ForeColor = Color.SeaGreen;
                }
                if (e.Value.ToString().Equals("3"))
                {
                    e.Value = "Danger";
                    e.CellStyle.ForeColor = Color.FromArgb(221, 73, 96);
                }
            }
        }

        private void StockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StockDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(StockDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    StockDataGrid["select", e.RowIndex].Value = Properties.Resources.check;
                    StockDataGrid["select", e.RowIndex].Tag = 1;
                    StockDataGrid.Rows[e.RowIndex].Selected = true;
                    selectStockID.Add(StockDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    StockDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    StockDataGrid["select", e.RowIndex].Tag = 0;
                    StockDataGrid.Rows[e.RowIndex].Selected = false;
                    selectStockID.Remove(StockDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == StockDataGrid.Columns["edit"].Index)
            {
                MessageBox.Show("You have selected row " + selectStockID[0] + " cell");
            }

            if (e.ColumnIndex == StockDataGrid.Columns["delete"].Index)
            {
                DeleteStock(e);
            }

        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetStock();
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
            dataTable.Columns.Add("ReorderLevel");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("MinLimit");
            dataTable.Columns.Add("_locationId");
            dataTable.Columns.Add("_supplierGoodsId");
            dataTable.Columns.Add("remarks");
            dataTable.Columns.Add("MaxLimit");
        }


        //Get Stock
        private void GetStock()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search by keywords")
            {
                result = cbStockGoods.GetAll();
            }
            else
            {
                string str = "id:" + this.SearchBarTxt.Texts
                            + "|ReorderLevel:" + this.SearchBarTxt.Texts + "|_locationId:" + this.SearchBarTxt.Texts;
                result = cbStockGoods.GetByQueryString(str);
            }
            try
            {
                Console.WriteLine(result.StatusCode);
                Console.WriteLine(result.Content);
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(result.Content, (typeof(DataTable)));
                var res = JArray.Parse(result.Content.ToString());
                List<string> list = new List<string>();
                dataTable.Columns.Add("loc");
                foreach (var goodsID in res)
                {
                    list.Add(goodsID["_supplierGoodsId"].ToString());
                }
                int index = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    row["goodsName"] = JObject.Parse(gc.GetGoodsById(list[index].ToString()).Content)["Name"].ToString();
                    index++;
                }
                bs.DataSource = dataTable;
                StockDataGrid.AutoGenerateColumns = false;
                StockDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                            result = cbStockGoods.Delete(uid);
                        }
                        MessageBox.Show(selectStockID.Count + " records have been deleted!", "Delete stock records Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetStock();
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
        }

        //Delete stock records
        private void DeleteStock(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + StockDataGrid.Rows[e.RowIndex].Cells["name"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    result = cbStockGoods.Delete(StockDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The " + StockDataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString() + " have been deleted!", "Delete stock records Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetStock();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete the stock records", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //Goodsmanagement_Add goodsAdd = new Goodsmanagement_Add();
            //goodsAdd.Show();
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
