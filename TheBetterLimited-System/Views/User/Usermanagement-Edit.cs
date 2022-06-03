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
    public partial class Usermanagement_Edit : Form
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

        public Usermanagement_Edit()
        {
            InitializeComponent();
        }

        private void Usermanagement_Edit_Load(object sender, EventArgs e)
        {
            InitUserInfo();
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

        public void InitUserInfo()
        {
            UserIdTxt.Texts = _uid;
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

            //init user info
            Console.WriteLine(_uid);
            result = uc.GetAccountById(_uid);
            Console.WriteLine(result.Content.ToString());
            var res = JObject.Parse(result.Content);
            _staffId = res["_StaffId"].ToString();
            if (res != null)
            {
                StaffIDTxt.Texts = _staffId;
            }
            GetStaff();

            //init account info
            GetAccount();
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
                MessageBox.Show("Not found the staff " + StaffIDTxt.Texts);
                return;
            }
            
            if (staff != null)
            {
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
                _remark = user["remarks"].ToString();
                RemarkTxt.Texts = _remark;
                if (_status.Equals("N"))
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

        private void UserNameTxt_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserNameTxt.Text))
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
            if (!StaffIDTxt.Texts.Equals(_staffId) && !StaffIDTxt.Texts.Equals(StaffIDTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "_StaffId",
                    value = StaffIDTxt.Texts
                };
                updatedData.Add(obj);
            }

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

            if (!RemarkTxt.Texts.Equals(_remark) && !RemarkTxt.Texts.Equals(RemarkTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "Remarks",
                    value = RemarkTxt.Texts
                };
                updatedData.Add(obj);
            }else if (RemarkTxt.Texts.Equals(RemarkTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "Remarks",
                    value = "update at " + DateTime.Now
                };
                updatedData.Add(obj);
            }

            if(updatedData.Count == 0)
            {
                MessageBox.Show("You have not change any information!");
                return;
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
    }
}
