using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace TheBetterLimited_ManagementSystem.Lib.Toolkit
{
    public class Render
    {
        SmoothingMode smoothingMode = SmoothingMode.AntiAlias; // 消鋸齒

        public static readonly Render instance = new Render();
        private Render() { }

        public Render DrawRoundRect(Rectangle rect, int radius, Graphics g, Color c , int size)
        {
            using (Pen pen = new Pen(c, size))
            {
                g.DrawPath(pen, Render.ToRoundedRect(rect, radius));
            }
            return instance;
        }

        public Render FillRoundRect(Rectangle rect, int radius, Graphics g, Color c)
        {
            using (Brush brush = new SolidBrush(c))
            {
                g.FillPath(brush, Render.ToRoundedRect(rect, radius));
            }
            return instance;
        }

        // https://stackoverflow.com/questions/33853434/how-to-draw-a-rounded-rectangle-in-c-sharp
        public static GraphicsPath ToRoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static GraphicsPath ToRoundedRect(Rectangle bounds, int radius1, int radius2, int radius3, int radius4)
        {
            int diameter1 = radius1 * 2;
            int diameter2 = radius2 * 2;
            int diameter3 = radius3 * 2;
            int diameter4 = radius4 * 2;

            Rectangle arc1 = new Rectangle(bounds.Location, new Size(diameter1, diameter1));
            Rectangle arc2 = new Rectangle(bounds.Location, new Size(diameter2, diameter2));
            Rectangle arc3 = new Rectangle(bounds.Location, new Size(diameter3, diameter3));
            Rectangle arc4 = new Rectangle(bounds.Location, new Size(diameter4, diameter4));
            GraphicsPath path = new GraphicsPath();

            // top left arc  
            if (radius1 == 0)
            {
                path.AddLine(arc1.Location, arc1.Location);
            }
            else
            {
                path.AddArc(arc1, 180, 90);
            }

            // top right arc  
            arc2.X = bounds.Right - diameter2;
            if (radius2 == 0)
            {
                path.AddLine(arc2.Location, arc2.Location);
            }
            else
            {
                path.AddArc(arc2, 270, 90);
            }

            // bottom right arc  

            arc3.X = bounds.Right - diameter3;
            arc3.Y = bounds.Bottom - diameter3;
            if (radius3 == 0)
            {
                path.AddLine(arc3.Location, arc3.Location);
            }
            else
            {
                path.AddArc(arc3, 0, 90);
            }

            // bottom left arc 
            arc4.X = bounds.Right - diameter4;
            arc4.Y = bounds.Bottom - diameter4;
            arc4.X = bounds.Left;
            if (radius4 == 0)
            {
                path.AddLine(arc4.Location, arc4.Location);
            }
            else
            {
                path.AddArc(arc4, 90, 90);
            }

            path.CloseFigure();
            return path;
        }

        public Render DrawRect(Rectangle rect , Graphics g , Color c , float width = 1)
        {
            using (Pen p = new Pen(c , width))
            {
                g.DrawRectangle(p , rect);
            }
            return instance;
        }


        public Render FillRect(Rectangle rect, Graphics g, Color c)
        {
            using (SolidBrush sb = new SolidBrush(c))
            {
                g.FillRectangle(sb, rect);
            }
            return instance;
        }


        // Draw string
    
        public Render DrawString(string text , Graphics g,  int size, Color c,  RectangleF rect, StringFormat format)
        {
            using (Brush sb = new SolidBrush(c))
            {
                g.DrawString(text, new System.Drawing.Font(Font.StandardFont.FontFamily, size), sb , rect , format);
            }
            return instance;
        }

        public Render DrawString(string text, Graphics g,  int size, Color color, float x, float y, StringFormat format)
        {
            using (Brush br = new SolidBrush(color))
            {
                g.DrawString(text, new System.Drawing.Font(Font.StandardFont.FontFamily, size), br, x, y, format);
            }
            return instance;
        }

        public Render DrawString( string text , Graphics g, int size , Color color, RectangleF rect)
        {
            using (Brush br = new SolidBrush(color))
            {
                g.DrawString(text, new System.Drawing.Font(Font.StandardFont.FontFamily, size), br, rect);
            }
            return instance; 
        }

        

        public Render DrawString( string text , Graphics g, int size, Color color, float x, float y)
        {
            using (Brush br = new SolidBrush(color))
            {
                g.DrawString(text, new System.Drawing.Font(Font.StandardFont.FontFamily, size), br, x, y);
            }
            return instance;
        }

        public static void DrawString(string text, Graphics g, int size, Color color, Point pt)
        => instance.DrawString(text, g, size, color, pt.X, pt.Y);

        public static void DrawString(string text, Graphics g, int size, Color color, Point pt , StringFormat format)
       => instance.DrawString(text, g, size, color, pt.X, pt.Y , format);


        // Draw circle
        public Render DrawCircle(Graphics g , Color color , float centerX, float centerY, float radius)
        {
            using (Pen p = new Pen(color))
            {
                g.DrawEllipse(p, centerX - radius, centerY - radius,
                      radius + radius, radius + radius);
            }
            return instance;
        }

        public Render FillCircle(Graphics g, Color color, float centerX, float centerY, float radius)
        {
            using (Brush brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, centerX - radius, centerY - radius,
                      radius + radius, radius + radius);
            }
            return instance;
        }




    }
}
