﻿using Newtonsoft.Json;
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
    public partial class PurchaseOrder_Details : Form
    {
        private RestResponse response = new RestResponse();
        private DataTable orderTable = new DataTable();
        private BindingSource bs = new BindingSource();
        private JObject orderData = new JObject();
        List<JObject> suppliers = new List<JObject>();
        private string supplierId = String.Empty;
        private ControllerBase cbSupplier = new ControllerBase("Supplier");
        private POController cbPO = new POController("purchase/order");
        public List<object> orderItems = new List<object>();
        private JObject PO;
        private string supId;
        private int selectedSup;
        private bool dataChange = false;

        public PurchaseOrder_Details()
        {
            InitializeComponent();
            InitSupplierCombo();
        }

        public PurchaseOrder_Details(JObject po)
        {
            PO = po;
            InitializeComponent();
            AccessControl();
            InitSupplierCombo();
            InitPurchaseOrder();
        }

        private void InitSupplierCombo()
        {
            response = cbSupplier.GetAll();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var sups = JArray.Parse(response.Content);
                foreach (JObject sup in sups)
                {
                    suppliers.Add(sup);
                    cbSup.Items.Add(sup["Name"].ToString());
                }
            }
        }

        private void AccessControl()
        {
            foreach (Control control in BottomBtn.Controls)
            {
                control.Visible = false;
            }
            switch ((int)PO["status"])
            {
                case (int)POStatus.PendingApproval:
                    if (GlobalsData.currentUser["department"].ToString() == "Accounting")
                    {
                        AddBtn.Visible = false;
                        ApproveBtn.Visible = true;
                        RejectBtn.Visible = true;
                        BackBtn.Visible = true;
                        OrderInfoBox.Enabled = false;
                        OrderDataGrid.ReadOnly = true;
                        OrderDataGrid.Columns["delete"].Visible = false;
                    }
                    else
                    {
                        ConfirmBtn.Visible = true;
                        SaveBtn.Visible = true;
                        CancelBtn.Visible = true;
                    }
                    break;
                case (int)POStatus.Approved:
                    AddBtn.Visible = false;
                    OrderDataGrid.ReadOnly = true;
                    CancelBtn.Visible = true;
                    SentBtn.Visible = true;
                    OrderDataGrid.Columns["delete"].Visible = false;
                    if (GlobalsData.currentUser["department"].ToString() == "Accounting")
                    {
                        SentBtn.Visible = false;
                        CancelBtn.Visible = false;
                        BackBtn.Visible=true;
                        BackBtn.Location = new Point(503, 6);
                    }
                    break;
                case (int)POStatus.Inbound:
                    AddBtn.Visible = false;
                    CompleteBtn.Visible = true;
                    CancelBtn.Visible = true;
                    OrderDataGrid.ReadOnly = true;
                    OrderInfoBox.Enabled = false;
                    OrderDataGrid.Columns["delete"].Visible = false;
                    OrderDataGrid.Columns["recQty"].Visible = true;
                    break;
                case (int)POStatus.Completed:
                case (int)POStatus.Rejected:
                case (int)POStatus.SentToSupplier:
                    AddBtn.Visible = false;
                    OrderDataGrid.ReadOnly = true;
                    OrderInfoBox.Enabled = false;
                    OrderDataGrid.Columns["delete"].Visible = false;
                    BackBtn.Visible = true;
                    BackBtn.Location = new Point(503, 6);
                    if ((int)PO["status"] == (int)POStatus.Completed)
                        OrderDataGrid.Columns["recQty"].Visible = true;
                    break;
                default:
                    ConfirmBtn.Visible = true;
                    SaveBtn.Visible = true;
                    CancelBtn.Visible = true;
                    break;
            }
        }

        private void InitPurchaseOrder()
        {
            var supplier = suppliers.Single(sup => sup["ID"].ToString() == PO["_supplierId"].ToString());
            cbSup.SelectedItem = supplier["Name"].ToString();
            supplierId = supplier["ID"].ToString();
            cbWarehouse.SelectedIndex = 0;
            foreach (JObject item in (JArray)PO["items"])
            {
                var i = new PurchaseItem(item["goods"]["GoodsId"].ToString(), item["goods"]["GoodsName"].ToString(), (int)item["goods"]["Price"], (int)item["quantity"], (int)item["receivedQuantity"]);
                orderItems.Add(i);
            }
            InitializeCartGridView();
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
            string supId = "";
            if (supplierId != suppliers[cbSup.SelectedIndex]["ID"].ToString())
            {
                supId = suppliers[cbSup.SelectedIndex]["ID"].ToString();
                dataChange = true;
            }
            else
            {
                supId = supplierId;
            }

            if (cbWarehouse.SelectedIndex == -1)
            {
                cbWarehouse.BorderColor = Color.Red;
                return;
            }
            string warehouseId = (cbWarehouse.SelectedIndex + 1).ToString("000");

            if (orderItems.Count == 0)
            {
                MessageBox.Show("You have not added any items");
                return;
            }

            if (!dataChange)
            {
                MessageBox.Show("You have not changed any things");
                return;
            }
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("_warehouseId", warehouseId);
            data.Add("_supplierId", supId);
            data.Add("Items", orderItems);
            data.Add("id", PO["id"].ToString());
            try
            {
                var response = cbPO.Update(data);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Update Purchase Order Successfully");
                    this.OnExit.Invoke();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                    MessageBox.Show("Update Purchase Order Unsuccessfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddItem(List<object> ois)
        {
            dataChange = true;
            foreach (var item in ois)
            {
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

            if (orderItems.Count != 0 && cbSup.SelectedIndex != selectedSup)
            {
                DialogResult result = MessageBox.Show("Changing the supplier will clear all current order items,\nDo you really need to change?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    selectedSup = cbSup.SelectedIndex;
                    orderItems.Clear();
                    InitializeCartGridView();
                }
                else
                {
                    cbSup.SelectedIndex = selectedSup;
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
            if (cbSup.SelectedIndex == -1)
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

        private void OrderDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (((PurchaseItem)orderItems[e.RowIndex]).quantity == Convert.ToInt32(OrderDataGrid["quantity", e.RowIndex].Value))
            {
                return;
            }
            ((PurchaseItem)orderItems[e.RowIndex]).quantity = Convert.ToInt32(OrderDataGrid["quantity", e.RowIndex].Value);
            dataChange = true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (dataChange)
            {
                MessageBox.Show("The purchase order has been changed.\nPlease click the update button to save first");
                return;
            }
            if ((int)PO["status"] == (int)POStatus.Pending)
            {
                DialogResult result = MessageBox.Show("Are you sure to send the purchase order to accounting department?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        response = cbPO.UpdateStatus(PO["id"].ToString(), (int)POStatus.PendingApproval);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The purchase order has been sent to accounting department.");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Confirm purchase order error.\n" + response.Content);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Confirm purchase order error.\n" + response.Content);
                    }
                }
            }
            else
            {
                MessageBox.Show("The purchase order has been processed.");
            }
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            if ((int)PO["status"] == (int)POStatus.PendingApproval)
            {
                DialogResult result = MessageBox.Show("Are you sure to approve the purchase order?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        response = cbPO.UpdateStatus(PO["id"].ToString(), (int)POStatus.Approved);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The purchase order approved successfully");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Approve purchase order error.\n" + response.Content);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Approve purchase order error.\n" + response.Content);
                    }
                }
            }
            else
            {
                MessageBox.Show("The purchase order has been processed.");
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            if ((int)PO["status"] == (int)POStatus.PendingApproval)
            {
                DialogResult result = MessageBox.Show("Are you sure to reject the purchase order?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        response = cbPO.UpdateStatus(PO["id"].ToString(), (int)POStatus.Rejected);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The purchase order rejected successfully");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Reject purchase order error.\n" + response.Content);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Reject purchase order error.\n" + response.Content);
                    }
                }
            }
            else
            {
                MessageBox.Show("The purchase order has been processed.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SentBtn_Click(object sender, EventArgs e)
        {
            if ((int)PO["status"] == (int)POStatus.Approved)
            {
                DialogResult result = MessageBox.Show("Have you sent out the purchase order to the supplier?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        response = cbPO.UpdateStatus(PO["id"].ToString(), (int)POStatus.SentToSupplier);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The purchase order updated successfully");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Update purchase order error.\n" + response.Content);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update purchase order error.\n" + response.Content);
                    }
                }
            }
            else
            {
                MessageBox.Show("The purchase order has been processed.");
            }
        }

        private void OrderDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (OrderDataGrid.Columns[e.ColumnIndex].Name == "recQty")
            {
                e.CellStyle.Font = new System.Drawing.Font("Segoe UI", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (Convert.ToInt32(e.Value) == ((PurchaseItem)orderItems[e.RowIndex]).quantity)
                {
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.SelectionForeColor = Color.SeaGreen;
                }
                else if (Convert.ToInt32(e.Value) > ((PurchaseItem)orderItems[e.RowIndex]).quantity)
                {
                    e.CellStyle.ForeColor = Color.FromArgb(203, 32, 39);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(203, 32, 39);
                }
                else if (Convert.ToInt32(e.Value) < ((PurchaseItem)orderItems[e.RowIndex]).quantity)
                {
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionForeColor = Color.Orange;
                }
            }
        }

        private void CompleteBtn_Click(object sender, EventArgs e)
        {
            if ((int)PO["status"] == (int)POStatus.Inbound)
            {
                DialogResult result = MessageBox.Show("Are you sure to complete the purchase order?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        response = cbPO.UpdateStatus(PO["id"].ToString(), (int)POStatus.Completed);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The purchase order completed successfully");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Complete purchase order error.\n" + response.Content);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Complete purchase order error.\n" + response.Content);
                    }
                }
            }
            else
            {
                MessageBox.Show("The purchase order cannot be completed.");
            }
        }
    }
}
