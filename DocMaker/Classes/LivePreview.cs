using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    static class LivePreview
    {
        public static MainForm mainForm = null;
        public static Panel paperReference = null;

        public static DocumentObject currentObject { get; private set; } = null;
        private static bool suspendedUpdates = false;

        public static void Update()
        {
            if (mainForm == null || currentObject == null || suspendedUpdates)
                return;

            Console.WriteLine("Updating...");

            currentObject.RenderObject();
            currentObject.Holder.Update();
        }

        public delegate void SelectionChanged(DocumentObject documentObject);
        public static event SelectionChanged OnSelectionChange;

        public static void Select(DocumentObject documentObject, bool silently = false)
        {
            if (currentObject == documentObject)
                return;

            currentObject = documentObject;

            if(!silently)
                OnSelectionChange?.Invoke(documentObject);

            // For Debug
            if(documentObject != null)
                Console.WriteLine("Selected object : " + currentObject.Name);
            else
                Console.WriteLine("UnSelecting object");

        }

        public static void UnSelect(bool silently = false)
        {
            Select(null, silently);
        }

        public static void SuspendUpdates() => suspendedUpdates = true;

        public static void ResumeUpdates() => suspendedUpdates = false;
    }
}
