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

        public int X;
        public int Y;

        public int Width;
        public int Height;

        public PictureBox Canvas;

        private bool isMouseDown = false;
        private Point mouseLastLocation;

        public DocumentObject(/*ObjectType type*/)
        {
            //Type = type;
            Data = null;

            X = Y = 0;
            Width = Height = 0;

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

            if (e.Delta == 0)
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
        }

        public void RenderObject()
        {
            switch (Data)
            {
                case LabelObject l:
                    Canvas.Image = l.Render(Project.UsedLanguages[0]);
                    Canvas.Width = Canvas.Image.Width;
                    Canvas.Height = Canvas.Image.Height;
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

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                X = X - mouseLastLocation.X + e.X;
                Y = Y - mouseLastLocation.Y + e.Y;

                Canvas.Location = new Point(X, Y);
                Canvas.Update();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseLastLocation = e.Location;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
