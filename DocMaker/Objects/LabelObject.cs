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
        public byte HorizontalAlignment { get; set; }
        public byte VerticalAlignment { get; set; }
        public byte FontStyle { get; set; }
        public byte Flags { get; set; }

        public Dictionary<string, string> ContentTable;

        [Flags]
        public enum ItemFlags
        {
            F1 = 1,
            F2 = 2,
            F3 = 4,
            F4 = 8,
            F5 = 16
        }

        public LabelObject(int labelCounter)
        {
            Name = "Label " + labelCounter.ToString();
            Key = "";

            FontID = 0;
            FontSize = 12;

            HorizontalAlignment = 0;
            VerticalAlignment = 0;
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


            //b.Save("test.jpg");

            return b;
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
