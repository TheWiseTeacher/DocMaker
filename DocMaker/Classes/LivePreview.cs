using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    static class LivePreview
    {
        public static Form mainForm = null;
        public static DocumentObject currentObject = null;

        public static void Update()
        {
            if (mainForm == null || currentObject == null)
                return;

            currentObject.RenderObject();
            currentObject.Canvas.Update();

        }

    }
}
