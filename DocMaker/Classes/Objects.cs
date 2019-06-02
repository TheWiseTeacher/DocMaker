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

            //Create a new document object
            DocumentObject documentObject = new DocumentObject();

            //Set document object to label type
            documentObject.Data = new LabelObject(labelObjCounter);

            //Call object editor and add object to objectsList if edited and confirmed
            if(documentObject.EditObject())
            {
                holder.Controls.Add(documentObject.Canvas);
                objectList.Add(documentObject);
            }
            
            /*
            LabelEditor labelEditor = new LabelEditor(data);
            if(labelEditor.ShowDialog() == DialogResult.OK)
            {
                
                documentObject.Data = data;

                //Render object
                documentObject.RenderObject();

                //add object to the holder panel
                
            }
            */
        }



        public static void AddLanguage(string languageCode)
        {
            foreach(DocumentObject obj in objectList)
            {
                if(obj.Data is LabelObject)
                {
                    ((LabelObject)obj.Data).AddLanguage(languageCode);
                }
            }
        }

        public static void RemoveLanguage(string languageCode)
        {
            foreach(DocumentObject obj in objectList)
            {
                if(obj.Data is LabelObject)
                {
                    ((LabelObject)obj.Data).RemoveLanguage(languageCode);
                }
            }
        }


    }
}
