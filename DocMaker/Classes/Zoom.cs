using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DocMaker
{
    static class Zoom
    {
        public static double zoomWidthRatio = 1;
        public static double zoomHeightRatio = 1;

        public static readonly int[] avaibleZooms = {800, 700, 600, 500, 400, 300, 200, 150, 100, 50, 25};

        public static void ApplyZoom(int percent)
        {
            zoomWidthRatio = (double)percent / 100D;
            zoomHeightRatio = (double)percent / 100D;
        }

        public static Size GetPaperSize()
        {
            Size s = new Size((int)((double)Project.paperSize.Width * zoomWidthRatio),
                              (int)((double)Project.paperSize.Height * zoomHeightRatio));

            if (Project.isLandscape)
                s = new Size(s.Height, s.Width);

            return s;
        }

        public static int GetFontSize(int fs)
        {
            return (int)((double)fs * zoomHeightRatio);
        }

        public static Point Calculate(Point p)
        {
            return new Point((int)((double)p.X * zoomWidthRatio),
                             (int)((double)p.Y * zoomHeightRatio));

        }
        public static Size Calculate(Size p)
        {
            return new Size((int)((double)p.Width * zoomWidthRatio),
                            (int)((double)p.Height * zoomHeightRatio));
        }

        public static Point CalculateReal(Point p)
        {
            return new Point((int)((double)p.X / zoomWidthRatio),
                             (int)((double)p.Y / zoomHeightRatio));

        }

        public static Size CalculateReal(Size p)
        {
            return new Size((int)((double)p.Width / zoomWidthRatio),
                            (int)((double)p.Height / zoomHeightRatio));
        }

    }
}
