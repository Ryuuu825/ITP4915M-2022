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
using TheBetterLimited.CustomizeControl;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class DefectItem_Add : Form
    {
        public object defectItem { get; set; }
        
        public DefectItem_Add()
        {
            InitializeComponent();
        }

        public ControllerBase defectCon = new ControllerBase("DefectItem");
        private void CreateUser_Click(object sender, EventArgs e)
        {
            RestResponse response = null;
            if (cbRefund.Checked == false && cbExchange.Checked == false)
            {
                MessageBox.Show("Please select the operation of the defective item.");
                return;
            }

            if (txtDesc.Texts == "" || txtDesc.Texts == txtDesc.Placeholder)
            {
                txtDesc.IsError = true;
                return;
            }
            ((DefectItem)defectItem).remark = txtDesc.Texts.ToString();

            if (cbRefund.Checked == true)
            {
                ((DefectItem)defectItem).handleStatus = 0;
                if (txtRefund.Texts == "" || txtRefund.Texts == txtRefund.Placeholder)
                {
                    txtRefund.IsError = true;
                    return;
                }
                ((DefectItem)defectItem).qty = Convert.ToInt32(txtRefund.Texts);
                response = defectCon.Create(defectItem);
            }

            if (cbExchange.Checked == true)
            {
                ((DefectItem)defectItem).handleStatus = 1;
                if (txtExchange.Texts == "" || txtExchange.Texts == txtExchange.Placeholder)
                {
                    txtExchange.IsError = true;
                    return;
                }
                ((DefectItem)defectItem).qty = Convert.ToInt32(txtExchange.Texts);
                response = defectCon.Create(defectItem);
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Defective item record created successfully");
                this.OnExit.Invoke();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        public event Action OnExit;

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtDesc_Click(object sender, EventArgs e)
        {
            txtDesc.IsError = false;
        }

        private void cbExchange_CheckedChanged(object sender, EventArgs e)
        {
            txtExchange.Enabled = cbExchange.Checked;
        }

        private void cbRefund_CheckedChanged(object sender, EventArgs e)
        {
            txtRefund.Enabled = cbRefund.Checked;
        }
    }
}
