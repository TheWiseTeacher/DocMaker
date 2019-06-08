using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public class CustomPanel : Panel
    {
        public int WheelDelta = 0;

        protected override System.Drawing.Point ScrollToControl(System.Windows.Forms.Control activeControl)
        {
            /* Thanks to Untouchable
             * https://stackoverflow.com/a/9317532/4944832
             * 
             * Without this code PageWrapper scroller keeps reseting when
             * loosing focus (sometimes when hovering above a child)
             * 
             */
        
            // Returning the current location prevents the panel from
            // scrolling to the active control when the panel loses and regains focus
            return this.DisplayRectangle.Location;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            //Save wheel delta before negating it
            WheelDelta = e.Delta;

            if (Control.ModifierKeys == Keys.Control ||
                Control.ModifierKeys == Keys.Shift ||
                Control.ModifierKeys == Keys.Alt)
            {
                e = new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, 0);
            }

            base.OnMouseWheel(e);
        }

        public void TriggerMouseWheel(MouseEventArgs e)
        {
            OnMouseWheel(e);
        }
    }
}
