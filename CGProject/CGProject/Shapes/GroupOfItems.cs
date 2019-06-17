using CGProject.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGProject.Shapes
{
    [Serializable]
    public class GroupOfItems : IDrawable, ITransformable 
    {
        public List<ITransformable> Items { get; set; }
        public int Opacity { get; set; }
        public string Name { get; set; }

        public GroupOfItems(int opacity, string name)
        {
            this.Opacity = opacity;
            this.Name = name;
            this.Items = new List<ITransformable>();
        }

        public bool ContainsPoint(Point point)
        {
            return this.GetBounds().Contains(point);
        }

        public void SetFillColor(Color color)
        {
        }

        public void Translate(int dX, int dY)
        {
            foreach (ITransformable item in Items)
            {
                item.Translate(dX, dY);
            }
        }

        public void Draw(Graphics g)
        {
            foreach (IDrawable item in Items)
            {
                item.Draw(g);
            }
        }

        public Rectangle GetBounds()
        {
            Point location = new Point(1000, 1000);
            Point size = new Point(0, 0);

            foreach (ITransformable item in Items)
            {
                if (location.X > item.GetBounds().Location.X)
                {
                    location.X = item.GetBounds().Location.X;
                }
                if (location.Y > item.GetBounds().Location.Y)
                {
                    location.Y = item.GetBounds().Location.Y;
                }

                if (size.X < (item.GetBounds().Location.X + item.GetBounds().Size.Width))
                {
                    size.X = item.GetBounds().Location.X + item.GetBounds().Size.Width;
                }
                if (size.Y < (item.GetBounds().Location.Y + item.GetBounds().Size.Height))
                {
                    size.Y = item.GetBounds().Location.Y + item.GetBounds().Size.Height;
                }
            }

            return new Rectangle(location, new Size(size.X - location.X, size.Y - location.Y));
        }

        public void SetOpacity(int opacity)
        {
            this.Opacity = opacity;
            foreach (IDrawable item in this.Items)
            {
                item.SetOpacity(opacity);
            }
        }

        public int GetOpacity()
        {
            return this.Opacity;
        }

        public void RotateShape(Point centerPoint, float angle)
        {
            foreach (ITransformable item in Items)
            {
                item.RotateShape(centerPoint, angle);
            }
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

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }

                case 1:
                    {
                        if (((this.GetBounds().Size.Width + dX) > 3) && ((this.GetBounds().Size.Height - dY) > 3))
                        {
                            aMatrix.Scale((dX + item.Size.Width) / item.Size.Width, item.Size.Height / (dY + item.Size.Height));

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate(item.Location.X - this.GetBounds().Location.X, (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }

                case 2:
                    {
                        if (((this.GetBounds().Size.Width + dX) > 2) && ((this.GetBounds().Size.Height + dY) > 2))
                        {
                            aMatrix.Scale((dX + item.Size.Width) / item.Size.Width, (dY + item.Size.Height) / item.Size.Height);

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate(item.Location.X - this.GetBounds().Location.X, item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 3:
                    {
                        if (((this.GetBounds().Size.Width - dX) > 2) && ((this.GetBounds().Size.Height + dY) > 2))
                        {
                            aMatrix.Scale(item.Size.Width / (dX + item.Size.Width), (dY + item.Size.Height) / item.Size.Height);

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 4:
                    {
                        if ((this.GetBounds().Size.Height - dY) > 2)
                        {
                            aMatrix.Scale(1, item.Size.Height / (dY + item.Size.Height));

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }

                case 5:
                    {
                        if ((this.GetBounds().Size.Width + dX) > 2)
                        {
                            aMatrix.Scale((dX + item.Size.Width) / item.Size.Width, 1);

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate(item.Location.X - this.GetBounds().Location.X, item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 6:
                    {
                        if ((this.GetBounds().Size.Height + dY) > 2)
                        {
                            aMatrix.Scale(1, (dY + item.Size.Height) / item.Size.Height);

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate(item.Location.X - this.GetBounds().Location.X, item.Location.Y - this.GetBounds().Location.Y);
                        }

                        return;
                    }

                case 7:
                    {
                        if ((this.GetBounds().Size.Width - dX) > 2)
                        {
                            aMatrix.Scale(item.Size.Width / (dX + item.Size.Width), 1);

                            foreach (ITransformable _item in this.Items)
                            {
                                Matrix transformMatrix = new Matrix();
                                transformMatrix.Multiply(aMatrix);

                                _item.Transform(transformMatrix);
                            }

                            this.Translate((item.Location.X + item.Size.Width) - (this.GetBounds().Location.X + this.GetBounds().Size.Width), (item.Location.Y + item.Size.Height) - (this.GetBounds().Location.Y + this.GetBounds().Size.Height));
                        }

                        return;
                    }
            }
        }

        public ITransformable CloneShape()
        {
            throw new NotImplementedException();
        }

        public void Transform(Matrix matrix)
        {
            throw new NotImplementedException();
        }
    }
}
