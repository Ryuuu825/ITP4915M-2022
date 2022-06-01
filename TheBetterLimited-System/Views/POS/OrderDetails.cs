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
    public partial class OrderDetails : Form
    {
        private UserController uc = new UserController();
        private StaffController sc = new StaffController();
        private PositionController pc = new PositionController();
        private DepartmentController dc = new DepartmentController();
        private RestResponse result = new RestResponse();
        private bool isUpload = false;
        private Bitmap icon = null;
        public string _oid { get; set; }
        private string _staffId;
        private string _staffName;
        private string _deptName;
        private string _positionName;
        private string _userName;
        private string _email;
        private string _status;
        private string _remark;

        public OrderDetails()
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

        public void InitOrderInfo()
        {
            
            //init Order info
            Console.WriteLine(_oid);
            result = uc.GetAccountById(_oid);
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
            }
            
            if (staff != null)
            {
                _staffName = staff["FirstName"].ToString() + " " + staff["LastName"].ToString();
                StaffNameTxt.Texts = _staffName;
                if (staff["Sex"].ToString().Equals("M"))
                {
                }
                else
                {
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
            }
        }

        private void GetAccount()
        {
            result = uc.GetAccountById(_oid);
            var user = JObject.Parse(result.Content);
            if (user != null)
            {

                _userName = user["userName"].ToString();
                _email = user["emailAddress"].ToString();
                _status = user["status"].ToString();
                _remark = user["remarks"].ToString();
                if (_status.Equals("N"))
                {
                }
                else
                {
                }
            }
        }

        private void UserNameTxt_Enter(object sender, EventArgs e)
        {
        }

        private void ValueUpdatedCheck()
        {
        }

        private void NormalStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void LockStatusRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StaffIDTxt.Focus();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
        }

        private void Email_Click(object sender, EventArgs e)
        {
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
            if (!StaffIDTxt.Texts.Equals(_staffId) && !StaffIDTxt.Texts.Equals(StaffIDTxt.Placeholder))
            {
                var obj = new
                {
                    attribute = "_StaffId",
                    value = StaffIDTxt.Texts
                };
                updatedData.Add(obj);
            }

            var tempStatus = "";
            if (!tempStatus.Equals(_status))
            {
                var obj = new
                {
                    attribute = "Status",
                    value = tempStatus
                };
                updatedData.Add(obj);
            }

            var json = JsonSerializer.Serialize(updatedData);
            try
            {
                Console.WriteLine(json);
                result = uc.UpdateAccount(updatedData, _oid);
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
    }
}
