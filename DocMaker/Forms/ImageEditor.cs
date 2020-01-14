using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public partial class ImageEditor : Form
    {
        private ImageObject Target;
        private bool editorReady = false;

        private bool IsLinkUpdate = false;
        private float aspectRatio;

        public ImageEditor(ImageObject target)
        {
            InitializeComponent();

            this.Target = target;
            LoadParameters();

            ActiveControl = btn_confirm;
        }

        private void LoadParameters()
        {
            LivePreview.SuspendUpdates();

            Target.SaveFlags();

            tb_name.Text = Target.Name;
            tb_name.Tag = Target.Name;

            tb_key.Text = Target.Key;
            tb_key.Tag = Target.Key;

            SetSizeRanges();

            tb_width.Text = Target.Width.ToString();
            tb_width.Tag = Target.Width;

            tb_height.Text = Target.Height.ToString();
            tb_height.Tag = Target.Height;

            cb_link.Checked = Target.LinkedSize;

            resourceComboList.Tag = Target.ResourceID;
            resourceComboList.DataSource = Resources.resourceList;
            resourceComboList.SelectedIndex = Resources.resourceList.IndexOf(Target.ResourceID);

            drawingModeCombo.DataSource = Enum.GetNames(typeof(ImageObject.DrawingTypes));
            drawingModeCombo.SelectedIndex = (int)Target.drawingType;
            drawingModeCombo.Tag = Target.drawingType;

            //EmployeeType empType = (EmployeeType)Enum.Parse(typeof(EmployeeType), ddl.SelectedValue);

            ShowSizeMode();
            ShowRotation();

            editorReady = true;
            LivePreview.ResumeUpdates();
        }

        private void DiscardChanges()
        {
            Target.LoadFlags();

            Target.Name = (string)tb_name.Tag;
            Target.Key = (string)tb_key.Tag;

            Target.ResourceID = (string)resourceComboList.Tag;

            Target.Width = (float)tb_width.Tag;
            Target.Height = (float)tb_height.Tag;

            Target.drawingType = (ImageObject.DrawingTypes)drawingModeCombo.Tag;

            UpdateCanvasImage();
        }

        public void ShowSizeMode()
        {
            if (!Target.SizeInPercent)
                sizeMode.SelectedItem = "Px";
            else
                sizeMode.SelectedItem = "%";
        }

        private void LabelEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DiscardChanges();
                LivePreview.Update();
            }
        }

        private void Tb_name_Validated(object sender, EventArgs e)
        {
            if (tb_name.Text.Equals(""))
                tb_name.Text = "Image object";

            Target.Name = tb_name.Text;
        }

        private void Tb_key_Validated(object sender, EventArgs e)
        {
            Target.Key = tb_key.Text;
        }

        private void UpdateCanvasImage()
        {
            //Target.Canvas.BackgroundImage = Project.resourceBitmap[Project.resourceList.IndexOf(Target.ResourceID)];


            //Target.Canvas.Size = Target.Canvas.Image.Size;
        }

        private void ShowRotation()
        {
            int angle = 0;
            if (Target.IsVertical) angle += 90;
            if (Target.IsTurned180) angle += 180;

            lab_angle.Text = $"{angle} °";

            if (!Target.IsVertical)
            {
                lab_size.Text = $"{imageFrame.BackgroundImage.Width}x{imageFrame.BackgroundImage.Height}";
                aspectRatio = (float)imageFrame.BackgroundImage.Width / (float)imageFrame.BackgroundImage.Height;
            }
            else
            {
                lab_size.Text = $"{imageFrame.BackgroundImage.Height}x{imageFrame.BackgroundImage.Width}";
                aspectRatio = (float)imageFrame.BackgroundImage.Height / (float)imageFrame.BackgroundImage.Width;
            }


            LivePreview.Update();
        }

        private void Btn_rotate_r_Click(object sender, EventArgs e)
        {
            Target.Rotate();
            ShowRotation();
        }

        private void Btn_rotate_l_Click(object sender, EventArgs e)
        {
            Target.Rotate(true);
            ShowRotation();
        }

        private void Btn_edit_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Config.LastVisitedPath;

            fileDialog.Title = "Select an image";
            fileDialog.Multiselect = false;

            fileDialog.Filter = "Portable network graphics files (*.png)|*.png|Jpeg files (*.jpg)|*.jpg";
            fileDialog.DefaultExt = "png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Save last opened directory
                Config.LastVisitedPath = Path.GetDirectoryName(fileDialog.FileName);

                if (File.Exists(fileDialog.FileName))
                {
                    Target.Holder.Image = Image.FromFile(fileDialog.FileName);
                    Target.Holder.Size = Target.Holder.Image.Size;
                }
            }
        }


        private void ResourceComboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageFrame.BackgroundImage = DocMaker.Properties.Resources.none;
            imageFrame.BackgroundImageLayout = ImageLayout.Center;

            if (resourceComboList.SelectedItem == null)
                return;

            int resID = resourceComboList.SelectedIndex;

            if (resID != 0)
            {
                Bitmap img = Resources.resourceBitmap[resID];

                if (img.Width > imageFrame.Width || img.Height > imageFrame.Height)
                    imageFrame.BackgroundImageLayout = ImageLayout.Zoom;
                else
                    imageFrame.BackgroundImageLayout = ImageLayout.Center;

                imageFrame.BackgroundImage = img;
            }

            // To recalculate size and aspect ratio
            ShowRotation();

            if (!editorReady)
                return;

            Target.ResourceID = (string)resourceComboList.SelectedItem;
            UpdateCanvasImage();

            //if(tb_width.Text.Equals("") || tb_height.Text.Equals(""))
            //{
            //    tb_width.Text = Target.Canvas.BackgroundImage.Size.Width.ToString();
            //    tb_height.Text = Target.Canvas.BackgroundImage.Size.Height.ToString();
            //}

            LivePreview.Update();
        }
        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            Target.ResourceID = (string)resourceComboList.SelectedItem;
            UpdateCanvasImage();
        }

        private void SetSizeRanges()
        {
            if (Target.SizeInPercent)
            {
                tb_width.AllowDecimal = tb_height.AllowDecimal = true;
                tb_width.Maximum = tb_height.Maximum = 100.0f;
                tb_width.Minimum = tb_height.Minimum = 0.001f;
            }
            else
            {
                tb_width.AllowDecimal = tb_height.AllowDecimal = false;
                tb_width.Maximum = tb_height.Maximum = Config.MaxLineSize;
                tb_width.Minimum = tb_height.Minimum = 1;
            }
        }

        private void SizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if value changed !
            if (Target.SizeInPercent == sizeMode.SelectedItem.Equals("%"))
                return;

            // Set the option
            Target.SizeInPercent = sizeMode.SelectedItem.Equals("%");
            SetSizeRanges();

            // Mode Changed so we will calculate size from object size 
            if (Target.SizeInPercent)
            {
                // Set the width and skip height if size in linked since it will be auto generated
                tb_width.Text = (Target.Width * 100f / Paper.Width).ToString();

                if(!Target.LinkedSize) 
                    tb_height.Text = (Target.Height * 100f / Paper.Height).ToString();
            }
            else
            {
                // Previously the size was in percentage
                tb_width.Text = ((int)(Paper.Width * Target.Width / 100f)).ToString();

                if (!Target.LinkedSize)
                    tb_height.Text = ((int)(Paper.Height * Target.Height / 100f)).ToString();

            }

            LivePreview.Update();
        }

        private void tb_width_OnSafeTextChange(object sender, string safeValue)
        {
            if (!editorReady || IsLinkUpdate)
            {
                IsLinkUpdate = false;
                return;
            }

            Target.Width = tb_width.GetFloatValue();

            if(Target.LinkedSize)
            {
                Target.Height = tb_width.GetFloatValue() / aspectRatio;
                    tb_height.Text = Target.SizeInPercent ? Target.Height.ToString() : ((int)Target.Height).ToString();

                if(!tb_height.Text.Equals(Target.Height))
                {
                    //IsLinkUpdate = true;
                }
            }
 
            LivePreview.Update();
        }

        private void tb_height_OnSafeTextChange(object sender, string safeValue)
        {
            if (!editorReady || IsLinkUpdate)
            {
                IsLinkUpdate = false;
                return;
            }

            Target.Height = tb_height.GetFloatValue();

            if (Target.LinkedSize)
            {
                Target.Width = tb_height.GetFloatValue() * aspectRatio;
                    tb_width.Text = Target.SizeInPercent ? Target.Width.ToString() : ((int)Target.Width).ToString();

                if (!tb_width.Text.Equals(Target.Width))
                {
                    //IsLinkUpdate = true;
                }

                
            }
            
            LivePreview.Update();
        }


        /*
        private void Tb_width_TextChanged(object sender, EventArgs e)
        {
            if (Target.ObjectSize.Width == tb_width.IntValue())
                return;

            // Set the new width
            Target.ObjectSize = new Size(tb_width.IntValue(), Target.ObjectSize.Height);

            if(Target.SizeInPercent)
            {

            }

            tb_width.Text = Target.ObjectSize.Width.ToString();

            if (cb_link.Checked && !IsLinkUpdate)
            {
                Console.WriteLine("Updating height");

                IsLinkUpdate = true;
                tb_height.Text = Funcs.Max(((int)(((float)Target.ObjectSize.Width) / aspectRatio)), 1).ToString();
            }
            else
            {
                LivePreview.Update();
                IsLinkUpdate = false;
            }

        }

        private void Tb_height_TextChanged(object sender, EventArgs e)
        {
            if (Target.ObjectSize.Height == tb_height.IntValue())
                return;

            // Set the new height
            Target.ObjectSize = new Size(Target.ObjectSize.Width, tb_height.IntValue());

            tb_height.Text = Target.ObjectSize.Height.ToString();

            if (cb_link.Checked && !IsLinkUpdate)
            {
                Console.WriteLine("Updating width");

                IsLinkUpdate = true;
                tb_width.Text = Funcs.Max(((int)(((float)Target.ObjectSize.Height) * aspectRatio)), 1).ToString();

            }
            else
            {
                LivePreview.Update();
                IsLinkUpdate = false;
            }
        }

    */
        
        private void cb_link_CheckedChanged(object sender, EventArgs e)
        {
            Target.LinkedSize = cb_link.Checked;
        }

        private void Lab_size_Click(object sender, EventArgs e)
        {
            bool tempLinkStat = cb_link.Checked;
            LivePreview.SuspendUpdates();

            // Disable Link Temporarily
            cb_link.Checked = false;

            if(!Target.IsVertical)
            {
                tb_width.Text = imageFrame.BackgroundImage.Width.ToString();
                tb_height.Text = imageFrame.BackgroundImage.Height.ToString();
            }
            else
            {
                tb_width.Text = imageFrame.BackgroundImage.Height.ToString();
                tb_height.Text = imageFrame.BackgroundImage.Width.ToString();
            }

            cb_link.Checked = tempLinkStat;

            LivePreview.ResumeUpdates();
            LivePreview.Update();
        }

        private void DrawingModeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!editorReady)
                return;

            Target.drawingType = (ImageObject.DrawingTypes)drawingModeCombo.SelectedIndex;

            LivePreview.Update();
        }


    }
}
