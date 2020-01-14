using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DocMaker
{
    public class ImageObject : DocumentObject
    {

        public string ResourceID { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public enum DrawingTypes : byte
        { 
            Stretch = 0, 
            Tiles = 1, 
            Center = 2, 
            Zoom = 3 
        };

        public DrawingTypes drawingType;

        public ImageObject(int imageCounter)
        {
            Type = ObjectType.Image;

            Name = "Image " + imageCounter.ToString();
            BackColor = Color.Transparent;

            SetAlignment(Flags.Left | Flags.Up);

            // Set the resource file to default (none)
            ResourceID = Resources.resourceList[0];

            // For this version only stretch image :/
            Holder.SizeMode = PictureBoxSizeMode.StretchImage;

            IsVertical = false;
            SizeInPercent = false;

            Width = Height = 100;

            drawingType = DrawingTypes.Center;
        }

        /// <summary>
        /// Checks if the object is using the same resource id,
        /// if true set it to no ressource selected.
        /// This is used to update ImageObjects when deleting a resource file.
        /// </summary>
        /// <param name="resID">The resource id to check for.</param>
        public void CheckResource(string resID)
        {
            if (ResourceID.Equals(resID))
            {
                ResourceID = Resources.resourceList[0];
                RenderObject();
            }
        }

        /*
        public override void RenderObject()
        {
            Thread thread = new Thread(new ThreadStart(ExRenderObject));
            thread.Start();

        }
        */

        public override void RenderObject()
        {
            Size realObjectSize;
            double xOffset, yOffset;

            if (!SizeInPercent)
                realObjectSize = new Size((int)Width, (int)Height);
            else
                realObjectSize = new Size((int)((float)Paper.Width * Width / 100.0f),
                                          (int)((float)Paper.Height * Height / 100.0f));

            // Limit Size to a minimum of 1
            realObjectSize = realObjectSize.Max(1);

            Bitmap c = new Bitmap(realObjectSize.Width, realObjectSize.Height);
            Bitmap i = new Bitmap(Resources.Get(ResourceID));

            Graphics g = Graphics.FromImage(c);

            if (IsVertical)
                i.RotateFlip(RotateFlipType.Rotate90FlipNone);

            if(IsTurned180)
                i.RotateFlip(RotateFlipType.Rotate180FlipNone);

            switch (drawingType)
            {
                case DrawingTypes.Tiles:
                    using (TextureBrush brush = new TextureBrush(i, WrapMode.Tile))
                    {
                        g.FillRectangle(brush, 0, 0, realObjectSize.Width, realObjectSize.Height);
                    }
                    break;

                case DrawingTypes.Stretch:
                    
                    g.DrawImage(i, 0, 0, realObjectSize.Width, realObjectSize.Height);
                    break;

                case DrawingTypes.Center:

                    xOffset = (double)(c.Width - i.Width)/2.0d;
                    yOffset = (double)(c.Height - i.Height)/2.0d;

                    g.DrawImage(i, (int)xOffset, (int)yOffset, i.Width, i.Height);

                    break;

                case DrawingTypes.Zoom:

                    Size newSize;

                    double cRatio = (double)c.Width / c.Height;
                    double iRatio = (double)i.Width / i.Height;

                    if(cRatio > iRatio)
                        newSize = new Size((int)(i.Width * ((double)c.Height / i.Height)), c.Height);
                    else
                        newSize = new Size(c.Width, (int)(i.Height * ((double)c.Width / i.Width)));

                    xOffset = (double)(c.Width - newSize.Width) / 2.0d;
                    yOffset = (double)(c.Height - newSize.Height) / 2.0d;

                    g.DrawImage(i, (int)xOffset, (int)yOffset, newSize.Width, newSize.Height);

                    break;

                default:
                    break;
            }

            // To prevent bitmap-ception, anchors will be off when zooming in/out for ImageObjects
            // After thinking I left the anchors to be shown even if zoomed but they become blurry (whatever) :/ 
            // Draw the anchor point for this label
            //
            Point anchor = new Point(0, 0);

            if (Config.ShowAnchorPoints /*&& Zoom.currentAppliedZoom == 100*/)
            {
                // Reset rotation for anchors (only if show [Optimisation :3])
                g.ResetTransform();

                if (IsCenter()) anchor.X = (int)(c.Width * 0.5F);
                if (IsRight()) anchor.X = (int)c.Width - 1;

                if (IsMiddle()) anchor.Y = (int)(c.Height * 0.5F);
                if (IsDown()) anchor.Y = (int)c.Height - 1;

                g.DrawLine(Config.AnchorPen, anchor.X - Config.ANCHOR_SIZE, anchor.Y, anchor.X + Config.ANCHOR_SIZE, anchor.Y);
                g.DrawLine(Config.AnchorPen, anchor.X, anchor.Y - Config.ANCHOR_SIZE, anchor.X, anchor.Y + Config.ANCHOR_SIZE);
            }

            // Release previous rendered bitmap (A lil bit of memore'h :3)
            if (Holder.Image != null)
                Holder.Image.Dispose();



            // Dispose of the copy
            i.Dispose();

            Holder.Image = c;
            Holder.Size = Zoom.Calculate(realObjectSize);

            base.RenderObject();
        }

        public override bool EditObject()
        {
            ImageEditor editor = new ImageEditor(this);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                RenderObject();
                return true;
            }

            return false;
        }

        public override void SaveObject()
        {
            base.SaveObject();

            Project.fileHandler.Write(ResourceID);

            Project.fileHandler.Write(Width);
            Project.fileHandler.Write(Height);

            Project.fileHandler.Write((byte)drawingType); 
        }

        public override void LoadObject()
        {
            base.LoadObject();

            ResourceID = Project.fileHandler.ReadString();

            Width = Project.fileHandler.ReadFloat();
            Height = Project.fileHandler.ReadFloat();

            drawingType = (DrawingTypes)Project.fileHandler.ReadByte();
        }
    }

}
