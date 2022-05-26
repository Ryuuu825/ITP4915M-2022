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
    public partial class Usermanagement_Add : Form
    {
        private StaffController sc = new StaffController();
        private PositionController pc = new PositionController();
        private DepartmentController dc = new DepartmentController();
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public Usermanagement_Add()
        {
            InitializeComponent();
        }

        private void Usermanagement_Add_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIconPic.ClientRectangle);
            Region region = new Region(gp);
            UserIconPic.Region = region;
            gp.Dispose();
            region.Dispose();
        }

        private void UserIconPic_MouseHover(object sender, EventArgs e)
        {

            UserIconPic.Image = Properties.Resources.photo_upload;
        }

        private void UserIconPic_MouseLeave(object sender, EventArgs e)
        {
            if (isUpload)
            {
                UserIconPic.Image = icon;

            }
            else
            {
                UserIconPic.Image = Properties.Resources.avatar;
            }
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
    }
}
