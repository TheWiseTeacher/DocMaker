using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DocMaker
{
    public partial class ResourceManager : Form
    {

        public ResourceManager()
        {
            InitializeComponent();
            RepopulateResourceList();

        }

        private void RepopulateResourceList()
        {
            //resourceList.Items.Clear();
            resourceList.DataSource = null;
            resourceList.DataSource = Resources.resourceList;    
        }

        private void btn_addResource_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Config.LastVisitedPath;

            fileDialog.Title = "Select one or multiple images";
            fileDialog.Multiselect = true;

            fileDialog.Filter = "Supported image files (*.png, *.jpg)|*.jpg;*.png|Portable network graphics files (*.png)|*.png|Jpeg files (*.jpg)|*.jpg";
            fileDialog.DefaultExt = "png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Save last opened directory
                Config.LastVisitedPath = Path.GetDirectoryName(fileDialog.FileName);

                foreach(string file in fileDialog.FileNames)
                {
                    if (File.Exists(file))
                    {
                        Resources.AddResourceFile(file);   
                    }
                }
            }

            RepopulateResourceList();
        }
        private void Btn_deleteResource_Click(object sender, EventArgs e)
        {
            if (resourceList.SelectedItem == null)
                return;

            string resID = resourceList.SelectedItem.ToString();

            if (resourceList.SelectedIndex != 0)
            {
                if(Funcs.Question("Are you sure you want to delete this file ?") == DialogResult.Yes)
                {
                    // free the image file from the preview panel so it can be deleted
                    imageFrame.BackgroundImage = null;

                    Resources.RemoveResourceFile(resID);
                    RepopulateResourceList();

                    Objects.DeletedResource(resID);
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResourceList_SelectedValueChanged(object sender, EventArgs e)
        {
            imageFrame.BackgroundImage = DocMaker.Properties.Resources.none;
            imageFrame.BackgroundImageLayout = ImageLayout.Center;

            if (resourceList.SelectedItem == null)
                return;

            int resID = resourceList.SelectedIndex;

            if(resID != 0)
            {
                Bitmap img = Resources.resourceBitmap[resID];

                if (img.Width > imageFrame.Width || img.Height > imageFrame.Height)
                    imageFrame.BackgroundImageLayout = ImageLayout.Zoom;
                else
                    imageFrame.BackgroundImageLayout = ImageLayout.Center;

                imageFrame.BackgroundImage = img;
            }
            
        }

        private void ImageFrame_Click(object sender, EventArgs e)
        {
            Project.colorDialog.Color = imageFrame.BackColor;

            if (Project.colorDialog.ShowDialog() == DialogResult.OK)
            {
                imageFrame.BackColor = Project.colorDialog.Color;
            }
        }

        private void ResourceManager_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                btn_deleteResource.PerformClick();
            }
        }

    }
}
