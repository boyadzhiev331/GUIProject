using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Processors
{
    public class ResizeRotateHandler
    {
        public GraphicsPath Path { get; set; }

        public List<Rectangle> Rectangles { get; set; }

        public ResizeRotateHandler(Size size, Point location)
        {
            this.Rectangles = new List<Rectangle>();

            Rectangles.Add(new Rectangle(location.X - 6, location.Y - 6, 6, 6));
            Rectangles.Add(new Rectangle(size.Width + location.X, location.Y - 6, 6, 6));
            Rectangles.Add(new Rectangle(size.Width + location.X, size.Height + location.Y, 6, 6));
            Rectangles.Add(new Rectangle(location.X - 6, size.Height + location.Y, 6, 6));
            Rectangles.Add(new Rectangle(size.Width + location.X - size.Width / 2 - 3, location.Y - 6, 6, 6));
            Rectangles.Add(new Rectangle(size.Width + location.X, size.Height + location.Y - size.Height / 2 - 3, 6, 6));
            Rectangles.Add(new Rectangle(size.Width + location.X - size.Width / 2 - 5, size.Height + location.Y, 6, 6));
            Rectangles.Add(new Rectangle(location.X - 6, size.Height + location.Y - size.Height / 2 - 3, 6, 6));

            this.Path = new GraphicsPath();
            Path.AddArc(size.Width + location.X + 6, location.Y - 12, 6, 6, 185, 275);
            Path.AddLine(size.Width + location.X + 9, location.Y - 6, size.Width + location.X + 14, location.Y - 6);
            Path.AddLine(size.Width + location.X + 9, location.Y - 6, size.Width + location.X + 9, location.Y - 10);
        }

        public void Draw(Graphics g, bool isActive)
        {
            if (isActive)
            {
                foreach (Rectangle item in Rectangles)
                {
                    g.DrawRectangle(new Pen(Color.DarkRed), item);
                    g.DrawPath(new Pen(Color.DarkRed), Path);
                }
            }
            else
            {
                foreach (Rectangle item in Rectangles)
                {
                    g.DrawRectangle(new Pen(Color.Black), item);
                }
            }
        }

        public int ContainsPoint(Point point)
        {
            foreach (Rectangle item in Rectangles)
            {
                if (item.Contains(point))
                {
                    return Rectangles.IndexOf(item);
                }
            }

            if (Path.GetBounds().Contains(point))
            {
                return 8;
            }

            return -1;
        }
    }
}
