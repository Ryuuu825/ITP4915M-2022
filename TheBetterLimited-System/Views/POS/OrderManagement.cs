using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class OrderManagement : Form
    {
        private UserController uc = new UserController();
        private BindingSource bs = new BindingSource();
        private List<string> selecteUserId = new List<string>();
        private DialogResult choose;
        private RestResponse result;
        private bool isSawDetails = false;
        private ControllerBase cbOrder = new ControllerBase("Order");
        private string _storeId;

        public OrderManagement()
        {
            InitializeComponent();
            GetOrder();//init user table
        }

        /*
         * Dom Style/Event Process
         */
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedOrder();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            GetOrder();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (OrderDataGrid.Columns[e.ColumnIndex].Name == "status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (e.Value.Equals("L"))
                {
                    e.Value = "Cancel";
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                    OrderDataGrid.Columns[e.ColumnIndex].ToolTipText = "Unlock";
                    OrderDataGrid.Rows[e.RowIndex].Cells["lockAcc"].Value = Properties.Resources.unlock;
                    OrderDataGrid.Rows[e.RowIndex].Cells["lockAcc"].Tag = 1;
                }
                else
                {
                    e.Value = "Normal";
                    e.CellStyle.ForeColor = Color.SeaGreen;
                }

            }
        }

        private void UserDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["select"].Index)
            {
                if (Convert.ToInt32(OrderDataGrid["select", e.RowIndex].Tag) == 0)
                {
                    OrderDataGrid["select", e.RowIndex].Value = Properties.Resources.check;
                    OrderDataGrid["select", e.RowIndex].Tag = 1;
                    OrderDataGrid.Rows[e.RowIndex].Selected = true;
                    selecteUserId.Add(OrderDataGrid["id", e.RowIndex].Value.ToString());
                }
                else
                {
                    OrderDataGrid["select", e.RowIndex].Value = Properties.Resources.square;
                    OrderDataGrid["select", e.RowIndex].Tag = 0;
                    OrderDataGrid.Rows[e.RowIndex].Selected = false;
                    selecteUserId.Remove(OrderDataGrid["id", e.RowIndex].Value.ToString());
                }
            }

            if (e.ColumnIndex == OrderDataGrid.Columns["details"].Index)
            {
                Form order = Application.OpenForms["OrderDetails"];
                if (order != null)
                {
                    order.Close();
                }
                OrderDetails od = new OrderDetails();
                od._oid = OrderDataGrid["id", e.RowIndex].Value.ToString();
                od.Show();
                od.TopLevel = true;
                od.OnExit += GetOrder;

            }

            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                DeleteOrder(e);
            }
        }

        //search bar text changed event
        private void SearchBarTxt__TextChanged(object sender, EventArgs e)
        {
            GetOrder();
        }


        /*
        * Dom Event Handler
        */

        //Initialize DataGridView
        private void InitializeDataGridView()
        {
            //Main data column
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = bs;

            for (int i = 0; i < OrderDataGrid.RowCount; i++)
                OrderDataGrid["select", i].Tag = 0;

            selecteUserId.Clear();
        }

        //Get Order
        public void GetOrder()
        {
            if (this.SearchBarTxt.Texts == "" || this.SearchBarTxt.Texts == SearchBarTxt.Placeholder)
            {
                result = cbOrder.GetByQueryString("storeId:");
            }
            else
            {
                string str = "id:" + this.SearchBarTxt.Texts + "|emailAddress:" + this.SearchBarTxt.Texts
                            + "|userName:" + this.SearchBarTxt.Texts + "|status:" + this.SearchBarTxt.Texts;
                result = cbOrder.GetByQueryString(str);
            }
            try
            {
                //DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(result.Content, (typeof(DataTable)));
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id");
                dataTable.Columns.Add("id2");
                dataTable.Columns.Add("id3");
                dataTable.Columns.Add("id4");
                dataTable.Columns.Add("id5");
                dataTable.Columns.Add("id6");
                dataTable.Columns.Add("id7");
                dataTable.Columns.Add("id8");
                dataTable.Columns.Add("id9");
                dataTable.Columns.Add("id10");
                dataTable.Columns.Add("id11");
                dataTable.Rows.Add(Properties.Resources.check, "1","1","1","1","1","1","1","1", Properties.Resources.check, Properties.Resources.check) ;
                bs.DataSource = dataTable;
                OrderDataGrid.AutoGenerateColumns = false;
                OrderDataGrid.DataSource = bs;
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Delete Selected Order
        private void DeleteSelectedOrder()
        {
            if (selecteUserId.Count > 0)
            {
                choose = MessageBox.Show("Do you really want to delete the " + selecteUserId.Count + " Order(s)?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (choose == DialogResult.Yes)
                {
                    try
                    {
                        int countDeleted = 0;
                        foreach (string uid in selecteUserId)
                        {
                            result = cbOrder.Delete(uid);
                            if(result.StatusCode != System.Net.HttpStatusCode.OK)
                            {
                                throw new Exception(result.ErrorMessage);
                            }
                        }
                        MessageBox.Show("The " + selecteUserId.Count + " order(s) have been deleted!", "Delete Order Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetOrder();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("You had not selected an order.", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }

        //Delete Order
        private void DeleteOrder(DataGridViewCellEventArgs e)
        {
            choose = MessageBox.Show("Do you really want to delete the " + OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value + "?", "Confirmation Request", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (choose == DialogResult.Yes)
            {
                try
                {
                    result = cbOrder.Delete(OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("The order " + OrderDataGrid.Rows[e.RowIndex].Cells["id"].Value + " have been deleted!", "Delete Order ScbOrdercessful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        GetOrder();
                    }else
                    {
                        MessageBox.Show("The order has been delivered. \n Cannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        GetOrder();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Cannot delete the order.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
