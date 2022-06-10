using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{

    public partial class Booking : Form
    {
        public double totalAmount { get; set; }
        private double deposit;

        public Booking()
        {
            InitializeComponent();
            
        }


        public event Action OnExit;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form pos = Application.OpenForms["POS"];
            ((POS)pos).SetCusInfo(null);
            this.Close();
            this.Dispose();
        }

        private void depositTxt_Load(object sender, EventArgs e)
        {
            if (totalAmount < 5000)
            {
                depositTxt.Texts = "0.0";
            }
            else
            {
                deposit = totalAmount * 0.2;
                depositTxt.Texts = String.Format("{0:C2}",deposit);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CusNameTxt.Texts.Equals(String.Empty) || CusNameTxt.Texts.Equals(CusNameTxt.Placeholder))
            {
                CusNameTxt.IsError = true;
                return;
            }
            var name = CusNameTxt.Texts;

            if (PhoneTxt.Texts.Equals(String.Empty) || PhoneTxt.Texts.Equals(PhoneTxt.Placeholder))
            {
                PhoneTxt.IsError = true;
                return;
            }
            var phone = PhoneTxt.Texts;

            string address;
            if (CusAddressTxt.Texts.Equals(String.Empty) || CusAddressTxt.Texts.Equals(CusAddressTxt.Placeholder))
            {
                address = String.Empty;
            }
            else
            {
                address = CusAddressTxt.Texts;
            }

            CustomerInfo cusInfo = new CustomerInfo(name, phone, address);
            Form pos = Application.OpenForms["POS"];
            ((POS)pos).SetCusInfo(cusInfo);
            ((POS)pos).OpenPaymentMethod(true);
        }

        private void CusNameTxt_Click(object sender, EventArgs e)
        {
            CusNameTxt.IsError = false;
        }

        private void CusPhoneTxt_Click(object sender, EventArgs e)
        {
            PhoneTxt.IsError = false;
        }

        private void CusAddressTxt_Click(object sender, EventArgs e)
        {
            CusAddressTxt.IsError = false;
        }

        private void PhoneTxt__Leave(object sender, EventArgs e)
        {
            if (PhoneTxt.Texts.Length == 8 || PhoneTxt.Texts.Length == 11)
            {
            }
            else
            {
                PhoneTxt.IsError = true;
                MessageBox.Show("The phone number should have 8 or 11 digits");
                return;
            }
        }

        private void PhoneTxt__TextChanged(object sender, EventArgs e)
        {
            string discountTxt = PhoneTxt.Texts;
            if (discountTxt.Trim() == "") return;
            for (int i = 0; i < discountTxt.Length; i++)
            {
                if (!char.IsNumber(discountTxt[i]))
                {
                    MessageBox.Show("Please enter a valid number");
                    PhoneTxt.Texts = "";
                    return;
                }
            }
            try
            {
                Convert.ToInt32(PhoneTxt.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number");
                PhoneTxt.Texts = "";
                return;
            }
        }
    }
}
