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
        public int Length { get; set; }
        public byte Thickness { get; set; }


        public ImageObject(int lineCounter)
        {
            Name = "Line " + lineCounter.ToString();

            BackColor = Color.FromArgb(0, 0, 0);

            IsVertical = false;
            Thickness = 2;
            Length = 50;

            IsVertical = false;
            SizeInPercent = false;
        }

        public override void RenderObject()
        {
            Canvas.BackColor = BackColor;

            if (IsVertical)
            {
                Canvas.Size = Zoom.Calculate(new Size(Thickness, Length));
            }
            else
            {
                Canvas.Size = Zoom.Calculate(new Size(Length, Thickness));
            }

            base.RenderObject();
        }

        public override bool EditObject()
        {
            /*
            LineEditor editor = new LineEditor(this);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                RenderObject();
                return true;
            }
            */

            return false;
        }
    }

}
