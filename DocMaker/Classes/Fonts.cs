using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DocMaker
{
    static class Fonts
    {
        public class FontEntry
        {
            public bool IsExternal { get; set; }
            public string FontName { get; set; }
            public string FontData { get; set; }
        }

        public static List<FontEntry> fontList = new List<FontEntry>();
        private static List<byte[]> ExternalFontRaw = new List<byte[]>();
        private static List<PrivateFontCollection> ExternalFont = new List<PrivateFontCollection>();

        
        private static int lastEntryIndex = 0;

        public static void Initialize()
        {
            //Clear all lists
            fontList.Clear();    
            ExternalFontRaw.Clear();

            //Free some memory
            foreach (var pfc in ExternalFont) pfc.Dispose();
            ExternalFont.Clear();

            AddFont(false, "Arial (default)", "Arial");
        }

        public static void AddFont(bool isExternal, string fontName, string fontData)
        {
            FontEntry fe = new FontEntry();

            if(isExternal)
            {
                lastEntryIndex = ExternalFontRaw.Count;

                //Load font and add its raw data to ExternalFontsRaw list
                ExternalFontRaw.Add(File.ReadAllBytes(fontData));

                // ASSIGN MEMORY AND COPY  BYTE[] ON THAT MEMORY ADDRESS
                IntPtr ptrData = Marshal.AllocCoTaskMem(ExternalFontRaw[lastEntryIndex].Length);
                Marshal.Copy(ExternalFontRaw[lastEntryIndex], 0, ptrData, ExternalFontRaw[lastEntryIndex].Length);

                //Read the font file
                ExternalFont.Add(new PrivateFontCollection());
                ExternalFont[lastEntryIndex].AddMemoryFont(ptrData, ExternalFontRaw[lastEntryIndex].Length);

                //FREE THE  "UNSAFE" MEMORY
                Marshal.FreeCoTaskMem(ptrData);

                fe.IsExternal = true;
                fe.FontName = ExternalFont[lastEntryIndex].Families[0].Name;
                fe.FontData = lastEntryIndex.ToString();
            }
            else
            {
                fe.IsExternal = false;
                fe.FontName = fontName;
                fe.FontData = fontData;
            }

            fontList.Add(fe);
        }

        public static Font GetFont(int id, int emSize = 12, FontStyle fontStyle = 0)
        {
            if (id < 0 || id >= fontList.Count)
                return new Font("arial", emSize);

            if(fontList[id].IsExternal)
            {
                int externalFontID = Funcs.ToInt(fontList[id].FontData);
                return new Font(ExternalFont[externalFontID].Families[0], emSize, fontStyle, GraphicsUnit.Pixel);
            }
            else
            {
                return new Font(fontList[id].FontData, emSize, fontStyle, GraphicsUnit.Pixel);
            }

        }

    }
}
