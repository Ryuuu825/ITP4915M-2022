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
    public partial class Usermanagement_Add : Form
    {
        private StaffController sc = new StaffController();
        private PositionController pc = new PositionController();
        private DepartmentController dc = new DepartmentController();
        private RestResponse result = new RestResponse();
        private UserController user = new UserController();
        private bool isUpload = false;
        private Bitmap icon = Properties.Resources._default;

        public Usermanagement_Add()
        {
            InitializeComponent();
        }

        private void UserIconPic_MouseHover(object sender, EventArgs e)
        {

            UserIconPic.Image = Properties.Resources.photo_upload;
        }

        private void UserIconPic_MouseLeave(object sender, EventArgs e)
        {
            UserIconPic.Image = icon;
        }

        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            /*StaffIDTxt.IsError = false;*/
        }

        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            if (StaffIDTxt.Texts.StartsWith("S") && StaffIDTxt.Texts.Length == StaffIDTxt.MaxLength)
            {
                if (StaffIDTxt.Texts.Substring(1, 4).All(char.IsDigit))
                {
                    /*StaffIDTxt.IsError = false;*/
                    GetStaff();
                }
            }
            else
            {
                StaffIDTxt.Focus();
                StaffIDTxt.Texts = "";
                StaffIDTxt.IsError = true;
                MessageBox.Show("Staff ID should start with \"S\" and follow with 4 digits! \n e.g. S0001 ");
            }
        }

        private void GetStaff()
        {
            result = sc.GetStaffById(StaffIDTxt.Texts);
            JObject staff = null;
            try
            {
                staff = JObject.Parse(result.Content);
            }catch (Exception ex)
            {
                MessageBox.Show("Not found the staff by " + StaffIDTxt.Texts);
                return;
            }
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
            if (department != null)
            {
                DeptTxt.Texts = department["Name"].ToString();
            }

            result = pc.GetPositionById(staff["_positionId"].ToString());
            var position = JObject.Parse(result.Content);
            if (position != null)
            {
                PositionTxt.Texts = position["jobTitle"].ToString();
            }
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            UpdatePwdStrength();

            if (StaffIDTxt.Texts.Equals(StaffIDTxt.Placeholder))
            {
                StaffIDTxt.IsError = true;
                return;
            }
            Console.WriteLine(StaffIDTxt.Texts);

            StaffIDTxt.IsError = false;

            if (userNameTxt.Texts.Equals(userNameTxt.Placeholder))
            {
                userNameTxt.IsError = true;
                return;
            }
            userNameTxt.IsError = false;
            Console.WriteLine(userNameTxt.Texts);
            Console.WriteLine(TestPWStrength(this.pwdTxt.Texts) == 0 || !pwdTxt.Texts.Equals(pwdTxt2));
            Console.WriteLine(TestPWStrength(this.pwdTxt.Texts) == 0);
            Console.WriteLine(TestPWStrength(this.pwdTxt.Texts));
            Console.WriteLine(!pwdTxt.Texts.Equals(pwdTxt2.Texts));

            if (TestPWStrength(this.pwdTxt.Texts) <= 3 || !pwdTxt.Texts.Equals(pwdTxt2.Texts))
            {
                pwdTxt.IsError = true;
                MessageBox.Show("Password strength is not enough! \n Password should consist of at least one upper and lower case letters with wu");
                return;
            }
            pwdTxt.IsError = false;

            if (pwdTxt.Texts.Equals(pwdTxt.Placeholder))
            {
                pwdTxt.IsError = true;
                return;
            }

            pwdTxt.IsError = false;



            if (pwdTxt2.Texts.Equals(pwdTxt2.Placeholder))
            {
                pwdTxt2.IsError = true;
                return;
            }
            pwdTxt2.IsError = false;


            if (emailTxt.Texts.Equals(emailTxt.Placeholder))
            {
                emailTxt.IsError = true;
                return;
            }
            emailTxt.IsError = false;



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
                        userName = userNameTxt.Texts,
                        Password = pwdTxt.Texts,
                        EmailAddress = emailTxt.Texts,
                        Status = "N",
                        _StaffId = StaffIDTxt.Texts,
                        Remarks = "Created at" + DateTime.Now
                    }) ;

                if (isUpload)
                {
                    var uploadIconRes = user.UploadUserIcon(
                        (byte[])(new ImageConverter().ConvertTo(this.UserIconPic.Image, typeof(byte[]))), StaffIDTxt.Texts
                    );
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
                UserIconPic.Image = icon;
                // image file path  
                string imgName = open.FileName;
                isUpload = true;
            }
        }

        private void userNameTxt_Click(object sender, EventArgs e)
        {
            userNameTxt.IsError = false;
        }

        // leave
        private void pwdTxt_Enter(object sender, EventArgs e)
        {
            pwdTxt.IsError = false;
        }

        private void pwdTxt2_Leave(object sender, EventArgs e)
        {
            DoubleCheckCorrect.Visible = pwdTxt2.Texts.Equals(pwdTxt.Texts) ? true : false;
        }

        private void UpdatePwdStrength()
        {
            DoubleCheckCorrect.Visible = false;
            PwdCorrect.Visible = false;
            if (pwdTxt.Texts.Equals(pwdTxt.Placeholder))
            {
                return;
            }

            int mark = TestPWStrength(this.pwdTxt.Texts);

            if (mark == 0)
            {
                StrengthCircle1.BackColor = Color.LightGray;
                StrengthCircle2.BackColor = Color.LightGray;
                StrengthCircle3.BackColor = Color.LightGray;
            }
            else if (mark < 2) // 219, 30, 72
            {
                StrengthCircle1.BackColor = Color.FromArgb(219, 30, 72);
                StrengthCircle2.BackColor = Color.LightGray;
                StrengthCircle3.BackColor = Color.LightGray;
            }
            else if (mark <= 3) // Gold // Fair
            {
                StrengthCircle1.BackColor = Color.Gold;
                StrengthCircle2.BackColor = Color.Gold;
                StrengthCircle3.BackColor = Color.LightGray;
            }
            else // 60, 183, 84
            {
                StrengthCircle1.BackColor = Color.FromArgb(60, 183, 84);
                StrengthCircle2.BackColor = Color.FromArgb(60, 183, 84);
                StrengthCircle3.BackColor = Color.FromArgb(60, 183, 84);
                PwdCorrect.Visible = true;
                pwdTxt2.ReadOnly = false;
            }
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

            // check username contain
            if (!pwd.Contains(this.userNameTxt.Texts))
            {
                mark++;
            }

            return mark;

        }

        private void pwdTxt__TextChanged(object sender, EventArgs e)
        {
            pwdTxt.IsError = false;
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
            pwdTxt2.IsError = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StaffIDTxt.Focus();
        }

        private void userName_Click(object sender, EventArgs e)
        {
            userNameTxt.Focus();
        }

        private void password_Click(object sender, EventArgs e)
        {
            pwdTxt.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pwdTxt2.Focus();
        }

        private void Email_Click(object sender, EventArgs e)
        {
            emailTxt.Focus();
        }

        private void StaffIDTxt_Click(object sender, EventArgs e)
        {
            StaffIDTxt.IsError = false;
        }

        private void userNameTxt_Enter(object sender, EventArgs e)
        {
            userNameTxt.IsError = false;
        }

        private void pwdTxt_Click(object sender, EventArgs e)
        {
            pwdTxt.IsError = false;
        }

        private void pwdTxt2_Click(object sender, EventArgs e)
        {
            pwdTxt2.IsError = false;
        }

        private void StaffIDTxt__TextChanged(object sender, EventArgs e)
        {
            StaffIDTxt.IsError = false;
        }

        private void StaffIDTxt_Leave(object sender, EventArgs e)
        {

        }

        private void showPwd_Click(object sender, EventArgs e)
        {
            if (pwdTxt2.PasswordChar)
            {
                showPwd.BackgroundImage = Properties.Resources.eye_crossed;
            }
            else
            {
                showPwd.BackgroundImage = Properties.Resources.eye;
            }
            pwdTxt.PasswordChar = pwdTxt.PasswordChar == true ? false : true;
            pwdTxt2.PasswordChar = pwdTxt2.PasswordChar == true ? false : true;
        }

        private void UserIconPic_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIconPic.ClientRectangle);
            Region region = new Region(gp);
            UserIconPic.Region = region;
            Pen pen = new Pen(Color.White, 10);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, gp);
            gp.Dispose();
            region.Dispose();
            pen.Dispose();
        }
    }
}
