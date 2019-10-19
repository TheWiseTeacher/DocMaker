using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public partial class LineEditor : Form
    {
        private LineObject Target;

        public LineEditor(LineObject lineObject)
        {
            InitializeComponent();

            Target = lineObject;

            LoadParameters();

            ActiveControl = label1;
            //lineLength.MouseWheel += LineLength_MouseWheel;
        }

        /*
        private void LineLength_MouseWheel(object sender, MouseEventArgs e)
        {
            lineLength.Text =
                Funcs.Clamp((Funcs.ToInt(lineLength.Text) + 4 * Funcs.Force(Funcs.ToInt(e.Delta))),
                            1, Config.MaxLineSize).ToString();
        }
        */

        private void LoadParameters()
        {
            LivePreview.SuspendUpdates();

            Target.SaveFlags();

            tb_name.Text = this.Target.Name;
            tb_name.Tag = this.Target.Name;

            tb_key.Text = this.Target.Key;
            tb_key.Tag = this.Target.Key;

            LoadColor();
            lab_color.Tag = Target.BackColor;

            lineLength.Text = Target.Length.ToString();
            lineLength.Tag = Target.Length;

            lineThickness.Value = Target.Thickness;
            lineThickness.Tag = Target.Thickness;

            ShowOrientation();
            ShowSizeMode();

            LivePreview.ResumeUpdates();
        }

        private void DiscardChanges()
        {
            Target.LoadFlags();

            this.Target.Name = (string)tb_name.Tag;
            this.Target.Key = (string)tb_key.Tag;

            Target.BackColor = (Color)lab_color.Tag;

            Target.Length = (int)lineLength.Tag;

            Target.Thickness = (byte)lineThickness.Tag;
        }

        private void Tb_name_Validated(object sender, EventArgs e)
        {
            if (tb_name.Text.Equals(""))
                tb_name.Text = "Line object";

            Target.Name = tb_name.Text;
        }

        private void Tb_key_Validated(object sender, EventArgs e)
        {
            Target.Key = tb_key.Text;
        }

        private void ShowOrientation()
        {
            if (!Target.IsVertical)
            {
                radioHorizontal.Checked = true;
                radioVertical.Checked = false;
            }
            else
            {
                radioHorizontal.Checked = false;
                radioVertical.Checked = true;
            }

            LivePreview.Update();
        }


        public void ShowSizeMode()
        {
           if (!Target.SizeInPercent)
                sizeMode.SelectedItem = "Px";
            else
                sizeMode.SelectedItem = "%";
        }

        #region Color parameter methods

        private void LoadColor()
        {
            tb_color_r.Text = Target.BackColor.R.ToString();
            tb_color_g.Text = Target.BackColor.G.ToString();
            tb_color_b.Text = Target.BackColor.B.ToString();

            lab_color.BackColor = Target.BackColor;
            LivePreview.Update();
        }

        private void Lab_color_Click(object sender, EventArgs e)
        {
            Project.colorDialog.Color = Target.BackColor;

            if (Project.colorDialog.ShowDialog() == DialogResult.OK)
            {
                Target.BackColor = Project.colorDialog.Color;
                LoadColor();
            }
        }

        private void OnValidatingColorInput(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            int colorValue = Funcs.ToInt(tb.Text);

            if (colorValue < 0 || colorValue > 255)
                e.Cancel = true;

            // To prevent any exception I'm using a special Clamp method :3
            Target.BackColor = Color.FromArgb(Funcs.Clamp(tb_color_r.Text, 0, 255),
                                              Funcs.Clamp(tb_color_g.Text, 0, 255),
                                              Funcs.Clamp(tb_color_b.Text, 0, 255));

            // Reload all inputs and display the color
            LoadColor();
        }

        #endregion

        private void LabelEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
            {
                DiscardChanges();
                LivePreview.Update();
            }
        }

        private void LineThickness_ValueChanged(object sender, EventArgs e)
        {
            Target.Thickness = (byte)Funcs.Max(lineThickness.Value, 1);
            LivePreview.Update();
        }

        private void LineLength_TextChanged(object sender, EventArgs e)
        {
            Target.Length = Funcs.Clamp(lineLength.Text, 1, Config.MaxLineSize);
            LivePreview.Update();
        }

        private void LineLength_Validated(object sender, EventArgs e)
        {
            Target.Length = Funcs.Clamp(lineLength.Text, 1, Config.MaxLineSize);
            lineLength.Text = Target.Length.ToString();
            LivePreview.Update();
        }

        private void RadioHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioHorizontal.Checked)
                return;

            Target.IsVertical = false;
            ShowOrientation();
        }

        private void RadioVertical_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioVertical.Checked)
                return;

            Target.IsVertical = true;
            ShowOrientation();
        }

        private void SizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Target.SizeInPercent = !sizeMode.SelectedItem.Equals("Px");
            LivePreview.Update();
        }


    }
}
