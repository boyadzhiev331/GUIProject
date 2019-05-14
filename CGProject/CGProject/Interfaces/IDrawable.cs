using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Interfaces
{
    public interface IDrawable
    {
        void Draw(Graphics g);

        Rectangle GetBounds();

        void SetOpacity(int opacity);
        int GetOpacity();

        IDrawable CloneShape();

        void RotateShape(Point centerPoint, float angle);

        void ResizeShape(float dX, float dY, int RszRttNumber);
    }
}
