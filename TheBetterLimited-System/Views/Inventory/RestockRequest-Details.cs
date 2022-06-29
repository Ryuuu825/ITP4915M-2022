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
    public partial class RestockRequest_Details : Form
    {
        private RestResponse response = new RestResponse();
        private DataTable orderTable = new DataTable();
        private BindingSource bs = new BindingSource();
        private JObject rq = new JObject();
        private List<JObject> orderItems = new List<JObject>();
        private List<RestockItem> items = new List<RestockItem>();
        private ControllerBase cbRestock = new ControllerBase("Restock");
        private ControllerBase cbStock = new ControllerBase("inventory/sgs");

        public RestockRequest_Details()
        {
            InitializeComponent();
        }

        public RestockRequest_Details(JObject restock)
        {
            this.rq = restock;
            InitializeComponent();
            InitDataTable();
            InitializeOrderItemTable();
        }


        private void InitDataTable()
        {
            orderTable.Columns.Add("goodsName");
            orderTable.Columns.Add("catalogue");
            orderTable.Columns.Add("goodsId");
            orderTable.Columns.Add("reqQty");
        }

        public void InitializeOrderItemTable()
        {
            orderItems.Clear();
            orderTable.Clear();
            items.Clear();

            foreach (JObject item in (JArray)rq["items"])
            {
                var row = orderTable.NewRow();
                row["goodsName"] = item["goods"]["GoodsName"].ToString();
                row["goodsId"] = item["goods"]["GoodsId"].ToString();
                row["reqQty"] = item["quantity"];
                row["catalogue"] = item["goods"]["Catalogue"].ToString();
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
            try {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            };
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
