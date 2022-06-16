using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TheBetterLimited_System.Controller;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace TheBetterLimited.Views
{
    public partial class Goods_Add : Form
    {
        private bool isUpload = false;
        private ControllerBase con = new ControllerBase("Catalogue");
        private ControllerBase GoodsCon = new ControllerBase("pos/goods");
        private ControllerBase SupplierCon = new ControllerBase("Supplier");
        private Bitmap icon = Properties.Resources.photo_upload;
        private List<_supplier> suppliersList = new List<_supplier>();

        private class _supplier 
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public Goods_Add()
        {
            InitializeComponent();
            RestResponse result = con.GetAll();
            JArray catRes = JArray.Parse(result.Content);
            foreach( var cat in catRes)
            {
                cbxCatalogue.Items.Add(cat["Name"].ToString());
                cbxCatalogue.AutoCompleteCustomSource.Add(cat["Name"].ToString());
            }

            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");

            cbxStatus.Items.Add("Selling");
            cbxStatus.Items.Add("PhasingOut");
            cbxStatus.Items.Add("StopSelling");

            var suppliers = JArray.Parse(SupplierCon.GetAll().Content);
            Console.WriteLine(SupplierCon.GetAll().Content);
            foreach(var supplier in suppliers)
            {
                suppliersList.Add(
                    new _supplier{
                        Id = supplier["ID"].ToString(),
                        Name = supplier["Name"].ToString()
                    }
                );
                cbxSupplier.Items.Add(supplier["Name"].ToString());
                cbxSupplier.AutoCompleteCustomSource.Add(supplier["Name"].ToString());
            }


        }

        private void UserIconPic_MouseHover(object sender, EventArgs e)
        {

            GoodsPic.Image = Properties.Resources.photo_upload;
        }

        private void UserIconPic_MouseLeave(object sender, EventArgs e)
        {
            GoodsPic.Image = icon;
        }


       

        private void CreateUser_Click(object sender, EventArgs e)
        {
            //check 
            if (txtGoodsName.Texts == txtGoodsName.Placeholder)
            {
                txtGoodsName.IsError = true;
                return;
            }

            if (cbxCatalogue.SelectedItem == null)
            {
                cbxCatalogue.BorderColor = Color.Red;
                return;
            }

            if (txtDescription.Texts == txtDescription.Placeholder)
            {
                txtDescription.IsError = true;
                return;
            }

            if (txtPrice.Texts == txtPrice.Placeholder)
            {
                txtPrice.IsError = true;
                return;
            }

            if (txtGTINCode.Texts == txtGTINCode.Placeholder)
            {
                txtGTINCode.IsError = true;
                return;
            }

            if (cbxSize.SelectedItem == null)
            {
                cbxSize.BorderColor = Color.Red;
                return;
            }

            if (cbxStatus.SelectedItem == null)
            {
                cbxStatus.BorderColor = Color.Red;
                return;
            }

            var re = GoodsCon.Create(new
            {
                Name = txtGoodsName.Texts,
                _catalogueId = cbxCatalogue.SelectedIndex + 1 + "00",
                Description = txtDescription.Texts,
                Price = txtPrice.Texts,
                GTINCode = txtGTINCode.Texts,
                Size = cbxSize.SelectedItem.ToString(),
                Status = cbxStatus.SelectedItem.ToString(),
                supplierId =  suppliersList[cbxSupplier.SelectedIndex].Id
            });
            string id = re.Content.ToString().Replace("\"", "");
            Console.WriteLine(re.Content);

            // upload photo
            if (isUpload)
            {

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                GoodsPic.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                byte[] image = ms.ToArray();
                RestRequest req = new RestRequest("/api/pos/goods/" + id + "/image", Method.Post)
                                    .AddHeader("Authorization", "Bearer " + Models.GlobalsData.currentUser["token"])
                                    .AddBody(image);
                var result = Utils.RestClientUtils.client.ExecuteAsync(req).GetAwaiter().GetResult();
                Console.WriteLine(result.Content);
                ms.Close();
            }

            if (re.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Goods Created");
                OnExit.Invoke();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error");
            }
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



        public event Action OnExit;


        

      

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }

        private void txtGoodsName_Click(object sender, EventArgs e)
        {
            txtGoodsName.IsError = false;
        }

        private void cbxCatalogue_Click(object sender, EventArgs e)
        {
            cbxCatalogue.BorderColor = Color.LightGray;
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            txtDescription.IsError = false;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.IsError = false;
        }

        private void txtGTINCode_Click(object sender, EventArgs e)
        {
            txtGTINCode.IsError = false;
        }

        private void cbxSize_Click(object sender, EventArgs e)
        {
            cbxSize.BorderColor = Color.LightGray;
        }

        private void cbxStatus_Click(object sender, EventArgs e)
        {
            cbxStatus.BorderColor = Color.LightGray;
        }

    }
}
