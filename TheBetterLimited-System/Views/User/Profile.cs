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

namespace TheBetterLimited.Views
{
    public partial class Profile : Form
    {
        private UserController uc = new UserController();
        private StaffController sc = new StaffController();
        private PositionController pc = new PositionController();
        private DepartmentController dc = new DepartmentController();
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public string _uid { get; set; }
        private string _staffId;
        private string _staffName;
        private string _deptName;
        private string _positionName;
        private string _userName;
        private string _email;
        private string _status;
        private string _remark;

        public Profile()
        {
            InitializeComponent();
        }

        public void SetData(string staffId)
        {
            _staffId = staffId;
            InitUserInfo();
        }

        public Profile(string staffId)
        {
            InitializeComponent();
        }

        private void InitUserInfo()
        {
            StaffIDTxt.Texts = _staffId;
            GetStaff();

            //init account info
            GetAccount();

            //init icon
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(UserIconPic.ClientRectangle);
            Region region = new Region(gp);
            UserIconPic.Region = region;
            gp.Dispose();
            region.Dispose();
            Bitmap bitmap = uc.GetUserIconById(_uid);
            if (bitmap != null)
            {
                UserIconPic.Image = bitmap;
            }
        }

        private void GetStaff()
        {
            result = sc.GetStaffById(_staffId);
            JObject staff = null;
            try
            {
                staff = JObject.Parse(result.Content);
            }catch (Exception ex)
            {
                MessageBox.Show("Not found the staff " + StaffIDTxt.Texts);
                return;
            }
            
            if (staff != null)
            {
                _uid = staff["_AccountId"].ToString();
                UserIdTxt.Texts = _uid;
                _staffName = staff["FirstName"].ToString() + " " + staff["LastName"].ToString();
                StaffNameTxt.Texts = _staffName;
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
                _email = user["emailAddress"].ToString();
                EmailTxt.Texts = _email;
                _status = user["status"].ToString();
            }
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
            EmailTxt.Focus();
        }

        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<object> updatedData = new List<object>();

            if (!UserNameTxt.Texts.Equals(_userName) && !UserNameTxt.Texts.Equals(UserNameTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "UserName",
                    value = UserNameTxt.Texts
                };
                updatedData.Add(obj);
            }

            if (!EmailTxt.Texts.Equals(_email) && !EmailTxt.Texts.Equals(EmailTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "EmailAddress",
                    value = EmailTxt.Texts
                };
                updatedData.Add(obj);
            }


            if(updatedData.Count == 0 && isUpload == false)
            {
                MessageBox.Show("You have not change any information!");
                return;
            }
            var sta = new
            {
                attribute = "Status",
                value = "N"
            };
            updatedData.Add(sta);
            var json = JsonSerializer.Serialize(updatedData);
            try
            {
                if (isUpload)
                {
                    result = uc.UploadUserIcon(
                        (byte[])(new ImageConverter().ConvertTo(this.UserIconPic.Image, typeof(byte[]))), StaffIDTxt.Texts
                    );
                }
                result = uc.UpdateAccount(updatedData, _uid);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("User information has been updated!\nPlease re-login the system.");
                    this.Close();
                    this.Dispose();
                    this.OnExit.Invoke();
                }else
                {
                    MessageBox.Show("Error"+result.Content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Sorry, user information update unsuccessfully");
            }
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

        private void UserIconPic_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    icon = new Bitmap(open.FileName);
                }catch (Exception ex)
                {
                    MessageBox.Show("Error when opening image" );
                    return;
                }
                // display image in picture box  
                UserIconPic.Image = icon;
                // image file path  
                string imgName = open.FileName;
                isUpload = true;
            }
        }
    }
}
