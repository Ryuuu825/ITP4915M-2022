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

namespace TheBetterLimited.Views
{
    public partial class OrderDetails : Form
    {
        private UserController uc = new UserController();
        private StaffController sc = new StaffController();
        private PositionController pc = new PositionController();
        private DepartmentController dc = new DepartmentController();
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        private DataTable orderTable = new DataTable();
        private BindingSource bs = new BindingSource();
        JArray orderItems = new JArray();

        public OrderDetails()
        {
            InitializeComponent();
            
        }

        public void SetOrderItems(JArray orderItems)
        {
            this.orderItems = orderItems;
            InitializeOrderItemTable();
        }

        private void InitializeOrderItemTable()
        {
            orderTable.Columns.Add("goodsName");
            orderTable.Columns.Add("supplierGoodsStockId");
            orderTable.Columns.Add("quantity");
            orderTable.Columns.Add("price");
            orderTable.Columns.Add("isDelivery");
            orderTable.Columns.Add("isInstall");
            orderTable.Columns.Add("isBooking");
            //
            foreach (var item in orderItems)
            {
                var row = orderTable.NewRow();
                row["goodsName"] = item["name"].ToString();
                row["supplierGoodsStockId"] = item["supplierGoodsStockId"].ToString();
                row["quantity"] = item["quantity"].ToString();
                row["price"] = item["price"].ToString();
                if((bool)item["needDelivery"] == false)
                {
                    Console.WriteLine("needDelivery");
                    row["isDelivery"] = Properties.Resources.square;
                }else
                {
                    row["isDelivery"] = Properties.Resources.check;
                }
                if ((bool)item["needInstall"] == false)
                {
                    Console.WriteLine("needInstall");
                    row["isInstall"] = Properties.Resources.square;
                }
                else
                {
                    Console.WriteLine("isInstall");
                    row["isInstall"] = Properties.Resources.check;
                }
                if ((bool)item["needBooking"] == false)
                {
                    Console.WriteLine("needBooking");
                    row["isBooking"] = Properties.Resources.square;
                }
                else
                {
                    row["isBooking"] = Properties.Resources.check;
                }
                orderTable.Rows.Add(row);
            }

            bs.DataSource = orderTable;
            OrderDataGrid.AutoGenerateColumns = false;
            OrderDataGrid.DataSource = bs;

        }


        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
        }

        /*private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<object> updatedData = new List<object>();
            if (!StaffIDTxt.Texts.Equals(_staffId) && !StaffIDTxt.Texts.Equals(StaffIDTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "_StaffId",
                    value = StaffIDTxt.Texts
                };
                updatedData.Add(obj);
            }

            var tempStatus = "";
            if (!tempStatus.Equals(_status))
            {
                var obj = new
                {
                    attribute = "Status",
                    value = tempStatus
                };
                updatedData.Add(obj);
            }

            var json = JsonSerializer.Serialize(updatedData);
            try
            {
                Console.WriteLine(json);
                result = uc.UpdateAccount(updatedData, _oid);
                Console.WriteLine(result.StatusCode);
                Console.WriteLine(result.Content);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("User information has been updated!");
                    this.Close();
                    this.Dispose();
                    this.OnExit.Invoke();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Sorry, user information update unsuccessfully");
            }
        }*/
    }
}
