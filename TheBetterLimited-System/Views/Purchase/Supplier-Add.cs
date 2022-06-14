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
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class Supplier_Add : Form
    {
        private RestResponse result = new RestResponse();
        private ControllerBase con = new ControllerBase("Supplier");

        public Supplier_Add()
        {
            InitializeComponent();
        }


        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            // only name is required
            if (txtSupplierName.Texts == txtSupplierName.Placeholder)
            {
                txtSupplierName.BorderColor = Color.Red;
                return;
            }
            txtSupplierName.BorderColor = Color.LightGray;

            string name = txtSupplierName.Texts;
            string address = txtAddress.Texts == txtAddress.Placeholder ? "" : txtAddress.Texts;
            string phone = txtPhone.Texts == txtPhone.Placeholder ? "" : txtPhone.Texts;
            string email = txtEmail.Texts == txtEmail.Placeholder ? "" : txtEmail.Texts;
            string contact = txtContact.Texts == txtContact.Placeholder ? "" : txtContact.Texts;
            // send the request to the server
            result = con.Create(
                new {
                    Name = name,
                    Address = address,
                    Phone = phone,
                    Email = email,
                    Contact = contact
                }
            );


            // show the result
            MessageBox.Show("Supplier created successfully");
            // close the form
            OnExit.Invoke();
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

       
    }
}
