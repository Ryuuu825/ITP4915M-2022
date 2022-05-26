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



            if (pwdTxt2.Texts.Equals("Please input password again") )
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
                        (byte[]) (new ImageConverter().ConvertTo(this.UserIconPic.Image, typeof(byte[])))
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
            catch (Exception exception )
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

        private void userNameTxt__TextChanged(object sender, EventArgs e)
        {
            userNameTxt.ForeColor = Color.Black;
            userNameTxt.Texts = userNameTxt.Texts.Equals("Please input user name") ? "" : userNameTxt.Texts;
        }

        private void pwdTxt__TextChanged(object sender, EventArgs e)
        {
            pwdTxt.ForeColor = Color.Black;
            pwdTxt.Texts = pwdTxt.Texts.Equals("Please input password") ? "" : pwdTxt.Texts;

        }

        private void customizeTextbox1__TextChanged(object sender, EventArgs e)
        {
            emailTxt.ForeColor = Color.Black;
            emailTxt.Texts = emailTxt.Texts.Equals("Please input email address") ? "" : emailTxt.Texts;
        }

        private void pwdTxt2__TextChanged(object sender, EventArgs e)
        {
            pwdTxt2.ForeColor = Color.Black;
            pwdTxt2.Texts = pwdTxt2.Texts.Equals("Please input password again") ? "" : pwdTxt2.Texts;
        }


        // leave
        private void userNameTxt__Leave(object sender, EventArgs e)
        {
            userNameTxt.ForeColor = Color.LightGray;
            userNameTxt.Texts = userNameTxt.Texts.Equals("") ? "Please input user name" : userNameTxt.Texts;
        }

        private void pwdTxt__Leave(object sender, EventArgs e)
        {
            pwdTxt.ForeColor = Color.LightGray;
            pwdTxt.Texts = pwdTxt.Texts.Equals("") ? "Please input password" : pwdTxt.Texts;

        }

        private void customizeTextbox1__Leave(object sender, EventArgs e)
        {
            emailTxt.ForeColor = Color.LightGray;
            emailTxt.Texts = emailTxt.Texts.Equals("") ? "Please input email address" : emailTxt.Texts;
        }

        private void pwdTxt2__Leave(object sender, EventArgs e)
        {
            pwdTxt2.ForeColor = Color.LightGray;
            pwdTxt2.Texts = pwdTxt2.Texts.Equals("") ? "Please input password again" : pwdTxt2.Texts;
        }

        private void pwdTxt2__TextChanged_1(object sender, EventArgs e)
        {
            UpdatePwdStrength();
        }

        private void UpdatePwdStrength()
        {
            if (pwdTxt.Texts.Equals(pwdTxt.Texts))
            {
                this.pwdTxt2.BorderColor = Color.LightGray;
            }
            else
            {
                this.pwdTxt2.BorderColor = Color.Red;
            }

            if (this.pwdTxt.Texts.Equals("Please input password"))
            {
                return;
            }


            int mark = TestPWStrength(this.pwdTxt.Texts);

            var parentSize = PwdStrengthBar.Size;

            if (mark == 0) // 219, 30, 72
            {
                var len = this.pwdTxt.Texts.Length;

                PwStrength.Size = new Size
                {
                    Width = len == 0 ? 0 : (  (int)(parentSize.Width * 0.3) / (8%len + 8)),
                    Height = parentSize.Height
                };
                PwStrength.BackColor = Color.FromArgb(219, 30, 72);
            }
            else if (mark >= 1 && mark <= 4) // Gold // Fair
            {
                PwStrength.Size = new Size
                {
                    Width = ((int)(parentSize.Width * 0.4) + (int)(parentSize.Width * 0.1 * mark)),
                    Height = parentSize.Height
                };
                PwStrength.BackColor = Color.Gold;

            }
            else // 60, 183, 84
            {
                PwStrength.Size = new Size
                {
                    Width = ((int)(parentSize.Width * 0.4) + (int)(parentSize.Width * 0.1 * mark)),
                    Height = parentSize.Height
                };
                PwStrength.BackColor = Color.FromArgb(60, 183, 84);
            }
        }

        public event Action OnExit;
        

        private short TestPWStrength(string pwd)
        {

            short mark = 0;
            if (pwd.Length <= 7)
                return 0;

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
                mark++;
            }

            // check username contain
            if (!pwd.Contains(this.userNameTxt.Texts))
            {
                mark++;
            }

            return mark;

        }

        private void pwdTxt__TextChanged_1(object sender, EventArgs e)
        {
            UpdatePwdStrength();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }
    }
}
