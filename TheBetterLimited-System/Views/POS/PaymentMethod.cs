using Newtonsoft.Json;
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
    public partial class PaymentMethod : Form
    {
        private RestResponse response = new RestResponse();
        private ControllerBase cbOrder = new ControllerBase("Order/Create");
        public double totalAmount { get; set; }
        private int selectedMethod = 0;
        private bool needBook;
        public Dictionary<string, object> data = new Dictionary<string, object>();

        public event Action OnExit;

        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (((PaymentPicBox)PaymentMethodBox.Controls[0]).IsSelected)
            {
                CashPayment();
            }
            else
            {

            }
        }

        private void CashPayment()
        {
            DialogResult result = DialogResult.None;
            if (needBook)
            {
                result = MessageBox.Show("Deposit is " + String.Format("{0:C2}", totalAmount * 0.2)
                        + "\nDose customer have paid?", "Confirm payment", MessageBoxButtons.YesNo);
            }
            else
            {
                result = MessageBox.Show("Total Amount is " + String.Format("{0:C2}", totalAmount)
                        + "\nDose customer have paid?", "Confirm payment", MessageBoxButtons.YesNo);
            }
            if (result == DialogResult.Yes)
            {
                //Create order
                try
                {
                    response = cbOrder.Create(data);
                    WaitResult waitResult = new WaitResult();
                    waitResult.Show();
                    waitResult.TopMost = true;
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        waitResult.Close();
                        waitResult.Dispose();
                        Receipt receipt = new Receipt(response.Content);
                        receipt.ShowDialog();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Unsuccessful");
                }
            }
        }

        private void VirtualPayment()
        {
            DialogResult result = DialogResult.None;
            if (needBook)
            {
                result = MessageBox.Show("Deposit is " + String.Format("{0:C2}", totalAmount * 0.2)
                        + "\nAre you going to pay?", "Confirm payment", MessageBoxButtons.YesNo);
            }
            else
            {
                result = MessageBox.Show("Total Amount is " + String.Format("{0:C2}", totalAmount)
                        + "\nAre you going to pay?", "Confirm payment", MessageBoxButtons.YesNo);
            }
            if (result == DialogResult.Yes)
            {
                //Create order
                try
                {
                    response = cbOrder.Create(data);
                    WaitResult waitResult = new WaitResult();
                    waitResult.ShowDialog();
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        waitResult.Close();
                        waitResult.Dispose();
                        Receipt receipt = new Receipt(response.Content);
                        receipt.ShowDialog();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Unsuccessful");
                }
            }
        }

        private void paymentPicBox_Click(object sender, EventArgs e)
        {
            Console.WriteLine((PaymentPicBox)PaymentMethodBox.Controls[selectedMethod]);
            if (selectedMethod != -1)
            {
                ((PaymentPicBox)PaymentMethodBox.Controls[selectedMethod]).IsSelected = false;
            }
            selectedMethod = PaymentMethodBox.Controls.IndexOf(((System.Windows.Forms.Control)sender).Parent);
        }

        private void ClearForm()
        {
            this.Close();
            this.Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really cancel the payment?", "Warming", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ClearForm();
            }
        }
    }
}
