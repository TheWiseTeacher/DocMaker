﻿using System;
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
        private LabelObject labelObject;
        private LabelObject originalLabelObject;

        public LabelEditor(LabelObject labelObject)
        {
            InitializeComponent();

            this.labelObject = labelObject;

            // Save the original configuration to apply if cancled
            originalLabelObject = (LabelObject)labelObject.Clone();

            // Clone the text table too
            originalLabelObject.ContentTable =
                labelObject.ContentTable.ToDictionary(entry => entry.Key,entry => (string)entry.Value.Clone());

            // Load object name and label key
            tb_name.Text = this.labelObject.Name;
            tb_key.Text = this.labelObject.Key;

            // Load and select the used font
            LoadFontList();
            fontList.SelectedIndex = labelObject.FontID;
            fontSize.Value = labelObject.FontSize;

            // Load other 
            ShowFontStyle();
            ShowFlags();

            // Load text for each language code
            LoadTextTable();

            ActiveControl = label1;
        }

        private void LoadTextTable()
        {
            textTable.Rows.Clear();

            foreach (var lang in labelObject.ContentTable)
            {
                textTable.Rows.Add(lang.Key, lang.Value);
            }
        }

        private void LoadFontList()
        {
            fontList.Items.Clear();

            foreach(Fonts.FontEntry f in Fonts.fontList)
            {
                fontList.Items.Add(f.FontName);
            }
        }

        private bool IsValidKeyChar(char c)
        {
            return
                (char.IsLetterOrDigit(c) && ((c >= 32 && c <= 127))) ||
                c == '_' || c == '$' || c == '#' ||
                c == (char)Keys.Delete ||
                c == (char)Keys.Back
                ;           
        }

        private void Tb_key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!IsValidKeyChar(e.KeyChar))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }           
        }

        private void Tb_key_Validated(object sender, EventArgs e)
        {
            string validString = "";
            foreach(char c in tb_key.Text)
            {
                if (IsValidKeyChar(c))
                    validString += c;
            }
            if(!tb_key.Text.Equals(validString))
            {
                System.Media.SystemSounds.Beep.Play();
                tb_key.Text = validString;
            }
        }

        private void TextTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (textTable.SelectedCells.Count > 0)
            {
                string langCode = textTable[grid_lang.Index, textTable.SelectedCells[0].RowIndex].Value.ToString();

                StringEditor stringEditor = new StringEditor("Insert the text to display - " + langCode);

                stringEditor.textBox.Text =
                    textTable[grid_content.Index, textTable.SelectedCells[0].RowIndex].Value.ToString();

                if (stringEditor.ShowDialog() == DialogResult.OK)
                {
                    if (stringEditor.textBox.Text.Length == 0)
                        Funcs.Error("The label text must be at least 1 character long !");
                    else
                        labelObject.ContentTable[langCode] = stringEditor.textBox.Text;
                }

                LoadTextTable();
                LivePreview.Update();
            }
        }


        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LabelEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
            {
                labelObject.Name = originalLabelObject.Name;
                labelObject.Key = originalLabelObject.Key;

                labelObject.FontID = originalLabelObject.FontID;
                labelObject.FontSize = originalLabelObject.FontSize;

                //labelObject.HorizontalAlignment = originalLabelObject.HorizontalAlignment;
                //labelObject.VerticalAlignment = originalLabelObject.VerticalAlignment;

                labelObject.Alignment = originalLabelObject.Alignment;

                labelObject.FontStyle = originalLabelObject.FontStyle;
                labelObject.Flags = originalLabelObject.Flags;

                foreach(string k in labelObject.ContentTable.Keys.ToList())
                {
                    labelObject.ContentTable[k] = (string)originalLabelObject.ContentTable[k].Clone();
                }

                LivePreview.Update();
            }
        }

        #region Style & alignement buttons methods

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            labelObject.FontSize = (byte)fontSize.Value;
            LivePreview.Update();
        }

        private void FontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelObject.FontID = (byte)fontList.SelectedIndex;
            LivePreview.Update();
        }

        private void ShowFontStyle()
        {
            btn_FSR.BackColor = btn_FSB.BackColor = btn_FSI.BackColor = btn_FSU.BackColor =
            btn_FSS.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(255, 148, 0);

            if (labelObject.FontStyle == 0) btn_FSR.BackColor = c;
            if ((labelObject.FontStyle & (int)FontStyle.Bold) > 0) btn_FSB.BackColor = c;
            if ((labelObject.FontStyle & (int)FontStyle.Italic) > 0) btn_FSI.BackColor = c;
            if ((labelObject.FontStyle & (int)FontStyle.Underline) > 0) btn_FSU.BackColor = c;
            if ((labelObject.FontStyle & (int)FontStyle.Strikeout) > 0) btn_FSS.BackColor = c;
        }

        private void ShowFlags()
        {
            btn_F1.BackColor = btn_F2.BackColor = btn_F3.BackColor = btn_F4.BackColor =
            btn_F5.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(166, 62, 63);

            if ((labelObject.Flags & (int)LabelObject.ItemFlags.F1) > 0) btn_F1.BackColor = c;
            if ((labelObject.Flags & (int)LabelObject.ItemFlags.F2) > 0) btn_F2.BackColor = c;
            if ((labelObject.Flags & (int)LabelObject.ItemFlags.F3) > 0) btn_F3.BackColor = c;
            if ((labelObject.Flags & (int)LabelObject.ItemFlags.F4) > 0) btn_F4.BackColor = c;
            if ((labelObject.Flags & (int)LabelObject.ItemFlags.F5) > 0) btn_F5.BackColor = c;
        }

        private void FontStyle_OnClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag.ToString().ToUpper())
            {
                case "R":
                    labelObject.FontStyle = 0;
                    break;

                case "B":
                    labelObject.FontStyle ^= (int)FontStyle.Bold;
                    break;

                case "I":
                    labelObject.FontStyle ^= (int)FontStyle.Italic;
                    break;

                case "U":
                    labelObject.FontStyle ^= (int)FontStyle.Underline;
                    break;

                case "S":
                    labelObject.FontStyle ^= (int)FontStyle.Strikeout;
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
                    labelObject.Flags ^= (int)LabelObject.ItemFlags.F1;
                    break;

                case "2":
                    labelObject.Flags ^= (int)LabelObject.ItemFlags.F2;
                    break;

                case "3":
                    labelObject.Flags ^= (int)LabelObject.ItemFlags.F3;
                    break;

                case "4":
                    labelObject.Flags ^= (int)LabelObject.ItemFlags.F4;
                    break;

                case "5":
                    labelObject.Flags ^= (int)LabelObject.ItemFlags.F5;
                    break;
            }

            ShowFlags();
            LivePreview.Update();
        }

        #endregion

        private void TextTable_Enter(object sender, EventArgs e)
        {
            ActiveControl = label1;
        }
    }
}
