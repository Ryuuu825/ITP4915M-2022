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
using TheBetterLimited_System.Controller;
namespace TheBetterLimited.Views
{
    public partial class Staff_Edit : Form
    {

        private string Id;
        private string Name;
        private string Address;
        private string Phone;
        private string Email;
        private string Contact;
        private RestResponse result = new RestResponse();
        private ControllerBase con = new ControllerBase("Staff");
        public Staff_Edit()
        {
            InitializeComponent();
        }

        public Staff_Edit(string SupplierId)
        {
            InitializeComponent();
            result = con.GetById(SupplierId);
            JObject res = JObject.Parse(result.Content);
            Id = SupplierId;
            Name = res["Name"].ToString();
            Address = res["Address"].ToString();
            Phone = res["Phone"].ToString();
            Email = res["Email"].ToString();
            Contact = res["Contact"].ToString();


/*            txtSupplierId.Texts = SupplierId;
            txtSupplierName.Texts = res["Name"].ToString();
            txtAddress.Texts = res["Address"].ToString();
            txtPhone.Texts = res["Phone"].ToString();
            txtEmail.Texts = res["Email"].ToString();
            txtContact.Texts = res["Contact"].ToString();*/

        }


        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            /*StaffIDTxt.IsError = false;*/
        }


       
        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            List<object> UpdateContent = new List<object>();

/*            if (!txtSupplierName.Texts.Equals(txtSupplierName.Placeholder) && !txtSupplierName.Texts.Equals(txtSupplierName))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Name",
                        Value = txtSupplierName.Texts
                    }
                );
            }

            if (!txtAddress.Texts.Equals(txtAddress.Placeholder) && !txtAddress.Texts.Equals(txtAddress))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Address",
                        Value = txtAddress.Texts
                    }
                );
            }

            if (!txtPhone.Texts.Equals(txtPhone.Placeholder) && !txtPhone.Texts.Equals(txtPhone))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Phone",
                        Value = txtPhone.Texts
                    }
                );
            }

            if (!txtEmail.Texts.Equals(txtEmail.Placeholder) && !txtEmail.Texts.Equals(txtEmail))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Email",
                        Value = txtEmail.Texts
                    }
                );
            }

            if (!txtContact.Texts.Equals(txtContact.Placeholder) && !txtContact.Texts.Equals(txtContact))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Contact",
                        Value = txtContact.Texts
                    }
                );
            }*/

            con.Update(Id, UpdateContent);

            this.OnExit.Invoke();
            this.Close();
            this.Dispose();


        }



        public event Action OnExit;


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

/*
        private void label1_Click(object sender, EventArgs e)
        {
            txtSupplierId.Focus();
        }


        private void StaffIDTxt_Click(object sender, EventArgs e)
        {
            txtSupplierId.IsError = false;
        }


        private void StaffIDTxt__TextChanged(object sender, EventArgs e)
        {
            txtSupplierId.IsError = false;
        }*/

        private void StaffIDTxt_Leave(object sender, EventArgs e)
        {

        }

       

    }
}
