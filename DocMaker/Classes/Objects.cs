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
        private static int labelObjCounter = 0;
        public static List<DocumentObject> objectList = new List<DocumentObject>();


        public static void Initialize()
        {
            //Clear object list
            objectList.Clear();

            labelObjCounter = 0;
        }


        public static void AddLabel(Panel holder)
        { 
            labelObjCounter++;

            //Set document object to label type
            LabelObject label = new LabelObject(labelObjCounter);

            //Call object editor and add object to objectsList if edited and confirmed
            if(label.EditObject())
            {
                holder.Controls.Add(label.Canvas);
                objectList.Add(label);
            }
            else
            {
                //We did not add a label
                labelObjCounter--;
            }
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
