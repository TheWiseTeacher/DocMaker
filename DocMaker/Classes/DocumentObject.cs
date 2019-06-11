using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public partial class DocumentObject : ICloneable
    {
        public string Name { get; set; }        // The object name to use in the object list
        public string Key { get; set; }         // The Key name to edit object in real time in the user's project


        public PictureBox Canvas;               // The drawing board of the object

        public Point RealLocation;              // Contains the real object position despite zooming

        private bool isMouseDown = false;
        private Point mouseLastLocation;

        public Color BackColor { get; set; }


        public DocumentObject()
        {
            Name = "Object";
            Key = "";

            flags = 0;

            SetAlignment(Flags.Left | Flags.Down);

            BackColor = Color.Transparent;
            RealLocation = Point.Empty;

            Canvas = new PictureBox();
            Canvas.Cursor = Config.OnHoveringObject;

            Canvas.DoubleClick += Canvas_DoubleClick;
            Canvas.MouseDown += Canvas_MouseDown;
            Canvas.MouseMove += Canvas_MouseMove;
            Canvas.MouseUp += Canvas_MouseUp;
            Canvas.MouseEnter += Canvas_MouseEnter;
            Canvas.MouseLeave += Canvas_MouseLeave;
            Canvas.MouseWheel += Canvas_MouseWheel;
        }

        public bool ToggleVisibility()
        {
            Canvas.Visible = !Canvas.Visible;
            return Canvas.Visible;
        }



        private void Canvas_MouseWheel(object sender, MouseEventArgs e)
        {
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
            // To capture wheel input 
            // Note : I'm setting AvtiveControl and not LivePreview.currentObject !
            //
            LivePreview.mainForm.ActiveControl = Canvas;

            Canvas.BackColor = Color.FromArgb(184, 150, 207);
        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            Canvas.BackColor = BackColor;
        }

        private void Canvas_DoubleClick(object sender, EventArgs e)
        {
            LivePreview.currentObject = this;
            EditObject();

            //LivePreview.currentObject = null;

        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                //X = X - mouseLastLocation.X + e.X;
                //Y = Y - mouseLastLocation.Y + e.Y;

                // Calcualte the Canvas's new location
                Point p = new Point(Canvas.Location.X - mouseLastLocation.X + e.X,
                                    Canvas.Location.Y - mouseLastLocation.Y + e.Y);

                // Clamp Position to inside the document
                p.X = Funcs.Clamp(p.X, 0, Zoom.paperSize.Width - Canvas.Width);
                p.Y = Funcs.Clamp(p.Y, 0, Zoom.paperSize.Height - Canvas.Height);

                Canvas.Location = p;
                Canvas.Update();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                // Mouse Released
                Point p = Canvas.Location;

                if (IsCenter()) p.X += (int)((float)Canvas.Width * 0.5);
                if (IsRight()) p.X += (int)((float)Canvas.Width);

                if (IsMiddle()) p.Y += (int)((float)Canvas.Height * 0.5);
                if (IsDown()) p.Y += (int)((float)Canvas.Height);

                // Calculate the Real position without zoom
                RealLocation = Zoom.CalculateReal(p);
            }

            isMouseDown = false;
            Canvas.Cursor = Config.OnHoveringObject;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;

            LivePreview.currentObject = this;
            LivePreview.mainForm.SelectObject();

            mouseLastLocation = e.Location;
            Canvas.Cursor = Config.OnMovingObject;
        }

        public virtual void RenderObject()
        {
            Point p = Zoom.Calculate(RealLocation);

            if (IsCenter()) p.X -= (int)((float)Canvas.Width * 0.5);
            if (IsRight()) p.X -= (int)((float)Canvas.Width);

            if (IsMiddle()) p.Y -= (int)((float)Canvas.Height * 0.5);
            if (IsDown()) p.Y -= (int)((float)Canvas.Height);

            // Clamp Position to inside the document
            p.X = Funcs.Clamp(p.X, 0, Zoom.paperSize.Width - Canvas.Width);
            p.Y = Funcs.Clamp(p.Y, 0, Zoom.paperSize.Height - Canvas.Height);

            // Finally set theposition clamped and with zoom applied
            Canvas.Location = p;
        }

        public virtual bool EditObject()
        {
            return false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public void Rotate(bool rotateLeft = false)
        {
            if ((!rotateLeft && IsVertical) || (rotateLeft && !IsVertical))
                IsTurned180 = !IsTurned180;

            IsVertical = !IsVertical;
        }

    }
}
