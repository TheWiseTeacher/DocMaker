using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocMaker
{
    public partial class PaperManager : Form
    {
        PaperSize originalPaperSize;

        public PaperManager()
        {
            InitializeComponent();

            //Make combobox display paper name
            comboPaperSize.DisplayMember = "PaperName";

            //Save the selected paperSize in case of canceling
            originalPaperSize = Paper.SelectedPaper;

            LoadPaperFormats();
            UpdateInformation();
        }

        private void LoadPaperFormats()
        {
            foreach (PaperSize ps in Paper.paperSizes)
            {
                comboPaperSize.Items.Add(ps);

                //Select the selected paper size
                if (ps.Kind == Paper.SelectedPaper.Kind)
                    comboPaperSize.SelectedItem = ps;
            }
        }

        private void UpdateInformation()
        {
            //Select the selected paper :3
            Paper.Set((PaperSize)comboPaperSize.SelectedItem);

            //Show selected paper info
            lab_name.Text = Paper.SelectedPaper.PaperName;

            if(Paper.SelectedPaper.Kind.ToString().Equals("Custom"))
            {
                radioPortrait.Enabled = false;
                radioLandscape.Enabled = false;

                tb_width.ReadOnly = false;
                tb_height.ReadOnly = false;

                Paper.UsingCustomPaper = true;
                Paper.IsLandScape = false;

                tb_width.Text = Paper.Width.ToString();
                tb_height.Text = Paper.Height.ToString();

                return;
            }
            else
            {
                Paper.UsingCustomPaper = false;
                radioPortrait.Enabled = true;
                radioLandscape.Enabled = true;

                tb_width.ReadOnly = true;
                tb_height.ReadOnly = true;
            }


            if (!Paper.IsLandScape)
            {
                // Portrait mode (Default)
                radioPortrait.Checked = true;
                radioLandscape.Checked = false;
            }
            else
            {
                // Landscape mode
                radioPortrait.Checked = false;
                radioLandscape.Checked = true;
            }

            tb_width.Text = Paper.Width.ToString();
            tb_height.Text = Paper.Height.ToString();
        }

        private void RadioPortrait_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioPortrait.Checked)
                return;

            Paper.IsLandScape = false;
            UpdateInformation();
        }

        private void RadioLandscape_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioLandscape.Checked)
                return;

            Paper.IsLandScape = true;
            UpdateInformation();
        }

        private void ComboPaperSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInformation();
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

        private void PaperManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
            {
                // Discard paper size change
                Paper.Set(originalPaperSize);
            }
        }

        private void tb_width_TextChanged(object sender, EventArgs e)
        {
            if (!Paper.UsingCustomPaper)
                return;

            Paper.paperSizes[0].Width = tb_width.Value;
            //UpdateInformation();
        }

        private void tb_height_TextChanged(object sender, EventArgs e)
        {
            if (!Paper.UsingCustomPaper)
                return;

            Paper.paperSizes[0].Height = tb_height.Value;
            //UpdateInformation();
        }
    }
}
