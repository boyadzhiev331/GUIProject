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
    public class RectangleShape : BaseShape, IDrawable, ITransformable
    {
        public Color BorderColor { get; set; }

        public RectangleShape(Size size, Point location, Color color, Color borderColor, int opacity, string name) 
            :base(size, location, color, opacity, name)
        {
            this.BorderColor = borderColor;
        }

        public void Draw(Graphics g)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(this.Location, this.Size));
            path.Transform(this.AMatrix.CreateMatrix());

            g.FillPath(new SolidBrush(Color.FromArgb(Opacity, Color)), path);
            g.DrawPath(new Pen(Color.FromArgb(Opacity, BorderColor)), path);
        }

        public bool ContainsPoint(Point point)
        {
            return this.GetBounds().Contains(point);
        }

        public ITransformable CloneShape()
        {
            RectangleShape item = new RectangleShape(Size, Location, Color, BorderColor, Opacity, Name);

            Matrix _Matrix = item.AMatrix.CreateMatrix();
            _Matrix.Multiply(this.AMatrix.CreateMatrix());
            item.AMatrix.GetElements(_Matrix);

            return item;
        }

        public void Translate(int dX, int dY)
        {
            Matrix matrix = new Matrix();

            matrix.Translate(dX, dY);
            matrix.Multiply(this.AMatrix.CreateMatrix());

            this.AMatrix.GetElements(matrix);
        }

        public void SetFillColor(Color color)
        {
            this.Color = color;
        }

        public Rectangle GetBounds()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(this.Location, this.Size));
            path.Transform(this.AMatrix.CreateMatrix());

            return Rectangle.Round(path.GetBounds());
        }

        public void RotateShape(Point centerPoint, float angle)
        {
            Matrix firstMatrix = this.AMatrix.CreateMatrix();
            Matrix _Matrix = new Matrix();

            _Matrix.RotateAt(angle, centerPoint);
            _Matrix.Multiply(firstMatrix);
            this.AMatrix.GetElements(_Matrix);
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

        public void Transform(Matrix matrix)
        {
            matrix.Multiply(this.AMatrix.CreateMatrix());
            this.AMatrix.GetElements(matrix);
        }
    }
}
