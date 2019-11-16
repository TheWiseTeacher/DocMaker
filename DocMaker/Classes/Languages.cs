using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocMaker
{
    public static class Languages
    {
        public static List<string> UsedLanguages = new List<string>();

        public static void Initialize()
        {
            // Clear languages list
            UsedLanguages.Clear();

            // Add a default language
            UsedLanguages.Add("default");
        }

        public static void SaveLanguages()
        {
            Project.fileHandler.Write(UsedLanguages.Count);

            foreach (string lang in UsedLanguages)
                Project.fileHandler.Write(lang);
        }

        public static void LoadLanguages()
        {
            UsedLanguages.Clear();
            int langCounter = Project.fileHandler.ReadInteger();

            for (int i = 0; i < langCounter; i++)
                UsedLanguages.Add(Project.fileHandler.ReadString());
        }

    }
}
