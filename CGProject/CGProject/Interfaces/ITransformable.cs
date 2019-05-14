using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Interfaces
{
    public interface ITransformable
    {
        void Transform(Matrix matrix);
    }
}
