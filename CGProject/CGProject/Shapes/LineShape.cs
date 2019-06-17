using CGProject.Interfaces;
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
    public class LineShape : IDrawable, ITransformable
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public int Opacity { get; set; }
        public string Name { get; set; }
        public MyMatrix AMatrix { get; set; }

        public LineShape(Point startPoint, Point endPoint, Color color, int opacity, string name)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Color = color;
            this.Opacity = opacity;
            this.Name = name;
            this.AMatrix = new MyMatrix();
        }

        public void Draw(Graphics g)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(StartPoint, EndPoint);
            path.Transform(this.AMatrix.CreateMatrix());

            g.DrawPath(new Pen(Color.FromArgb(Opacity, Color)), path);
        }

        public void Translate(int dX, int dY)
        {
            Matrix matrix = new Matrix();

            matrix.Translate(dX, dY);
            matrix.Multiply(this.AMatrix.CreateMatrix());
            this.AMatrix.GetElements(matrix);
        }

        public Rectangle GetBounds()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(StartPoint, EndPoint);
            path.Transform(this.AMatrix.CreateMatrix());

            return Rectangle.Round(path.GetBounds());
        }

        public void RotateShape(Point centerPoint, float angle)
        {
            //Matrix firstMatrix = this.AMatrix.CreateMatrix();
            Matrix _Matrix = new Matrix();

            _Matrix.RotateAt(angle, centerPoint);
            _Matrix.Multiply(this.AMatrix.CreateMatrix());
            this.AMatrix.GetElements(_Matrix);
        }

        public bool ContainsPoint(Point point)
        {
            return this.GetBounds().Contains(point);
        }

        public void SetFillColor(Color color)
        {
            this.Color = color;
        }

        public void ResizeShape(float dX, float dY, int RszRttNumber)
        {
            Rectangle item = Rectangle.Round(this.GetBounds());
            Matrix aMatrix = new Matrix();

            switch (RszRttNumber)
            {
                case 0:
                    {
                        if (((this.GetBounds().Size.Width - dX) > 2) && ((this.GetBounds().Size.Height - dY) > 2))
                        {
                            aMatrix.Scale(item.Size.Width / (dX + item.Size.Width), item.Size.Height / (dY + item.Size.Height));
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }

                case 1:
                    {
                        if (((this.GetBounds().Size.Width + dX) > 3) && ((this.GetBounds().Size.Height - dY) > 3))
                        {
                            aMatrix.Scale((dX + item.Size.Width) / item.Size.Width, item.Size.Height / (dY + item.Size.Height));
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate(item.Location.X - this.GetBounds().Location.X, (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }

                case 2:
                    {
                        if (((this.GetBounds().Size.Width + dX) > 2) && ((this.GetBounds().Size.Height + dY) > 2))
                        {
                            aMatrix.Scale((dX + item.Size.Width) / item.Size.Width, (dY + item.Size.Height) / item.Size.Height);
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate(item.Location.X - this.GetBounds().Location.X, item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 3:
                    {
                        if (((this.GetBounds().Size.Width - dX) > 2) && ((this.GetBounds().Size.Height + dY) > 2))
                        {
                            aMatrix.Scale(item.Size.Width / (dX + item.Size.Width), (dY + item.Size.Height) / item.Size.Height);
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 4:
                    {
                        if ((this.GetBounds().Size.Height - dY) > 2)
                        {
                            aMatrix.Scale(1, item.Size.Height / (dY + item.Size.Height));
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }

                case 5:
                    {
                        if ((this.GetBounds().Size.Width + dX) > 2)
                        {
                            aMatrix.Scale((dX + item.Size.Width) / item.Size.Width, 1);
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate(item.Location.X - this.GetBounds().Location.X, item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 6:
                    {
                        if ((this.GetBounds().Size.Height + dY) > 2)
                        {
                            aMatrix.Scale(1, (dY + item.Size.Height) / item.Size.Height);
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate(item.Location.X - this.GetBounds().Location.X, item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 7:
                    {
                        if ((this.GetBounds().Size.Width - dX) > 2)
                        {
                            aMatrix.Scale(item.Size.Width / (dX + item.Size.Width), 1);
                            aMatrix.Multiply(this.AMatrix.CreateMatrix());

                            this.AMatrix.GetElements(aMatrix);
                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }
            }
        }

        public void SetOpacity(int opacity)
        {
            this.Opacity = opacity;
        }

        public int GetOpacity()
        {
            return this.Opacity;
        }

        public ITransformable CloneShape()
        {
            LineShape item = new LineShape(StartPoint, EndPoint, Color, Opacity, Name);

            Matrix _Matrix = item.AMatrix.CreateMatrix();
            _Matrix.Multiply(this.AMatrix.CreateMatrix());
            item.AMatrix.GetElements(_Matrix);

            return item;
        }

        public void Transform(Matrix matrix)
        {
            matrix.Multiply(this.AMatrix.CreateMatrix());
            this.AMatrix.GetElements(matrix);
        }
    }
}
