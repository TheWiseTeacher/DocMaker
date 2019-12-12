using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocMaker
{
    public class ObjectHolder : PictureBox
    {
        /*
        private delegate void SafeCallDelegate(object o);

        public void SetSize(object o)
        {
            if (this.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetSize);
                this.Invoke(d, new object[] { o });
            }
            else
            {
                this.Size = (Size)o;
            }
        }

        */

        /*
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        */
    }
}
