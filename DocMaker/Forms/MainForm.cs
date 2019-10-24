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

        #region Variables and Properties & Form Constructor

        private bool isPopulating = false;
        public MainForm()
        {
            InitializeComponent();
            InitializeAlignmentButtons();

            LivePreview.mainForm = this;

            Project.Initialize();

            cb_showAnchors.Checked = Config.ShowAnchorPoints;

            ActiveControl = lab_paperSize;
            PaperWrap.MouseWheel += PaperWrap_MouseWheel;
            pan_VSplit.SplitterDistance = pan_VSplit.Width - pan_VSplit.Panel2MinSize;

        }

        #endregion

        #region Form events

        private void MainForm_Load(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterPaper();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            CenterPaper();
        }

        #endregion

        #region Zooming events and methods

        private void CenterPaper()
        {
            double newX, newY;

            if (PaperWrap.Width > thePaper.Width)
            {
                newX = (PaperWrap.Width - thePaper.Width -
                        SystemInformation.VerticalScrollBarWidth) / 2;
            }
            else
            {
                newX = 20d;
            }

            if (PaperWrap.Height > thePaper.Height)
            {
                newY = (PaperWrap.Height - thePaper.Height -
                        SystemInformation.HorizontalScrollBarHeight) / 2;
            }
            else
            {
                newY = 20d;
            }

            thePaper.Location = new Point((int)newX - PaperWrap.HorizontalScroll.Value,
                                          (int)newY - PaperWrap.VerticalScroll.Value);
        }

        private void ResizePaper()
        {

            //Set paper name
            if(Paper.usingCustomPaper)
                lab_paperSize.Text = $"Paper size : {Paper.paperSize.Width} x {Paper.paperSize.Height}";
            else
                lab_paperSize.Text = $"Paper kind : {Paper.paperSize.PaperName}";

            // Optional : Setting a tooltip to know the Dimensions
            if (!Paper.isLandscape)
                toolTip.SetToolTip(lab_paperSize,
                    $"Dimension : {Paper.paperSize.Width}x{Paper.paperSize.Height} pixels");
            else
                toolTip.SetToolTip(lab_paperSize, $"Dimension : " +
                    $"{Paper.paperSize.Height}x{Paper.paperSize.Width} pixels");

            thePaper.Size = Zoom.GetPaperSize();   //Get paper size relative to the zoom percent
            CenterPaper();                      //Center paper for better view
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

        private void ComboZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zoom.ApplyZoom(Zoom.avaibleZooms[comboZoom.SelectedIndex]);

            ResizePaper();
            Objects.RenderAll();
        }

        #endregion

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

        #region Object alignmment methods

        private void InitializeAlignmentButtons()
        {
            btn_LU.Tag = DocumentObject.Flags.Left | DocumentObject.Flags.Up;
            btn_CU.Tag = DocumentObject.Flags.Center | DocumentObject.Flags.Up;
            btn_RU.Tag = DocumentObject.Flags.Right | DocumentObject.Flags.Up;

            btn_LM.Tag = DocumentObject.Flags.Left | DocumentObject.Flags.Middle;
            btn_CM.Tag = DocumentObject.Flags.Center | DocumentObject.Flags.Middle;
            btn_RM.Tag = DocumentObject.Flags.Right | DocumentObject.Flags.Middle;

            btn_LD.Tag = DocumentObject.Flags.Left | DocumentObject.Flags.Down;
            btn_CD.Tag = DocumentObject.Flags.Center | DocumentObject.Flags.Down;
            btn_RD.Tag = DocumentObject.Flags.Right | DocumentObject.Flags.Down;
        }

        private void ShowAlignment()
        {
            btn_LU.BackColor = btn_CU.BackColor = btn_RU.BackColor =
            btn_LM.BackColor = btn_CM.BackColor = btn_RM.BackColor =
            btn_LD.BackColor = btn_CD.BackColor = btn_RD.BackColor =
            Color.FromArgb(192, 192, 192);

            if (LivePreview.currentObject == null)
                return;

            foreach (Control c in pan_AlignmentBtns.Controls)
            {
                if (c.Tag == null)
                    continue;

                if ((uint)((DocumentObject.Flags)c.Tag) == LivePreview.currentObject.Alignment)
                {
                    c.BackColor = Color.FromArgb(0, 128, 255);
                }
            }
        }

        private void Alignment_OnClick(object sender, EventArgs e)
        {
            if (LivePreview.currentObject == null)
                return;

            LivePreview.currentObject.Alignment = (uint)((Control)sender).Tag;

            ShowAlignment();
            LivePreview.Update();
            UpdateObjectPosition(LivePreview.currentObject);
        }

        #endregion

        #region Key pressing events
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

        #endregion

        #region layers table events

        private void Layers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //!\\ Also triggered by CellContentDoubleClick to allow fast clicking
            
            if (e.RowIndex >= 0 && e.RowIndex < layers.Rows.Count)
            {
                if (e.ColumnIndex == layer_visible.Index)
                {
                    if (((DocumentObject)layers[layer_object.Index, e.RowIndex].Value).ToggleVisibility())
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

        private void Layers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LivePreview.currentObject == null || e.ColumnIndex == layer_visible.Index)
                return;

            LivePreview.currentObject.EditObject();
        }

        private void Layers_SelectionChanged(object sender, EventArgs e)
        {
            if (isPopulating)
                return;

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
            UpdateStatusBar();
        }
        #endregion

        #region ToolStrip Events

        public void UpdateFormTitle()
        {
            this.Text = $"{Application.ProductName} {Application.ProductVersion} - {Project.projectTitle}";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize a new project
            Project.NewProject();
            UpdateFormTitle();

            // Set application title

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
            if (paperManager.ShowDialog() == DialogResult.OK)
                ResizePaper();
        }

        private void ResManagertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResourceManager resManager = new ResourceManager();
            resManager.ShowDialog();
        }

        #endregion

        #region StatusBar update methods
        private void UpdateStatusBar()
        {
            //UpdateLocationInformation();

        }

        /*
        public void UpdateLocationInformation()
        {
            if (LivePreview.currentObject == null)
                return;

            lab_x_pos.Text = LivePreview.currentObject.RealLocation.X.ToString();
            lab_y_pos.Text = LivePreview.currentObject.RealLocation.Y.ToString();

            lab_x_pos.Update();
            lab_y_pos.Update();
        }
        */

        #endregion


        public void UpdateObjectPosition(DocumentObject obj)
        {
            Point r = LivePreview.currentObject.RealLocation;

            /*
            Point p = new Point(thePaper.Width - LivePreview.currentObject.Canvas.Width,
                                thePaper.Height - LivePreview.currentObject.Canvas.Height);

            p = Zoom.CalculateReal(p);
            */

            /*
            sl_xPosition.Minimum = 0;
            sl_xPosition.Maximum = p.X;
            sl_xPosition.Value = r.X;
            */
            /*
            sl_yPosition.Minimum = 0;
            sl_yPosition.Maximum = p.Y;
            sl_yPosition.Value = r.Y;
            */

            tb_xPosition.Text = r.X.ToString();
            tb_yPosition.Text = r.Y.ToString();
            tb_xPosition.Update();
            tb_yPosition.Update();
        }

        #region Adding objects and layers table populating methods

        public void SelectObject()
        {
            if (LivePreview.currentObject == null)
                return;

            //foreach(DocumentObject o in layers.Columns[layer_object.Index].)
            for (int i = 0; i < layers.Rows.Count; i++)
            {
                DocumentObject obj = (DocumentObject)layers[layer_object.Index, i].Value;
                if (obj == LivePreview.currentObject)
                {
                    layers.ClearSelection();
                    layers.Rows[i].Selected = true;

                    Console.WriteLine("Selected");
                    UpdateObjectPosition(obj);

                    break;
                }
            }

            ActiveControl = layers;
        }

        private void PopulateObjectList()
        {
            // To prevent triggering SelectionChanged Event and loose selected object
            isPopulating = true;

            layers.Rows.Clear();

            foreach (DocumentObject o in Objects.objectList)
            {
                layers.Rows.Add(
                    o.Visible ? Properties.Resources.ico_visible : Properties.Resources.ico_nvisible, 
                    o.Name, 
                    o);
            }

            isPopulating = false;
            SelectObject();
        }

        public void AddObjectToPaper(DocumentObject obj)
        {
            if (obj == null)
                return;

            thePaper.Controls.Add(obj.Canvas);
            LivePreview.currentObject = obj;

            // Populate object table after adding object
            PopulateObjectList();
        }

        private void btn_add_label_Click(object sender, EventArgs e)
        {
            AddObjectToPaper(Objects.NewLabel());
        }

        private void Btn_add_line_Click(object sender, EventArgs e)
        {
            AddObjectToPaper(Objects.NewLine());
        }

        private void Btn_add_image_Click(object sender, EventArgs e)
        {
            AddObjectToPaper(Objects.NewImage());
        }

        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {


        }
  
        private void Button2_Click(object sender, EventArgs e)
        {
            //label1.Font = new Font("Janna LT", 16);
            //Snapper.Initialize();
            //Snapper.DrawRectangle();
        }

        private void X_pos_Scroll(object sender, EventArgs e)
        {
            /*
            LivePreview.currentObject.RealLocation.X = sl_xPosition.Value;
            tb_xPosition.Text = sl_xPosition.Value.ToString();
            LivePreview.Update();*/
        }

        private void Y_pos_Scroll(object sender, EventArgs e)
        {/*
            LivePreview.currentObject.RealLocation.Y = sl_yPosition.Value;
            tb_yPosition.Text = sl_yPosition.Value.ToString();
            LivePreview.Update();*/
        }

        private void Cb_showAnchor_CheckedChanged(object sender, EventArgs e)
        {
            Config.ShowAnchorPoints = cb_showAnchors.Checked;
            Objects.RenderAll();
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Enter");
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            // Repopulate object list whenever the main form get foccus back
            // Used to apply objects custom name
            //
            PopulateObjectList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.OpenProject();
            UpdateFormTitle();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.SaveProject();
            UpdateFormTitle();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.SaveProject(true);
            UpdateFormTitle();
        }

        private void pan_VSplit_SplitterMoved(object sender, SplitterEventArgs e)
        {
            CenterPaper();
        }

        private void pan_VSplit_MouseUp(object sender, MouseEventArgs e)
        {
            ActiveControl = thePaper;
        }

        private void SuspendPaperScrollEvent(object sender, EventArgs e)
        {
            PaperWrap.IgnoreWheel = true;
        } 
        
        private void ResumePaperScrollEvent(object sender, EventArgs e)
        {
            PaperWrap.IgnoreWheel = false;
        }

        private void lab_showAnchors_Click(object sender, EventArgs e)
        {
            cb_showAnchors.Checked = !cb_showAnchors.Checked;
        }
    }
}
