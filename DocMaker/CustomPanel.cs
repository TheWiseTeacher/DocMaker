using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    /* Thanks to Untouchable
     * https://stackoverflow.com/a/9317532/4944832
     * 
     * Without this code PageWrapper scroller keeps reseting when
     * loosing focus
     * 
     */

    public class CustomPanel : System.Windows.Forms.Panel
    {
        protected override System.Drawing.Point ScrollToControl(System.Windows.Forms.Control activeControl)
        {
            // Returning the current location prevents the panel from
            // scrolling to the active control when the panel loses and regains focus
            return this.DisplayRectangle.Location;
        }
    }
}
