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


        public Stock_Edit()
        {
            InitializeComponent();
        }

        public Stock_Edit(string StockId)
        {
            Console.WriteLine("New ing form" + StockId);
            RestRequest req = new RestRequest("/api/inventory/sgs/" + StockId, Method.Get);
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

            Console.WriteLine("LocationId: " + LocationId);
            Console.WriteLine("SupplierGoodsId: " + SupplierGoodsId);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("MaxLimit: " + MaxLimit);
            Console.WriteLine("MinLimit: " + MinLimit);
            Console.WriteLine("ReorderLevel: " + ReorderLevel);


            txtId.Texts = ID;
            txtLocId.Texts = LocationId;
            txtSupplierGoodsId.Texts = SupplierGoodsId;
            txtQuantity.Texts = Quantity;
            txtMaxLimit.Texts = MaxLimit.ToString();
            txtMinLimit.Texts = MinLimit.ToString();
            txtReorderLevel.Texts = ReorderLevel;
        }


        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            /*StaffIDTxt.IsError = false;*/
        }

       
        private void GetStaff()
        {
           
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
        }


        private void userNameTxt_Click(object sender, EventArgs e)
        {
        }

        // leave
        private void pwdTxt_Enter(object sender, EventArgs e)
        {
        }

        private void pwdTxt2_Leave(object sender, EventArgs e)
        {
        }

        private void UpdatePwdStrength()
        {

        }

        public event Action OnExit;


        private short TestPWStrength(string pwd)
        {
            short mark = 0;
            if (pwd.Length == 0)
            {
                return mark;
            }


            if (pwd.Length <= 7)
            {
                return ++mark;
            }

            // check number
            if (pwd.Any(char.IsDigit))
            {
                mark++;
            }

            // check special char
            if (pwd.Any(char.IsPunctuation))
            {
                mark++;
            }

            // check upper case
            if (pwd.Any(char.IsUpper))
            {
                mark++;
            }

            // check lower case
            if (pwd.Any(char.IsLower))
            {
                mark++;
            }

            // check any repeat
            if (pwd.All(c => pwd.IndexOf(c) == pwd.LastIndexOf(c)))
            {
                mark--;
            }


            return mark;

        }

        private void pwdTxt__TextChanged(object sender, EventArgs e)
        {
            UpdatePwdStrength();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        private void pwdTxt2_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void userName_Click(object sender, EventArgs e)
        {
        }

        private void password_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Email_Click(object sender, EventArgs e)
        {
        }

        private void StaffIDTxt_Click(object sender, EventArgs e)
        {
            txtId.IsError = false;
        }

        private void userNameTxt_Enter(object sender, EventArgs e)
        {
        }

        private void pwdTxt_Click(object sender, EventArgs e)
        {
        }

        private void pwdTxt2_Click(object sender, EventArgs e)
        {
        }

        private void StaffIDTxt__TextChanged(object sender, EventArgs e)
        {
            txtId.IsError = false;
        }

        private void StaffIDTxt_Leave(object sender, EventArgs e)
        {

        }

        private void showPwd_Click(object sender, EventArgs e)
        {

        }

        private void UserIconPic_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(GoodsPic.ClientRectangle);
            Region region = new Region(gp);
            //GoodsPic.Region = region;
            Pen pen = new Pen(Color.White, 10);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, gp);
            gp.Dispose();
            region.Dispose();
            pen.Dispose();
        }
    }
}
