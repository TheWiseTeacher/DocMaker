using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    static class Objects
    {
        public static List<DocumentObject> objectList = new List<DocumentObject>();

        private static int labelObjCounter = 0;
        private static int ImageObjCounter = 0;
        private static int lineObjCounter = 0;
        private static bool isLoadingObjects = false;

        public static void Initialize()
        {
            // Remove document objects
            foreach(DocumentObject docObj in objectList)
            {
                if(docObj != null)
                {
                    docObj.Dispose();
                }
            }

            // Clear object list
            objectList.Clear();

            labelObjCounter = 0;
            ImageObjCounter = 0;
            lineObjCounter = 0;
        }

        public static DocumentObject NewLabel()
        {
            LabelObject docObject = new LabelObject(labelObjCounter + 1, isLoadingObjects);

            if (isLoadingObjects || docObject.EditObject())
            {
                objectList.Add(docObject);

                labelObjCounter++;
                return docObject;
            }

            return null;
        }

        public static DocumentObject NewLine()
        {
            LineObject docObject = new LineObject(lineObjCounter + 1);

            if(isLoadingObjects || docObject.EditObject())
            {
                objectList.Add(docObject);

                lineObjCounter++;
                return docObject;
            }

            return null;
        }

        public static DocumentObject NewImage()
        {
            ImageObject docObject = new ImageObject(ImageObjCounter + 1);

            if (docObject.EditObject())
            {
                objectList.Add(docObject);

                ImageObjCounter++;
                return docObject;
            }

            return null;
        }

        public static void AddLanguage(string languageCode)
        {
            foreach(DocumentObject docObject in objectList)
            {
                if(docObject is LabelObject)
                {
                    ((LabelObject)docObject).AddLanguage(languageCode);
                }
            }
        }

        public static void RemoveLanguage(string languageCode)
        {
            foreach (DocumentObject docObject in objectList)
            {
                if (docObject is LabelObject)
                {
                    ((LabelObject)docObject).RemoveLanguage(languageCode);
                }
            }
        }

        public static void DeletedFont(string fontID)
        {
            foreach (DocumentObject docObject in objectList)
            {
                if (docObject is LabelObject)
                {
                    ((LabelObject)docObject).CheckFont(fontID);
                }
            }
        }

        public static void DeletedResource(string resID)
        {
            foreach (DocumentObject docObject in objectList)
            {
                if (docObject is ImageObject)
                {
                    ((ImageObject)docObject).CheckResource(resID);
                }
            }
        }

        public static void RenderAll()
        {
            foreach (DocumentObject obj in objectList)
            {
                obj.RenderObject();
                obj.Holder.Update();
            }
        }

        public static void SaveObjects()
        {
            Project.fileHandler.Write(objectList.Count);

            foreach(DocumentObject docObject in objectList)
            {
                docObject.SaveObject();
            }
        }

        public static void LoadObjects()
        {
            // prevent editor on creating new objects
            isLoadingObjects = true;
            
            int objCounter = Project.fileHandler.ReadInteger();
            
            for(int i = 0; i < objCounter; i++)
            {
                // Read the Identifier
                char OBJ_IDENTIFIER = Project.fileHandler.ReadChar();
                DocumentObject buffer;

                switch(OBJ_IDENTIFIER)
                {
                    case 'L':
                        /*
                        LabelObject docObject = new LabelObject(labelObjCounter + 1);
                        labelObjCounter++;

                        objectList.Add(docObject);*/

                        buffer = NewLabel();
                        buffer.LoadObject();

                        break;

                    case 'O':
                    default:
                        buffer = new DocumentObject();
                        buffer.LoadObject();
                        break;
                }
            }

            // Open editor on creating new objects
            isLoadingObjects = false;

            // Render all objects
            RenderAll();
        }

    }
}
