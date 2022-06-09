using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited_System.Controller;
namespace TheBetterLimited.Views
{
    public partial class Stock_Edit : Form
    {
        private RestResponse result = new RestResponse();
        private string ID; 
        private string LocationId;
        private string SupplierGoodsId;
        private string Quantity;
        private int MaxLimit;
        private int MinLimit;
        private string ReorderLevel;
        private string GoodsName;
        private ControllerBase conn = new ControllerBase("Supplier_Goods_Stock");


        public Stock_Edit()
        {
            InitializeComponent();
        }

        public Stock_Edit(string StockId)
        {
            Console.WriteLine("New ing form" + StockId);
            RestRequest req = new RestRequest("/api/inventory/sgs/" + StockId, Method.Get)
                                    .AddHeader("Language", "en");
            result = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            JObject obj = JObject.Parse(result.Content);
            if (obj["isSoftDeleted"].ToObject<bool>())
            {
                throw new Exception("This stock has been deleted");
            }
            InitializeComponent();
            ID = StockId;
            LocationId = obj["_locationId"].ToString();
            SupplierGoodsId = obj["_supplierGoodsId"].ToString();
            Quantity = obj["Quantity"].ToString();
            MaxLimit = obj["MaxLimit"].ToObject<int>();
            MinLimit = obj["MinLimit"].ToObject<int>();
            ReorderLevel = obj["ReorderLevel"].ToString();
            GoodsName = obj["GoodsName"].ToString();



            txtId.Texts = ID;
            txtLocId.Texts = LocationId;
            txtSupplierGoodsId.Texts = SupplierGoodsId;
            txtQuantity.Texts = Quantity;
            txtMaxLimit.Texts = MaxLimit.ToString();
            txtMinLimit.Texts = MinLimit.ToString();
            txtReorderLevel.Texts = ReorderLevel;
            txtGoodsName.Texts = GoodsName;
        }


        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            /*StaffIDTxt.IsError = false;*/
        }


        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            List<object> UpdateContent = new List<object>();

            // if (!txtSupplierName.Texts.Equals(txtSupplierName.Placeholder) && !txtSupplierName.Texts.Equals(txtSupplierName))
            // {
            //     UpdateContent.Add(
            //         new { 
            //             Attribute = "Name",
            //             Value = txtSupplierName.Texts
            //         }
            //     );
            // }

            if (!txtQuantity.Texts.Equals(txtQuantity.Placeholder) && !txtQuantity.Texts.Equals(txtQuantity))
            {
                UpdateContent.Add(
                    new {
                        Attribute = "Quantity",
                        Value = txtQuantity.Texts
                    }
                );
            }

            if (!txtMaxLimit.Texts.Equals(txtMaxLimit.Placeholder) && !txtMaxLimit.Texts.Equals(txtMaxLimit))
            {
                UpdateContent.Add(
                    new {
                        Attribute = "MaxLimit",
                        Value = txtMaxLimit.Texts
                    }
                );
            }

            if (!txtMinLimit.Texts.Equals(txtMinLimit.Placeholder) && !txtMinLimit.Texts.Equals(txtMinLimit))
            {
                UpdateContent.Add(
                    new {
                        Attribute = "MinLimit",
                        Value = txtMinLimit.Texts
                    }
                );
            }

            if (!txtReorderLevel.Texts.Equals(txtReorderLevel.Placeholder) && !txtReorderLevel.Texts.Equals(txtReorderLevel))
            {
                UpdateContent.Add(
                    new {
                        Attribute = "ReorderLevel",
                        Value = txtReorderLevel.Texts
                    }
                );
            }

            RestRequest req = new RestRequest("/api/inventory/sgs/" + ID, Method.Put)
                                    .AddHeader("Language", "en")
                                    .AddBody(UpdateContent);
            result = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
            if (result.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Update Successfully");
                this.OnExit.Invoke();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(result.Content);
            }


        }





        public event Action OnExit;

       

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            txtId.Focus();
        }

      

        private void StaffIDTxt_Click(object sender, EventArgs e)
        {
            txtId.IsError = false;
        }

     
        private void StaffIDTxt__TextChanged(object sender, EventArgs e)
        {
            txtId.IsError = false;
        }

        private void StaffIDTxt_Leave(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mius_Click(object sender, EventArgs e)
        {
        }
    }
}
