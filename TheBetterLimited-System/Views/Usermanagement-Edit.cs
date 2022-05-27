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
        private string uid;
        public Usermanagement_Edit()
        {
            InitializeComponent();
        }

        public Usermanagement_Edit(string uid)
        {
            InitializeComponent();
            this.uid = uid;
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
            Console.WriteLine(uid);
            result = uc.GetAccountById(uid);
            Console.WriteLine(result.Content.ToString());
            var res = JObject.Parse(result.Content);
            if (res != null)
            {
                StaffIDTxt.Texts = res["_StaffId"].ToString();
            }
            GetStaff();

            //init account info
            GetAccount();
        }

        private void InitializeUserInfoForm()
        {

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
            StaffIDTxt.ForeColor = Color.LightGray;
            if (StaffIDTxt.Texts == "")
            {
                StaffIDTxt.Texts = "Please input staff ID";
            }
        }

        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            if (StaffIDTxt.Texts.Substring(0, 1) != "S")
            {
                StaffIDTxt.Focus();
                StaffIDTxt.Texts = "";
                MessageBox.Show("Staff ID should start with \"S\"! e.g. S0001 ");
            }
            else if (StaffIDTxt.Texts.Length < 5)
            {
                StaffIDTxt.Focus();
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
                StaffNameTxt.Texts = staff["FirstName"].ToString() + " " + staff["LastName"].ToString();
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
            if (staff != null)
            {
                DeptTxt.Texts = department["Name"].ToString();
            }

            result = pc.GetPositionById(staff["_positionId"].ToString());
            var position = JObject.Parse(result.Content);
            if (staff != null)
            {
                PositionTxt.Texts = position["jobTitle"].ToString();
            }
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
        }

        private void UserIconPic_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                icon = new Bitmap(open.FileName);
                // display image in picture box  
                UserIconPic.Image = icon;
                // image file path  
                string imgName = open.FileName;
                isUpload = true;
            }
        }

        private void GetAccount()
        {
            result = uc.GetAccountById(uid);
            var user = JObject.Parse(result.Content);
            if (user != null)
            {
                UserNameTxt.Texts = user["userName"].ToString();
                EmainTxt.Texts = user["emailAddress"].ToString();
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
    }
}
