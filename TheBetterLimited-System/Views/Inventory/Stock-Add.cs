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
using TheBetterLimited.CustomizeControl;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Stock_Add : Form
    {
        public Stock_Add()
        {
            InitializeComponent();
        }


        public ControllerBase goodsCon = new ControllerBase("Goods");
        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            
            if (txtSupplierGoodsId.Texts == "" || txtSupplierGoodsId.Texts == txtSupplierGoodsId.Placeholder)
            {
                txtSupplierGoodsId.BorderColor = Color.Red;
                return;
            }
            txtSupplierGoodsId.BorderColor = Color.LightGray;


            if (txtQuantity.Texts == "" || txtQuantity.Texts == txtQuantity.Placeholder)
            {
                txtQuantity.BorderColor = Color.Red;
                return;
            }
            txtQuantity.BorderColor = Color.LightGray;

            try
            {
                int.Parse(txtQuantity.Texts);
            }
            catch
            {
                MessageBox.Show("Quantity must be number");
                return;
            }

            if (txtMaxLimit.Texts == "" || txtMaxLimit.Texts == txtMaxLimit.Placeholder)
            {
                txtMaxLimit.BorderColor = Color.Red;
                return;
            }
            txtMaxLimit.BorderColor = Color.LightGray;

            int max = 0;

            try
            {
                max = int.Parse(txtMaxLimit.Texts);
            }
            catch
            {
                MessageBox.Show("Max Limit must be number");
                return;
            }

            if (txtMinLimit.Texts == "" || txtMinLimit.Texts == txtMinLimit.Placeholder)
            {
                txtMinLimit.BorderColor = Color.Red;
                return;
            }   
            txtMinLimit.BorderColor = Color.LightGray;

            int min = 0;
            try
            {
                min = int.Parse(txtMinLimit.Texts);
            }
            catch
            {
                MessageBox.Show("Min Limit must be number");
                return;
            }

            if (max < min)
            {
                MessageBox.Show("Max Limit must be greater than Min Limit");
                return;
            }

            if (txtReorderLevel.Texts == "" || txtReorderLevel.Texts == txtReorderLevel.Placeholder)
            {
                txtReorderLevel.BorderColor = Color.Red;
                return;
            }
            txtReorderLevel.BorderColor = Color.LightGray;

            int reorder = 0;
            try
            {
                reorder = int.Parse(txtReorderLevel.Texts);
            }
            catch
            {
                MessageBox.Show("Reorder Level must be number");
                return;
            }

            if (reorder < min)
            {
                MessageBox.Show("Reorder Level is smaller than Min Limit.\r\nAre you sure?" , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            };
            if (reorder > max)
            {
                MessageBox.Show("Reorder Level is greater than Max Limit.\r\nAre you sure?" , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            };

 
            /*
            {
                "supplier_GoodsID": "100000001",
                "quantity": 0,
                "maxLimit": 0,
                "minLimit": 0,
                "reorderLevel": 0
            }
            */
            var obj = new {
                quantity = txtQuantity.Texts,
                maxLimit = txtMaxLimit.Texts,
                minLimit = txtMinLimit.Texts,
                reorderLevel = txtReorderLevel.Texts,
                GoodsId = txtSupplierGoodsId.Texts
            };

            RestRequest ewq = new RestRequest("/api/inventory/sgs", Method.Post)
                                    .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"])
                                    .AddJsonBody(obj);

            var result = Utils.RestClientUtils.client.ExecuteAsync(ewq).GetAwaiter().GetResult();
            Console.WriteLine(result.Content);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Add new stock successfully");
                this.OnExit.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Add new stock failed: " + result.Content);
            }
        }


        public event Action OnExit;

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            string id = txtSupplierGoodsId.Texts.Trim();
            if (id == "" || id == txtSupplierGoodsId.Placeholder)
            {
                MessageBox.Show("Please enter a valid ID");
                return;
            }
            
            var res = goodsCon.GetById(id);

            try 
            {
                var obj = JObject.Parse(res.Content);
                if (obj["Status"].ToString() == "2")
                {
                    MessageBox.Show("This goods is no longer for sale");
                    return;
                }
                else if (obj["Status"].ToString() == "1")
                {
                    var isCon = MessageBox.Show("This goods is phasing out, Do you want to continue?" , "Warning", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
                    if (isCon == DialogResult.No)
                    {
                        return;
                    }
                }

                StaffNameTxt.Texts = obj["Name"].ToString();
                DeptTxt.Texts = obj["GTINCode"].ToString();

                ((RoundPanel)SizeGroup.Controls[(int)obj["Size"]]).BorderColor = Color.DimGray;
                // ((Label)SizeGroup.Controls[(int)obj["GoodsSize"]].Controls[0]).ForeColor = Color.DimGray;

                Console.WriteLine(obj.ToString());

            }catch(Exception ex)
            {
                MessageBox.Show("This supplier goods ID is not exist");
                return;
            }
            


        }
    }
}
