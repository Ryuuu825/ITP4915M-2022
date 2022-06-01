using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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
    public partial class Receipt : Form
    {
        private GoodsController uc = new GoodsController();
        private ControllerBase cbSupplierGoodsStock = new ControllerBase("Supplier_Goods_Stock");
        private ControllerBase cbSupplierGoods = new ControllerBase("Supplier_Goods");
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public JObject goodsData { get; set; }
        private OrderItem oi = new OrderItem();

        public Receipt()
        {
            InitializeComponent();
        }

        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            if (GoodsIDTxt.Texts.Substring(0, 1) != "S")
            {
                GoodsIDTxt.Focus();
                MessageBox.Show("Staff ID should start with \"S\"! e.g. S0001 ");
            }
            else if (GoodsIDTxt.Texts.Length < 5)
            {
                MessageBox.Show("The length of Staff ID should be 5!");
            }
            else
            {
                GetStaff();
            }
        }

        public void InitInfo()
        {
            // LocTxt.Texts = GoodsInfo.GetType().GetProperty("ID").GetValue(GoodsInfo).ToString();
            //init icon
            JToken token = goodsData["Photo"];
            if (token.Type != JTokenType.Null)
            {
                byte[] byteBuffer = Convert.FromBase64String(goodsData["Photo"].ToString());
                MemoryStream memoryStream = new MemoryStream(byteBuffer);
                IconPic.Image = new Bitmap(memoryStream);
                memoryStream.Close(); 
            }
            else
            {
                IconPic.Image = Properties.Resources.product;
            }
            
            GoodsIDTxt.Texts = goodsData["Id"].ToString();
            GTINCodeTxt.Texts = goodsData["GTINCode"].ToString();
            DescriptionTxt.Texts = goodsData["Description"].ToString();
            PriceTxt.Texts = String.Format("{0:C2}",goodsData["Price"]); 
            Info.Text = goodsData["Name"].ToString();

            //cbSupplierGoods


            //var res = JObject.Parse(result.Content);
            //_staffId = res["_StaffId"].ToString();
            /*if (res != null)
            {
                GoodsIDTxt.Texts = _staffId;
            }*/
            //GetStaff();

            //init account info
            //GetAccount();
        }

        private void GetStaff()
        {
            //result = sc.GetStaffById(GoodsIDTxt.Texts);
            JObject staff = null;
            try
            {
                staff = JObject.Parse(result.Content);
            }catch (Exception ex)
            {
                MessageBox.Show("Not found the staff " + GoodsIDTxt.Texts);
            }
            
            if (staff != null)
            {
                //_staffName = staff["FirstName"].ToString() + " " + staff["LastName"].ToString();
                //CatalogueTxt.Texts = _staffName;
                if (staff["Sex"].ToString().Equals("M"))
                {
                }
                else
                {
                }
            }
            //result = dc.GetDepartmentById(staff["_departmentId"].ToString());
            var department = JObject.Parse(result.Content);
            //_deptName = department["Name"].ToString();
            if (department != null)
            {
                GTINCodeTxt.Texts = department["Name"].ToString();
            }

            //result = pc.GetPositionById(staff["_positionId"].ToString());
            var position = JObject.Parse(result.Content);
            //_positionName = position["jobTitle"].ToString();
            if (position != null)
            {
                //PriceTxt.Texts = _positionName;
            }
        }

        private void GetAccount()
        {
            //result = uc.GetAccountById(_uid);
            var user = JObject.Parse(result.Content);
            if (user != null)
            {

                //_userName = user["userName"].ToString();
                //StockTxt.Texts = _userName;
                //_email = user["emailAddress"].ToString();
                //StockLevelTxt.Texts = _email;
                // = user["status"].ToString();
                //_remark = user["remarks"].ToString();
                //DescriptionTxt.Texts = _remark;
                //if (_status.Equals("N"))
                /*{
                    NormalStatusRadio.Checked = true;
                    LockStatusRadio.Checked = false;
                }
                else
                {
                    NormalStatusRadio.Checked = false;
                    LockStatusRadio.Checked = true;
                }*/
            }
        }

        private void UserNameTxt_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(StockTxt.Text))
            {

            }
        }

        private void ValueUpdatedCheck()
        {
        }

        private void NormalStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            NormalStatusRadio.Checked = true;
            LockStatusRadio.Checked = false;
        }

        private void LockStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            NormalStatusRadio.Checked = false;
            LockStatusRadio.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GoodsIDTxt.Focus();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            StockTxt.Focus();
        }

        private void Email_Click(object sender, EventArgs e)
        {
            StockLevelTxt.Focus();
        }

        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<object> updatedData = new List<object>();
            
        }

        private void GoodsDetails_Load(object sender, EventArgs e)
        {
            InitInfo();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
