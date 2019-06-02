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
        private LabelObject labelObject;
        private LabelObject originalLabelObject;

        public LabelEditor(LabelObject labelObject)
        {
            InitializeComponent();

            this.labelObject = labelObject;

            //Save the original configuration to apply if cancled
            originalLabelObject = (LabelObject)labelObject.Clone();

            //Clone the text table too
            originalLabelObject.ContentTable =
                labelObject.ContentTable.ToDictionary(entry => entry.Key,entry => (string)entry.Value.Clone());

            tb_name.Text = this.labelObject.Name;
            tb_key.Text = this.labelObject.Key;

            fontSize.Value = labelObject.FontSize;

            //Load fonts
            LoadFontList();
            fontList.SelectedIndex = labelObject.FontID;

            //Load text for each language code
            LoadTextTable();
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

                labelObject.HorizontalAlignment = originalLabelObject.HorizontalAlignment;
                labelObject.VerticalAlignment = originalLabelObject.VerticalAlignment;

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

        private byte GetAlignment(string a)
        {
            switch (a)
            {
                case "Center":
                case "Middle":
                case "C":
                case "M":
                    return (byte)StringAlignment.Center;

                case "Left":
                case "Up":
                case "L":
                case "U":
                    return (byte)StringAlignment.Near;

                case "Right":
                case "Down":
                case "R":
                case "D":
                    return (byte)StringAlignment.Far;

                default:
                    return (byte)StringAlignment.Near;
            }
        }

        private void ResetHAlign()
        {
            btn_HAL.BackColor = btn_HAC.BackColor = btn_HAR.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void ResetVAlign()
        {
            btn_VAU.BackColor = btn_VAM.BackColor = btn_VAD.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void HorizantalAlignment_OnClick(object sender, EventArgs e)
        {
            ResetHAlign();
            ((Button)sender).BackColor = Color.FromArgb(115, 181, 19);
            labelObject.HorizontalAlignment = GetAlignment(((Button)sender).Tag.ToString());
        }

        private void VerticalAlignment_OnClick(object sender, EventArgs e)
        {
            ResetVAlign();
            ((Button)sender).BackColor = Color.FromArgb(115, 181, 19);
            labelObject.VerticalAlignment = GetAlignment(((Button)sender).Tag.ToString());
        }
  

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

        private void SelectFontStyle(int fontStyle)
        {
            btn_FSR.BackColor = btn_FSB.BackColor = btn_FSI.BackColor = btn_FSU.BackColor =
            btn_FSS.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(255, 148, 0);

            if (fontStyle == 0) btn_FSR.BackColor = c;
            if ((fontStyle & (int)FontStyle.Bold) > 0) btn_FSB.BackColor = c;
            if ((fontStyle & (int)FontStyle.Italic) > 0) btn_FSI.BackColor = c;
            if ((fontStyle & (int)FontStyle.Underline) > 0) btn_FSU.BackColor = c;
            if ((fontStyle & (int)FontStyle.Strikeout) > 0) btn_FSS.BackColor = c;
        }

        private void SelectFlags(int flags)
        {
            btn_F1.BackColor = btn_F2.BackColor = btn_F3.BackColor = btn_F4.BackColor =
            btn_F5.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(166, 62, 63);

            if ((flags & (int)LabelObject.ItemFlags.F1) > 0) btn_F1.BackColor = c;
            if ((flags & (int)LabelObject.ItemFlags.F2) > 0) btn_F2.BackColor = c;
            if ((flags & (int)LabelObject.ItemFlags.F3) > 0) btn_F3.BackColor = c;
            if ((flags & (int)LabelObject.ItemFlags.F4) > 0) btn_F4.BackColor = c;
            if ((flags & (int)LabelObject.ItemFlags.F5) > 0) btn_F5.BackColor = c;

        }

        private void FontStyle_OnClick(object sender, EventArgs e)
        {
            int fontStyle = labelObject.FontStyle;

            switch (((Button)sender).Tag.ToString().ToUpper())
            {
                case "R":
                    fontStyle = 0;
                    break;

                case "B":
                    fontStyle ^= (int)FontStyle.Bold;
                    break;

                case "I":
                    fontStyle ^= (int)FontStyle.Italic;
                    break;

                case "U":
                    fontStyle ^= (int)FontStyle.Underline;
                    break;

                case "S":
                    fontStyle ^= (int)FontStyle.Strikeout;
                    break;
            }


            labelObject.FontStyle = (byte)fontStyle;

            SelectFontStyle(fontStyle);
            LivePreview.Update();
        }

        private void Flags_OnClick(object sender, EventArgs e)
        {
            int flags = labelObject.Flags;

            switch (((Button)sender).Text.ToUpper())
            {
                case "1":
                    flags ^= (int)LabelObject.ItemFlags.F1;
                    break;

                case "2":
                    flags ^= (int)LabelObject.ItemFlags.F2;
                    break;

                case "3":
                    flags ^= (int)LabelObject.ItemFlags.F3;
                    break;

                case "4":
                    flags ^= (int)LabelObject.ItemFlags.F4;
                    break;

                case "5":
                    flags ^= (int)LabelObject.ItemFlags.F5;
                    break;
            }

            labelObject.Flags = (byte)flags;

            SelectFlags(flags);
            LivePreview.Update();
        }

        #endregion

    }
}
