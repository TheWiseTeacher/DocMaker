using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static DocMaker.Config;
using static DocMaker.Funcs;

namespace DocMaker
{
    public partial class MainForm : Form
    {

        #region Paper and PaperWrap MouseWheel Event Handler

        private void PaperWrap_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (PaperWrap.WheelDelta < 0)
                {
                    if (comboZoom.SelectedIndex + 1 < comboZoom.Items.Count)
                        comboZoom.SelectedIndex = comboZoom.SelectedIndex + 1;
                }
                else
                {
                    if (comboZoom.SelectedIndex - 1 >= 0)
                        comboZoom.SelectedIndex = comboZoom.SelectedIndex - 1;
                }
            }

            if (Control.ModifierKeys == Keys.Alt)
            {
                int newvalue = Funcs.Clamp((PaperWrap.HorizontalScroll.Value - PaperWrap.WheelDelta),
                               PaperWrap.HorizontalScroll.Minimum, PaperWrap.HorizontalScroll.Maximum);

                // Don't ask me but if you don't set the value twice the H Scroll seems
                // To not register the value at first call (debugged for f'ing 5 hours)
                //
                PaperWrap.HorizontalScroll.Value = newvalue;
                PaperWrap.HorizontalScroll.Value = newvalue;
                //
            }

            PaperWrap.Update();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            PaperWrap.TriggerMouseWheel(e);
            base.OnMouseWheel(e);
        }

        private void PaperWrap_OnClick(object sender, EventArgs e)
        {
            ActiveControl = PaperWrap;
        }

        #endregion

        private void CenterPaper()
        {
            double newX, newY;

            if (PaperWrap.Width > Paper.Width)
            {
                newX = (PaperWrap.Width - Paper.Width -
                        SystemInformation.VerticalScrollBarWidth) / 2;
            }
            else
            {
                newX = 20d;
            }

            if (PaperWrap.Height > Paper.Height)
            {
                newY = (PaperWrap.Height - Paper.Height -
                        SystemInformation.HorizontalScrollBarHeight) / 2;
            }
            else
            {
                newY = 20d;
            }

            Paper.Location = new Point((int)newX - PaperWrap.HorizontalScroll.Value,
                                       (int)newY - PaperWrap.VerticalScroll.Value);
        }
        
        private void ResizePaper()
        {
            //Set paper name
            lab_paperSize.Text = "Paper size : " + Project.paperSize.PaperName;

            // Optional : Setting a tooltip to know the Dimensions
            if (!Project.isLandscape)
                toolTip.SetToolTip(lab_paperSize, 
                    $"Dimension : {Project.paperSize.Width}x{Project.paperSize.Height} pixels");
            else
                toolTip.SetToolTip(lab_paperSize, $"Dimension : " +
                    $"{Project.paperSize.Height}x{Project.paperSize.Width} pixels");

            Paper.Size = Zoom.GetPaperSize();   //Get paper size relative to the zoom percent
            CenterPaper();                      //Center paper for better view
        }

        public MainForm()
        {
            InitializeComponent();
            LivePreview.mainForm = this;

            PaperWrap.MouseWheel += PaperWrap_MouseWheel;
            ActiveControl = lab_paperSize;

        }

        private void LoadZoomList()
        {
            comboZoom.Items.Clear();

            foreach (int z in Zoom.avaibleZooms)
            {
                comboZoom.Items.Add(z + " %");
                if (z == 100) comboZoom.SelectedItem = z + " %";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();


        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterPaper();
        }



        private void btn_add_label_Click(object sender, EventArgs e)
        {
            Objects.AddLabel(Paper);

        }



   

        private void layers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Painting Handling
            e.Handled = true;

            // this means draw whole cell without focus border
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
        }

        



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize a new project
            Project.NewProject();

            // Resize the paper
            ResizePaper();

            //Reset zooms
            LoadZoomList();
        }

        private void AddFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontManager fontManager = new FontManager();
            fontManager.ShowDialog();
        }

        private void LanguageManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageManager languageManager = new LanguageManager();
            languageManager.ShowDialog();
        }

        private void PaperSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaperManager paperManager = new PaperManager();
            if(paperManager.ShowDialog() == DialogResult.OK)
                ResizePaper();
        }

        
        private void UpdateStatusBar()
        {
           
        }

        private void ComboZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zoom.ApplyZoom(Zoom.avaibleZooms[comboZoom.SelectedIndex]);

            ResizePaper();
            Objects.ApplyZoom();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {




        }
    }
}
