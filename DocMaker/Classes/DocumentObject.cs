using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public class DocumentObject : ICloneable
    {
        //public ObjectType Type;
        public object Data;

        /*
        public int X;
        public int Y;
        */

        public Point RealLocation;

        //public Size RealSize;
        /*
        public int Width;
        public int Height;
        */
        public PictureBox Canvas;

        private bool isMouseDown = false;
        private Point mouseLastLocation;

        public DocumentObject(/*ObjectType type*/)
        {
            //Type = type;
            Data = null;

            RealLocation = Point.Empty;
            //RealSize = Size.Empty;

            Canvas = new PictureBox();
            Canvas.DoubleClick += Canvas_DoubleClick;
            Canvas.MouseDown += Canvas_MouseDown;
            Canvas.MouseMove += Canvas_MouseMove;
            Canvas.MouseUp += Canvas_MouseUp;
            Canvas.MouseEnter += Canvas_MouseEnter;
            Canvas.MouseLeave += Canvas_MouseLeave;
            Canvas.MouseWheel += Canvas_MouseWheel;
        }

        private void Canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Delta);

            if (e.Delta == 0 || Control.ModifierKeys != Keys.Shift)
                return;

            

            if(e.Delta > 0)
            {
                Canvas.SendToBack();
            }
            else
            {
                Canvas.BringToFront();

            }
        }

        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            Canvas.BackColor = Color.Red;
            LivePreview.mainForm.ActiveControl = Canvas;
        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            Canvas.BackColor = Color.Transparent;
        }

        private void Canvas_DoubleClick(object sender, EventArgs e)
        {
            LivePreview.currentObject = this;
            EditObject();

            LivePreview.currentObject = null;

        }

        public void RenderObject()
        {
            switch (Data)
            {
                case LabelObject l:
                    Canvas.Image = l.Render(Project.UsedLanguages[0]);
                    Canvas.Size = Canvas.Image.Size;


                    break;

                case null:
                default:
                    Funcs.Error("Object not initialized");
                    break;
            }

        }

        public bool EditObject()
        {
            switch (Data)
            {
                case LabelObject label:
                    LabelEditor editor = new LabelEditor(label);
                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        RenderObject();
                        return true;
                    }
                    break;

                case null:
                default:
                    Funcs.Error("Object not initialized");
                    break;
            }

            return false;
        }

        public void ApplyZoom()
        {
            

            Canvas.Location = Zoom.Calculate(RealLocation);
            //Canvas.Size = Zoom.Calculate(RealSize);

            RenderObject();

            //Console.WriteLine($"Zoom: {RealLocation} > {Canvas.Location}");
        }


        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                //X = X - mouseLastLocation.X + e.X;
                //Y = Y - mouseLastLocation.Y + e.Y;

                // Calcualte the Canvas's new location
                Canvas.Location = new Point(Canvas.Location.X - mouseLastLocation.X + e.X,
                                            Canvas.Location.Y - mouseLastLocation.Y + e.Y);

                // This class X and Y members represent the real X and Y without zoom
                RealLocation = Zoom.CalculateReal(Canvas.Location);

                Canvas.Update();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            Canvas.Cursor = Cursors.Default;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseLastLocation = e.Location;
            Canvas.Cursor = Cursors.SizeAll;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
