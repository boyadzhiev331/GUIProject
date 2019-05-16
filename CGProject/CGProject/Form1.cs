using CGProject.Dialogs;
using CGProject.Dialogs.About;
using CGProject.Interfaces;
using CGProject.Processors;
using CGProject.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGProject
{
    public partial class Form1 : Form
    {
        private Point point;
        public int ToggleSelection = -1;
        private IDrawable HelpSelectedItem = null;
        public IDrawable SelectedItem = null;
        public List<IDrawable> Items = new List<IDrawable>();
        public GroupOfItems groupOfItems;
        private List<Point> Points = new List<Point>();
        private Point[] PointsToConvert;
        public GraphicsProcessor graphicsProcessor;
        public Point RectPoint1;
        public Point RectPoint2;
        private bool IsRectOrEll = false;
        private IDrawable copied;
        private FindItem findItemDialog = new FindItem();
        private GroupItems groupItemsDialog = new GroupItems();
        private CGProject.Dialogs.Help helpDialog = new CGProject.Dialogs.Help();
        private Antonio aboutAntonio = new Antonio();
        private Daniel aboutDaniel = new Daniel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphicsProcessor = new GraphicsProcessor(HelpSelectedItem);
            KeyPreview = true;
            findItemDialog.form = this;
            groupItemsDialog.form = this;
            DoubleBuffered = true;
            this.CustomRefresh();
        }

        public void CustomRefresh()
        {
            this.Refresh();

            if (SelectedItem != null)
            {
                OpacityChangeBtn.Enabled = true;
                OpacityChangeBtn.Value = SelectedItem.GetOpacity();
                deleteBtn.Enabled = true;
                if (SelectedItem.GetType().Name != "GroupOfItems")
                {
                    copyBtn.Enabled = true;
                }
            }
            else
            {
                OpacityChangeBtn.Enabled = false;
                OpacityChangeBtn.Value = 0;
                deleteBtn.Enabled = false;
                copyBtn.Enabled = false;
            }

            if (this.Items.Count > 0)
            {
                findItemBtn.Enabled = true;
            }
            else
            {
                findItemBtn.Enabled = false;
            }
            
            if (this.copied != null)
            {
                pasteBtn.Enabled = true;
            }
            else
            {
                pasteBtn.Enabled = false;
            }

            if (this.groupOfItems != null && SelectedItem != null && this.SelectedItem.GetType().Name == "GroupOfItems")
            {
                breakBtn.Enabled = true;
                groupBtn.Enabled = false;
                copyBtn.Enabled = false;
            }
            else
            {
                if (this.Items.Count > 1 && this.groupOfItems == null)
                {
                    groupBtn.Enabled = true;
                }
                else
                {
                    groupBtn.Enabled = false;
                }
                breakBtn.Enabled = false;
            }
        }
       
        private bool ConvertPoints()
        {
            if (Points.Count > 1)
            {
                int i = 0;
                PointsToConvert = new Point[Points.Count];
                foreach (Point item in Points)
                {
                    PointsToConvert[i] = item;
                    i++;
                }

                return true;
            }
            return false;
        }

        private void GetRectPoints(int X, int Y)
        {
            RectPoint1 = new Point(X, Y);
            RectPoint2 = new Point(X, Y);

            this.CustomRefresh();
        }

        public void ShapeDraw(int X, int Y)
        {
            Rectangle item;

            RectPoint2.X = X;
            RectPoint2.Y = Y;

            this.CustomRefresh();
            item = new Rectangle(Math.Min(RectPoint1.X, RectPoint2.X), Math.Min(RectPoint1.Y, RectPoint2.Y), Math.Max(RectPoint1.X, RectPoint2.X) - Math.Min(RectPoint1.X, RectPoint2.X), Math.Max(RectPoint1.Y, RectPoint2.Y) - Math.Min(RectPoint1.Y, RectPoint2.Y));
            if (IsRectOrEll)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(127, Color.Black)), item);
            }
            else
            {
                this.CreateGraphics().DrawEllipse(new Pen(Color.FromArgb(127, Color.Black)), item);
            }
        }

        private bool IsInRange(Point point, Point center)
        {
            Rectangle item = new Rectangle(center, new Size(6, 6));
            item.Offset(-3, -3);

            return item.Contains(point);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphicsProcessor.Draw(e.Graphics);

            foreach (IDrawable item in Items)
            {
                item.Draw(e.Graphics);
            }

            if (this.ConvertPoints())
            {
                e.Graphics.DrawLines(new Pen(Color.Blue), PointsToConvert);
            }
        }
        
        #region Buttons
        private void SelectBtn_Click(object sender, EventArgs e)
        {
            ToggleSelection = 1;
            label1.Text = "select";
        }

        private void DrawRectBtn_Click(object sender, EventArgs e)
        {
            ToggleSelection = 2;
            label1.Text = "draw a rectangle";
        }

        private void DrawEllipseBtn_Click(object sender, EventArgs e)
        {
            ToggleSelection = 3;
            label1.Text = "draw an ellipse";
        }

        private void ChangeClrBtn_Click(object sender, EventArgs e)
        {
            ToggleSelection = 4;
            label1.Text = "choose a shape";
        }

        private void DrawLineBtn_Click(object sender, EventArgs e)
        {
            ToggleSelection = 5;
            Points.Clear();
            label1.Text = "draw a line";
            this.CustomRefresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DrawPolygonBtn_Click(object sender, EventArgs e)
        {
            ToggleSelection = 6;
            label1.Text = "draw a polygon";
        }

        private void DrawCurveBtn_Click(object sender, EventArgs e)
        {
            ToggleSelection = 7;
            label1.Text = "draw a curve";
        }
        private void OpacityChangeBtn_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                SelectedItem.SetOpacity((int)OpacityChangeBtn.Value);
                this.CustomRefresh();
            }
        }
        private void GroupBtn_Click(object sender, EventArgs e)
        {
            GroupToolStripMenuItem_Click(sender, e);
        }
        private void BreakBtn_Click(object sender, EventArgs e)
        {
            BreakToolStripMenuItem_Click(sender, e);
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            CopyToolStripMenuItem_Click(sender, e);
        }
        private void PasteBtn_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(sender, e);
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteToolStripMenuItem_Click(sender, e);
        }

        private void FindItemBtn_Click(object sender, EventArgs e)
        {
            FindItemToolStripMenuItem_Click(sender, e);
        }
        #endregion
        
        #region Mouse events

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.point.X = e.X;
            this.point.Y = e.Y;
            graphicsProcessor.MouseDownEvent(e);
            switch (ToggleSelection)
            {
                case 0:
                    {
                        if (graphicsProcessor.MouseDownEvent(e) == 0)
                        {
                            GetRectPoints(e.X, e.Y);
                        }
                        this.CustomRefresh();
                        break;
                    }
                case 1:
                    {
                        foreach (IDrawable item in Items)
                        {
                            if (item.GetBounds().Contains(new Point(e.X, e.Y)))
                            {
                                HelpSelectedItem = item;
                                SelectedItem = HelpSelectedItem;
                                label1.Text = item.GetType().Name;
                                graphicsProcessor.SelectedItem = SelectedItem;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        GetRectPoints(e.X, e.Y);
                        IsRectOrEll = true;
                        ToggleSelection = 0;
                        //if (Items.Count > 1) { graphicsProcessor.MouseDownEvent(e); }
                        break;
                    }
                case 3:
                    {
                        GetRectPoints(e.X, e.Y);
                        IsRectOrEll = false;
                        ToggleSelection = 0;
                        //if (Items.Count > 1) { graphicsProcessor.MouseDownEvent(e); }
                        break;
                    }
                case 4:
                    {
                        foreach (IDrawable item in Items)
                        {
                            if (item is IShape)
                            {
                                if (((IShape)item).ContainsPoint(new Point(e.X, e.Y)))
                                {
                                    HelpSelectedItem = item;
                                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                                    {
                                        if (HelpSelectedItem.GetType().Name == "GroupOfItems")
                                        {
                                            foreach (IShape x in this.groupOfItems.Items)
                                            {
                                                ((IShape)x).SetFillColor(colorDialog1.Color);
                                                HelpSelectedItem = null;
                                                this.CustomRefresh();
                                            }
                                        }
                                        else
                                        {
                                            ((IShape)HelpSelectedItem).SetFillColor(colorDialog1.Color);
                                            HelpSelectedItem = null;
                                            this.CustomRefresh();
                                        }
                                    }
                                }
                            }
                        }
                        ToggleSelection = 1;
                        break;
                    }
                case 5:
                    {
                        Points.Clear();
                        Points.Add(new Point(e.X, e.Y));
                        Points.Add(new Point(e.X, e.Y));
                        break;
                    }
                case 6:
                    {
                        if ((Points.Count > 1) && (IsInRange(new Point(e.X, e.Y), PointsToConvert[0])))
                        {
                            Points.Add(new Point(PointsToConvert[0].X, PointsToConvert[0].Y));
                            IDrawable item = new PolygonShape(new List<Point>(Points), Color.Transparent, Color.Black, 255);
                            Items.Add(item);
                            ToggleSelection = 1;
                            SelectedItem = item;
                            graphicsProcessor.SelectedItem = SelectedItem;
                            Points.Clear();
                        }
                        else
                        {
                            Points.Add(new Point(e.X, e.Y));
                        }
                        graphicsProcessor.MouseDownEvent(e);
                        this.CustomRefresh();
                        break;
                    }
                case 7:
                    {
                        Points.Add(new Point(e.X, e.Y));
                        this.CustomRefresh();
                        break;
                    }
            }

            this.CustomRefresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (graphicsProcessor.MouseMoveEvent(e))
            {
                this.CustomRefresh();
            }
            else
            {
                switch (ToggleSelection)
                {
                    case 0:
                        {
                            ShapeDraw(e.X, e.Y);
                            break;
                        }
                    case 5:
                        {
                            if (Points.Count > 1)
                            {
                                Points.RemoveAt(1);
                            }
                            Points.Add(new Point(e.X, e.Y));
                            this.CustomRefresh();
                            break;
                        }
                    case 6:
                        {
                            Points.Add(new Point(e.X, e.Y));

                            this.CustomRefresh();
                            Points.RemoveAt(Points.Count - 1);
                            break;
                        }
                    case 7:
                        {
                            if (e.Button.ToString() == "Left")
                            {
                                Points.Add(new Point(e.X, e.Y));
                                this.CustomRefresh();
                            }
                            break;
                        }
                }

                if (HelpSelectedItem != null && HelpSelectedItem is ITranslatable)
                {
                    int dX = e.X - this.point.X;
                    int dY = e.Y - this.point.Y;
                    ((ITranslatable)HelpSelectedItem).Translate(dX, dY);
                    this.CustomRefresh();
                }

                this.point.X = e.X;
                this.point.Y = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            graphicsProcessor.MouseUpEvent();

            switch (ToggleSelection)
            {
                case 0:
                    {
                        if (this.RectPoint1 != this.RectPoint2)
                        {
                            IDrawable item;
                            if (IsRectOrEll)
                            {
                                item = new RectangleShape(new Size(Math.Max(RectPoint1.X, RectPoint2.X) - Math.Min(RectPoint1.X, RectPoint2.X),
                                                                    Math.Max(RectPoint1.Y, RectPoint2.Y) - Math.Min(RectPoint1.Y, RectPoint2.Y)),
                                                                    new Point(Math.Min(RectPoint1.X, RectPoint2.X),
                                                                    Math.Min(RectPoint1.Y, RectPoint2.Y)), Color.Transparent, colorDialog1.Color, 200);
                                Items.Add(item);
                                ToggleSelection = 1;
                            }
                            else
                            {
                                item = new EllipseShape(new Size(Math.Max(RectPoint1.X, RectPoint2.X) - Math.Min(RectPoint1.X, RectPoint2.X),
                                            Math.Max(RectPoint1.Y, RectPoint2.Y) - Math.Min(RectPoint1.Y, RectPoint2.Y)),
                                            new Point(Math.Min(RectPoint1.X, RectPoint2.X),
                                            Math.Min(RectPoint1.Y, RectPoint2.Y)), Color.Transparent, colorDialog1.Color, 200);
                                Items.Add(item);
                                ToggleSelection = 1;
                            }

                            this.GetRectPoints(e.X, e.Y);
                            SelectedItem = item;
                            graphicsProcessor.SelectedItem = SelectedItem;
                            this.CustomRefresh();
                        }
                        break;
                    }
                case 5:
                    {
                        LineShape item = new LineShape(Points[0], new Point(e.X + 1, e.Y + 1), colorDialog1.Color, 255);
                        Items.Add(item);
                        Points.Clear();
                        ToggleSelection = 1;
                        SelectedItem = item;
                        graphicsProcessor.SelectedItem = SelectedItem;
                        this.CustomRefresh();
                        break;
                    }
                case 6:
                    {
                        SelectedItem = null;
                        break;
                    }
                case 7:
                    {
                        IDrawable item;
                        if (Points.Count > 1)
                        {
                            item = new CurveShape(new List<Point>(Points), colorDialog1.Color, 255);
                            Items.Add(item);
                            ToggleSelection = 1;
                            SelectedItem = item;
                            graphicsProcessor.SelectedItem = SelectedItem;
                        }

                        Points.Clear();
                        this.CustomRefresh();
                        break;
                    }
            }

            HelpSelectedItem = null;
            this.CustomRefresh();
        }

        #endregion

        #region ToolStripMenu
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "drawer files (*.drwr)|*.drwr";
            saveFileDialog1.Title = "Save a Drawer file";
            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, Items);
                stream.Close();
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            Items = (List<IDrawable>)formatter.Deserialize(stream);
            foreach(IDrawable item in this.Items)
            {
                if (item.GetType().Name == "GroupOfItems")
                {
                    this.groupOfItems = (GroupOfItems)item;
                }
            }
            stream.Close();

            ToggleSelection = 1;
            SelectedItem = null;
            graphicsProcessor = new GraphicsProcessor(HelpSelectedItem);
            saveFileDialog1.FileName = openFileDialog1.FileName;
            this.CustomRefresh();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName == String.Empty)
            {
                saveFileDialog1.ShowDialog();
            }
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Items);
            stream.Close();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Items = new List<IDrawable>();
            this.SelectedItem = null;
            this.groupOfItems = null;
            graphicsProcessor = new GraphicsProcessor(HelpSelectedItem);
            openFileDialog1.FileName = String.Empty;
            saveFileDialog1.FileName = String.Empty;
            this.CustomRefresh();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                if (SelectedItem.GetType().Name != "GroupOfItems")
                {
                    copied = SelectedItem;
                }
                else
                {
                    MessageBox.Show("You cannot clone a group of items.");
                }
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (copied != null)
            {
                Items.Add(copied.CloneShape());
            }
            this.CustomRefresh();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                IDrawable itemToDelete = SelectedItem;
                foreach (IDrawable item in Items)
                {
                    if (item == SelectedItem)
                    {
                        itemToDelete = item;
                        break;
                    }
                }
                if (SelectedItem.GetType().Name == "GroupOfItems")
                {
                    this.groupOfItems = null;
                }

                Items.Remove(itemToDelete);
                graphicsProcessor.SelectedItem = null;
                SelectedItem = null;

                this.CustomRefresh();
            }
        }

        private void FindItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findItemDialog.ShowDialog();
            ToggleSelection = 1;
        }

        private void AntonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutAntonio.ShowDialog();
        }

        private void DanielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDaniel.ShowDialog();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpDialog.ShowDialog();
        }

        private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Items.Count < 2)
            {
                MessageBox.Show(String.Format("There must be minimum 2 items in order to create a group.\nCurrent count: {0}", this.Items.Count));
            }
            else if (this.groupOfItems != null)
            {
                MessageBox.Show("There is already a group. Please break it before creating new one.");
            }
            else
            {
                groupItemsDialog.ShowDialog();
                ToggleSelection = 1;
            }
        }

        private void BreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null && SelectedItem.GetType().Name == "GroupOfItems")
            {
                GroupOfItems tempGroup = (GroupOfItems)SelectedItem;

                this.Items.Remove(tempGroup);
                SelectedItem = null;

                foreach (IDrawable item in tempGroup.Items)
                {
                    this.Items.Add(item);
                }
                this.graphicsProcessor.SelectedItem = this.Items.Last();
                this.groupOfItems = null;
                this.CustomRefresh();
            }
        }

        #endregion

        #region KeyDownEvent
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "N, Control":
                    {
                        NewToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "S, Control":
                    {
                        SaveToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "S, Shift, Control":
                    {
                        SaveAsToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "M":
                    {
                        colorDialog1.ShowDialog();
                        break;
                    }
                case "C, Control":
                    {
                        CopyToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "V, Control":
                    {
                        PasteToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "Delete":
                    {
                        DeleteToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "B":
                    {
                        BreakToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "G":
                    {
                        GroupToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "F, Control":
                    {
                        FindItemToolStripMenuItem_Click(sender, e);
                        break;
                    }
                case "NumPad8":
                    {
                        if (SelectedItem != null && SelectedItem is ITranslatable)
                        {
                            ((ITranslatable)SelectedItem).Translate(0, -20);
                            this.CustomRefresh();
                        }
                        break;
                    }
                case "NumPad2":
                    {
                        if (SelectedItem != null && SelectedItem is ITranslatable)
                        {
                            ((ITranslatable)SelectedItem).Translate(0, 20);
                            this.CustomRefresh();
                        }
                        break;
                    }
                case "NumPad4":
                    {
                        if (SelectedItem != null && SelectedItem is ITranslatable)
                        {
                            ((ITranslatable)SelectedItem).Translate(-20, 0);
                            this.CustomRefresh();
                        }
                        break;
                    }
                case "NumPad6":
                    {
                        if (SelectedItem != null && SelectedItem is ITranslatable)
                        {
                            ((ITranslatable)SelectedItem).Translate(20, 0);
                            this.CustomRefresh();
                        }
                        break;
                    }
            }
        }
        #endregion
    }
}
