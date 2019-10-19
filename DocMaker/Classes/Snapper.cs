using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace DocMaker
{
    public class Snapper
    {
        /*
        public SimpleCircleAdorner(UIElement adornedElement)
          : base(adornedElement)
        {
        }

        // A common way to implement an adorner's rendering behavior is to override the OnRender
        // method, which is called by the layout system as part of a rendering pass.
        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect adornedElementRect = new Rect(this.AdornedElement.DesiredSize);

            // Some arbitrary drawing implements.
            SolidColorBrush renderBrush = new SolidColorBrush(Colors.Green);
            renderBrush.Opacity = 0.2;
            Pen renderPen = new Pen(new SolidColorBrush(Colors.Navy), 1.5);
            double renderRadius = 5.0;

            // Draw a circle at each corner.
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopLeft, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopRight, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomLeft, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
        }

        */

        /*
        static IntPtr desktopPtr;
        static Graphics g;


        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);


        public static void Initialize()
        {
            desktopPtr = GetDC(IntPtr.Zero);
            g = Graphics.FromHdc(desktopPtr);
        }

        public static void Dispose()
        {
            if(g != null)
                g.Dispose();

            if (desktopPtr != IntPtr.Zero)
                ReleaseDC(IntPtr.Zero, desktopPtr);
        }

        static int i = 300;

        public static void DrawRectangle()
        {
            //SolidBrush b = new SolidBrush(Color.Green);
            //g.FillRectangle(b, new Rectangle(0, 0, 1920, 1080));

            LivePreview.mainForm.Refresh();

            g.DrawRectangle(Pens.Green, new Rectangle(400, i, 200, 100));
            i += 50;



        }
        */



    }
}
