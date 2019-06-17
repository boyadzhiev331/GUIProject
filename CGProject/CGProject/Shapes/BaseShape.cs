using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Shapes
{
    [Serializable]
    public abstract class BaseShape
    {
        public Size Size { get; set; }
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int Opacity { get; set; }
        public string Name { get; set; }
        public MyMatrix AMatrix { get; set; }

        public BaseShape(Size size, Point location, Color color, int opacity, string name)
        {
            this.Size = size;
            this.Location = location;
            this.Color = color;
            this.Opacity = opacity;
            this.Name = name;
            AMatrix = new MyMatrix();
        }

    }
}
