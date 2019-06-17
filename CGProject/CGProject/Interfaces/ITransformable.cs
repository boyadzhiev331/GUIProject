using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Interfaces
{
    public interface ITransformable
    {
        ITransformable CloneShape();
        void RotateShape(Point centerPoint, float angle);
        void ResizeShape(float dX, float dY, int RszRttNumber);
        bool ContainsPoint(Point point);
        void Transform(Matrix matrix);
        void Translate(int dX, int dY);
        Rectangle GetBounds();
    }
}
