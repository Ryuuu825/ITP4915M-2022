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
        private RestResponse result = new RestResponse();
        private ControllerBase con = new ControllerBase("Goods");
        private ControllerBase catCon = new ControllerBase("Catalogue");
        private string Id;
        private string CatId;
        private string CatName;
        private string Name; 
        private string Description;
        private string Price;
        private string Code;
        private int size;
        private int Status;

        private List<string> catList = new List<string>();
        private bool isUpload = false;

        public DefectiveItem_Details()
        {
            InitializeComponent();
        }
        public DefectiveItem_Details(string GoodsId)
        {
            InitializeComponent();
            result =  con.GetById(GoodsId);
            JObject res = JObject.Parse(result.Content);

            Id = res["Id"].ToString();
            CatId = res["_catalogueId"].ToString();
            Name = res["Name"].ToString();
            Description = res["Description"].ToString();
            Price = res["Price"].ToString();
            Code = res["GTINCode"].ToString();
            size = res["Size"].ToObject<int>();
            Status = res["Status"].ToObject<int>();

            txtGoodsId.Texts = GoodsId;
            txtGoodsName.Texts = res["Name"].ToString();
            txtSupAddress.Texts = res["Description"].ToString();
            txtPrice.Texts = res["Price"].ToString();
            txtGTINCode.Texts = res["GTINCode"].ToString();

            result = catCon.GetAll();
            JArray catRes = JArray.Parse(result.Content);

            // convert base64 to image
            RestRequest req = new RestRequest("/api/pos/goods/" + Id + "/image", Method.Get)
                                    .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"]);

            var photo = Utils.RestClientUtils.client.DownloadDataAsync(req).GetAwaiter().GetResult();
            try
            {
                using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
                {
                
                    ms.Write(photo, 0, photo.Length);

                    // convert image to bitmap
                    icon = new Bitmap(ms);
                }
            }catch(Exception ex)
            {
                icon  = Properties.Resources._default;
            }
                
        }
        private Bitmap icon;

        private void StaffIDTxt_Enter(object sender, EventArgs e)
        {
            /*StaffIDTxt.IsError = false;*/
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            List<object> UpdateContent = new List<object>();

            if (!txtGoodsName.Texts.Equals(txtGoodsName.Placeholder) && !txtGoodsName.Texts.Equals(Name))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Name",
                        Value = txtGoodsName.Texts
                    }
                );
            }
            if (!txtSupAddress.Texts.Equals(txtSupAddress.Placeholder) && !txtSupAddress.Texts.Equals(Description))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Description",
                        Value = txtSupAddress.Texts
                    }
                );
            }

            if (!txtPrice.Texts.Equals(txtPrice.Placeholder) && !txtPrice.Texts.Equals(Price))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Price",
                        Value = txtPrice.Texts
                    }
                );
            }

            if (!txtGTINCode.Texts.Equals(txtGTINCode.Placeholder) && !txtGTINCode.Texts.Equals(Code))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "GTINCode",
                        Value = txtGTINCode.Texts
                    }
                );
            }
            con.Update(Id, UpdateContent);

            this.OnExit.Invoke();
            this.Close();
            this.Dispose();


        }

        private void userNameTxt_Click(object sender, EventArgs e)
        {
        }

        public event Action OnExit;
       
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
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
    }
}
