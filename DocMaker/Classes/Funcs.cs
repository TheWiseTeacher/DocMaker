using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    static class Funcs
    {
        public static int ToInt(object v)
        {
            try
            {
                return Convert.ToInt32(v);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
        public static float ToFloat(this string s)
        {
            try
            {
                return float.Parse(s);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int IntValue(this TextBox tb)
        {
            return ToInt(tb.Text);
        }

        public static int IntValue(this TextBox tb, int min, int max)
        {
            return Clamp(ToInt(tb.Text), min, max);
        }

        public static float[] GetFloatList(this string str, char separator)
        {
            return Array.ConvertAll(str.Split(separator), s => s.ToFloat());
        }

        public static void Flip(this Point p)
        {
            p = new Point(p.Y, p.X);
        }

        public static void Flip(this Size s)
        {
            s = new Size(s.Height, s.Width);
        }

        public static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        public static int Clamp(object value, int min, int max)
        {
            return Clamp(ToInt(value), min, max);
        }

        /*
        public static bool LimitTextBox(this TextBox tb, int targetReference, int min, int max)
        {
            int v = ToInt(tb.Text);

            if(v > max)
            {          
                Console.WriteLine("Invalidate");
                tb.Invalidate();

                tb.Text = max.ToString();
                return true;
            }else if(v < min)
            {
                Console.WriteLine("Invalidate");
                tb.Invalidate();
                tb.Text = min.ToString();
                return true;
            }

            
            return false;
        }
        */

        public static DialogResult Question(string message)
        {
            return MessageBox.Show(message, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult Question_YNC(string message)
        {
            return MessageBox.Show(message, "Please confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static DialogResult Information(string message)
        {
            return MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Error(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ApplyGraphicsQuality(this Graphics g)
        {
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            g.SmoothingMode = SmoothingMode.HighSpeed;
        }

        public static StringAlignment GetAlignment(object config)
        {
            if (config == null)
                return StringAlignment.Near;

            switch (config.ToString())
            {
                case "Center":
                case "Middle":
                case "C":
                case "M":
                    return StringAlignment.Center;

                case "Left":
                case "Up":
                case "L":
                case "U":
                    return StringAlignment.Near;

                case "Right":
                case "Down":
                case "R":
                case "D":
                    return StringAlignment.Far;

                default:
                    return StringAlignment.Near;

            }
            
        }

        public static string GetAlignmentFromChar(char config, bool Set)
        {
            if(!Set)
            {
                if ((int)config == 0) return "L";
                if ((int)config == 1) return "C";
                if ((int)config == 2) return "R";

                return "L";
            }
            else
            {
                if ((int)config == 0) return "U";
                if ((int)config == 1) return "M";
                if ((int)config == 2) return "D";

                return "U";
            }
        }

        public static FontFamily F(PrivateFontCollection TTF)
        {
            return TTF.Families[0];
        }

        public static Bitmap ResizeImage(Image image, double percent)
        {
            return ResizeImage(image,
                              (int)((double)image.Width * percent),
                              (int)((double)image.Height * percent));
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static int Max(int v, int m)
        {
            return (v >= m) ? v : m;
        }

        public static int Max(object v, int m)
        {
            return Max(ToInt(v), m);
        }

        public static int Force(int i)
        {
            if (i == 0) return 0;
            if (i > 0) return 1;
            else return -1;
        }

        public static int Min(int v, int m)
        {
            return (v <= m) ? v : m;
        }

        public static int Min(object v, int m)
        {
            return Min(ToInt(v), m);
        }

        public static FontStyle GetFontStyle(bool B, bool I, bool U, bool S)
        {
            FontStyle Result = FontStyle.Regular;

            if (B) Result |= FontStyle.Bold;
            if (I) Result |= FontStyle.Italic;
            if (U) Result |= FontStyle.Underline;
            if (S) Result |= FontStyle.Strikeout;

            return Result;
        }

        public static byte[] getBytes(object str)
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);

            return arr;
        }

        public static T fromBytes<T>(byte[] arr)
        {
            T str = default(T);

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (T)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);
            
            return str;
        }

        public static bool ItemMove<T>(this List<T> list, int oldIndex, int newIndex)
        {
            //Thanks To Francisco
            //https://stackoverflow.com/a/28597288/4944832

            // exit if possitions are equal or outside array
            if ((oldIndex == newIndex) || (0 > oldIndex) || (oldIndex >= list.Count) || (0 > newIndex) ||
                (newIndex >= list.Count)) return false;

            // local variables
            var i = 0;
            T tmp = list[oldIndex];

            // move element down and shift other elements up
            if (oldIndex < newIndex)
            {
                for (i = oldIndex; i < newIndex; i++)
                {
                    list[i] = list[i + 1];
                }
            }
            else // move element up and shift other elements down
            {
                for (i = oldIndex; i > newIndex; i--)
                {
                    list[i] = list[i - 1];
                }
            }

            // put element from position 1 to destination
            list[newIndex] = tmp;
            return true;
        }
    }
}
