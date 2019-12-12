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
            lab_color.Tag = Target.LineColor;

            radioHorizontal.Checked = !Target.IsVertical;
            radioVertical.Checked = Target.IsVertical;

            SetLineRanges();
            lineLength.Text = Target.Length.ToString();
            lineLength.Tag = Target.Length;

            lineThickness.Value = Target.Thickness;
            lineThickness.Tag = Target.Thickness;

            tbDashPattern.Text = Target.DashPattern;
            tbDashPattern.Tag = Target.DashPattern;

            ShowSizeMode();

            LivePreview.ResumeUpdates();
        }

        private void DiscardChanges()
        {
            Target.LoadFlags();

            this.Target.Name = (string)tb_name.Tag;
            this.Target.Key = (string)tb_key.Tag;

            Target.LineColor = (Color)lab_color.Tag;

            Target.Length = (float)lineLength.Tag;

            Target.Thickness = (byte)lineThickness.Tag;

            Target.DashPattern = (string)tbDashPattern.Tag;
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
            tb_color_r.Text = Target.LineColor.R.ToString();
            tb_color_g.Text = Target.LineColor.G.ToString();
            tb_color_b.Text = Target.LineColor.B.ToString();

            lab_color.BackColor = Target.LineColor;
            LivePreview.Update();
        }

        private void Lab_color_Click(object sender, EventArgs e)
        {
            Project.colorDialog.Color = Target.LineColor;

            if (Project.colorDialog.ShowDialog() == DialogResult.OK)
            {
                Target.LineColor = Project.colorDialog.Color;
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
            Target.LineColor = Color.FromArgb(tb_color_r.IntValue(), tb_color_g.IntValue(), tb_color_b.IntValue());

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


        private void Orientation_CheckedChanged(object sender, EventArgs e)
        {
            // Filter only one change and discard this other
            if (((RadioButton)sender).Checked)
                return;

            Target.IsVertical = radioVertical.Checked;
            LivePreview.Update();
        }

        private void SetLineRanges()
        {
            if (Target.SizeInPercent)
            {
                lineLength.AllowDecimal = true;
                lineLength.Maximum = 100.0f;
                lineLength.Minimum = 0.001f;
            }
            else
            {
                lineLength.AllowDecimal = false;
                lineLength.Maximum = Config.MaxLineSize;
                lineLength.Minimum = 1;
            }
        }

        private void SizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if value changed !
            if (Target.SizeInPercent == sizeMode.SelectedItem.Equals("%"))
                return;

            // Set the option
            Target.SizeInPercent = sizeMode.SelectedItem.Equals("%");
            SetLineRanges();

            // Mode Changed so we will calculate size from object size 
            if (Target.SizeInPercent)
            {
                // Previously the size was in pixels
                if (Target.IsVertical)
                    lineLength.Text = ((Target.Length / Paper.Height) * 100f).ToString();
                else
                    lineLength.Text = ((Target.Length / Paper.Width) * 100f).ToString();
            }
            else
            {
                // Previously the size was in percentage
                if (Target.IsVertical)
                    lineLength.Text = ((int)(Paper.Height * Target.Length / 100f)).ToString();
                else
                    lineLength.Text = ((int)(Paper.Width * Target.Length / 100f)).ToString();
            }

            LivePreview.Update();
        }

        private void lineLength_OnSafeTextChange(object sender, string safeValue)
        {
            if (Target.SizeInPercent)
                Target.Length = lineLength.GetFloatValue();
            else
                Target.Length = lineLength.GetFloatValue();

            LivePreview.Update();
        }

        private void tbDashPattern_OnSafeTextChange(object sender, string safeValue)
        {
            Target.DashPattern = safeValue;
            LivePreview.Update();
        }
    }
}
