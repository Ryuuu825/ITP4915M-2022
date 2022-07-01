using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class RestockRequest_Add : Form
    {
        private RestResponse response = new RestResponse();
        private DataTable orderTable = new DataTable();
        private BindingSource bs = new BindingSource();
        private List<string> stocks = new List<string>();
        private List<JObject> orderItems = new List<JObject>();
        private List<RestockItem> items = new List<RestockItem>();
        private ControllerBase cbRestock = new ControllerBase("Restock");
        private ControllerBase cbStock = new ControllerBase("inventory/sgs");

        public RestockRequest_Add()
        {
            InitializeComponent();
        }

        public RestockRequest_Add(List<string> goodsIds)
        {
            this.stocks = goodsIds;
            InitializeComponent();
            InitDataTable();
            InitializeOrderItemTable();
        }


        private void InitDataTable()
        {
            orderTable.Columns.Add("goodsName");
            orderTable.Columns.Add("supplierGoodsStockId");
            orderTable.Columns.Add("curQty");
            orderTable.Columns.Add("reqQty");
            orderTable.Columns.Add("max");
        }

        public void InitializeOrderItemTable()
        {
            orderItems.Clear();
            orderTable.Clear();
            items.Clear();
            foreach (var item in stocks)
            {
                response = cbStock.GetById(item, lang: System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
                JObject stock = JObject.Parse(response.Content);
                orderItems.Add(stock);
            }
            foreach (var item in orderItems)
            {
                var row = orderTable.NewRow();
                row["goodsName"] = item["GoodsName"].ToString();
                row["supplierGoodsStockId"] = item["Id"].ToString();
                row["curQty"] = item["Quantity"];
                row["reqQty"] = (int)item["MaxLimit"] - (int)item["Quantity"];
                row["max"] = item["MaxLimit"].ToString();
                items.Add(new RestockItem(item["Id"].ToString(), Convert.ToInt32(row["reqQty"])));
                orderTable.Rows.Add(row);
            }
            bs.DataSource = orderTable;
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = bs;
        }

        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("items", items);
                Console.WriteLine("Request: " + JsonConvert.SerializeObject(data));
                var response = cbRestock.Create(data);
                Console.WriteLine(response.Content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Restock Request Created Successfully");
                    this.OnExit.Invoke();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show(response.Content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            };
        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                stocks.RemoveAt(e.RowIndex);
                InitializeOrderItemTable();
            }
        }
        private void OrderDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (OrderDataGrid.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void OrderDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Quantity value is invaild");
            OrderDataGrid.CancelEdit();
        }

        private void OrderDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qty = Convert.ToInt32(OrderDataGrid["reqQty", e.RowIndex].Value);
            if (qty <= 0)
            {
                MessageBox.Show("Quantity is at least one.");
                OrderDataGrid["reqQty", e.RowIndex].Value = items[e.RowIndex].quantity;
                return;
            }
            if(qty > (Convert.ToInt32(OrderDataGrid["max", e.RowIndex].Value) - Convert.ToInt32(OrderDataGrid["curQty", e.RowIndex].Value)))
            {
                MessageBox.Show("Quantity cannot exceed maximum limit.");
                OrderDataGrid["reqQty", e.RowIndex].Value = items[e.RowIndex].quantity;
                return;
            }
            items[e.RowIndex].quantity = Convert.ToInt32(OrderDataGrid["reqQty", e.RowIndex].Value);
        }
    }
}
