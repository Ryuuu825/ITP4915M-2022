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
    public partial class Goods : Form
    {
        private GoodsController gc = new GoodsController();
        private BindingSource bs = new BindingSource();
        private List<string> selectGoodsID = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private ControllerBase cbCatalogue = new ControllerBase("Catalogue");
        private BackgroundWorker bw = new BackgroundWorker();
        private bool loadAll = true;
        private string QryString = "";

        public Goods()
        {
            InitializeComponent();
            initBackgroundWorker();
            showLoading();
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
            GetGoods();//init
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InitList();
            loadPic.Hide();
            loadPic.Controls.Clear();
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
            try
            {
                showLoading();
                bw.RunWorkerAsync();
            }catch (Exception ex)
            {
                MessageBox.Show("Goods are loading.\nPlease wait a moment!");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if (GoodsDataGrid.Columns[e.ColumnIndex].Name == "Size")
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
            if (e.ColumnIndex == GoodsDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(GoodsDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    GoodsDataGrid["select", e.RowIndex].Value = Properties.Resources.check24;
                    GoodsDataGrid["select", e.RowIndex].Tag = 1;
                    GoodsDataGrid.Rows[e.RowIndex].Selected = true;
                    selectGoodsID.Add(GoodsDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    GoodsDataGrid["select", e.RowIndex].Value = Properties.Resources.square24;
                    GoodsDataGrid["select", e.RowIndex].Tag = 0;
                    GoodsDataGrid.Rows[e.RowIndex].Selected = false;
                    selectGoodsID.Remove(GoodsDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == GoodsDataGrid.Columns["edit"].Index)
            {
                string id = GoodsDataGrid["id", e.RowIndex].Value.ToString();
                Goods_Edit editGoodsForm = new Goods_Edit(id);
                editGoodsForm.Show();
                editGoodsForm.TopLevel = true;
                editGoodsForm.OnExit += ()=> {
                    showLoading();
                    bw.RunWorkerAsync(); 
                };
            }

            if (e.ColumnIndex == GoodsDataGrid.Columns["delete"].Index)
            {
                DeleteGoods(e);
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
            for (int i = 0; i < GoodsDataGrid.RowCount; i++)
                GoodsDataGrid["select", i].Tag = 0;

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
                            + "|gtincode:" + this.SearchBarTxt.Texts + "|size:" + this.SearchBarTxt.Texts
                            + "|status:" + this.SearchBarTxt.Texts;
                result = gc.GetGoodsByQry(str);
            }
        }
        private void InitList()
        {
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
                GoodsDataGrid.AutoGenerateColumns = false;
                GoodsDataGrid.DataSource = bs;
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
                        showLoading();
                        bw.RunWorkerAsync();
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
            choose = MessageBox.Show("Do you really want to delete the " + GoodsDataGrid.Rows[e.RowIndex].Cells["name"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                System.ComponentModel.BackgroundWorker backgroundWorker = new BackgroundWorker();
                try
                {
                    backgroundWorker.DoWork += (s, eventArg) =>
                    {
                        result = gc.DeleteGoods(GoodsDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                        if (result.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The " + GoodsDataGrid.Rows[e.RowIndex].Cells["name"].Value.ToString() + " have been deleted!", "Delete Goods Successful", MessageBoxButtons.OK, MessageBoxIcon.None);

                        };
                    };

                    backgroundWorker.RunWorkerCompleted += (s, eventArgs) =>
                    {
                        loadPic.Hide();
                        InitList();
                    };
                    loadPic.Show();
                    backgroundWorker.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete the goods", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                backgroundWorker.Dispose();
            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Goods_Add goodsAdd = new Goods_Add();
            goodsAdd.OnExit += () => {
                showLoading();
                bw.RunWorkerAsync(); 
            };
            goodsAdd.Show();
        }


        // Export Goods PDF
        private async void exportBtn_Click(object sender, EventArgs e)
        {
            System.ComponentModel.BackgroundWorker bgWorker = new System.ComponentModel.BackgroundWorker();

            string WriteFilePath = AppDomain.CurrentDomain.BaseDirectory + "/tmp/test.pdf";

            bgWorker.DoWork += (s, eargs) =>
            {
                byte[] response = gc.GetGoodsPDF();
                System.IO.File.WriteAllBytes(WriteFilePath, response);
            };


            bgWorker.RunWorkerCompleted += (s, eargs) =>
            {
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
            };
            bgWorker.RunWorkerAsync();
            bgWorker.Dispose();
        }

        private void curdAction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
    }
}
