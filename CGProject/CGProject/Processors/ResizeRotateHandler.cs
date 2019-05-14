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

            Rectangles.Add(new Rectangle(location.X - 5, location.Y - 5, 5, 5));
            Rectangles.Add(new Rectangle(size.Width + location.X, location.Y - 5, 5, 5));
            Rectangles.Add(new Rectangle(size.Width + location.X, size.Height + location.Y, 5, 5));
            Rectangles.Add(new Rectangle(location.X - 5, size.Height + location.Y, 5, 5));
            Rectangles.Add(new Rectangle(size.Width + location.X - size.Width / 2 - 3, location.Y - 5, 5, 5));
            Rectangles.Add(new Rectangle(size.Width + location.X, size.Height + location.Y - size.Height / 2 - 3, 5, 5));
            Rectangles.Add(new Rectangle(size.Width + location.X - size.Width / 2 - 5, size.Height + location.Y, 5, 5));
            Rectangles.Add(new Rectangle(location.X - 5, size.Height + location.Y - size.Height / 2 - 3, 5, 5));

            this.Path = new GraphicsPath();
            Path.AddArc(size.Width + location.X + 5, location.Y - 10, 5, 5, 160, 250);
            Path.AddLine(size.Width + location.X + 8, location.Y - 5, size.Width + location.X + 13, location.Y - 5);
            Path.AddLine(size.Width + location.X + 8, location.Y - 5, size.Width + location.X + 8, location.Y - 9);
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
