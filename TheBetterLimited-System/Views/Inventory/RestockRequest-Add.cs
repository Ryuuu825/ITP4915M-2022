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
        private List<JObject> orderItems = new List<JObject>();
        private List<PurchaseItem> items = new List<PurchaseItem>();
        private ControllerBase cbRestock = new ControllerBase("RestockRequest");

        public RestockRequest_Add()
        {
            InitializeComponent();
        }

        public void SetOrderData(List<JObject> goods)
        {
            this.orderItems = goods;
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

        private void InitializeOrderItemTable()
        {
            items.Clear();
            foreach (var item in orderItems)
            {
                var row = orderTable.NewRow();
                row["goodsName"] = item["GoodsName"].ToString();
                row["supplierGoodsStockId"] = item["_supplierGoodsStockId"].ToString();
                row["curQty"] = item["Quantity"];
                row["reqQty"] = (int)item["MaxLimit"] - (int)item["Quantity"];
                row["max"] = item["MaxLimit"].ToString();
                items.Add(new PurchaseItem(item["_supplierGoodsStockId"].ToString(), item["GoodsName"].ToString(), (int)row["reqQty"]));
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
           
        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                orderItems.RemoveAt(e.RowIndex);
                items.RemoveAt(e.RowIndex);
                InitializeOrderItemTable();
            }
        }
        private void OrderDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (OrderDataGrid.CurrentCell.ColumnIndex == 0) //Desired Column
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
            MessageBox.Show("Quantity value is invalid!");
        }

        private void OrderDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            items[e.RowIndex].quantity = Convert.ToInt32(OrderDataGrid["quantity", e.RowIndex].Value);
        }
    }
}
