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
        PaperKind lastSelectedPaper = 0;

        public PaperManager()
        {
            InitializeComponent();

            //Make combobox display paper name
            comboPaperSize.DisplayMember = "PaperName";

            //Save last selected paperkind in case of canceling
            lastSelectedPaper = Paper.paperSize.Kind;

            LoadPaperFormats();
            UpdateInformation();
        }

        private void LoadPaperFormats()
        {
            //PaperSize cps = new PaperSize("User defined", 500, 700);
            
            //comboPaperSize.Items.Add();

            foreach (PaperSize ps in Paper.paperSizes)
            {
                comboPaperSize.Items.Add(ps);

                //Select the selected paper size
                if (ps.Kind == Paper.paperSize.Kind)
                    comboPaperSize.SelectedItem = ps;
            }

            /*
            PaperSize pkSize;
            for (int i = 0; i < Project.printerSettings.PaperSizes.Count; i++)
            {
                pkSize = Project.printerSettings.PaperSizes[i];
                comboPaperSize.Items.Add(pkSize);

                //Select the selected paper size
                if (pkSize.Kind == Project.paperSize.Kind)
                    comboPaperSize.SelectedItem = pkSize;
            }
            */
        }

        private void UpdateInformation()
        {
            //Select the selected paper :3
            Paper.paperSize = (PaperSize)comboPaperSize.SelectedItem;

            //Show selected paper info
            lab_name.Text = Paper.paperSize.PaperName;

            if(Paper.paperSize.Kind.ToString().Equals("Custom"))
            {
                radioPortrait.Enabled = false;
                radioLandscape.Enabled = false;

                tb_width.ReadOnly = false;
                tb_height.ReadOnly = false;

                Paper.usingCustomPaper = true;
                Paper.isLandscape = false;

                tb_width.Text = Paper.paperSize.Width.ToString();
                tb_height.Text = Paper.paperSize.Height.ToString();

                return;
            }
            else
            {
                Paper.usingCustomPaper = false;
                radioPortrait.Enabled = true;
                radioLandscape.Enabled = true;

                tb_width.ReadOnly = true;
                tb_height.ReadOnly = true;
            }


            if (!Paper.isLandscape)
            {
                //Portrait mode (Default)

                radioPortrait.Checked = true;
                radioLandscape.Checked = false;

                tb_width.Text = Paper.paperSize.Width.ToString();
                tb_height.Text = Paper.paperSize.Height.ToString();
            }
            else
            {
                //Landscape mode

                radioPortrait.Checked = false;
                radioLandscape.Checked = true;

                //Flip width and height sizes
                tb_height.Text = Paper.paperSize.Width.ToString();
                tb_width.Text = Paper.paperSize.Height.ToString();
            }
        }

        private void RadioPortrait_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioPortrait.Checked)
                return;

            Paper.isLandscape = false;
            UpdateInformation();
        }

        private void RadioLandscape_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioLandscape.Checked)
                return;

            Paper.isLandscape = true;
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
                if(Paper.paperSize.Kind != lastSelectedPaper)
                {
                    // Discard paper size change
                    Paper.paperSize = Paper.paperSizes.First<PaperSize>(size => size.Kind == lastSelectedPaper);
                }
            }
        }

        private void tb_width_TextChanged(object sender, EventArgs e)
        {
            if (!Paper.usingCustomPaper)
                return;

            Paper.paperSizes[0].Width = tb_width.Value;
            //UpdateInformation();
        }

        private void tb_height_TextChanged(object sender, EventArgs e)
        {
            if (!Paper.usingCustomPaper)
                return;

            Paper.paperSizes[0].Height = tb_height.Value;
            //UpdateInformation();
        }
    }
}
