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
        private RQController cbRestock = new RQController("Restock");
        private ControllerBase cbStock = new ControllerBase("inventory/sgs");

        public RestockRequest_Details()
        {
            InitializeComponent();
        }

        public RestockRequest_Details(JObject restock)
        {
            this.rq = restock;
            InitializeComponent();
            AccessControl();
            InitDataTable();
            InitializeOrderItemTable();
        }

        private void AccessControl()
        {
            foreach (Control control in BottomBtn.Controls)
            {
                control.Visible = false;
            }
            switch ((int)rq["status"])
            {
                case (int)RestockStatusEnum.PendingApproval:
                    if (GlobalsData.currentUser["department"].ToString().Equals("Inventory") && rq["location"]["Id"].ToString() != "003")
                    {
                        BackBtn.Visible = true;
                        ApproveBtn.Visible = true;
                        RejectBtn.Visible = true;
                    }else if(GlobalsData.currentUser["department"].ToString().Equals("Purchase") && rq["location"]["Id"].ToString() == "003")
                    {
                        BackBtn.Visible = true;
                        ApproveBtn.Visible = true;
                        RejectBtn.Visible = true;
                    }
                    else
                    {
                        BackBtn.Visible = true;
                        BackBtn.Location = new Point(774, 6);
                    }
                    break;
                case (int)RestockStatusEnum.Pending:
                    CancelBtn.Visible = true;
                    ConfirmBtn.Visible = true;
                    break;
                default:
                    BackBtn.Visible = true;
                    BackBtn.Location = new Point(774, 6);
                    break;
            }
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

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            if ((int)rq["status"] == (int)RestockStatusEnum.PendingApproval)
            {
                DialogResult result = MessageBox.Show("Are you sure to approve the restock request?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int status = 0;
                        if (GlobalsData.currentUser["department"].Equals("Inventory"))
                        {
                            status = (int)RestockStatusEnum.Handling;
                        }
                        else
                        {
                            status = (int)RestockStatusEnum.Approved;
                        }
                        response = cbRestock.UpdateStatus(rq["id"].ToString(), status);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The restock request approved successfully");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Approve restock request error.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Approve restock request error.");
                    }
                }
            }
            else
            {
                MessageBox.Show("The restock request has been processed.");
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            if ((int)rq["status"] == (int)RestockStatusEnum.PendingApproval)
            {
                DialogResult result = MessageBox.Show("Are you sure to reject the restock request?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        response = cbRestock.UpdateStatus(rq["id"].ToString(), (int)RestockStatusEnum.Rejected);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The restock request rejected successfully");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Reject restock request error.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Reject restock request error.");
                    }
                }
            }
            else
            {
                MessageBox.Show("The restock request has been processed.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if ((int)rq["status"] == (int)RestockStatusEnum.Pending)
            {
                DialogResult result = MessageBox.Show("Are you sure to send out the restock request?", "Confirmation Request", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        response = cbRestock.UpdateStatus(rq["id"].ToString(), (int)RestockStatusEnum.PendingApproval);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show("The restock request has been sent out.");
                            this.OnExit.Invoke();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Confirm restock request error.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Confirm restock request error.");
                    }
                }
            }
            else
            {
                MessageBox.Show("The restock request has been processed.");
            }
        }
    }
}
