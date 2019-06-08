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
        public string Name { get; set; }        // The object name to use in the object list
        public string Key { get; set; }         // The Key name to edit object in real time in the user's project

        public byte Alignment { get; set; }

        public Point RealLocation;
        public PictureBox Canvas;

        private bool isMouseDown = false;
        private Point mouseLastLocation;

        public Color BackColor { get; set; }

        [Flags]
        public enum AlignmentFlags
        {
            Left = 1,
            Center = 2,
            Right = 4,
            Up = 8,
            Middle = 16,
            Down = 32
        }

        public DocumentObject()
        {
            Name = "Object";
            Key = "";

            Alignment = (int)AlignmentFlags.Left | (int)AlignmentFlags.Down;

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

                if ((Alignment & (int)DocumentObject.AlignmentFlags.Center) > 0) p.X += (int)((float)Canvas.Width * 0.5);
                if ((Alignment & (int)DocumentObject.AlignmentFlags.Right) > 0) p.X += (int)((float)Canvas.Width);

                if ((Alignment & (int)DocumentObject.AlignmentFlags.Middle) > 0) p.Y += (int)((float)Canvas.Height * 0.5);
                if ((Alignment & (int)DocumentObject.AlignmentFlags.Down) > 0) p.Y += (int)((float)Canvas.Height);

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

            if ((Alignment & (int)DocumentObject.AlignmentFlags.Center) > 0) p.X -= (int)((float)Canvas.Width * 0.5);
            if ((Alignment & (int)DocumentObject.AlignmentFlags.Right) > 0) p.X -= (int)((float)Canvas.Width);

            if ((Alignment & (int)DocumentObject.AlignmentFlags.Middle) > 0) p.Y -= (int)((float)Canvas.Height * 0.5);
            if ((Alignment & (int)DocumentObject.AlignmentFlags.Down) > 0) p.Y -= (int)((float)Canvas.Height);

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

        public void ApplyZoom()
        {
            RenderObject();
        }




        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void SetAlignment(AlignmentFlags newAlignment)
        {
            /*
                Byte                    :   00 000 000
                Signification           :   -- DMU RCL
                To erase HA and with    :   00 111 000   = 0x38
                To erase VA and with    :   00 000 111   = 0x07
            */

            // If alignement is an horizontal alignment
            if(((int)newAlignment & 0x07) > 0) 
                Alignment &= 0x38;

            // If alignement is a vertical alignment
            if (((int)newAlignment & 0x38) > 0)
                Alignment &= 0x07;

            Alignment ^= (byte)newAlignment;
        }
    }
}
