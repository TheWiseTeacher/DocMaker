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
        private static int lineObjCounter = 0;

        public static void Initialize()
        {

            //Clear object list
            objectList.Clear();

            labelObjCounter = 0;
            lineObjCounter = 0;
        }

        public static DocumentObject NewLabel()
        {
            LabelObject docObject = new LabelObject(labelObjCounter + 1);

            if (docObject.EditObject())
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

            if(docObject.EditObject())
            {
                objectList.Add(docObject);

                lineObjCounter++;
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

        public static void ApplyZoom()
        {
            foreach (DocumentObject obj in objectList)
            {
                obj.ApplyZoom();
            }
        }
    }
}
