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

        //public static List<FontEntry> fontList = new List<FontEntry>();

        //private static List<byte[]> ExternalFontRaw = new List<byte[]>();
        //private static List<PrivateFontCollection> ExternalFont = new List<PrivateFontCollection>();


        public class FontData
        {
            public bool IsExternal { get; set; }

            public string CustomName { get; set; }

            public byte[] fontRawBytes { get; set; }

            public PrivateFontCollection pfc { get; set; }

            public FontData()
            {
                IsExternal = false;
                CustomName = "";

                fontRawBytes = null;
                pfc = null;
            }

            public FontFamily GetFamily()
            {
                if(pfc != null)
                    return pfc.Families[0];

                return FontFamily.GenericMonospace;           
            }
        }

        public static Dictionary<string, FontData> fontList = new Dictionary<string, FontData>();


        public static void Initialize()
        {
            //Clear all lists
            //fontList.Clear();    
            //ExternalFontRaw.Clear();

            //Free some memory
            //foreach (var pfc in ExternalFont) pfc.Dispose();
            //ExternalFont.Clear();

            // Free some memory
            foreach (var p in fontList.Values)
            {
                if (p.pfc != null)
                    p.pfc.Dispose();

                if (p.fontRawBytes != null)
                    p.fontRawBytes = null;
            }

            fontList.Clear();

            // Add a default font
            AddFont(false, $"{Config.DefaultFont} (default)", Config.DefaultFont);
        }

        public static void AddFont(bool isExternal, string customName, string fontNameOrFile)
        {
            FontData data = new FontData();     // Here lies the soult of the font data :3

            data.IsExternal = isExternal;       // True if it's an external file else False for system fonts
            data.CustomName = customName;       // a custom name for the font

            string keyName  = fontNameOrFile;

            if (isExternal)
            {
                // Load font and add its raw data to ExternalFontsRaw list
                data.fontRawBytes = File.ReadAllBytes(fontNameOrFile);

                // ASSIGN MEMORY AND COPY  BYTE[] ON THAT MEMORY ADDRESS
                IntPtr ptrData = Marshal.AllocCoTaskMem(data.fontRawBytes.Length);
                Marshal.Copy(data.fontRawBytes, 0, ptrData, data.fontRawBytes.Length);

                // Read the font file
                data.pfc = new PrivateFontCollection();
                data.pfc.AddMemoryFont(ptrData, data.fontRawBytes.Length);

                // FREE THE  "UNSAFE" MEMORY
                Marshal.FreeCoTaskMem(ptrData);

                // Check if we already added the same font earlier
                keyName = data.pfc.Families[0].Name;
            }

            if (fontList.ContainsKey(keyName))
                Funcs.Information("This font already exist in the list !");
            else
                fontList.Add(keyName, data);

        }

        public static Font GetFont(string id, int emSize = 12, FontStyle fontStyle = 0)
        {

            if(fontList.ContainsKey(id))
            {
                if(fontList[id].IsExternal)
                    return new Font(fontList[id].GetFamily(), emSize, fontStyle, GraphicsUnit.Pixel);
                else
                    return new Font(id, emSize, fontStyle, GraphicsUnit.Pixel);
            }

            return new Font("arial", emSize);


            /*
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
            */
        }

    }
}
