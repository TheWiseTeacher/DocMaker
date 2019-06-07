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


        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            CenterPaper();
        }

        public MainForm()
        {
            InitializeComponent();
     
            #region Set Alignment Tag Info

            btn_LU.Tag = DocumentObject.AlignmentFlags.Left   | DocumentObject.AlignmentFlags.Up;
            btn_CU.Tag = DocumentObject.AlignmentFlags.Center | DocumentObject.AlignmentFlags.Up;
            btn_RU.Tag = DocumentObject.AlignmentFlags.Right  | DocumentObject.AlignmentFlags.Up;

            btn_LM.Tag = DocumentObject.AlignmentFlags.Left   | DocumentObject.AlignmentFlags.Middle;
            btn_CM.Tag = DocumentObject.AlignmentFlags.Center | DocumentObject.AlignmentFlags.Middle;
            btn_RM.Tag = DocumentObject.AlignmentFlags.Right  | DocumentObject.AlignmentFlags.Middle;

            btn_LD.Tag = DocumentObject.AlignmentFlags.Left   | DocumentObject.AlignmentFlags.Down;
            btn_CD.Tag = DocumentObject.AlignmentFlags.Center | DocumentObject.AlignmentFlags.Down;
            btn_RD.Tag = DocumentObject.AlignmentFlags.Right  | DocumentObject.AlignmentFlags.Down;

            #endregion

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
            PopulateObjectList();
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

            // Populate object list
            PopulateObjectList();

            // Reset zooms
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
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad7:
                        btn_LU.PerformClick();
                        break;

                    case Keys.NumPad8:
                        btn_CU.PerformClick();
                        break;

                    case Keys.NumPad9:
                        btn_RU.PerformClick();
                        break;

                    case Keys.NumPad4:
                        btn_LM.PerformClick();
                        break;

                    case Keys.NumPad5:
                        btn_CM.PerformClick();
                        break;

                    case Keys.NumPad6:
                        btn_RM.PerformClick();
                        break;

                    case Keys.NumPad1:
                        btn_LD.PerformClick();
                        break;

                    case Keys.NumPad2:
                        btn_CD.PerformClick();
                        break;

                    case Keys.NumPad3:
                        btn_RD.PerformClick();
                        break;
                }
            }

            if (e.KeyCode == Keys.F2)
            {
                if (LivePreview.currentObject != null)
                {
                    LivePreview.currentObject.EditObject();
                    e.Handled = true;
                }
            }



        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {




        }

        private void PopulateObjectList()
        {
            layers.Rows.Clear();

            foreach(DocumentObject o in Objects.objectList)
            {             
                layers.Rows.Add(0, Properties.Resources.ico_visible, o.Name, o);
            }

            ActiveControl = layers;
        }

        /*
        private void layers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < layers.Rows.Count)
            {
                if (e.ColumnIndex == layer_visible.Index)
                    ((DocumentObject)layers[layer_object.Index, e.RowIndex].Value).Canvas.Visible =
                        (bool)layers[layer_visible.Index, e.RowIndex].Value;

                if (e.ColumnIndex == layer_name.Index)
                    ((DocumentObject)layers[layer_object.Index, e.RowIndex].Value).Name =
                        layers[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
        }
        */

        private void Layers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < layers.Rows.Count)
            {
                if (e.ColumnIndex == layer_visible.Index)
                {
                    if(((DocumentObject)layers[layer_object.Index, e.RowIndex].Value).ToggleVisibility())
                    {
                        layers[layer_visible.Index, e.RowIndex].Value = 
                            Properties.Resources.ico_visible;
                    }
                    else
                    {
                        layers[layer_visible.Index, e.RowIndex].Value = 
                            Properties.Resources.ico_nvisible;
                    }
                }
            }
        }

        private void Layers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex < layers.Rows.Count)
            {
                ((DocumentObject)layers[layer_object.Index, e.RowIndex].Value).Name =
                    layers[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
        }

        private void layers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == layer_visible.Index)
            {
                layers.EndEdit();
            }

            layers.BeginEdit(true);
        }

        private void Layers_SelectionChanged(object sender, EventArgs e)
        {
            if (layers.SelectedCells.Count <= 0)
            {
                LivePreview.currentObject = null;
            }
            else
            {
                int index = layers.SelectedCells[0].RowIndex;
                LivePreview.currentObject = (DocumentObject)layers[layer_object.Index, index].Value;

                ActiveControl = LivePreview.currentObject.Canvas;
            }

            ShowAlignment();
        }

        private void Layers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LivePreview.currentObject == null || e.ColumnIndex == layer_visible.Index)
                return;

            LivePreview.currentObject.EditObject();
        }

        private void ShowAlignment()
        {
            btn_LU.BackColor = btn_CU.BackColor = btn_RU.BackColor =
            btn_LM.BackColor = btn_CM.BackColor = btn_RM.BackColor =
            btn_LD.BackColor = btn_CD.BackColor = btn_RD.BackColor =
            Color.FromArgb(192, 192, 192);

            if (LivePreview.currentObject == null)
                return;

            foreach(Control c in pan_AlignmentBtns.Controls)
            {
                if (c.Tag == null)
                    continue;

                if ((byte)((DocumentObject.AlignmentFlags)c.Tag) == LivePreview.currentObject.Alignment)
                {
                    c.BackColor = Color.FromArgb(0, 128, 255);
                }
            }
        }

        private void Alignment_OnClick(object sender, EventArgs e)
        {
            if (LivePreview.currentObject == null)
                return;

            LivePreview.currentObject.Alignment = (byte)((DocumentObject.AlignmentFlags)((Control)sender).Tag);

            ShowAlignment();
            LivePreview.Update();
        }


    }
}
