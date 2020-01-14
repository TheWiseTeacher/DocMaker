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
        /*
        public class FontEntry
        {
            public bool IsExternal { get; set; }
            public string FontName { get; set; }
            public string FontData { get; set; }
        }
        */
        //public static List<FontEntry> fontList = new List<FontEntry>();

        //private static List<byte[]> ExternalFontRaw = new List<byte[]>();
        //private static List<PrivateFontCollection> ExternalFont = new List<PrivateFontCollection>();

        const string LOAD_FROM_BYTES_FLAG = "__LOADING_FROM_PROJECT_FILE__";

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

        



        public static void Initialize(bool skipDefault = false)
        {
            // Free some memory
            foreach (var p in fontList.Values)
            {
                if (p.pfc != null)
                    p.pfc.Dispose();

                if (p.fontRawBytes != null)
                    p.fontRawBytes = null;
            }

            fontList.Clear();

            if(!skipDefault) // Add the default font here if not asked to skip this
                AddFont(false, $"{Config.DEFAULT_FONT} {Config.DEFAULT_FONT_NAME}", Config.DEFAULT_FONT);
        }

        public static void AddFont(bool isExternal, string customName, string fontNameOrFile, byte[] byteArray = null)
        {
            FontData data = new FontData();     // Here lies the soult of the font data :3

            data.IsExternal = isExternal;       // True if it's an external file else False for system fonts
            data.CustomName = customName;       // a custom name for the font

            string keyName  = fontNameOrFile;

            if (isExternal)
            {
                // Load font and add its raw data to ExternalFontsRaw list
                if (!fontNameOrFile.Equals(LOAD_FROM_BYTES_FLAG))
                    data.fontRawBytes = File.ReadAllBytes(fontNameOrFile);
                else
                    data.fontRawBytes = byteArray;

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
        }

        public static void SaveFonts()
        {
            Project.fileHandler.Write(fontList.Count);
            foreach (var p in fontList)
            {
                Project.fileHandler.Write(p.Value.IsExternal);
                Project.fileHandler.Write(p.Value.CustomName);

                if(!p.Value.IsExternal)
                    Project.fileHandler.Write(p.Key);
                else
                    Project.fileHandler.Write(p.Value.fontRawBytes);
            }
        }

        public static void ExportFonts()
        {
            Project.fileHandler.Write(fontList.Count);

            foreach (var p in fontList)
            {
                Project.fileHandler.Write(p.Value.IsExternal);
                Project.fileHandler.Write(p.Value.CustomName);

                if (!p.Value.IsExternal)
                    Project.fileHandler.Write(p.Key);
                else
                    Project.fileHandler.Write(p.Value.fontRawBytes);
            }

        }

        public static void LoadFonts()
        {        
            Initialize(true);   // Initialise and skip adding the default font because it will be loaded from file

            int fontNum = Project.fileHandler.ReadInteger();    // The number of fonts saved in the project file

            for (int i = 0; i < fontNum; i++)
            {
                if(Project.fileHandler.ReadBoolean())
                {
                    AddFont(true,
                            Project.fileHandler.ReadString(),
                            LOAD_FROM_BYTES_FLAG,
                            Project.fileHandler.ReadBytes());
                }
                else
                {
                    AddFont(false,
                            Project.fileHandler.ReadString(),
                            Project.fileHandler.ReadString());
                }
               
            }
        }
    }
}
