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
    public partial class PurchaseOrder_Create : Form
    {
        private RestResponse response = new RestResponse();
        private DataTable orderTable = new DataTable();
        private BindingSource bs = new BindingSource();
        private JObject orderData = new JObject();
        List<JObject> suppliers = new List<JObject>();
        private string supplierId = String.Empty;
        private ControllerBase cbSupplier = new ControllerBase("Supplier");
        private ControllerBase cbPO = new ControllerBase("purchase/order");
        private bool firstInit = false;
        public List<object> orderItems = new List<object>();

        public PurchaseOrder_Create()
        {
            InitializeComponent();
            InitSupplierCombo();
        }

        private void InitSupplierCombo()
        {
            response = cbSupplier.GetAll();
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var sups =  JArray.Parse(response.Content);
                foreach(JObject sup in sups)
                {
                    suppliers.Add(sup);
                    Console.WriteLine(sup.ToString());
                    cbSup.Items.Add(sup["Name"].ToString());
                }
            }
        }

        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (cbSup.SelectedIndex == -1)
            {
                cbSup.BorderColor = Color.Red;
                return;
            }
            var supplierId = suppliers[cbSup.SelectedIndex]["ID"];

            if (cbWarehouse.SelectedIndex == -1)
            {
                cbWarehouse.BorderColor = Color.Red;
                return;
            }
            var warehouseId = (cbWarehouse.SelectedIndex+1).ToString("000");

            if(orderItems.Count == 0)
            {
                MessageBox.Show("You have not added any items");
                return;
            }

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("_warehouseId", warehouseId);
            data.Add("_supplierId", supplierId);
            data.Add("Items", orderItems);
            foreach (PurchaseItem value in orderItems)
            {
                Console.WriteLine("Value of the Dictionary Item is: {0}", value.goodsName);
            }
            string re = JObject.FromObject(data).ToString();

            var response = cbPO.Create(re);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Create Purchase Order Successfully");
                this.OnExit.Invoke();
                this.Close();
                this.Dispose();
            }else
            {
                Console.WriteLine(response.StatusCode);
                MessageBox.Show(response.Content);
            }
        }

        private void PhoneTxt_Click(object sender, EventArgs e)
        {
            txtContact.IsError = false;
        }

        private void ArrangeBtn_Click(object sender, EventArgs e)
        {
            Form arrangeForm = Application.OpenForms["Appointment_Arrange"];
            if (arrangeForm != null)
            {
                arrangeForm.Close();
                arrangeForm.Dispose();
            }
            Appointment_Arrange arrangeAppointment = new Appointment_Arrange();
            arrangeAppointment.Show();
            arrangeAppointment.TopLevel = true;
        }


        public void AddItem(List<object> ois) {
            foreach (var item in ois) {
                bool isExist = false;
                if (this.orderItems.Count == 0)
                {
                    orderItems.Add(item);
                }
                else
                {
                    for (int i = 0; i < orderItems.Count; i++)
                    {
                        //Check if an order item exists in the shopping cart
                        if (((PurchaseItem)orderItems[i])._goodsId == ((PurchaseItem)item)._goodsId)
                        {
                            ((PurchaseItem)orderItems[i]).quantity += 1;
                            isExist = true;
                            break;
                        }
                    }
                    if (isExist == false)
                    {
                        orderItems.Add(item);
                    }
                }
            }
            InitializeCartGridView();
        }

        private void InitializeCartGridView()
        {
            //Main data column
            var dt = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(orderItems));
            bs.DataSource = dt;
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = dt;
            this.Invalidate();
        }

        private void OrderDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrderDataGrid.Columns["delete"].Index)
            {
                orderItems.RemoveAt(e.RowIndex);
                InitializeCartGridView();
                return;
            }
        }

        private void OrderDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (OrderDataGrid.Columns[e.ColumnIndex].Name == "status")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (e.Value.Equals("Refund"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                    OrderDataGrid.Rows[e.RowIndex].Cells["defect"].Tag = 1;
                }
                else if (e.Value.Equals("Exchange"))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(19, 115, 235);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(19, 115, 235);
                    OrderDataGrid.Rows[e.RowIndex].Cells["defect"].Tag = 1;
                }
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

        private void cbSup_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtContact.Texts = suppliers[cbSup.SelectedIndex]["Contact"].ToString();
            txtTel.Texts = suppliers[cbSup.SelectedIndex]["Phone"].ToString();
            txtSupAddress.Texts = suppliers[cbSup.SelectedIndex]["Address"].ToString();
            supplierId = suppliers[cbSup.SelectedIndex]["ID"].ToString();

            if(orderItems.Count != 0)
            {
                DialogResult result = MessageBox.Show("Changing the supplier will clear all current order items,\nDo you really need to change?", "",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    orderItems.Clear();
                    InitializeCartGridView();
                }
            }

            Form supGoods = Application.OpenForms["SupplierGoods"];
            if (supGoods != null)
            {
                ((SupplierGoods)supGoods).InitTable(supplierId);
            }
        }

        private void cbWarehouse_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtWHAddress.Texts = "59 Tai Yip Street Kowloon Bay Kolwoon, Hong Kong";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(cbSup.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a supplier first.");
                cbSup.BorderColor = Color.Red;
                return;
            }
            SupplierGoods od = new SupplierGoods(supplierId);
            od.TopLevel = false;
            od.Dock = DockStyle.Fill;
            this.Controls.Add(od);
            this.Tag = od;
            od.BringToFront();
            od.Show();
        }

        private void cbSup_Click(object sender, EventArgs e)
        {
            cbSup.BorderColor = Color.LightGray;
        }

        private void OrderDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Quantity value " + OrderDataGrid["quantity", e.RowIndex].Value + " is invalid!");
        }

        private void cbWarehouse_Click(object sender, EventArgs e)
        {
            cbWarehouse.BorderColor = Color.LightGray;
        }
    }
}
