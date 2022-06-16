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
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class DefectItem_Add : Form
    {
        public Dictionary<string, string> DefectItem { get; set; }
        public DefectItem_Add()
        {
            InitializeComponent();
        }


        public ControllerBase defectCon = new ControllerBase("DefectItemRecord");
        private void CreateUser_Click(object sender, EventArgs e)
        {
            if (txtDesc.Texts == "" || txtDesc.Texts == txtDesc.Placeholder)
            {
                txtDesc.IsError = true;
                return;
            }
            DefectItem.Add("Remark", txtDesc.Texts.ToString());
            Console.WriteLine(DefectItem["_supplierGoodsStockId"]);
            Console.WriteLine(DefectItem["_salesOrderId"]);
            var response = defectCon.Create(DefectItem);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Defective item record created successfully");
                this.OnExit.Invoke();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(response.ErrorMessage);
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
    }
}
