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

        // TODO : add a changes list so we can go back in time with Ctrl+Z 'Whoaoaoa :O'
        public static List<string> changeList = new List<string>(); 


        // static int resourceCounter = 0;

        public static void Initialize()
        {
            //Paper.Initialize();
        }

        public static void InitializeComponents()
        {
            // Empty the temp folder for the new project files
            Resources.EmptyTempFolder();

            // Clear paper from the controls
            LivePreview.paperReference.Controls.Clear();

            if (colorDialog != null)
                colorDialog.Dispose();

            colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;

            Paper.Initialize();
            Fonts.Initialize();

            Languages.Initialize();
            Objects.Initialize();

            LivePreview.UnSelect();
        }

        public static void NewProject()
        {
            // Reset project file to be none
            projectLoadedFromFile = false;
            projectTitle = "New project";
            projectFile = string.Empty;

            InitializeComponents();
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

                fileHandler = new BinaryFileHandler(projectFile, BinaryFileHandler.FileMode.WRITE);

                Paper.SavePaper();
                Fonts.SaveFonts();
                Languages.SaveLanguages();

                Resources.SaveResources();
                Objects.SaveObjects();

                fileHandler.Close();
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

                if(changeList.Count > 0)
                {
                    DialogResult dr = Funcs.Question_YNC("Do you want to save changes before opening the file ?");

                    if (dr == DialogResult.Cancel)
                        return;

                    if (dr == DialogResult.Yes)
                        SaveProject();
                }

                // Save the file
                projectLoadedFromFile = true;
                projectFile = fileDialog.FileName;
                projectTitle = Path.GetFileName(projectFile);
            }

            try
            {
                InitializeComponents();

                fileHandler = new BinaryFileHandler(projectFile, BinaryFileHandler.FileMode.READ);

                Paper.LoadPaper();
                Fonts.LoadFonts();
                Languages.LoadLanguages();

                Resources.LoadResources();
                Objects.LoadObjects();

                fileHandler.Close();
            }
            catch (Exception ex)
            {
                Funcs.Error("Error while loading the project file.\n" + ex.Message);
                fileHandler.Close(); // Force closing file

                NewProject();
            }
        }
    }
}
