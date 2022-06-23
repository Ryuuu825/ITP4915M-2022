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
    public partial class Staff_Add : Form
    {
        private RestResponse result = new RestResponse();
        private ControllerBase cbStaff = new ControllerBase("Staff");
        private string firstName = "";
        private string lastName = "";
        private string departmentId = "";
        private string positionId = "";
        private string sex = "";
        private int age = 0;
        private string store = null;
        private string warehouse = null;
        private string phone = "";
        private string team = null;
        public Staff_Add()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(DepartmentEnum)))
            {
                cbDept.Items.Add(EnumExtensions.Description((DepartmentEnum)item));
            }
        }


        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            if (txtFistName.Texts.Equals(txtFistName.Placeholder))
            {
                txtFistName.IsError = true;
                return;
            }
            firstName = txtFistName.Texts;

            if (txtLastName.Texts.Equals(txtLastName.Placeholder))
            {
                txtLastName.IsError = true;
                return;
            }
            lastName = txtLastName.Texts;

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

            if (txtAge.Texts.Equals(txtAge.Placeholder) || age == 0)
            {
                txtAge.IsError = true;
                return;
            }
            age = Convert.ToInt16(txtAge.Texts);

            if (txtPhone.Texts.Equals(txtPhone.Placeholder))
            {
                txtPhone.IsError = true;
                return;
            }
            phone = txtPhone.Texts;

            if (cbDept.SelectedIndex == -1)
            {
                cbDept.BorderColor = Color.Red;
                return;
            }

            if (cbPosition.SelectedIndex == -1)
            {
                cbPosition.BorderColor = Color.Red;
                return;
            }

            if (departmentId == ((int)DepartmentEnum.Sales).ToString("000"))
            {
                if (cbStore.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the store of this staff.");
                    cbStore.BorderColor = Color.Red;
                    return;
                }
                store = ((LocationEnum)(cbStore.SelectedIndex + 2)).ToString();
            }

            if (departmentId == ((int)DepartmentEnum.Inventory).ToString("000"))
            {
                if (cbWarehouse.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the warehouse of this staff.");
                    cbWarehouse.BorderColor = Color.Red;
                    return;
                }
                warehouse = ((int)(LocationEnum)Enum.Parse(typeof(LocationEnum), (cbWarehouse.SelectedItem).ToString().Replace(" ", ""), true)).ToString("000");
            }

            if (positionId == ((int)PositionEnum.DeliveryWorkman).ToString("000") || positionId == ((int)PositionEnum.TechnicalWorkman).ToString("000"))
            {
                if (cbTeam.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the team of this workman.");
                    cbTeam.BorderColor = Color.Red;
                    return;
                }
                team = ((int)(TeamEnum)Enum.Parse(typeof(TeamEnum), (cbTeam.SelectedItem).ToString().Replace(" ", ""), true)).ToString("000");
            }

            // send the request to the server
            result = cbStaff.Create(
                new
                {
                    Id = "",
                    _departmentId = departmentId,
                    _positionId = positionId,
                    _warehouseId = warehouse,
                    _storeId = store,
                    _teamId = team,
                    FirstName = firstName,
                    LastName = lastName,
                    Sex = sex,
                    Age = age,
                    Phone = phone
                }
            );
            if (result.StatusCode == HttpStatusCode.OK)
            {
                // show the result
                MessageBox.Show("Add Staff Successfully!");
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
                return;
            }
            if (department == DepartmentEnum.Inventory)
            {
                cbWarehouse.Items.Add(EnumExtensions.Description(LocationEnum.KolwoonWarehouse));
                return;
            }
        }

        private void cbPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbTeam.Items.Clear();
            cbTeam.Texts = "Team";
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
                    age = Convert.ToInt16(txtAge.Texts);
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
