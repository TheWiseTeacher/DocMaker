using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public enum ObjectType : byte
    {
        Object = 0,
        Label = 1,
        Line = 2,
        Image = 3,
        Table = 4,
    }

    public partial class DocumentObject : ICloneable, IDisposable
    {
        public ObjectType Type { get; set; }

        public string Name { get; set; }        // The object name to use in the object list
        public string Key { get; set; }         // The Key name to edit object in real time in the user's project

        public ObjectHolder Holder;             // The control holding the rendred object image

        public Point RealLocation;              // Contains the real object position despite zooming

        private bool isMouseDown = false;
        private Point mouseLastLocation;

        public Color BackColor { get; set; }

        public DocumentObject()
        {
            Type = ObjectType.Object;

            Name = "Object";
            Key = "";

            flags = 0;

            SetAlignment(Flags.Left | Flags.Down);

            BackColor = Color.Transparent;
            RealLocation = Point.Empty;

            Holder = new ObjectHolder();
            Holder.Cursor = Config.OnHoveringObject;

            Holder.DoubleClick += Canvas_DoubleClick;
            Holder.MouseDown += Canvas_MouseDown;
            Holder.MouseMove += Canvas_MouseMove;
            Holder.MouseUp += Canvas_MouseUp;
            Holder.MouseEnter += Canvas_MouseEnter;
            Holder.MouseLeave += Canvas_MouseLeave;
            Holder.MouseWheel += Canvas_MouseWheel;

            // Set visibility to true
            ShowObject();
        }

        public bool ToggleVisibility()
        {
            //Toggle visiblity flag
            this.Visible = !this.Visible;

            Holder.Visible = this.Visible;
            return this.Visible;
        }

        public void ShowObject()
        {
            this.Visible = true;
            Holder.Visible = true;
        }

        public void HideObject()
        {
            this.Visible = false;
            Holder.Visible = false;
        }



        private void Canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta == 0 || Control.ModifierKeys != Keys.Shift)
                return;

            if(e.Delta > 0)
            {
                Holder.SendToBack();
            }
            else
            {
                Holder.BringToFront();

            }
        }

        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            // To capture wheel input 
            // Note : I'm setting AvtiveControl and not LivePreview.currentObject !
            //
            LivePreview.mainForm.ActiveControl = Holder;

            Holder.BackColor = Color.FromArgb(184, 150, 207);
        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            Holder.BackColor = BackColor;
        }

        private void Canvas_DoubleClick(object sender, EventArgs e)
        {
            LivePreview.Select(this);
            EditObject();

            //LivePreview.currentObject = null;

        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Point s = new Point(200, 200);
            Point s;

            if (isMouseDown)
            {
                //X = X - mouseLastLocation.X + e.X;
                //Y = Y - mouseLastLocation.Y + e.Y;
                /*
                // Calcualte the Canvas's new location
                Point newLocation = new Point(RealLocation.X - mouseLastLocation.X + e.X,
                                              RealLocation.Y - mouseLastLocation.Y + e.Y);

                Size halfCanvas = new Size((int)((float)Canvas.Width / 2.0f),
                                           (int)((float)Canvas.Height / 2.0f));

                Point canvasLocation = Point.Empty;

                if(IsLeft())
                {
                    newLocation.X = Funcs.Clamp(newLocation.X, 0, Zoom.paperSize.Width - Canvas.Width);
                    canvasLocation.X = newLocation.X;
                }
                else if(IsCenter())
                {
                    newLocation.X = Funcs.Clamp(newLocation.X, halfCanvas.Width, Zoom.paperSize.Width - halfCanvas.Width);
                    canvasLocation.X = newLocation.X - halfCanvas.Width;
                }
                else if(IsRight())
                {
                    newLocation.X = Funcs.Clamp(newLocation.X, Canvas.Width, Zoom.paperSize.Width);
                    canvasLocation.X = newLocation.X - Canvas.Width;
                }

                if (IsUp())
                {
                    newLocation.Y = Funcs.Clamp(newLocation.Y, 0, Zoom.paperSize.Height - Canvas.Height);
                    canvasLocation.Y = newLocation.Y;
                }
                else if (IsMiddle())
                {
                    newLocation.Y = Funcs.Clamp(newLocation.Y, halfCanvas.Height, Zoom.paperSize.Height - halfCanvas.Height);
                    canvasLocation.Y = newLocation.Y - halfCanvas.Height;
                }
                else if (IsDown())
                {
                    newLocation.Y = Funcs.Clamp(newLocation.Y, Canvas.Height, Zoom.paperSize.Height);
                    canvasLocation.Y = newLocation.Y - Canvas.Height;
                }


                RealLocation = newLocation;

                Canvas.Location = Zoom.Calculate(canvasLocation);
                Canvas.Update();

                */

             
                // Calcualte the Canvas's new location
                Point p = new Point(Holder.Location.X - mouseLastLocation.X + e.X,
                                    Holder.Location.Y - mouseLastLocation.Y + e.Y);

                // Ignore snapping and alignment if control is pressed
                if(Control.ModifierKeys != Keys.Control && e.Button != MouseButtons.Right)
                {
                    // A Basic snapping Algorithm
                    foreach (DocumentObject obj in Objects.objectList)
                    {
                        if (obj == this || !obj.Visible)
                            continue;

                        s = obj.Holder.Location;

                        if (p.X >= s.X - 10 && p.X < s.X + 10)
                        {
                            p.X = s.X;
                        }

                        if (p.Y >= s.Y - 10 && p.Y < s.Y + 10)
                        {
                            p.Y = s.Y;
                        }
                    }

                }

                // Always clamp Position to inside the document
                p.X = Funcs.Clamp(p.X, 0, Zoom.paperSize.Width - Holder.Width);
                p.Y = Funcs.Clamp(p.Y, 0, Zoom.paperSize.Height - Holder.Height);

                Holder.Location = p;
                Holder.Update();

                RecalculateRealPosition();

                // Update position labels on the main form
                LivePreview.mainForm.UpdateObjectPosition();
            }
        }

        public void MoveTo(int x, int y)
        {
            Holder.Location = new Point(Funcs.Clamp(x, 0, Zoom.paperSize.Width - Holder.Width),
                                        Funcs.Clamp(y, 0, Zoom.paperSize.Height - Holder.Height));

            RecalculateRealPosition();
        }

        private void RecalculateRealPosition()
        {
            Point p = Holder.Location;

            //
            // Recalculate the real position
            //
            if (IsCenter()) p.X += (int)((float)Holder.Width * 0.5);
            if (IsRight()) p.X += (int)((float)Holder.Width);
            //
            if (IsMiddle()) p.Y += (int)((float)Holder.Height * 0.5);
            if (IsDown()) p.Y += (int)((float)Holder.Height);
            //
            // Calculate the Real position without zoom
            RealLocation = Zoom.CalculateReal(p);
            //
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            Holder.Cursor = Config.OnHoveringObject;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            LivePreview.Select(this);

            mouseLastLocation = e.Location;
            Holder.Cursor = Config.OnMovingObject;
        }

        public virtual void RenderObject()
        {
            Point p = Zoom.Calculate(RealLocation);

            if (IsCenter()) p.X -= (int)((float)Holder.Width * 0.5);
            if (IsRight()) p.X -= (int)((float)Holder.Width);

            if (IsMiddle()) p.Y -= (int)((float)Holder.Height * 0.5);
            if (IsDown()) p.Y -= (int)((float)Holder.Height);

            // Clamp Position to inside the document
            p.X = Funcs.Clamp(p.X, 0, Zoom.paperSize.Width - Holder.Width);
            p.Y = Funcs.Clamp(p.Y, 0, Zoom.paperSize.Height - Holder.Height);

            // Finally set theposition clamped and with zoom applied
            Holder.Location = p;
            RecalculateRealPosition();

            // Set the BackColor
            Holder.BackColor = BackColor;
        }

        public virtual bool EditObject()
        {
            return false;
        }

        public virtual void SaveObject()
        {
            Project.fileHandler.Write((byte)Type);
            Project.fileHandler.Write(flags);
            
            Project.fileHandler.Write(Name);
            Project.fileHandler.Write(Key);

            Project.fileHandler.Write(RealLocation.X);
            Project.fileHandler.Write(RealLocation.Y);

            // Get if background is transparent
            bool isTransparent = BackColor == Color.Transparent;
            Project.fileHandler.Write(isTransparent);

            // Write the color if it isn't transparent
            if (!isTransparent)
            {
                Project.fileHandler.Write(BackColor.R);
                Project.fileHandler.Write(BackColor.G);
                Project.fileHandler.Write(BackColor.B);
            }
        }

        public virtual void LoadObject()
        {
            // The ObjectType is read before initializing the object
            flags = Project.fileHandler.ReadUInteger();

            Name = Project.fileHandler.ReadString();
            Key = Project.fileHandler.ReadString();

            RealLocation.X = Project.fileHandler.ReadInteger();
            RealLocation.Y = Project.fileHandler.ReadInteger();

            // Check if backfround is transparent
            if(Project.fileHandler.ReadBoolean())
                BackColor = Color.Transparent;
            else
            { 
                BackColor = Color.FromArgb(Project.fileHandler.ReadByte(),
                                           Project.fileHandler.ReadByte(),
                                           Project.fileHandler.ReadByte());
            }
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

        public void Dispose()
        {
            // TODO : Add disposing methodes for each documentObject type

            if(Holder.Image != null)
                Holder.Image.Dispose();

            if(Holder != null)
                Holder.Dispose();
        }
    }
}
