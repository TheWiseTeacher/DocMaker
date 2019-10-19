using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    static class Project
    {

        public static BinaryFileHandler fileHandler = null;
        public static bool projectLoadedFromFile = false;
        public static string projectTitle;
        public static string projectFile;

        public static ColorDialog colorDialog;



        // Temporary cache file
        private static string projectTempDir = Path.GetTempPath() + "\\DocMakerTempDir\\";

        public static List<string> UsedLanguages = new List<string>();

        public static List<string> resourceList = new List<string>();
        public static List<Bitmap> resourceBitmap = new List<Bitmap>();
        // static int resourceCounter = 0;

        public static void Initialize()
        {
            //Paper.Initialize();
        }

        public static bool NewProject()
        {
            // Empty the temp folder for the new project files
            EmptyTempFolder();

            // Reset project file to be none
            projectLoadedFromFile = false;
            projectTitle = "New project";
            projectFile = string.Empty;

            if (colorDialog != null)
                colorDialog.Dispose();

            colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;


            // tempFile = File.OpenWrite(projectTempDir);

            //Clear languages list
            UsedLanguages.Clear();

            //Add default language
            UsedLanguages.Add("default");

            Paper.Initialize();
            Fonts.Initialize();
            Objects.Initialize();

            return true;
        }

        public static void SaveProject(bool SaveAs = false)
        {
            if (!projectLoadedFromFile || SaveAs)
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.InitialDirectory = Config.LastVisitedPath;

                fileDialog.Title = "Save your project";

                fileDialog.Filter = "DocMaker Project (*.dmprj)|*.dmprj";
                fileDialog.DefaultExt = "dmprj";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Save last opened directory
                    Config.LastVisitedPath = Path.GetDirectoryName(fileDialog.FileName);

                    /*
                    // Windows already asks if you want to replace file
                    if (File.Exists(fileDialog.FileName))
                    {
                        if (Funcs.Question("Do you want to overwrite this file ?") != DialogResult.Yes)
                            return;
                    }
                    */

                    // Save the file
                    projectLoadedFromFile = true;
                    projectFile = fileDialog.FileName;
                    projectTitle = Path.GetFileName(projectFile);
                }
            }

            if (projectLoadedFromFile)
            {
                //Saving routings

                BinaryFileHandler f = new BinaryFileHandler(projectFile, BinaryFileHandler.FileMode.WRITE);

                Paper.SavePaper(f);
                Fonts.SaveFonts(f);

                f.Close();
            }
        }

        public static void OpenProject()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Config.LastVisitedPath;

            fileDialog.Title = "Open a project";
            fileDialog.Multiselect = false;

            fileDialog.Filter = "DocMaker Project (*.dmprj)|*.dmprj";
            fileDialog.DefaultExt = "dmprj";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Save last opened directory
                Config.LastVisitedPath = Path.GetDirectoryName(fileDialog.FileName);

                if (!File.Exists(fileDialog.FileName))
                {
                    Funcs.Error("Project file not found !");
                    return;
                }

                DialogResult dr = Funcs.Question_YNC("Do you want to save changes before opening the file ?");

                if(dr == DialogResult.Cancel)
                    return;

                if(dr == DialogResult.Yes)
                    SaveProject();

                // Save the file
                projectLoadedFromFile = true;
                projectFile = fileDialog.FileName;
                projectTitle = Path.GetFileName(projectFile);
            }

            try
            {
                fileHandler = new BinaryFileHandler(projectFile, BinaryFileHandler.FileMode.READ);
                Paper.LoadPaper(fileHandler);
                Fonts.LoadFonts(fileHandler);
                fileHandler.Close();
            }
            catch (Exception ex)
            {
                Funcs.Error("Error while loading the project file.\n" + ex.Message);
                fileHandler.Close(); // Force closing file
            }
        }


        public static string GetResourceFilePath(string resID)
        {
            return projectTempDir + resID;
        }

        private static void EmptyTempFolder()
        {
            if(!Directory.Exists(projectTempDir))
            {
                Directory.CreateDirectory(projectTempDir);
            }

            string[] files = Directory.GetFiles(projectTempDir);
            foreach(string file in files)
            {
                File.Delete(file);
            }

            //resourceCounter = 0;
            resourceList.Clear();
            resourceList.Add("(none)");

            // Release preloaded bitmaps
            foreach(Bitmap b in resourceBitmap)
                b.Dispose();

            resourceBitmap.Clear();
            resourceBitmap.Add(DocMaker.Properties.Resources.none);
        }



        public static void AddResourceFile(string filePath)
        {
            string resID = Path.GetFileName(filePath);
            int resListIndex = resourceList.IndexOf(resID);

            if (resListIndex != -1)
            {
                if (Funcs.Question("A resource file with the same name is already in the resource list!\n" +
                    $"Do you want to overwrite '{resID}' ?") != DialogResult.Yes)
                {
                    return;
                }
            }

            string destFile = string.Format("{0}{1}", projectTempDir, Path.GetFileName(filePath));
            File.Copy(filePath, destFile, true);

            if(resListIndex == -1)
            {
                // Add a new resource file
                resourceList.Add(resID);

                using (Bitmap tempBitmap = new Bitmap(destFile))
                { resourceBitmap.Add(new Bitmap(tempBitmap)); }
            }
            else
            {
                // Update the resource file in case of overwrite
                resourceBitmap[resListIndex].Dispose();

                using (Bitmap tempBitmap = new Bitmap(destFile))
                {resourceBitmap[resListIndex] = new Bitmap(tempBitmap);}
            }
        }

        public static void RemoveResourceFile(string resID)
        {
            for (int i = resourceList.Count-1; i > 0; i--)
            {
                if (resourceList[i].Equals(resID))
                {
                    resourceList.RemoveAt(i);
                    File.Delete(GetResourceFilePath(resID));

                    resourceBitmap[i].Dispose();
                    resourceBitmap.RemoveAt(i);
                }
            }
        }





    }
}
