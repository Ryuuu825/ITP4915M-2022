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
    public partial class GoodsDetails : Form
    {
        private GoodsController uc = new GoodsController();
        private ControllerBase cbSupplierGoodsStock = new ControllerBase("Supplier_Goods_Stock");
        private ControllerBase cbSupplierGoods = new ControllerBase("Supplier_Goods");
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public string goodsId { get; set; }
        private OrderItem oi = new OrderItem();

        public GoodsDetails()
        {
            InitializeComponent();
        }

        private void Usermanagement_Edit_Load(object sender, EventArgs e)
        {
            //InitUserInfo();
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

        public void InitUserInfo()
        {
           // LocTxt.Texts = GoodsInfo.GetType().GetProperty("ID").GetValue(GoodsInfo).ToString();
            //init icon
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIconPic.ClientRectangle);
            Region region = new Region(gp);
            UserIconPic.Region = region;
            gp.Dispose();
            region.Dispose();
            //Bitmap bitmap = uc.GetUserIconById(_uid);
            /*if (bitmap != null)
            {
                UserIconPic.Image = bitmap;
            }*/

            //init user info
            //Console.WriteLine(_uid);
            //result = uc.GetAccountById(_uid);
            Console.WriteLine(result.Content.ToString());
            var res = JObject.Parse(result.Content);
            //_staffId = res["_StaffId"].ToString();
            if (res != null)
            {
                //GoodsIDTxt.Texts = _staffId;
            }
            GetStaff();

            //init account info
            GetAccount();
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
                CatalogueTxt.Texts = _staffName;
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
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<object> updatedData = new List<object>();
            /*if (!GoodsIDTxt.Texts.Equals(_staffId) && !GoodsIDTxt.Texts.Equals(GoodsIDTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "_StaffId",
                    value = GoodsIDTxt.Texts
                };
                updatedData.Add(obj);
            }

            if (!StockTxt.Texts.Equals(_userName) && !StockTxt.Texts.Equals(StockTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "UserName",
                    value = StockTxt.Texts
                };
                updatedData.Add(obj);
            }

            if (!StockLevelTxt.Texts.Equals(_email) && !StockLevelTxt.Texts.Equals(StockLevelTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "EmailAddress",
                    value = StockLevelTxt.Texts
                };
                updatedData.Add(obj);
            }

            var tempStatus = "";
            if (NormalStatusRadio.Checked == true) tempStatus = "N";
            if (LockStatusRadio.Checked == true) tempStatus = "L";
            if (!tempStatus.Equals(_status))
            {
                var obj = new
                {
                    attribute = "Status",
                    value = tempStatus
                };
                updatedData.Add(obj);
            }

            if (!DescriptionTxt.Texts.Equals(_remark) && !DescriptionTxt.Texts.Equals(DescriptionTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "Remarks",
                    value = DescriptionTxt.Texts
                };
                updatedData.Add(obj);
            }else if (DescriptionTxt.Texts.Equals(DescriptionTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "Remarks",
                    value = "update at " + DateTime.Now
                };
                updatedData.Add(obj);
            }

            var json = JsonSerializer.Serialize(updatedData);
            try
            {
                Console.WriteLine(json);
                result = uc.UpdateAccount(updatedData, _uid);
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
            }*/
        }

        private void GoodsIDTxt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
