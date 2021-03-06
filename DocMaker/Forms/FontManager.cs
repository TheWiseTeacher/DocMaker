﻿using System;
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
    public partial class FontManager : Form
    {

        public FontManager()
        {
            InitializeComponent();
        }

        private void LoadFonts()
        { 
            //Clear old data
            fontsTable.Rows.Clear();
    
            foreach(var pair in Fonts.fontList)
            {
                fontsTable.Rows.Add(pair.Key, pair.Value.CustomName);
            }

        }


        private void FontManager_Load(object sender, EventArgs e)
        {
            LoadFonts();
        }

        private void Btn_add_sys_font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowColor = false;
            fontDialog.ShowApply = false;
            fontDialog.ShowEffects = false;
            fontDialog.ShowHelp = true;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                Fonts.AddFont(false, fontDialog.Font.Name, fontDialog.Font.Name);
                LoadFonts();
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FontsTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePreview();
        }
        private void FontsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdatePreview();
        }

        private int previewSize = 12;

        private void UpdatePreview()
        {
            lab_preview_size.Text = previewSize.ToString();

            if (fontsTable.SelectedCells.Count > 0)
            {
                string fontID = fontsTable[grid_id.Index, fontsTable.SelectedCells[0].RowIndex].Value.ToString();
                lab_preview.Font = Fonts.GetFont(fontID, previewSize);
            }
        }

        private void Btn_size_up_Click(object sender, EventArgs e)
        {
            previewSize += 2;

            if (previewSize > 48)
                previewSize = 48;

            UpdatePreview();
        }

        private void Btn_size_down_Click(object sender, EventArgs e)
        {
            previewSize -= 2;

            if (previewSize < 8)
                previewSize = 8;

            UpdatePreview();
        }

        private void Lab_preview_Click(object sender, EventArgs e)
        {
            StringEditor stringEditor = new StringEditor();
            stringEditor.textBox.Text = lab_preview.Text;

            if(stringEditor.ShowDialog() == DialogResult.OK)
                lab_preview.Text = stringEditor.textBox.Text;
        }

        private void Btn_edit_name_Click(object sender, EventArgs e)
        {
            if (fontsTable.SelectedCells.Count > 0)
            {
                string fontID = fontsTable[grid_id.Index, fontsTable.SelectedCells[0].RowIndex].Value.ToString();

                StringEditor stringEditor = new StringEditor();
                stringEditor.textBox.Text = Fonts.fontList[fontID].CustomName;

                if (stringEditor.ShowDialog() == DialogResult.OK)
                {
                    Fonts.fontList[fontID].CustomName = stringEditor.textBox.Text;
                    LoadFonts();
                }
            }

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (fontsTable.SelectedCells.Count > 0)
            {
                string fontID = fontsTable[grid_id.Index, fontsTable.SelectedCells[0].RowIndex].Value.ToString();

                if (fontID == Config.DEFAULT_FONT)
                {
                    Funcs.Information("You can't delete the default font, it is used when a font is missing or corrupted.");
                }
                else
                {
                    if (Funcs.Question("Are you sure you want to delete this font ?") == DialogResult.Yes)
                    {
                        Fonts.fontList.Remove(fontID);
                        Objects.DeletedFont(fontID);

                        LoadFonts();
                        Objects.RenderAll();
                    }
                }
            }
        }

        private void Btn_add_ext_font_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Config.LastVisitedPath;

            fileDialog.Title = "Select your font files";
            fileDialog.Multiselect = true;

            fileDialog.Filter = "TrueType Font files (*.ttf)|*.ttf";
            fileDialog.DefaultExt = "ttf";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Save last opened directory
                Config.LastVisitedPath = Path.GetDirectoryName(fileDialog.FileName);

                foreach(string file in fileDialog.FileNames)
                {
                    if (File.Exists(file))
                    {
                        Fonts.AddFont(true, Path.GetFileName(file), file);
                    }
                }
            }

            LoadFonts();
        }

        private void FontsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_edit_name.PerformClick();
        }


    }
}
