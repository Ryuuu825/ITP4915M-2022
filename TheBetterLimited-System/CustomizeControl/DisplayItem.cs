using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBetterLimited.CustomizeControl
{
    public partial class DisplayItem : UserControl
    {
        private Bitmap image;
        private double productPrice = 0.0;
        private int borderSize = 2;
        private int borderRadius = 0;
        private bool isSelected = false;
        private Color borderSelectedColor = Color.Black;
        private Color borderColor = Color.LightGray;
        private string title = "";
        public DisplayItem()
        {
            InitializeComponent();
        }

        public Bitmap Image { get => image; set { image = value; pictureBox1.Image = image; this.Invalidate(); } }
        public double ProductPrice { get => productPrice; set { productPrice = value; Price.Text = String.Format("{0:C2}",productPrice); this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        public bool IsSelected { get => isSelected; set { isSelected = value; this.Invalidate(); } }
        public Color BorderSelectedColor { get => borderSelectedColor; set { borderSelectedColor = value; this.Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public string Title { get => title; set { title = value; ProductNameTxt.Text = title; this.Invalidate(); } }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 1;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 1) //Rounded Product Box
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Pen penResetBorder = new Pen(this.Parent.BackColor, borderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                    //textbox surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    //e.Graphics.DrawPath(penSurface, pathSurface);
                    e.Graphics.DrawPath(penResetBorder, pathBorder);
                    //textbox border                    
                    if (borderSize >= 1)
                        //Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    if (isSelected) penBorder.Color = borderSelectedColor;//Set Border color in focus. Otherwise, normal border color
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal Product Box
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                        if (isSelected) penBorder.Color = borderSelectedColor;//Set Border color in focus. Otherwise, normal border color
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 1F, this.Height - 1F);
                    }
                }
            }
        }

        public event EventHandler PicInfoClicked;
        private void PicBox_Click(object sender, EventArgs e)
        {
            if (PicInfoClicked != null)
                PicInfoClicked(sender, new EventArgs());
            isSelected = isSelected == false ? true:false;
            this.Invalidate();
        }
    }
}
