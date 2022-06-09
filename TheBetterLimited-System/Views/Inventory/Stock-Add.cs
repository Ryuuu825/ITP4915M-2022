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
                supplier_GoodsID = txtSupplierGoodsId.Texts
            };

            RestRequest ewq = new RestRequest("/api/inventory/sgs", Method.Post)
                                    .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"])
                                    .AddJsonBody(obj);

            var result = Utils.RestClientUtils.client.ExecuteAsync(ewq).GetAwaiter().GetResult();
            Console.WriteLine(result.Content);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Add new stock successfully");
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
            this.OnExit.Invoke();
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
