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
            StaffIDTxt.IsError = false;
            StaffIDTxt.ForeColor = Color.Black;
            StaffIDTxt.Texts = StaffIDTxt.Texts.Equals("Please input staff ID") ? "" : StaffIDTxt.Texts;
        }

        private void StaffIDTxt_Leave(object sender, EventArgs e)
        {
            StaffIDTxt.Texts = StaffIDTxt.Texts.Equals("") ? "Please input staff ID" : StaffIDTxt.Texts;
            StaffIDTxt.ForeColor = StaffIDTxt.Texts.Equals("Please input staff ID") ? Color.LightGray : Color.Black;
        }

        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            if (StaffIDTxt.Texts.Substring(0, 1).Equals("S") && StaffIDTxt.Texts.Substring(1, 4).All(char.IsDigit))
            {
                StaffIDTxt.IsError = false;
                GetStaff();
            }
            else
            {
                StaffIDTxt.Focus();
                StaffIDTxt.IsError = true;
                StaffIDTxt.Texts = "";
                MessageBox.Show("Staff ID should start with \"S\" and follow with 4 digits! \n e.g. S0001 ");
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
            UpdatePwdStrength();

            if (StaffIDTxt.Texts.Equals("Please input staff ID"))
            {
                StaffIDTxt.BorderColor = Color.Red;
                return;
            }

            StaffIDTxt.BorderColor = Color.LightGray;

            if (userNameTxt.Texts.Equals("Please input user name"))
            {
                userNameTxt.BorderColor = Color.Red;
                return;

            }
            userNameTxt.BorderColor = Color.LightGray;
            Console.WriteLine(TestPWStrength(this.pwdTxt.Texts) == 0 || !pwdTxt.Texts.Equals(pwdTxt2));
            Console.WriteLine(TestPWStrength(this.pwdTxt.Texts) == 0);
            Console.WriteLine(TestPWStrength(this.pwdTxt.Texts));
            Console.WriteLine(!pwdTxt.Texts.Equals(pwdTxt2.Texts));


            if (TestPWStrength(this.pwdTxt.Texts) == 0 || !pwdTxt.Texts.Equals(pwdTxt2.Texts))
            {
                pwdTxt.BorderColor = Color.Red;
                pwdTxt2.BorderColor = Color.Red;
                return;
            }


            if (pwdTxt.Texts.Equals("Please input password"))
            {
                pwdTxt.BorderColor = Color.Red;
                return;
            }

            pwdTxt.BorderColor = Color.LightGray;



            if (pwdTxt2.Texts.Equals("Please input password again"))
            {
                pwdTxt2.BorderColor = Color.Red;
                return;
            }
            pwdTxt2.BorderColor = Color.LightGray;


            if (emailTxt.Texts.Equals("Please input email address"))
            {
                emailTxt.BorderColor = Color.Red;
                return;
            }
            emailTxt.BorderColor = Color.LightGray;



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
                var response = user.AddAccount(
                    new
                    {
                        Id = "A" + Utils.RandomId.GenerateID(4),
                        userName = userNameTxt.Texts,
                        Password = pwdTxt.Texts,
                        EmailAddress = emailTxt.Texts,
                        Status = "N",
                        _StaffId = StaffIDTxt.Texts,
                        Remarks = "Created at" + DateTime.Now
                    });

                if (isUpload)
                {

                    var uploadIconRes = user.UploadUserIcon(
                        (byte[])(new ImageConverter().ConvertTo(this.UserIconPic.Image, typeof(byte[])))
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

        private void userNameTxt_Click(object sender, EventArgs e)
        {
            userNameTxt.IsError = false;

        }


        // leave
        private void userNameTxt__Leave(object sender, EventArgs e)
        {
            //userNameTxt.ForeColor = Color.LightGray;
            userNameTxt.Texts = userNameTxt.Texts.Equals("") ? "Please input user name" : userNameTxt.Texts;
            userNameTxt.ForeColor = userNameTxt.Texts.Equals("Please input user name") ? Color.LightGray : Color.Black;
            pwdTxt.ReadOnly = userNameTxt.Texts.Equals("Please input user name") ? true : false;
        }
        private void pwdTxt_Enter(object sender, EventArgs e)
        {
            pwdTxt.IsError = false;
            pwdTxt2.IsError = false;
            pwdTxt.ForeColor = Color.Black;
            pwdTxt.Texts = pwdTxt.Texts.Equals("Please input password") ? "" : pwdTxt.Texts;
            pwdTxt.PasswordChar = true;
        }

        private void pwdTxt_Leave(object sender, EventArgs e)
        {
            pwdTxt.Texts = pwdTxt.Texts.Equals("") ? "Please input password" : pwdTxt.Texts;
            pwdTxt.PasswordChar = pwdTxt.Texts.Equals("Please input password") ? false : true;
            pwdTxt.ForeColor = pwdTxt.Texts.Equals("Please input password") ? Color.LightGray : Color.Black;
        }

        private void pwdTxt2_Leave(object sender, EventArgs e)
        {
            pwdTxt2.Texts = pwdTxt2.Texts.Equals("") ? "Please input password again" : pwdTxt2.Texts;
            pwdTxt2.PasswordChar = pwdTxt2.Texts.Equals("Please input password again") ? false : true;
            pwdTxt2.ForeColor = pwdTxt2.Texts.Equals("Please input password again") ? Color.LightGray : Color.Black;
            DoubleCheckCorrect.Visible = pwdTxt2.Texts.Equals(pwdTxt.Texts) ? true : false;
            pwdTxt2.IsError = pwdTxt2.Texts.Equals(pwdTxt.Texts) 
                            && !pwdTxt2.Texts.Equals("Please input password again") ? 
                            false : true;
        }

        private void pwdTxt2__TextChanged(object sender, EventArgs e)
        {
            UpdatePwdStrength();
        }

        private void UpdatePwdStrength()
        {
            DoubleCheckCorrect.Visible = false;
            PwdCorrect.Visible = false;
            pwdTxt2.ReadOnly = true;
            if (pwdTxt.Texts.Equals("Please input password"))
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
            pwdTxt2.ForeColor = Color.Black;
            pwdTxt2.Texts = pwdTxt2.Texts.Equals("Please input password again") ? "" : pwdTxt2.Texts;
            pwdTxt2.PasswordChar = true;
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

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            emailTxt.ForeColor = Color.Black;
            emailTxt.Texts = emailTxt.Texts.Equals("Please input email address") ? "" : emailTxt.Texts;
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            emailTxt.ForeColor = Color.LightGray;
            emailTxt.Texts = emailTxt.Texts.Equals("") ? "Please input email address" : emailTxt.Texts;
        }

        private void StaffIDTxt_Click(object sender, EventArgs e)
        {
            StaffIDTxt.IsError = false;
        }

        private void userNameTxt_Enter(object sender, EventArgs e)
        {
            userNameTxt.IsError = false;
            userNameTxt.ForeColor = Color.Black;
            userNameTxt.Texts = userNameTxt.Texts.Equals("Please input user name") ? "" : userNameTxt.Texts;
        }

        private void CheckStep()
        {
            if (pwdTxt2.ReadOnly == true)
            {
                if (pwdTxt.ReadOnly == true)
                {
                    userNameTxt.Focus();
                    userNameTxt.IsError = true;
                    return;
                }
                pwdTxt.Focus();
                pwdTxt.IsError = true;
            }
        }

        private void pwdTxt_Click(object sender, EventArgs e)
        {
            pwdTxt.IsError = false;
        }

        private void pwdTxt2_Click(object sender, EventArgs e)
        {
            pwdTxt2.IsError = false;
        }

    }
}
