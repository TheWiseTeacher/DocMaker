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
        private bool MouseOverPaperWrap;
        private bool MouseOverPaper;
        private KeyEventArgs keys = new KeyEventArgs(0);

        private bool pressedControl = false;
        private bool pressedShift = false;
        private bool pressedAlt = false;



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

            MouseOverPaperWrap = false;
            MouseOverPaper = false;


        }

        int oldVerticalScroll;
        private void NegateScroll(bool goingDown)
        {
            if(goingDown)
            {
                PaperWrap.VerticalScroll.Value = Funcs.Clamp(PaperWrap.VerticalScroll.Value + PaperWrap.VerticalScroll.SmallChange,
                        PaperWrap.VerticalScroll.Minimum, PaperWrap.VerticalScroll.Maximum);
            }
            else
            {
                PaperWrap.VerticalScroll.Value = Funcs.Clamp(PaperWrap.VerticalScroll.Value - PaperWrap.VerticalScroll.SmallChange,
                        PaperWrap.VerticalScroll.Minimum, PaperWrap.VerticalScroll.Maximum);
            }

        }

        private void PaperWrap_MouseWheel(object sender, MouseEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Shift)
            {
                if (e.Delta < 0)
                    NegateScroll(true);
                else
                    NegateScroll(false);

                return;    
            }

            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta < 0)
                {
                    NegateScroll(true);

                    if (comboZoom.SelectedIndex + 1 < comboZoom.Items.Count)
                        comboZoom.SelectedIndex = comboZoom.SelectedIndex + 1;
                }
                else
                {
                    NegateScroll(false);

                    if (comboZoom.SelectedIndex - 1 >= 0)
                        comboZoom.SelectedIndex = comboZoom.SelectedIndex - 1;
                }

                return;
            }

            if(Control.ModifierKeys == Keys.Alt)
            {
                if (e.Delta < 0)
                {
                    NegateScroll(true);

                    PaperWrap.HorizontalScroll.Value = 
                        Funcs.Clamp(PaperWrap.HorizontalScroll.Value + PaperWrap.HorizontalScroll.LargeChange,
                        PaperWrap.HorizontalScroll.Minimum, PaperWrap.HorizontalScroll.Maximum);
                }
                else
                {
                    NegateScroll(false);

                    PaperWrap.HorizontalScroll.Value =
                        Funcs.Clamp(PaperWrap.HorizontalScroll.Value - PaperWrap.HorizontalScroll.LargeChange,
                        PaperWrap.HorizontalScroll.Minimum, PaperWrap.HorizontalScroll.Maximum);
                }

                return;
            }

            PaperWrap.Update();
        }

        private void LoadZoomList()
        {
            comboZoom.Items.Clear();

            foreach (int z in Zoom.avaibleZooms)
            {
                comboZoom.Items.Add(z);
                if (z == 100) comboZoom.SelectedItem = z;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


            x_pos.Minimum = 0;
            x_pos.Maximum = Paper.Width;

            y_pos.Minimum = 0;
            y_pos.Maximum = Paper.Height;


            newToolStripMenuItem.PerformClick();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterPaper();
        }

        private void PaperWrap_MouseEnter(object sender, EventArgs e)
        {
            if (!MouseOverPaperWrap)
            {
                MouseOverPaperWrap = true;
                PaperWrap.Focus();
            }           
        }

        private void PaperWrap_MouseLeave(object sender, EventArgs e)
        {
            if (MouseOverPaperWrap)
            {
                MouseOverPaperWrap = false;
                StatusIcon.Focus();
            }
        }

        private void Paper_MouseEnter(object sender, EventArgs e)
        {
            if (!MouseOverPaper)
            {
                MouseOverPaper = true;
                PaperWrap.Focus();
            }
        }

        private void Paper_MouseLeave(object sender, EventArgs e)
        {
            if (MouseOverPaper)
            {
                MouseOverPaper = false;
                StatusIcon.Focus();
            }
        }



        private void MainFormMenuStrip_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            Zoom.ApplyZoom((int)comboZoom.SelectedItem);

            ResizePaper();
            Objects.ApplyZoom();
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control || e.Alt || e.Shift)
                oldVerticalScroll = PaperWrap.VerticalScroll.Value;
            /*
            pressedControl = e.Control;
            pressedShift = e.Shift;
            pressedAlt = e.Alt;*/
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {/*
            pressedControl = e.Control;
            pressedShift = e.Shift;
            pressedAlt = e.Alt;*/
        }

        private void PaperWrap_Scroll(object sender, ScrollEventArgs e)
        {
            Console.WriteLine("maybe");
        }

        /*
        private void ZoomBar_Scroll(object sender, EventArgs e)
        {
            zoomPercent.Text = zoomBar.Value + "%";
            
            Zoom.ApplyZoom(zoomBar.Value);


        }

        private void ZoomPercent_Click(object sender, EventArgs e)
        {
            zoomBar.Value = 100;
            ZoomBar_Scroll(zoomBar, null);
        }
        */
    }
}
