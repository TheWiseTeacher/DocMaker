using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public class ImageObject : DocumentObject
    {

        public string ResourceID { get; set; }

        public Size ObjectSize { get; set; }

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
            ObjectSize = new Size(100, 100);

            IsVertical = false;
            SizeInPercent = false;

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

        public override void RenderObject()
        {
            Bitmap b = new Bitmap(ObjectSize.Width, ObjectSize.Height);
            Bitmap r = Resources.Get(ResourceID);

            Graphics g = Graphics.FromImage(b);
            Point anchor = new Point(0, 0);

            int angle = 0;

            if (IsVertical)
                angle += 90;

            if (IsTurned180)
                angle += 180;

            g.TranslateTransform((float)b.Width / 2.0f, (float)b.Height / 2.0f);
            g.RotateTransform(angle);
            g.TranslateTransform((float)b.Width / -2.0f, (float)b.Height / -2.0f);

            switch (drawingType)
            {
                case DrawingTypes.Tiles:
                    using (TextureBrush brush = new TextureBrush(r, WrapMode.Tile))
                    {
                        g.FillRectangle(brush, 0, 0, ObjectSize.Width, ObjectSize.Height);
                    }
                    break;

                case DrawingTypes.Stretch:
                    
                    g.DrawImage(r, 0, 0, ObjectSize.Width, ObjectSize.Height);
                    break;

                case DrawingTypes.Center:

                    double xOffset = (double)(b.Width - r.Width)/2.0d;
                    double yOffset = (double)(b.Height - r.Height)/2.0d;

                    g.DrawImage(r, (int)xOffset, (int)yOffset, r.Width, r.Height);

                    break;

                case DrawingTypes.Zoom:

                    // TODO Zoom

                    break;

                default:
                    break;
            }

            // To prevent bitmap-ception, anchors will be off when zooming in/out for ImageObjects
            // After thinking I left the anchors to be shown even if zoomed but they become blurry (whatever) :/ 
            // Draw the anchor point for this label
            //
            if (Config.ShowAnchorPoints /*&& Zoom.currentAppliedZoom == 100*/)
            {
                // Reset rotation for anchors (only if show [Optimisation :3])
                g.ResetTransform();

                if (IsCenter()) anchor.X = (int)(b.Width * 0.5F);
                if (IsRight()) anchor.X = (int)b.Width - 1;

                if (IsMiddle()) anchor.Y = (int)(b.Height * 0.5F);
                if (IsDown()) anchor.Y = (int)b.Height - 1;

                g.DrawLine(Config.AnchorPen, anchor.X - Config.ANCHOR_SIZE, anchor.Y, anchor.X + Config.ANCHOR_SIZE, anchor.Y);
                g.DrawLine(Config.AnchorPen, anchor.X, anchor.Y - Config.ANCHOR_SIZE, anchor.X, anchor.Y + Config.ANCHOR_SIZE);
            }

            // Release previous rendered bitmap (A lil bit of memore'h :3)
            if (Holder.Image != null)
                Holder.Image.Dispose();


            //Canvas.BackColor = BackColor;

            Holder.Image = b;
            Holder.Size = Zoom.Calculate(ObjectSize);

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

            Project.fileHandler.Write(ObjectSize.Width);
            Project.fileHandler.Write(ObjectSize.Height);

            Project.fileHandler.Write((byte)drawingType); 
        }

        public override void LoadObject()
        {
            base.LoadObject();

            ResourceID = Project.fileHandler.ReadString();

            ObjectSize = new Size(Project.fileHandler.ReadInteger(),
                                  Project.fileHandler.ReadInteger());

            drawingType = (DrawingTypes)Project.fileHandler.ReadByte();
        }
    }

}
