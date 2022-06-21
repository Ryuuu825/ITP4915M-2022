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
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBetterLimited.Controller;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Views
{
    public partial class DefectiveItem_Details : Form
    {
        private DefectItemController cbDefect = new DefectItemController("DefectItem");
        private string Id;
        private string recordStatus;

        private List<string> catList = new List<string>();
        private bool isUpload = false;

        public DefectiveItem_Details()
        {
            InitializeComponent();
        }
        public DefectiveItem_Details(JObject itemInfo)
        {
            InitializeComponent();

            Id = itemInfo["Id"].ToString();
            recordStatus = itemInfo["Status"].ToString();

            //Defect item info
            txtGoodsName.Texts = itemInfo["GoodsName"].ToString();
            txtGoodsId.Texts = itemInfo["_supplierGoodsStockId"].ToString();
            txtSup.Texts = itemInfo["Supplier"]["Name"].ToString();
            txtSupTel.Texts = itemInfo["Supplier"]["Phone"].ToString();
            txtSupAddress.Texts = itemInfo["Supplier"]["Address"].ToString();
            txtDesc.Texts = itemInfo["Remark"].ToString();

            //Collect info
            if ((int)itemInfo["HandleStatus"] == 1)
            {
                txtStatus.Texts = "Exchange";
                txtStatus.ForeColor = Color.FromArgb(19, 115, 235);
            }
            else if ((int)itemInfo["HandleStatus"] == 0)
            {
                txtStatus.Texts = "Refund";
                txtStatus.ForeColor = Color.FromArgb(203, 32, 39);
            }
            txtQty.Texts = itemInfo["Qty"].ToString();

            if (itemInfo["Customer"].Type != JTokenType.Null)
            {
                txtCusName.Texts = itemInfo["Customer"]["name"].ToString();
                txtCusPhone.Texts = itemInfo["Customer"]["phone"].ToString();
            }else
            {
                txtStore.Texts = itemInfo["StoreName"].ToString();
            }
            txtCollectAddress.Texts = itemInfo["CollectAddress"].ToString();
        }

        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            /*StaffIDTxt.IsError = false;*/
        }

        private void userNameTxt_Click(object sender, EventArgs e)
        {
        }

        public event Action OnExit;

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtGoodsId.Focus();
        }

        private void StaffIDTxt_Click(object sender, EventArgs e)
        {
            txtGoodsId.IsError = false;
        }

        private void StaffIDTxt__TextChanged(object sender, EventArgs e)
        {
            txtGoodsId.IsError = false;
        }

        private void collectBtn_Click(object sender, EventArgs e)
        {
            if (recordStatus.Equals("Handling"))
            {
                MessageBox.Show("The item had been collected");
                return;
            }else if (recordStatus.Equals("Returned"))
            {
                MessageBox.Show("The item had been returned to supplier.\nYou cannot return again!");
                return;
            }
            RestResponse result = new RestResponse();
            result = cbDefect.Update(new { id = Id, status = 1 });
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Defect Item Updated!");
                this.OnExit.Invoke();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
            result = null;
        }
        private void returnedBtn_Click(object sender, EventArgs e)
        {
            if (recordStatus.Equals("Returned"))
            {
                MessageBox.Show("The item had been returned to supplier.\nYou cannot return again!");
                return;
            }
            RestResponse result = new RestResponse();
            result = cbDefect.Update(new { id = Id, status = 2 });
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Defect Item Updated!");
                this.OnExit.Invoke();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
            result = null;
        }
    }
}
