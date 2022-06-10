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
    public partial class Inventorymanagement_Edit : Form
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

        public Inventorymanagement_Edit()
        {
            InitializeComponent();
        }
        public Inventorymanagement_Edit(string GoodsId)
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
            txtDescription.Texts = res["Description"].ToString();
            txtPrice.Texts = res["Price"].ToString();
            txtGTINCode.Texts = res["GTINCode"].ToString();

            result = catCon.GetAll();
            JArray catRes = JArray.Parse(result.Content);
            cbxCatalogue.UnderlinedStyle = false;

            foreach (var cat in catRes)
            {
                cbxCatalogue.Items.Add(cat["Name"].ToString());
                cbxCatalogue.AutoCompleteCustomSource.Add(cat["Name"].ToString());
                if (cat["Id"].ToString() == CatId)
                {
                    cbxCatalogue.SelectedItem = cat["Name"].ToString();
                }
                catList.Add(cat["Id"].ToString());
            }
            cbxSize.UnderlinedStyle = false;
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");

            if (size == 0)
            {
                cbxSize.SelectedItem = "Small";
            }
            else if (size == 1)
            {
                cbxSize.SelectedItem = "Medium";
            }
            else if (size == 2)
            {
                cbxSize.SelectedItem = "Large";
            }

            cbxStatus.UnderlinedStyle = false;
            cbxStatus.Items.Add("Selling");
            cbxStatus.Items.Add("PhasingOut");
            cbxStatus.Items.Add("StopSelling");

            if (Status == 0)
            {
                cbxStatus.SelectedItem = "Selling";
            }
            else if (Status == 1)
            {
                cbxStatus.SelectedItem = "PhasingOut";
            }
            else if (Status == 2)
            {
                cbxStatus.SelectedItem = "StopSelling";
            }
            // convert base64 to image
            RestRequest req = new RestRequest("/api/pos/goods/" + Id + "/image", Method.Get)
                                    .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"]);

            var photo = Utils.RestClientUtils.client.DownloadDataAsync(req).GetAwaiter().GetResult();
            if (photo is null)
            {
                icon  = Properties.Resources._default;
            }
            else 
            {
                using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
                {
                    
                    ms.Write(photo, 0, photo.Length);

                    // convert image to bitmap
                    icon = new Bitmap(ms);
                }
            }
            GoodsPic.Image = icon;
        }
        private Bitmap icon;


        private void UserIconPic_MouseHover(object sender, EventArgs e)
        {

            GoodsPic.Image = Properties.Resources.photo_upload;
        }

        private void UserIconPic_MouseLeave(object sender, EventArgs e)
        {
            GoodsPic.Image = icon;
        }

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
            if (!txtDescription.Texts.Equals(txtDescription.Placeholder) && !txtDescription.Texts.Equals(Description))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Description",
                        Value = txtDescription.Texts
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

            if (!cbxSize.SelectedItem.Equals(Size))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Size",
                        Value = cbxSize.SelectedIndex.ToString()
                    }
                );
            }

            if (!cbxStatus.SelectedItem.Equals(Status))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "Status",
                        Value = cbxStatus.SelectedIndex.ToString()
                    }
                );
            }

            if(!cbxCatalogue.SelectedItem.Equals(CatName))
            {
                UpdateContent.Add(
                    new { 
                        Attribute = "_catalogueId",
                        Value = catList[cbxCatalogue.SelectedIndex]
                    }
                );
            }

            con.Update(Id, UpdateContent);

            if (GoodsPic.Image != Properties.Resources._default)
            {

                MemoryStream ms = new MemoryStream();
                GoodsPic.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Gif);
                byte[] image = ms.ToArray();
                RestRequest req = new RestRequest("/api/pos/goods/" + Id + "/image", Method.Post)
                                    .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"])
                                    .AddBody(image);

                var result = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
                Console.WriteLine(result.Content);
                Console.WriteLine(result.StatusCode);
            }

            this.OnExit.Invoke();
            this.Close();
            this.Dispose();


        }

        private void UserIconPic_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                icon = new Bitmap(open.FileName);
                // display image in picture box  
                GoodsPic.Image = icon;
                // image file path  
                string imgName = open.FileName;
                isUpload = true;
            }
        }

        private void userNameTxt_Click(object sender, EventArgs e)
        {
        }

        // leave
        private void pwdTxt_Enter(object sender, EventArgs e)
        {
        }

        private void pwdTxt2_Leave(object sender, EventArgs e)
        {
        }

        private void UpdatePwdStrength()
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

        private void StaffIDTxt_Leave(object sender, EventArgs e)
        {

        }
    }
}
