﻿using Newtonsoft.Json.Linq;
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
        private ControllerBase cbOrder= new ControllerBase("Order/Create");
        public double totalAmount { get; set; }
        private int selectedMethod = 0;
        private List<object> orderItems = null;
        private CustomerInfo cusInfo = null;
        private List<object> appointmentInfos = null;
        private Dictionary<string, object> orderInfo= new Dictionary<string, object>();

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
            }else
            {
                DigitPayment();
            }
        }

        private async void DigitPayment()
        {
            WaitResult waitResult = new WaitResult();
            this.Hide();
            waitResult.ShowDialog();
        }

        private void CashPayment()
        {
            Console.WriteLine(totalAmount);
            DialogResult result = MessageBox.Show("Total Amount is " + String.Format("{0:C2}", totalAmount)
                + "\nDose customer have paid?", "Confirm payment", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //Create order
                try
                {
                    response = cbOrder.Create(orderInfo);
                    if(response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Receipt receipt = new Receipt();
                        receipt.ShowDialog();
                        this.Close();
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Unsuccessflu");
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Do you really cancel the order?", "Warming", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClearForm();
                }
                else
                {
                    CashPayment();
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
            ClearForm();
        }

        public void SetOrderList(List<object> orderItems)
        {
            this.orderItems = orderItems;
            orderInfo.Add("salesOrderItems", orderItems);
        }
        public void SetCusInfo(object cusInfo)
        {
            this.cusInfo = (CustomerInfo)cusInfo;
            orderInfo.Add("customer", cusInfo);
        }

        public void SetAppointmentInfo(List<object> appInfos)
        {
            this.appointmentInfos = appInfos;
            orderInfo.Add("appointments", appInfos);
        }

        private void CreateOrder()
        {
            
        }

    }
}
