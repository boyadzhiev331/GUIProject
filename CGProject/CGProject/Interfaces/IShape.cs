using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Interfaces
{
    public interface IShape
    {
        bool ContainsPoint(Point point);

        void SetFillColor(Color color);
    }
}
