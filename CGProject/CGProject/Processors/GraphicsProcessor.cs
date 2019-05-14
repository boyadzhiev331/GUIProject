using CGProject.Interfaces;
using CGProject.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGProject.Processors
{
    public class GraphicsProcessor
    {
        public int Operation { get; set; }
        public int ResizeRotateNumber { get; set; }
        public Point MousePosition { get; set; }
        //public ArrayList Items { get; set; }
        public ArrayList ItemsInGroup { get; set; }
        public IDrawable SelectedItem { get; set; }
        public ResizeRotateHandler ResizeRotate { get; set; }

        #region Constructor
        public GraphicsProcessor(IDrawable selItem)
        {
            //this.Items = items;
            this.Operation = 0;
            this.SelectedItem = selItem;
        }
        #endregion

        #region Math operations for computing angle
        private double GetAngle(Point start, Point newP, Point center)
        {
            double temp = (GetLine(center, start) + GetLine(center, newP) + GetLine(newP, start)) / 2;

            double angle = Math.Sqrt((temp * (temp - GetLine(newP, start))) / (GetLine(center, start) * GetLine(center, newP)));

            double angleInDegrees = (2 * Math.Acos(angle)) * 180 / Math.PI;

            return angleInDegrees;
        }

        private double GetLine(Point start, Point end)
        {
            return Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
        }

        private double RotateAngle(Point start, Point newP, Point center)
        {
            double oldAngle = GetAngle(start, new Point(start.X, center.Y), center);
            double newAngle = GetAngle(newP, new Point(newP.X, center.Y), center);

            /*if (oldAngle >= 0 && newAngle >= 0)
            {
                if (center.X > newP.X)
                {
                    return newAngle - oldAngle;
                }
                else
                {
                    if (center.Y > newP.Y)
                    {
                        return oldAngle - newAngle;
                    }
                    else
                    {
                        return newAngle - oldAngle;
                    }
                }
            }
            return 0;*/

            if ((oldAngle >= 0) && (newAngle >= 0))
            {
                if (center.X > newP.X)
                {
                    if (center.Y > newP.Y)
                    {
                        return newAngle - oldAngle;
                    }
                    else
                    {
                        return oldAngle - newAngle;
                    }
                }
                else
                {
                    if (center.Y > newP.Y)
                    {
                        return oldAngle - newAngle;
                    }
                    else
                    {
                        return newAngle - oldAngle;
                    }
                }
            }
            return 0;
        }
        #endregion

        public void Draw(Graphics g)
        {
            bool isActive = false;

            if (SelectedItem != null)
            {
                isActive = true;
            }

            if(SelectedItem != null)
            {
                ResizeRotate = new ResizeRotateHandler(SelectedItem.GetBounds().Size, SelectedItem.GetBounds().Location);
                ResizeRotate.Draw(g, isActive);
            }

            

            if (isActive == false)
            {
                ResizeRotate = null;
            }
        }

        #region Mouse events
        public int MouseDownEvent(MouseEventArgs e)
        {
            this.MousePosition = new Point(e.X, e.Y);

            if (Operation == 0)
            {
                if (SelectedItem != null && this.ResizeRotate != null)
                {
                    //ResizeRotate = new ResizeRotateHandler(SelectedItem.GetBounds().Size, SelectedItem.GetBounds().Location);
                    ResizeRotateNumber = ResizeRotate.ContainsPoint(this.MousePosition);

                    if (ResizeRotateNumber != -1)
                    {
                        if (ResizeRotateNumber < 8)
                        {
                            Operation = 2;
                            return 2;
                        }
                        else
                        {
                            Operation = 3;
                            return 3;
                        }
                    }

                    SelectedItem = null;
                    return 1;
                }
            }

            return -1;
        }

        public bool MouseMoveEvent(MouseEventArgs e)
        {
            switch (Operation)
            {
                case 2:
                    {
                        //IDrawable item = (IDrawable)Items[0];

                        SelectedItem.ResizeShape(e.X - MousePosition.X, e.Y - MousePosition.Y, ResizeRotateNumber);
                        MousePosition = new Point(e.X, e.Y);
                        return true;
                    }
                case 3:
                    {
                        //IDrawable item = (IDrawable)Items[0];

                        if ((MousePosition.Y - e.Y) != 0)
                        {
                            float angle = (float)RotateAngle(new Point((int)MousePosition.X, (int)MousePosition.Y), new Point(e.X, e.Y), new Point(SelectedItem.GetBounds().Location.X + SelectedItem.GetBounds().Size.Width / 2, SelectedItem.GetBounds().Location.Y + SelectedItem.GetBounds().Size.Height / 2));

                            SelectedItem.RotateShape(new Point(SelectedItem.GetBounds().Location.X + SelectedItem.GetBounds().Size.Width / 2, SelectedItem.GetBounds().Location.Y + SelectedItem.GetBounds().Size.Height / 2), angle);

                            MousePosition = new Point(e.X, e.Y);
                        }
                        return true;
                    }
            }
            return false;
        }

        public void MouseUpEvent()
        {
            this.Operation = 0;
        }
        #endregion
    }
}
