using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace DocMaker
{
    public class LabelObject : ICloneable
    {
        public string Name { get; set; }

        public string Key { get; set; }

        public byte FontID { get; set; }

        public byte FontSize { get; set; }

        public byte Alignment { get; set; }

        public byte FontStyle { get; set; }

        public byte Flags { get; set; }

        public Dictionary<string, string> ContentTable;

        [Flags]
        public enum ItemFlags
        {
            //To use later I don't know
            F1 = 1,
            F2 = 2,
            F3 = 4,
            F4 = 8,
            F5 = 16
        }

        [Flags]
        public enum AlignmentFlags
        {
            Left = 1,
            Center = 2,
            Right = 4,
            Up = 8,
            Middle = 16,
            Down = 32
        }

        public LabelObject(int labelCounter)
        {
            Name = "Label " + labelCounter.ToString();
            Key = "";

            FontID = 0;
            FontSize = 12;

            Alignment = (int)AlignmentFlags.Left | (int)AlignmentFlags.Down;
            FontStyle = 0;

            Flags = 0;

            //Create a text value for each language
            ContentTable = new Dictionary<string, string>();
            foreach (string lang in Project.UsedLanguages)
                ContentTable.Add(lang, "");

            ContentTable[Project.UsedLanguages[0]] = $"New Label {labelCounter}";
        }

        public Bitmap Render(string lang)
        {
            Font font = Fonts.GetFont(FontID, Zoom.GetFontSize(FontSize), (FontStyle)FontStyle);

            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            ApplyGraphicsQuality(g);

            //Measure label size
            SizeF s = g.MeasureString(ContentTable[lang], font);
            g.Dispose();

            Bitmap b = new Bitmap((int)s.Width, (int)s.Height);

            g = Graphics.FromImage(b);
            ApplyGraphicsQuality(g);

            g.DrawString(ContentTable[lang], font, Brushes.Black, new Point(0, 0));

            //g.DrawLine(new Pen(Color.Red, 2), 0, 0, 4, 0);
            //g.DrawLine(new Pen(Color.Red, 2), 0, 0, 0, 4);

            var p = new Pen(Color.Red, 1);
            //g.DrawRectangle(p, new Rectangle(0, 0, 16, 2));
            //g.DrawRectangle(p, new Rectangle(0, 0, 2, 16));

            float X = 0;
            float Y = 0;

            if ((Alignment & (int)AlignmentFlags.Left) > 0) X = 0;
            if ((Alignment & (int)AlignmentFlags.Center) > 0) X = (s.Width * 0.5F);
            if ((Alignment & (int)AlignmentFlags.Right) > 0) X = s.Width - 1;

            if ((Alignment & (int)AlignmentFlags.Up) > 0) Y = 0;
            if ((Alignment & (int)AlignmentFlags.Middle) > 0) Y = (s.Height * 0.5F);
            if ((Alignment & (int)AlignmentFlags.Down) > 0) Y = s.Height - 1;

            g.DrawLine(p, X - 5, Y, X + 5, Y);
            g.DrawLine(p, X, Y - 5, X, Y + 5);

            //b.Save("test.jpg");

            return b;
        }

        private void RenderAnchorPoint()
        {


        }

        private void ApplyGraphicsQuality(Graphics g)
        {
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            g.SmoothingMode = SmoothingMode.HighSpeed;
        }

        public void AddLanguage(string languageCode)
        {
            if (!ContentTable.ContainsKey(languageCode))
                ContentTable.Add(languageCode, "");
        }

        public void RemoveLanguage(string languageCode)
        {
            if (ContentTable.ContainsKey(languageCode))
                ContentTable.Remove(languageCode);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
