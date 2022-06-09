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
    public partial class RestockRequest : Form
    {
        private UserController uc = new UserController();
        private GoodsController gc = new GoodsController();
        private BindingSource bs = new BindingSource();
        private List<string> selectGoodsID = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private ControllerBase cbCatalogue = new ControllerBase("Catalogue");

        public RestockRequest()
        {
            InitializeComponent();
            GetGoods();//init user table
        }

        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedGoods();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetGoods();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoodsDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (RestockRequestDataGrid.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value.ToString().Equals("0"))
                {
                    e.Value = "Selling";
                }
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "PhasingOut";
                }
                if (e.Value.ToString().Equals("2"))
                {
                    e.Value = "StopSelling";
                }
            }

            if (RestockRequestDataGrid.Columns[e.ColumnIndex].Name == "Size")
            {

                if (e.Value.ToString().Equals("0"))
                {
                    e.Value = "Small";
                }
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "Medium";
                }
                if (e.Value.ToString().Equals("2"))
                {
                    e.Value = "Large";
                }
            }

        }

        private void GoodsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RestockRequestDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(RestockRequestDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    RestockRequestDataGrid["select", e.RowIndex].Value = Properties.Resources.check;
                    RestockRequestDataGrid["select", e.RowIndex].Tag = 1;
                    RestockRequestDataGrid.Rows[e.RowIndex].Selected = true;
                    selectGoodsID.Add(RestockRequestDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    RestockRequestDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    RestockRequestDataGrid["select", e.RowIndex].Tag = 0;
                    RestockRequestDataGrid.Rows[e.RowIndex].Selected = false;
                    selectGoodsID.Remove(RestockRequestDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == RestockRequestDataGrid.Columns["edit"].Index)
            {
                MessageBox.Show("You have selected row " + selectGoodsID[0] + " cell");
            }

            if (e.ColumnIndex == RestockRequestDataGrid.Columns["delete"].Index)
            {
                DeleteGoods(e);
            }

        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetGoods();
        }


        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            RestockRequestDataGrid.AutoGenerateColumns = false;
            RestockRequestDataGrid.DataSource = bs;

            for (int i = 0; i < RestockRequestDataGrid.RowCount; i++)
                RestockRequestDataGrid["select", i].Tag = 0;

            selectGoodsID.Clear();
        }

        //Get Goods
        private void GetGoods()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                result = gc.GetAllGoods();
            }
            else
            {
                string str = "id:" + this.SearchBarTxt.Texts
                            + "|description:" + this.SearchBarTxt.Texts + "|price:" + this.SearchBarTxt.Texts
                            + "|gtincode:" + this.SearchBarTxt.Texts + "|size:" + this.SearchBarTxt.Texts
                            + "|status:" + this.SearchBarTxt.Texts;
                result = gc.GetGoodsByQry(str);
            }
            try
            {
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(result.Content, (typeof(DataTable)));
                var res = JArray.Parse(result.Content.ToString());
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
                RestockRequestDataGrid.AutoGenerateColumns = false;
                RestockRequestDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Delete Selected Goods
        private void DeleteSelectedGoods()
        {
            if (selectGoodsID.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to delete the " + selectGoodsID.Count + " goods?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        int countDeleted = 0;
                        string res;
                        foreach (string uid in selectGoodsID)
                        {
                            result = gc.DeleteGoods(uid);
                        }
                        MessageBox.Show(selectGoodsID.Count + " records have been deleted!", "Delete Goods Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetGoods();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete the goods.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("You had not selected a goods.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }

        //Delete Goods
        private void DeleteGoods(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + RestockRequestDataGrid.Rows[e.RowIndex].Cells["name"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    result = gc.DeleteGoods(RestockRequestDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The " + RestockRequestDataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString() + " have been deleted!", "Delete Goods Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetGoods();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete the goods", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //Goodsmanagement_Add goodsAdd = new Goodsmanagement_Add();
            //goodsAdd.Show();
        }



        // Export Goods PDF
        private void exportBtn_Click(object sender, EventArgs e)
        {
            Loading progress = new Loading();
            progress.Show();
            progress.Update("Fetch data from server ...", 10);
            byte[] response = gc.GetGoodsPDF();
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

            progress.End();

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

        private void curdAction_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
