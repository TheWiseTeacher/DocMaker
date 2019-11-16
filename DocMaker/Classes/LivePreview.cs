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

        public static DocumentObject currentObject = null;
        private static bool suspendedUpdates = false;

        public static void Update()
        {
            if (mainForm == null || currentObject == null || suspendedUpdates)
                return;

            Console.WriteLine("Updating...");

            currentObject.RenderObject();
            currentObject.Holder.Update();
        }

        public static void SuspendUpdates() => suspendedUpdates = true;

        public static void ResumeUpdates() => suspendedUpdates = false;
    }
}
