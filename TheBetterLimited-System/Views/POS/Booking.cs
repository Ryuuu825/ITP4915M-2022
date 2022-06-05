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
            var name = CusNameTxt.Text;

            if (CusPhoneTxt.Texts.Equals(String.Empty) || CusPhoneTxt.Texts.Equals(CusPhoneTxt.Placeholder))
            {
                CusPhoneTxt.IsError = true;
                return;
            }
            var phone = CusPhoneTxt.Text;

            if (CusAddressTxt.Texts.Equals(String.Empty) || CusAddressTxt.Texts.Equals(CusAddressTxt.Placeholder))
            {
                CusAddressTxt.IsError = true;
                return;
            }
            var address = CusAddressTxt.Text;

            CustomerInfo cusInfo = new CustomerInfo(name, phone, address);
            Form pos = Application.OpenForms["POS"];
            ((POS)pos).SetCusInfo(cusInfo);
            ((POS)pos).OpenPaymentMethod();
        }
    }
}
