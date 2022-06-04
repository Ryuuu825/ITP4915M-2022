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
    public partial class Supplier_Edit : Form
    {
        private StaffController sc = new StaffController();
        private PositionController pc = new PositionController();
        private DepartmentController dc = new DepartmentController();
        private RestResponse result = new RestResponse();
        private UserController user = new UserController();
        private bool isUpload = false;
        private Bitmap icon = Properties.Resources._default;

        public Supplier_Edit()
        {
            InitializeComponent();
        }

        private void UserIconPic_MouseHover(object sender, EventArgs e)
        {

            //GoodsPic.Image = Properties.Resources.photo_upload;
        }

        private void UserIconPic_MouseLeave(object sender, EventArgs e)
        {
            //GoodsPic.Image = icon;
        }

        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            /*StaffIDTxt.IsError = false;*/
        }

        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            if (txtSupplierId.Texts.StartsWith("S") && txtSupplierId.Texts.Length == txtSupplierId.MaxLength)
            {
                if (txtSupplierId.Texts.Substring(1, 4).All(char.IsDigit))
                {
                    /*StaffIDTxt.IsError = false;*/
                    GetStaff();
                }
            }
            else
            {
                txtSupplierId.Focus();
                txtSupplierId.Texts = "";
                txtSupplierId.IsError = true;
                MessageBox.Show("Staff ID should start with \"S\" and follow with 4 digits! \n e.g. S0001 ");
            }
        }

        private void GetStaff()
        {
            result = sc.GetStaffById(txtSupplierId.Texts);
            JObject staff = null;
            try
            {
                staff = JObject.Parse(result.Content);
            }catch (Exception ex)
            {
                MessageBox.Show("Not found the staff by " + txtSupplierId.Texts);
                return;
            }
            if (staff != null)
            {
                if (staff["Sex"].ToString().Equals("M"))
                {
                }
                else
                {
                }
            }
            result = dc.GetDepartmentById(staff["_departmentId"].ToString());
            var department = JObject.Parse(result.Content);
            if (department != null)
            {
                txtPhone.Texts = department["Name"].ToString();
            }

            result = pc.GetPositionById(staff["_positionId"].ToString());
            var position = JObject.Parse(result.Content);
            if (position != null)
            {
                //txtDescription.Texts = position["jobTitle"].ToString();
            }
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            

            if (txtSupplierId.Texts.Equals(txtSupplierId.Placeholder))
            {
                txtSupplierId.IsError = true;
                return;
            }
            Console.WriteLine(txtSupplierId.Texts);

            txtSupplierId.IsError = false;

            



            /*
             * {
                   "Id": null,
                   "UserName": null,
                   "Password": null,
                   "EmailAddress": null,
                   "Status": null,
                   "_StaffId": null,
                   "Remarks": null
               }
             */
            try
            {
                string id = "A" + new Random().Next(10000);
                var response = user.AddAccount(
                    new
                    {
                        Id = id,
                        Status = "N",
                        _StaffId = txtSupplierId.Texts,
                        Remarks = "Created at" + DateTime.Now
                    }) ;

                if (isUpload)
                {
                    //var uploadIconRes = user.UploadUserIcon(
                        //(byte[])(new ImageConverter().ConvertTo(this.GoodsPic.Image, typeof(byte[]))), txtSupplierId.Texts
                    //);
                }
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.Close();
                    this.Dispose();
                    this.OnExit.Invoke();
                }
                else
                {
                    MessageBox.Show(
                        response.Content, "Fail", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UserIconPic_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                icon = new Bitmap(open.FileName);
                // display image in picture box  
                //GoodsPic.Image = icon;
                // image file path  
                string imgName = open.FileName;
                isUpload = true;
            }
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
            txtSupplierId.Focus();
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
            txtSupplierId.IsError = false;
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
            txtSupplierId.IsError = false;
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
            //Region region = new Region(gp);
            //GoodsPic.Region = region;
            //Pen pen = new Pen(Color.White, 10);
            //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.DrawPath(pen, gp);
            //gp.Dispose();
            //region.Dispose();
            //pen.Dispose();
        }
    }
}
