using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocMaker
{
    static class Resources
    {
        // Temporary cache file
        private static string projectTempDir = Path.GetTempPath() + "\\DocMakerTempDir\\";
        private const string DEFAULT_RESOURCE_NAME = "(none)";

        public static List<string> resourceList = new List<string>();
        public static List<Bitmap> resourceBitmap = new List<Bitmap>();

        public static string GetResourceFilePath(string resID)
        {
            return projectTempDir + resID;
        }

        public static void ClearList()
        {
            resourceList.Clear();
            resourceList.Add(DEFAULT_RESOURCE_NAME);

            // Release preloaded bitmaps
            foreach (Bitmap b in resourceBitmap)
                b.Dispose();

            resourceBitmap.Clear();
            resourceBitmap.Add(DocMaker.Properties.Resources.none);
        }

        public static void EmptyTempFolder()
        {
            if (!Directory.Exists(projectTempDir))
            {
                Directory.CreateDirectory(projectTempDir);
            }

            string[] files = Directory.GetFiles(projectTempDir);
            foreach (string file in files)
            {
                File.Delete(file);
            }

            Resources.ClearList();
        }

        private static void LoadResourceBitmap(string filePath, int onlyUpdateIndex = -1)
        {
            using (Bitmap tempBitmap = new Bitmap(filePath))
            {
                if (onlyUpdateIndex < 0)
                    resourceBitmap.Add(new Bitmap(tempBitmap));
                else
                {
                    resourceBitmap[onlyUpdateIndex].Dispose();
                    resourceBitmap[onlyUpdateIndex] = new Bitmap(tempBitmap);
                }
            }
        }

        public static void AddResourceFile(string filePath)
        {
            string resID = Path.GetFileName(filePath);
            int resListIndex =  resourceList.IndexOf(resID);

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

            if (resListIndex == -1)
            {
                // Add a new resource file
                resourceList.Add(resID);
                LoadResourceBitmap(destFile);
            }
            else
            {
                // Update the resource file in case of overwrite
                LoadResourceBitmap(destFile, resListIndex);
            }
        }

        public static void RemoveResourceFile(string resID)
        {
            for (int i = resourceList.Count - 1; i > 0; i--)
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

        public static Bitmap Get(string resID)
        {
            int resIndex = resourceList.IndexOf(resID);
            return resourceBitmap[resIndex < 0 ? 0 : resIndex];
        }

        public static void SaveResources()
        {
            // Write the number of resource files minus the default (none)
            Project.fileHandler.Write(resourceList.Count - 1);

            for (int i = 1; i < resourceList.Count; i++)
            {
                Project.fileHandler.Write(resourceList[i]);
                Project.fileHandler.WriteFile(GetResourceFilePath(resourceList[i]));
            }
        }

        public static void LoadResources()
        {
            int objectCounter = Project.fileHandler.ReadInteger();
            for (int i = 0; i < objectCounter; i++)
            {
                string buffer = Project.fileHandler.ReadString();
                resourceList.Add(buffer);

                buffer = GetResourceFilePath(buffer);
                Project.fileHandler.ReadFile(buffer);

                LoadResourceBitmap(buffer);
            }
        }
    }
}
