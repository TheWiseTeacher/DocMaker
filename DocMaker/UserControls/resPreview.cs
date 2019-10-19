using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public partial class resPreview : UserControl
    {
        public resPreview(string resID)
        {
            InitializeComponent();
            //this.Margin = new Padding(1);

            //lab_name.Text = Project.resourceList[resID];
            //pictureFrame.BackgroundImage = Image.FromFile(Project.GetResourceFilePath(resID));


        }

        private void ResPreview_Click(object sender, EventArgs e)
        {

        }
    }
}
