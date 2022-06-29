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
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;
using TheBetterLimited.Utils;

namespace TheBetterLimited.Views
{
    public partial class Staff_Edit : Form
    {
        private RestResponse result = new RestResponse();
        private ControllerBase cbStaff = new ControllerBase("Staff");
        private List<object> updateValue = new List<object>();
        private JObject staff = new JObject();
        private string id = "";
        private string firstName = "";
        private string lastName = "";
        private string departmentId = "";
        private string positionId = "";
        private string sex = "";
        private int age = 0;
        private string storeId = null;
        private string warehouseId = null;
        private string phone = "";
        private string teamId = null;

        public Staff_Edit()
        {
            InitializeComponent();
            if (GlobalsData.currentUser["department"].ToString().Equals("Admin"))
            {
                foreach (var item in Enum.GetValues(typeof(DepartmentEnum)))
                {
                    cbDept.Items.Add(EnumExtensions.Description((DepartmentEnum)item));
                }
            }
            else
            {
                cbDept.Items.Add(GlobalsData.currentUser["department"].ToString());
            }
        }
        public Staff_Edit(JObject staff)
        {
            this.staff = staff;
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(DepartmentEnum)))
            {
                cbDept.Items.Add(EnumExtensions.Description((DepartmentEnum)item));
            }
            InitStaffInfo();
        }


        private void InitStaffInfo()
        {
            id = staff["Id"].ToString();
            firstName = staff["FirstName"].ToString();
            lastName = staff["LastName"].ToString();
            DepartmentEnum departmentEnum = ((DepartmentEnum)Convert.ToInt32(staff["_departmentId"].ToString()));
            var department = EnumExtensions.Description((DepartmentEnum)departmentEnum);
            sex = staff["Sex"].ToString();
            PositionEnum positionEnum = ((PositionEnum)Convert.ToInt32(staff["_positionId"].ToString()));
            var position = EnumExtensions.Description((PositionEnum)positionEnum);
            Console.WriteLine("position:" + position);
            phone = staff["Phone"].ToString();
            if (staff["Age"].Type != JTokenType.Null)
            {
                age = Convert.ToInt32(staff["Age"]);
            }
            var warehouse = "";
            if (staff["_warehouseId"].Type != JTokenType.Null)
            {
                LocationEnum warehouseEnum = ((LocationEnum)Convert.ToInt32(staff["_warehouseId"].ToString()));
                warehouse = EnumExtensions.Description((LocationEnum)warehouseEnum);
            }
            var store = "";
            if (staff["_storeId"].Type != JTokenType.Null)
            {
                LocationEnum storeEnum = (LocationEnum)Enum.Parse(typeof(LocationEnum), staff["_storeId"].ToString());
                store = EnumExtensions.Description((LocationEnum)storeEnum);
            }
            var team = "";
            if (staff["_teamId"].Type != JTokenType.Null)
            {
                TeamEnum teamEnum = ((TeamEnum)Convert.ToInt32(staff["_teamId"].ToString()));
                team = EnumExtensions.Description((TeamEnum)teamEnum);
            }
            if (staff["Sex"].ToString().Equals("F"))
            {
                FemaleGenderRadio.Checked = true;
            }
            else
            {
                MaleGenderRadio.Checked = true;
            }
            //Set data to dom
            txtFistName.Texts = firstName;
            txtLastName.Texts = lastName;
            txtAge.Texts = age.ToString();
            txtPhone.Texts = phone;
            cbDept.SelectedItem = department;
            cbPosition.SelectedItem = position;
            Console.WriteLine("D:" + cbDept.SelectedItem);
            Console.WriteLine("P:" + cbPosition.SelectedItem);
            cbStore.SelectedItem = store;
            Console.WriteLine("S:" + cbStore.SelectedItem);
            cbWarehouse.SelectedItem = warehouse;
            Console.WriteLine("W:" + cbWarehouse.SelectedItem);
            cbTeam.SelectedItem = team;
            Console.WriteLine("T:" + cbTeam.SelectedItem);
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            //check 
            if (txtFistName.Texts.Equals(txtFistName.Placeholder))
            {
                txtFistName.IsError = true;
                return;
            }
            firstName = txtFistName.Texts;
            if (!firstName.Equals(staff["FirstName"]))
            {
                updateValue.Add(new { attribute = "FirstName", value = firstName });
            }

            if (txtLastName.Texts.Equals(txtLastName.Placeholder))
            {
                txtLastName.IsError = true;
                return;
            }
            lastName = txtLastName.Texts;
            if (!lastName.Equals(staff["LastName"]))
            {
                updateValue.Add(new { attribute = "LastName", value = lastName });
            }

            if (!FemaleGenderRadio.Checked && !MaleGenderRadio.Checked)
            {
                MessageBox.Show("Please select the gender of this staff.");
                return;
            }
            else
            {
                if (FemaleGenderRadio.Checked)
                {
                    sex = "F";
                }
                else
                {
                    sex = "M";
                }
            }
            if (!sex.Equals(staff["Sex"]))
            {
                updateValue.Add(new { attribute = "Sex", value = sex });
            }

            if (txtAge.Texts.Equals(txtAge.Placeholder) || age == 0)
            {
                txtAge.IsError = true;
                return;
            }
            age = Convert.ToInt16(txtAge.Texts);
            if (!age.Equals(staff["Age"]))
            {
                updateValue.Add(new { attribute = "Age", value = age });
            }

            if (txtPhone.Texts.Equals(txtPhone.Placeholder) || txtPhone.Texts == "")
            {
                txtPhone.IsError = true;
                return;
            }
            phone = txtPhone.Texts;
            if (!phone.Equals(staff["Phone"]))
            {
                updateValue.Add(new { attribute = "Phone", value = phone });
            }

            if (cbDept.SelectedIndex == -1)
            {
                cbDept.BorderColor = Color.Red;
                return;
            }
            if (!departmentId.Equals(staff["_departmentId"]))
            {
                updateValue.Add(new { attribute = "_departmentId", value = departmentId });
            }

            if (cbPosition.SelectedIndex == -1)
            {
                cbPosition.BorderColor = Color.Red;
                return;
            }
            if (!positionId.Equals(staff["_positionId"]))
            {
                updateValue.Add(new { attribute = "_positionId", value = positionId });
            }

            if (departmentId == ((int)DepartmentEnum.Sales).ToString("000"))
            {
                if (cbStore.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the store of this staff.");
                    cbStore.BorderColor = Color.Red;
                    return;
                }
                var store = ((LocationEnum)(cbStore.SelectedIndex + 2)).ToString();
                if (!store.Equals(storeId))
                {
                    updateValue.Add(new { attribute = "_storeId", value = store });
                    warehouseId = null;
                    updateValue.Add(new { attribute = "_warehouseId", value = warehouseId });
                }
            }

            if (departmentId == ((int)DepartmentEnum.Inventory).ToString("000"))
            {
                if (cbWarehouse.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the warehouse of this staff.");
                    cbWarehouse.BorderColor = Color.Red;
                    return;
                }
                var warehouse = ((int)(LocationEnum)Enum.Parse(typeof(LocationEnum), (cbWarehouse.SelectedItem).ToString().Replace(" ", ""), true)).ToString("000");
                if (!warehouse.Equals(warehouseId))
                {
                    updateValue.Add(new { attribute = "_warehouseId", value = warehouse });
                    storeId = null;
                    updateValue.Add(new { attribute = "_storeId", value = storeId });
                }
            }

            if (positionId == ((int)PositionEnum.DeliveryWorkman).ToString("000") || positionId == ((int)PositionEnum.TechnicalWorkman).ToString("000"))
            {
                if (cbTeam.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the team of this workman.");
                    cbTeam.BorderColor = Color.Red;
                    return;
                }
                var team = ((int)(TeamEnum)Enum.Parse(typeof(TeamEnum), (cbTeam.SelectedItem).ToString().Replace(" ", ""), true)).ToString("000");
                if (!team.Equals(teamId))
                {
                    updateValue.Add(new { attribute = "_teamId", value = team });
                }
            }

            // send the request to the server
            result = cbStaff.Update(id, updateValue);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                // show the result
                MessageBox.Show("Update Staff Successfully!");
                // close the form
                this.OnExit.Invoke();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(result.Content);
            }

        }

        public event Action OnExit;

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void departmentCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var department = (DepartmentEnum)Enum.Parse(typeof(DepartmentEnum), (cbDept.SelectedItem).ToString().Replace(" ", ""), true);
            departmentId = ((int)department).ToString("000");
            cbPosition.Items.Clear();
            cbStore.Items.Clear();
            cbWarehouse.Items.Clear();
            cbTeam.Items.Clear();
            cbPosition.Texts = "Position";
            cbStore.Texts = "Store";
            cbWarehouse.Texts = "Warehouse";
            cbTeam.Texts = "Team";
            if (department == DepartmentEnum.System)
            {
                cbPosition.Items.Add(EnumExtensions.Description((PositionEnum)0));
            }
            else if (department == DepartmentEnum.Admin)
            {
                cbPosition.Items.Add(EnumExtensions.Description((PositionEnum)1));
            }
            else
            {
                foreach (var item in Enum.GetValues(typeof(PositionEnum)))
                {
                    if ((int)item > (int)department && (int)item < ((int)department + 99))
                    {
                        cbPosition.Items.Add(EnumExtensions.Description((PositionEnum)item));
                    }
                }
            }
            if (department == DepartmentEnum.Sales)
            {
                foreach (var item in Enum.GetValues(typeof(LocationEnum)))
                {
                    if ((int)item > 1)
                        cbStore.Items.Add(EnumExtensions.Description((LocationEnum)item));
                }
            }

            if (department == DepartmentEnum.Inventory)
            {
                cbWarehouse.Items.Add(EnumExtensions.Description(LocationEnum.KolwoonWarehouse));
            }
        }

        private void cbPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbTeam.Items.Clear();
            var department = (DepartmentEnum)Enum.Parse(typeof(DepartmentEnum), (cbDept.SelectedItem).ToString().Replace(" ", ""), true);
            var position = (PositionEnum)Enum.Parse(typeof(PositionEnum), (cbPosition.SelectedItem).ToString().Replace(" ", ""), true);
            positionId = ((int)position).ToString("000");
            if (position == PositionEnum.DeliveryWorkman || position == PositionEnum.TechnicalWorkman)
            {
                foreach (var item in Enum.GetValues(typeof(TeamEnum)))
                {
                    if ((int)item > (int)department && (int)item < ((int)department + 99))
                        cbTeam.Items.Add(EnumExtensions.Description((TeamEnum)item));
                }
            }
        }

        private void txtFistName_Click(object sender, EventArgs e)
        {
            txtFistName.IsError = false;
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            txtLastName.IsError = false;
        }

        private void txtAge_Click(object sender, EventArgs e)
        {
            txtAge.IsError = false;
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.IsError = false;
        }

        private void cbDept_Click(object sender, EventArgs e)
        {
            cbDept.BorderColor = Color.LightGray;
        }

        private void cbPosition_Click(object sender, EventArgs e)
        {
            cbPosition.BorderColor = Color.LightGray;
        }

        private void cbStore_Click(object sender, EventArgs e)
        {
            cbStore.BorderColor = Color.LightGray;
        }

        private void cbWarehouse_Click(object sender, EventArgs e)
        {
            cbWarehouse.BorderColor = Color.LightGray;
        }

        private void cbTeam_Click(object sender, EventArgs e)
        {
            cbTeam.BorderColor = Color.LightGray;
        }

        private void txtPhone__TextChanged(object sender, EventArgs e)
        {
            string discountTxt = txtPhone.Texts;
            if (discountTxt.Trim() == "") return;
            for (int i = 0; i < discountTxt.Length; i++)
            {
                if (!char.IsNumber(discountTxt[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    return;
                }
            }
            try
            {
                Convert.ToInt64(txtPhone.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }
        }

        private void txtAge__TextChanged(object sender, EventArgs e)
        {
            string discountTxt = txtAge.Texts;
            if (discountTxt.Trim() == "") return;
            for (int i = 0; i < discountTxt.Length; i++)
            {
                if (!char.IsNumber(discountTxt[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    txtAge.Texts = "";
                    return;
                }
            }
        }

        private void txtAge__Leave(object sender, EventArgs e)
        {
            if (txtAge.Texts != txtAge.Placeholder && txtAge.Texts != "")
            {
                try
                {
                    age = Convert.ToInt32(txtAge.Texts);
                    if (age < 18 || age > 99)
                    {
                        MessageBox.Show("Age should between 18 to 99!");
                        txtAge.Texts = "";
                        age = 0;
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a valid number");
                    txtAge.Texts = "";
                    return;
                }
            }
        }

        private void txtPhone__Leave(object sender, EventArgs e)
        {
            if (txtPhone.Texts != txtPhone.Placeholder && txtPhone.Texts != "")
            {
                if (txtPhone.Texts.Length != 8 && txtPhone.Texts.Length != 11)
                {
                    txtPhone.IsError = true;
                    MessageBox.Show("The phone number should have 8 or 11 digits");
                    return;
                }
            }
        }
    }
}
