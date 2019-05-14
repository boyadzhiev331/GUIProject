using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Shapes
{
    public class MyMatrix
    {
        public float A11 { get; set; }
        public float A12 { get; set; }
        public float A21 { get; set; }
        public float A22 { get; set; }
        public float dX { get; set; }
        public float dY { get; set; }

        public MyMatrix()
        {
            A11 = 1;
            A12 = 0;
            A21 = 0;
            A22 = 1;
            dX = 0;
            dY = 0;
        }

        public Matrix CreateMatrix()
        {
            return new Matrix(A11, A12, A21, A22, dX, dY);
        }

        public void GetElements(Matrix transformMatrix)
        {
            A11 = transformMatrix.Elements[0];
            A12 = transformMatrix.Elements[1];
            A21 = transformMatrix.Elements[2];
            A22 = transformMatrix.Elements[3];
            dX = transformMatrix.Elements[4];
            dY = transformMatrix.Elements[5];
        }

        public void Translate(float dX, float dY)
        {
            Matrix transformMatrix = new Matrix(this.A11, this.A12, this.A21, this.A22, this.dX, this.dY);
            transformMatrix.Translate(dX, dY);
            GetElements(transformMatrix);
        }
    }
}
