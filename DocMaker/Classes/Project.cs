using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    static class Project
    {
        // Load PrinterSettings
        public static PrinterSettings printerSettings = new PrinterSettings();
        public static IEnumerable<PaperSize> paperSizes = printerSettings.PaperSizes.Cast<PaperSize>();

        public static ColorDialog colorDialog;

        // Selected paperSize for this project
        public static PaperSize paperSize = null;

        // Temporary cache file
        private static string ProjectTemp = Path.GetTempPath() + "\\DocMaker_Project.dmt";

        private static FileStream tempFile = null;

        public static List<string> UsedLanguages = new List<string>();

        public static bool isLandscape;

        public static bool NewProject()
        {
            if(tempFile != null)
            {
                tempFile.Close();
                tempFile.Dispose();
            }

            if (colorDialog != null)
                colorDialog.Dispose();

            colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;

            // Select default paper size "A4" for the new project
            paperSize = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4);

            tempFile = File.OpenWrite(ProjectTemp);

            //Clear languages list
            UsedLanguages.Clear();

            //Add default language
            UsedLanguages.Add("default");

            Fonts.Initialize();
            Objects.Initialize();

            return true;
        }



    }
}
