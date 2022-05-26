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
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;

namespace TheBetterLimited.Views
{
    public partial class Usermanagement_Edit : Form
    {
        private UserController uc = new UserController();
        private StaffController sc = new StaffController();
        private PositionController pc = new PositionController();
        private DepartmentController dc = new DepartmentController();
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        private string _uid;
        private string _staffId;
        private string _staffName;
        private string _deptName;
        private string _positionName;
        private string _userName;
        private string _email;

        public Usermanagement_Edit()
        {
            InitializeComponent();
        }

        public Usermanagement_Edit(string uid)
        {
            InitializeComponent();
            _uid = uid;
            UserIdTxt.Texts = uid;
            UserIdTxt.ForeColor = Color.Black;
        }

        private void Usermanagement_Edit_Load(object sender, EventArgs e)
        {
            //init icon
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIconPic.ClientRectangle);
            Region region = new Region(gp);
            UserIconPic.Region = region;
            gp.Dispose();
            region.Dispose();
            Bitmap bitmap = uc.GetUserIcon();
            if (bitmap != null)
            {
                UserIconPic.Image = bitmap;
            }

            //init user info
            Console.WriteLine(_uid);
            result = uc.GetAccountById(_uid);
            Console.WriteLine(result.Content.ToString());
            var res = JObject.Parse(result.Content);
            if (res != null)
            {
                StaffIDTxt.Texts = res["_StaffId"].ToString();
                StaffIDTxt.ForeColor = Color.Black;
            }
            GetStaff();

            //init account info
            GetAccount();
        }

        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            StaffIDTxt.ForeColor = Color.Black;
            if (StaffIDTxt.Texts == "Please input staff ID")
            {
                StaffIDTxt.Texts = "";
            }
        }

        private void StaffIDTxt_Leave(object sender, EventArgs e)
        {
            if (StaffIDTxt.Texts == "")
            {
                StaffIDTxt.ForeColor = Color.LightGray;
                StaffIDTxt.Texts = "Please input staff ID";
            }
        }

        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            if (StaffIDTxt.Texts.Substring(0, 1) != "S")
            {
                StaffIDTxt.Focus();
                StaffIDTxt.Texts = _staffId;
                MessageBox.Show("Staff ID should start with \"S\"! e.g. S0001 ");
            }
            else if (StaffIDTxt.Texts.Length < 5)
            {
                MessageBox.Show("The length of Staff ID should be 5!");
            }
            else
            {
                GetStaff();
            }
        }

        private void GetStaff()
        {
            result = sc.GetStaffById(StaffIDTxt.Texts);
            var staff = JObject.Parse(result.Content);
            if (staff != null)
            {
                _staffName = staff["FirstName"].ToString() + " " + staff["LastName"].ToString();
                StaffNameTxt.Texts = _staffName;
                StaffNameTxt.ForeColor = Color.Black;
                if (staff["Sex"].ToString().Equals("M"))
                {
                    MaleGenderRadio.Checked = true;
                    FemaleGenderRadio.Checked = false;
                }
                else
                {
                    MaleGenderRadio.Checked = false;
                    FemaleGenderRadio.Checked = true;
                }
            }
            result = dc.GetDepartmentById(staff["_departmentId"].ToString());
            var department = JObject.Parse(result.Content);
            _deptName = department["Name"].ToString();
            if (department != null)
            {
                DeptTxt.Texts = department["Name"].ToString();
                DeptTxt.ForeColor = Color.Black;
            }

            result = pc.GetPositionById(staff["_positionId"].ToString());
            var position = JObject.Parse(result.Content);
            _positionName = position["jobTitle"].ToString();
            if (position != null)
            {
                PositionTxt.Texts = _positionName;
            }
        }

        private void GetAccount()
        {
            result = uc.GetAccountById(_uid);
            var user = JObject.Parse(result.Content);
            if (user != null)
            {

                _userName = user["userName"].ToString();
                UserNameTxt.Texts = _userName;
                UserNameTxt.ForeColor = Color.Black;
                _email = user["emailAddress"].ToString();
                EmainTxt.Texts = _email;
                EmainTxt.ForeColor = Color.Black;
                if (user["status"].ToString().Equals("N"))
                {
                    NormalStatusRadio.Checked = true;
                    LockStatusRadio.Checked = false;
                }
                else
                {
                    NormalStatusRadio.Checked = false;
                    LockStatusRadio.Checked = true;
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void UserNameTxt_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserNameTxt.Text))
            {

            }
        }
        private void UserNameTxt_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(UserNameTxt.Text))
            {
                UserNameTxt.Text = _userName;
                UserNameTxt.ForeColor = Color.LightGray;
            }
            else
            {
                UserNameTxt.ForeColor = Color.Black;
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
            StaffIDTxt.Focus();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            UserNameTxt.Focus();
        }

        private void Email_Click(object sender, EventArgs e)
        {
            EmainTxt.Focus();
        }
    }
}
