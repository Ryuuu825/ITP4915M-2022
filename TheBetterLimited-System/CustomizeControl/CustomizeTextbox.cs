using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBetterLimited.CustomizeControl
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomizeTextbox : UserControl
    {
        //Fields
        private Color borderColor = Color.LightGray;
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.Black;
        private Color tbBackColor = Color.Red;
        private bool isFocused = false;
        private bool isError = false;
        private int borderRadius = 0;
        private string placeholder = "";
        private bool passwordChar = false;
        public enum TextAlignEnum { Left, Right, Center }
        private TextAlignEnum textAlign = TextAlignEnum.Left;
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
                this.Resize += new EventHandler(Textbox_Resize);
            }
        }
        private void UpdateTextForeColor()
        {
            if (textBox1.Text.Equals(placeholder))
            {
                textBox1.ForeColor = Color.LightGray;
            }else
            {
                textBox1.ForeColor = this.ForeColor;
            }
        }

        public bool IsError
        {
            get { return isError; }
            set
            {
                isError = value;
                textBox1.UseSystemPasswordChar = PasswordChar;
                this.Invalidate();
            }
        }
        public TextAlignEnum TextAlign
        {
            get
            {
                return textAlign;
            }
            set
            {
                textAlign = value;
                switch (textAlign)
                {
                    case TextAlignEnum.Center:
                        textBox1.TextAlign = HorizontalAlignment.Center;
                        break;
                    case TextAlignEnum.Left:
                        textBox1.TextAlign = HorizontalAlignment.Left;
                        break;
                    case TextAlignEnum.Right:
                        textBox1.TextAlign = HorizontalAlignment.Right;
                        break;
                }
                this.Invalidate();
            }
        }

        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                textBox1.Text = placeholder;
                textBox1.ForeColor = Color.LightGray;
                this.Invalidate();
            }
        }



        public int MaxLength
        {
            get { return textBox1.MaxLength; }
            set { textBox1.MaxLength = value; }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public bool PasswordChar
        {
            get { return passwordChar; }
            set
            {
                passwordChar = value;
                this.Invalidate();
            }
        }
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        public bool ReadOnly
        {
            get { return textBox1.ReadOnly; }
            set
            {
                textBox1.ReadOnly = value;
                this.Invalidate();
            }
        }

        public Color TbBackColor
        {
            get { return textBox1.BackColor; }
            set { textBox1.BackColor = value; }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
                this.Invalidate ();
            }
        }
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        public CustomizeTextbox()
        {
            InitializeComponent();

        }
        public event EventHandler _TextChanged;
        //TextBox-> TextChanged event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void Textbox_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

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
            if (borderRadius > 1) //Rounded button
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
                    if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color
                    if (isError) penBorder.Color = Color.Red;//Set Border color in focus. Otherwise, normal border color
                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Normal button
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
                        if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color
                        if (underlinedStyle) //Line Style
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        else //Normal Style
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 1F, this.Height - 1F);
                        }
                    }
                }
            }

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            UpdateTextForeColor();
        }

        public event EventHandler _Enter;
        //Change border color in focus mode
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
                _Enter.Invoke(sender, e);
            isFocused = true;
            textBox1.ForeColor = this.ForeColor;
            if (Texts.Equals(placeholder))
            {
                Texts = "";
            }
            else
            {
                Texts = textBox1.Text;
            }
            if (passwordChar == true) textBox1.UseSystemPasswordChar = true;
            this.Invalidate();
        }
        public event EventHandler _Leave;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
                _Leave.Invoke(sender, e);
            isFocused = false;
            if (Texts.Equals(""))
            {
                textBox1.Text = placeholder;

                textBox1.ForeColor = Color.LightGray;
            }
            else
            {
                Texts = textBox1.Text;
            }
            if (passwordChar == false)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else if (textBox1.Text.Equals(placeholder))
            {
                textBox1.UseSystemPasswordChar = false;
            }else
            {
                textBox1.UseSystemPasswordChar = true;
            }
            this.Invalidate();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}
