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
    public partial class LabelEditor : Form
    {
        private LabelObject Target;

        public LabelEditor(LabelObject labelObject)
        {
            InitializeComponent();

            this.Target = labelObject;
            LoadParameters();
        }

        private void LoadParameters()
        {
            LivePreview.SuspendUpdates();

            Target.SaveFlags();

            tb_name.Text = Target.Name;
            tb_name.Tag = Target.Name;

            tb_key.Text = Target.Key;
            tb_key.Tag = Target.Key;

            LoadColor();
            lab_color.Tag = Target.TextColor;

            fontSize.Value = Target.FontSize;
            fontSize.Tag = Target.FontSize;

            LoadFontList();   
            fontList.Tag = Target.FontID;

            ShowFontStyle();
            pan_FontStyle.Tag = Target.FontStyle;

            ShowRotation();
            LoadTextTable();

            LivePreview.ResumeUpdates();
        }

        private void DiscardChanges()
        {
            Target.LoadFlags();

            Target.Name = (string)tb_name.Tag;
            Target.Key = (string)tb_key.Tag;

            Target.TextColor = (Color)lab_color.Tag;
            Target.FontSize = (byte)fontSize.Tag;

            Target.FontID = (string)fontList.Tag;
            Target.FontStyle = (byte)pan_FontStyle.Tag;

            for (int i = 0; i < textTable.Rows.Count; i++)
            {
                string langCode = textTable[grid_lang.Index, i].Value.ToString();
                Target.ContentTable[langCode] = textTable[grid_old_value.Index, i].Value.ToString();
            }   
        }

        private void LoadTextTable()
        {
            textTable.Rows.Clear();

            foreach (var lang in Target.ContentTable)
                textTable.Rows.Add(lang.Key, lang.Value, lang.Value);
        }

        private class FontListEntry
        {
            public string FontID { get; set; }
            public string FontCustomName { get; set; }
            public FontListEntry(string fontID, string fontCustomName)
            {
                FontID = fontID;
                FontCustomName = fontCustomName;
            }
        }

        private void LoadFontList()
        {
            fontList.Items.Clear();
            fontList.DisplayMember = "FontCustomName";

            foreach (var f in Fonts.fontList)
            {
                // Create a font list entry ;3
                FontListEntry e = new FontListEntry(f.Key, f.Value.CustomName);

                // Add the font object
                fontList.Items.Add(e);

                // Select the selected font
                if (f.Key == Target.FontID)
                    fontList.SelectedItem = e;
            }
        }

        private void TextTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (textTable.SelectedCells.Count > 0)
            {
                string langCode = textTable[grid_lang.Index, e.RowIndex].Value.ToString();

                StringEditor stringEditor = new StringEditor("Insert the text to display - " + langCode);

                stringEditor.textBox.Text =
                    textTable[grid_content.Index, e.RowIndex].Value.ToString();

                if (stringEditor.ShowDialog() == DialogResult.OK)
                {
                    if (stringEditor.textBox.Text.Length == 0)
                        Funcs.Error("The label text must be at least 1 character long !");
                    else
                        Target.ContentTable[langCode] = stringEditor.textBox.Text;
                }

                textTable[grid_content.Index, e.RowIndex].Value = Target.ContentTable[langCode];
                LivePreview.Update();
            }
        }

        private void LabelEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
            {
                DiscardChanges();
                LivePreview.Update();
            }
        }

        #region Label Style inputs methods

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            Target.FontSize = (byte)fontSize.Value;
            LivePreview.Update();
        }

        private void FontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Target.FontID = ((FontListEntry)fontList.SelectedItem).FontID;
            LivePreview.Update();
        }

        private void ShowFontStyle()
        {
            btn_FSR.BackColor = btn_FSB.BackColor = btn_FSI.BackColor = btn_FSU.BackColor =
            btn_FSS.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(255, 148, 0);

            if (Target.FontStyle == 0) btn_FSR.BackColor = c;
            if ((Target.FontStyle & (int)FontStyle.Bold) > 0) btn_FSB.BackColor = c;
            if ((Target.FontStyle & (int)FontStyle.Italic) > 0) btn_FSI.BackColor = c;
            if ((Target.FontStyle & (int)FontStyle.Underline) > 0) btn_FSU.BackColor = c;
            if ((Target.FontStyle & (int)FontStyle.Strikeout) > 0) btn_FSS.BackColor = c;
        }

        private void ShowFlags()
        {
            btn_F1.BackColor = btn_F2.BackColor = btn_F3.BackColor = btn_F4.BackColor =
            btn_F5.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(166, 62, 63);

            if ((Target.LabelFlags & (int)LabelObject.ItemFlags.F1) > 0) btn_F1.BackColor = c;
            if ((Target.LabelFlags & (int)LabelObject.ItemFlags.F2) > 0) btn_F2.BackColor = c;
            if ((Target.LabelFlags & (int)LabelObject.ItemFlags.F3) > 0) btn_F3.BackColor = c;
            if ((Target.LabelFlags & (int)LabelObject.ItemFlags.F4) > 0) btn_F4.BackColor = c;
            if ((Target.LabelFlags & (int)LabelObject.ItemFlags.F5) > 0) btn_F5.BackColor = c;
        }

        private void FontStyle_OnClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag.ToString().ToUpper())
            {
                case "R":
                    Target.FontStyle = 0;
                    break;

                case "B":
                    Target.FontStyle ^= (int)FontStyle.Bold;
                    break;

                case "I":
                    Target.FontStyle ^= (int)FontStyle.Italic;
                    break;

                case "U":
                    Target.FontStyle ^= (int)FontStyle.Underline;
                    break;

                case "S":
                    Target.FontStyle ^= (int)FontStyle.Strikeout;
                    break;
            }

            ShowFontStyle();
            LivePreview.Update();
        }

        private void Flags_OnClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Text.ToUpper())
            {
                case "1":
                    Target.LabelFlags ^= (int)LabelObject.ItemFlags.F1;
                    break;

                case "2":
                    Target.LabelFlags ^= (int)LabelObject.ItemFlags.F2;
                    break;

                case "3":
                    Target.LabelFlags ^= (int)LabelObject.ItemFlags.F3;
                    break;

                case "4":
                    Target.LabelFlags ^= (int)LabelObject.ItemFlags.F4;
                    break;

                case "5":
                    Target.LabelFlags ^= (int)LabelObject.ItemFlags.F5;
                    break;
            }

            ShowFlags();
            LivePreview.Update();
        }

        #endregion

        #region Color parameter methods

        private void LoadColor()
        {
            tb_color_r.Text = Target.TextColor.R.ToString();
            tb_color_g.Text = Target.TextColor.G.ToString();
            tb_color_b.Text = Target.TextColor.B.ToString();

            lab_color.BackColor = Target.TextColor;
            LivePreview.Update();
        }

        private void Lab_color_Click(object sender, EventArgs e)
        {
            Project.colorDialog.Color = Target.TextColor;

            if (Project.colorDialog.ShowDialog() == DialogResult.OK)
            {
                Target.TextColor = Project.colorDialog.Color;
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
            Target.TextColor = Color.FromArgb(Funcs.Clamp(tb_color_r.Text, 0, 255),
                                                   Funcs.Clamp(tb_color_g.Text, 0, 255),
                                                   Funcs.Clamp(tb_color_b.Text, 0, 255));

            // Reload all inputs and display the color
            LoadColor();
        }

        #endregion

        private void TextTable_Enter(object sender, EventArgs e)
        {
            ActiveControl = label1;
        }

        private void Tb_key_Validated(object sender, EventArgs e)
        {
            Target.Key = tb_key.Text;
        }

        private void ShowRotation()
        {
            int angle = 0;
            if (Target.IsVertical) angle += 90;
            if (Target.IsTurned180) angle += 180;

            lab_angle.Text = $"{angle} °";

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
    }
}
