using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Interfaces
{
    public interface IDrawable
    {
        string Name { get; set; }
        void Draw(Graphics g);
        void SetOpacity(int opacity);
        void SetFillColor(Color color);
        int GetOpacity();
    }
}
