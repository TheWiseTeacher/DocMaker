﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public class LabelObject : DocumentObject
    {
        public string FontID { get; set; }

        public byte FontSize { get; set; }

        public byte FontStyle { get; set; }

        public byte LabelFlags { get; set; }

        public Color TextColor { get; set; }

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

        public LabelObject(int labelCounter)
        {
            Name = "Label " + labelCounter.ToString();

            FontID = Config.DEFAULT_FONT;
            FontSize = 12;
            TextColor = Color.FromArgb(0, 0, 0);

            SetAlignment(DocumentObject.Flags.Left | DocumentObject.Flags.Down);

            FontStyle = 0;
            LabelFlags = 0;

            //Create a text value for each language
            ContentTable = new Dictionary<string, string>();
            foreach (string lang in Project.UsedLanguages)
                ContentTable.Add(lang, "");

            ContentTable[Project.UsedLanguages[0]] = $"New Label {labelCounter}";
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

        public void CheckFont(string fontID)
        {
            if (FontID == fontID)
                FontID = Config.DEFAULT_FONT;
        }

        public override void RenderObject()
        {
            Point anchor = new Point(0, 0);

            Font font = Fonts.GetFont(FontID, Zoom.GetFontSize(FontSize), (FontStyle)FontStyle);

            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            g.ApplyGraphicsQuality();

            // Measure label size
            SizeF s = g.MeasureString(ContentTable[Project.UsedLanguages[0]], font);
            s = new SizeF((float)Math.Ceiling(s.Width), (float)Math.Ceiling(s.Height));

            g.Dispose();

            // Is Object Vertical
            if (IsVertical)
                s.Flip();

            Bitmap b = new Bitmap((int)s.Width, (int)s.Height);

            g = Graphics.FromImage(b);
            g.ApplyGraphicsQuality();

            Point trans = Point.Empty;
            int angle = 0;

            if(IsVertical)
            {
                if (!IsTurned180) trans.X = (int)s.Width;
                angle += 90;
            }

            if(IsTurned180)
            {
                if (!IsVertical) trans = new Point((int)s.Width, (int)s.Height);
                else trans.Y = Funcs.ToInt(s.Height);

                angle += 180;
            }

            // Apply transformation when label is rotated
            g.TranslateTransform(trans.X, trans.Y);
            g.RotateTransform(angle);

            // Draw the string
            g.DrawString(ContentTable[Project.UsedLanguages[0]], 
                         font, 
                         new SolidBrush(TextColor), 
                         Point.Empty);

            // Remove the transformation for next drawing methods
            g.ResetTransform();

            // Draw the anchor point for this label
            if(Config.ShowAnchorPoints)
            {
                if (IsCenter()) anchor.X = (int)(s.Width * 0.5F);
                if (IsRight()) anchor.X = (int)s.Width - 1;

                if (IsMiddle()) anchor.Y = (int)(s.Height * 0.5F);
                if (IsDown()) anchor.Y = (int)s.Height - 1;

                g.DrawLine(Config.AnchorPen, anchor.X - Config.ANCHOR_SIZE, anchor.Y, anchor.X + Config.ANCHOR_SIZE, anchor.Y);
                g.DrawLine(Config.AnchorPen, anchor.X, anchor.Y - Config.ANCHOR_SIZE, anchor.X, anchor.Y + Config.ANCHOR_SIZE);
            }

            // Release previous rendered bitmap (A lil bit of memore'h :3)
            if(Canvas.Image != null)
                Canvas.Image.Dispose();

            // Set Canvas Image
            Canvas.Image = b;
            Canvas.Size = Canvas.Image.Size;

            base.RenderObject();
        }

        public override bool EditObject()
        {
            LabelEditor editor = new LabelEditor(this);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                RenderObject();
                return true;
            }

            return false;
        }

    }
}
