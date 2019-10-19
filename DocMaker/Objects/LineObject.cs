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

        public LineObject(int lineCounter)
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
            int realLength = Length;

            if (SizeInPercent)
                realLength = (int)(((float)Length / 100.0F) * 
                                    (float)(IsVertical ? Paper.paperSize.Height : Paper.paperSize.Width));

            if (IsVertical)
            {
                Canvas.Size = Zoom.Calculate(new Size(Thickness, realLength));
            }
            else
            {
                Canvas.Size = Zoom.Calculate(new Size(realLength, Thickness));
            }

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
    }

}
