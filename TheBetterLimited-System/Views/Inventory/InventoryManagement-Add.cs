using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TheBetterLimited_System.Controller;
using RestSharp;
using Newtonsoft.Json.Linq;
namespace TheBetterLimited.Views
{
    public partial class Inventorymanagement_Add : Form
    {
        private bool isUpload = false;
        private ControllerBase con = new ControllerBase("Catalogue");
        private ControllerBase GoodsCon = new ControllerBase("Goods");
        private Bitmap icon = Properties.Resources._default;

        public Inventorymanagement_Add()
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
                txtGoodsName.BorderColor = Color.Red;
                return;
            }
            txtGoodsName.BorderColor = Color.LightGray;

            if (cbxCatalogue.SelectedItem == null)
            {
                cbxCatalogue.BorderColor = Color.Red;
                return;
            }
            cbxCatalogue.BorderColor = Color.LightGray;

            if (txtDescription.Texts == txtDescription.Placeholder)
            {
                txtDescription.BorderColor = Color.Red;
                return;
            }
            txtDescription.BorderColor = Color.LightGray;

            if (txtPrice.Texts == txtPrice.Placeholder)
            {
                txtPrice.BorderColor = Color.Red;
                return;
            }
            txtPrice.BorderColor = Color.LightGray;

            if (txtGTINCode.Texts == txtGTINCode.Placeholder)
            {
                txtGTINCode.BorderColor = Color.Red;
                return;
            }
            txtGTINCode.BorderColor = Color.LightGray;

            if (cbxSize.SelectedItem == null)
            {
                cbxSize.BorderColor = Color.Red;
                return;
            }
            cbxSize.BorderColor = Color.LightGray;

            if (cbxStatus.SelectedItem == null)
            {
                cbxStatus.BorderColor = Color.Red;
                return;
            }
            cbxStatus.BorderColor = Color.LightGray;

            GoodsCon.Create(new
            {
                Name = txtGoodsName.Texts,
                _catalogueId = cbxCatalogue.SelectedIndex + 1 + "00",
                Description = txtDescription.Texts,
                Price = txtPrice.Texts,
                GTINCode = txtGTINCode.Texts,
                Size = cbxSize.SelectedItem.ToString(),
                Status = cbxStatus.SelectedItem.ToString()
            });

            MessageBox.Show("Goods Created");
            OnExit.Invoke();
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



        public event Action OnExit;


        

      

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.OnExit.Invoke();
            this.Close();
            this.Dispose();
        }


        private void UserIconPic_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(GoodsPic.ClientRectangle);
            Region region = new Region(gp);
            GoodsPic.Region = region;
            Pen pen = new Pen(Color.White, 10);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, gp);
            gp.Dispose();
            region.Dispose();
            pen.Dispose();
        }

    }
}
