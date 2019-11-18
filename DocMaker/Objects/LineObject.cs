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
    public class LineObject : DocumentObject
    {
        public int Length { get; set; }
        public byte Thickness { get; set; }
        public Color LineColor { get; set; }
        public string DashPattern { get; set; }

        public LineObject(int lineCounter)
        {
            Type = ObjectType.Line;
            Name = "Line " + lineCounter.ToString();

            LineColor = Color.FromArgb(0, 0, 0);
            Holder.SizeMode = PictureBoxSizeMode.Normal;

            IsVertical = false;
            Thickness = 2;
            Length = 50;

            IsVertical = false;
            SizeInPercent = false;

            DashPattern = "1";
        }

        public override void RenderObject()
        {
            int realLength = Length;

            if (SizeInPercent)
                realLength = (int)(((float)Length / 100.0F) * 
                             (float)(IsVertical ? Paper.paperSize.Height : Paper.paperSize.Width));

            Size lineDimentions = Zoom.Calculate(new Size(realLength, Thickness));
            //if (IsVertical) lineDimentions.Flip();

            // Initialize the bitmap
            Bitmap b = new Bitmap(lineDimentions.Width, lineDimentions.Height);

            // Initialize the graphics and render settings
            Graphics g = Graphics.FromImage(b);
            g.ApplyGraphicsQuality();

            Pen drawingPen = new Pen(LineColor, lineDimentions.Height);
            drawingPen.DashPattern = DashPattern.GetFloatList(' ');

            g.DrawLine(drawingPen, new Point(0, lineDimentions.Height / 2), new Point(lineDimentions.Width, lineDimentions.Height / 2));

            if (IsVertical)
                b.RotateFlip(RotateFlipType.Rotate90FlipNone);

            // Set the image
            Holder.Image = b;
            Holder.Size = Holder.Image.Size;

            base.RenderObject();
        }

        public override bool EditObject()
        {
            LineEditor editor = new LineEditor(this);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                RenderObject();
                return true;
            }

            return false;
        }

        public override void SaveObject()
        {
            // Do the usual stuff
            base.SaveObject();

            Project.fileHandler.Write(Length);
            Project.fileHandler.Write(Thickness);
            Project.fileHandler.Write(DashPattern);

            Project.fileHandler.Write(LineColor.R);
            Project.fileHandler.Write(LineColor.G);
            Project.fileHandler.Write(LineColor.B);
        }

        public override void LoadObject()
        {
            // Do the usual stuff
            base.LoadObject();

            Length = Project.fileHandler.ReadInteger();
            Thickness = Project.fileHandler.ReadByte();
            DashPattern = Project.fileHandler.ReadString();

            LineColor = Color.FromArgb(Project.fileHandler.ReadByte(),
                                       Project.fileHandler.ReadByte(),
                                       Project.fileHandler.ReadByte());

        }
    }

}
