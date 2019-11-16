using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace DocMaker
{
    static class Paper
    {
        // Load PrinterSettings
        public static PrinterSettings printerSettings;
        public static List<PaperSize> paperSizes;

        // Selected paperSize for this project
        public static PaperSize paperSize = null;
        public static bool usingCustomPaper = false;

        public static bool isLandscape;


        public static void Initialize()
        {
            if(printerSettings == null)
                printerSettings = new PrinterSettings();

            if(paperSizes == null)
                paperSizes = new List<PaperSize>();

            //paperSizes = printerSettings.PaperSizes.Cast<PaperSize>();

            // Clear paper list
            paperSizes.Clear();

            // Add a customizable paper at the TOP [0]
            paperSizes.Add(new PaperSize(Config.CUSTOM_PAPER_NAME,
                                         Config.CUSTOM_PAPER_SIZE.Width,
                                         Config.CUSTOM_PAPER_SIZE.Height));

            // Add other kind of papers
            foreach (PaperSize ps in printerSettings.PaperSizes)
            {
                if (!ps.Kind.ToString().Equals("Custom"))
                    paperSizes.Add(ps);

                //Console.WriteLine("Bad Paper : {0} {1}", ps.PaperName, ps.Kind);
                //Console.WriteLine("{0} {1}", ps.PaperName, ps.Kind);
            }

            // Select default paper size "A4" for the new project
            paperSize = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4);

            // Select Portrait Mode
            isLandscape = false;
        }

        public static void SavePaper()
        {
            Project.fileHandler.Write(usingCustomPaper);
            Project.fileHandler.Write(isLandscape);

            // Save the custom paper size before the kind so it can be loaded once for all
            Project.fileHandler.Write(paperSizes[0].Width);
            Project.fileHandler.Write(paperSizes[0].Height);

            Project.fileHandler.Write(paperSize.Kind.ToString());
        }
        
        public static void LoadPaper()
        {
            Initialize(); // Reset values

            usingCustomPaper = Project.fileHandler.ReadBoolean();
            isLandscape = Project.fileHandler.ReadBoolean();

            // Read the custom paper size before selecting the paper kind
            paperSizes[0].Width = Project.fileHandler.ReadInteger();
            paperSizes[0].Height = Project.fileHandler.ReadInteger();

            // Read paper kind and select it
            string targetKind = Project.fileHandler.ReadString();
            //if(targetKind.Equals(""))
            foreach (PaperSize ps in paperSizes)
                if (ps.Kind.ToString().Equals(targetKind))
                {
                    paperSize = ps;
                    break; // Break if found ?!!
                }
        }
    }
}
