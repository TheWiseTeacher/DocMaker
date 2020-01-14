using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace DocMaker
{
    static class Paper
    {
        // Load PrinterSettings
        private static PrinterSettings printerSettings;
        public static List<PaperSize> paperSizes;

        // Selected paperSize for this project
        public static PaperSize SelectedPaper { get; private set; } = null;
        public static bool UsingCustomPaper { get; set; }
        public static bool IsLandScape { get; set; }

        public static int Width
        {
            get
            {
                if (IsLandScape)
                    return SelectedPaper.Height;
                else
                    return SelectedPaper.Width;
            }
        }

        public static int Height
        {
            get
            {
                if (IsLandScape)
                    return SelectedPaper.Width;
                else
                    return SelectedPaper.Height;
            }
        }

        public static void Initialize()
        {
            if(printerSettings == null)
                printerSettings = new PrinterSettings();

            if(paperSizes == null)
                paperSizes = new List<PaperSize>();

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
            }

            // Select default paper size "A4" for the new project
            SelectedPaper = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4);

            // Select Portrait Mode
            IsLandScape = false;
        }

        public static void Set(PaperSize ps)
        {
            SelectedPaper = ps;
        }

        public static void SavePaper()
        {
            Project.fileHandler.Write(UsingCustomPaper);
            Project.fileHandler.Write(IsLandScape);

            // Save the custom paper size before the kind so it can be loaded once for all
            Project.fileHandler.Write(paperSizes[0].Width);
            Project.fileHandler.Write(paperSizes[0].Height);

            Project.fileHandler.Write(SelectedPaper.Kind.ToString());
        }

        public static void ExportPaper()
        {
            //Project.fileHandler.Write(IsLandScape);
            Project.fileHandler.Write(Width);
            Project.fileHandler.Write(Height);
        }
        
        public static void LoadPaper()
        {
            Initialize(); // Reset values

            UsingCustomPaper = Project.fileHandler.ReadBoolean();
            IsLandScape = Project.fileHandler.ReadBoolean();

            // Read the custom paper size before selecting the paper kind
            paperSizes[0].Width = Project.fileHandler.ReadInteger();
            paperSizes[0].Height = Project.fileHandler.ReadInteger();

            // Read paper kind and select it
            string targetKind = Project.fileHandler.ReadString();

            foreach (PaperSize ps in paperSizes)
            {
                if (ps.Kind.ToString().Equals(targetKind))
                {
                    SelectedPaper = ps;
                    break; // Break if found ?!!
                }
            }

            // Resize the paper before putting the documentObjects
            LivePreview.mainForm.ResizePaper();
        }
    }
}
