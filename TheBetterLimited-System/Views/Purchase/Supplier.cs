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
    public partial class Supplier : Form
    {
        private UserController uc = new UserController();
        private GoodsController gc = new GoodsController();
        private BindingSource bs = new BindingSource();
        private List<string> selectGoodsID = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private ControllerBase con = new ControllerBase("Supplier");

        public Supplier()
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
            if (SupplierDataGrid.Columns[e.ColumnIndex].Name == "Status")
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

            if (SupplierDataGrid.Columns[e.ColumnIndex].Name == "Size")
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
            if (e.ColumnIndex == SupplierDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(SupplierDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    SupplierDataGrid["select", e.RowIndex].Value = Properties.Resources.check;
                    SupplierDataGrid["select", e.RowIndex].Tag = 1;
                    SupplierDataGrid.Rows[e.RowIndex].Selected = true;
                    selectGoodsID.Add(SupplierDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    SupplierDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    SupplierDataGrid["select", e.RowIndex].Tag = 0;
                    SupplierDataGrid.Rows[e.RowIndex].Selected = false;
                    selectGoodsID.Remove(SupplierDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == SupplierDataGrid.Columns["edit"].Index)
            {
                Supplier_Edit editSupplier = new Supplier_Edit(SupplierDataGrid["id", e.RowIndex].Value.ToString());
                editSupplier.Show();
                editSupplier.OnExit += () => GetGoods();
            }

            if (e.ColumnIndex == SupplierDataGrid.Columns["delete"].Index)
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
            SupplierDataGrid.AutoGenerateColumns = false;
            SupplierDataGrid.DataSource = bs;
            SupplierDataGrid.Columns["id"].HeaderText = "ID";
            SupplierDataGrid.Columns["supplierName"].HeaderText = "Name";
            SupplierDataGrid.Columns["phone"].HeaderText = "Phone";
            SupplierDataGrid.Columns["contact"].HeaderText = "Contact";
            SupplierDataGrid.Columns["address"].HeaderText = "Address";
            // GoodsDataGrid.Columns["id"].HeaderText = "ID";
            // GoodsDataGrid.Columns["userName"].HeaderText = "User Name";
            // GoodsDataGrid.Columns["staffName"].HeaderText = "Staff Name";
            // GoodsDataGrid.Columns["emailAddress"].HeaderText = "Email Address";
            // GoodsDataGrid.Columns["status"].HeaderText = "Status";
            // GoodsDataGrid.Columns["_staffId"].HeaderText = "Staff ID";
            // GoodsDataGrid.Columns["remarks"].HeaderText = "Remark";

            for (int i = 0; i < SupplierDataGrid.RowCount; i++)
                SupplierDataGrid["select", i].Tag = 0;

            selectGoodsID.Clear();
        }

        //Get Goods
        private void GetGoods()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == "Search")
            {
                result = con.GetAll();
            }
            else
            {
                string str = "id:" + this.SearchBarTxt.Texts
                            + "|description:" + this.SearchBarTxt.Texts + "|price:" + this.SearchBarTxt.Texts
                            + "|gtincode:" + this.SearchBarTxt.Texts + "|size:" + this.SearchBarTxt.Texts
                            + "|status:" + this.SearchBarTxt.Texts;
                result = con.GetByQueryString(str);
            }
            try
            {
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(result.Content, (typeof(DataTable)));
               
                bs.DataSource = dataTable;
                SupplierDataGrid.AutoGenerateColumns = false;
                SupplierDataGrid.DataSource = bs;
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
            choose = MessageBox.Show("Do you really want to delete the " + SupplierDataGrid.Rows[e.RowIndex].Cells["supplierName"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    result = con.Delete(SupplierDataGrid["id", e.RowIndex].Value.ToString());
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The " + SupplierDataGrid["supplierName", e.RowIndex].Value.ToString() + " is deleted",  "Delete Goods Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    GetGoods();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Cannot delete the goods", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //Goodsmanagement_Add goodsAdd = new Goodsmanagement_Add();
            //goodsAdd.Show();
            Supplier_Add supplierAdd = new Supplier_Add();
            supplierAdd.OnExit += () => GetGoods();
            supplierAdd.Show();
        }



        // Export Goods PDF
        private void exportBtn_Click(object sender, EventArgs e)
        {
            CustomizeControl.Loading progress = new CustomizeControl.Loading();
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
