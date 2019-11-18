﻿using System;
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

        public static Size paperSize;

        public static readonly int[] avaibleZooms = {800, 700, 600, 500, 400, 300, 200, 150, 100, 50, 25};
        public static int currentAppliedZoom = 0;

        public static void ApplyZoom(int percent)
        {
            zoomWidthRatio = (double)percent / 100D;
            zoomHeightRatio = (double)percent / 100D;

            currentAppliedZoom = percent;
        }

        public static Size GetPaperSize()
        {
            Size s = new Size((int)((double)Paper.paperSize.Width * zoomWidthRatio),
                              (int)((double)Paper.paperSize.Height * zoomHeightRatio));

            if (Paper.isLandscape)
                s = new Size(s.Height, s.Width);

            // Method called whenever paper size is changed
            Zoom.paperSize = s;

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
            // For sizes we can't accept a size of 0 so let's take 1 as minimum
            return new Size(Funcs.Max(1, (int)((double)p.Width * zoomWidthRatio)),
                            Funcs.Max(1, (int)((double)p.Height * zoomHeightRatio)));
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
