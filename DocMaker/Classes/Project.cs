using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DocMaker
{
    static class Project
    {
        private static string ProjectTemp = Path.GetTempPath() + "\\DocMaker_Project.dmt";

        private static FileStream tempFile = null;

        public static List<string> UsedLanguages = new List<string>();

        public static bool NewProject()
        {
            if(tempFile != null)
            {
                tempFile.Close();
                tempFile.Dispose();
            }

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
