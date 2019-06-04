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
            lastSelectedPaper = Project.paperSize.Kind;

            LoadPaperFormats();
            UpdateInformation();
        }

        private void LoadPaperFormats()
        {
            foreach(PaperSize ps in Project.paperSizes)
            {
                comboPaperSize.Items.Add(ps);

                //Select the selected paper size
                if (ps.Kind == Project.paperSize.Kind)
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
            Project.paperSize = (PaperSize)comboPaperSize.SelectedItem;

            //Show selected paper info
            lab_name.Text = Project.paperSize.PaperName;

            if (!Project.isLandscape)
            {
                //Portrait mode (Default)

                radioPortrait.Checked = true;
                radioLandscape.Checked = false;

                lab_width.Text = Project.paperSize.Width.ToString() + " pixels";
                lab_height.Text = Project.paperSize.Height.ToString() + " pixels";
            }
            else
            {
                //Landscape mode

                radioPortrait.Checked = false;
                radioLandscape.Checked = true;

                //Flip width and height sizes
                lab_height.Text = Project.paperSize.Width.ToString() + " pixels";
                lab_width.Text = Project.paperSize.Height.ToString() + " pixels";
            }
        }

        private void RadioPortrait_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioPortrait.Checked)
                return;

            Project.isLandscape = false;
            UpdateInformation();
        }

        private void RadioLandscape_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioLandscape.Checked)
                return;

            Project.isLandscape = true;
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
                if(Project.paperSize.Kind != lastSelectedPaper)
                {
                    // Discard paper size change
                    Project.paperSize = Project.paperSizes.First<PaperSize>(size => size.Kind == lastSelectedPaper);
                }
            }
        }


    }
}
