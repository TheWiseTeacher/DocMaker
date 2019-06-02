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
        private const double COMPRESSION_RATIO = 0.1d;

        private bool MouseOverPaperWrap;
        private bool MouseOverPaper;

        private void ResizePaper(double width)
        {
            Paper.Width =  (int)(width);
            Paper.Height = (int)(width * Config.CurrentPaperRatio);

            CenterPaper();
        }

        private void CenterPaper()
        {
            double newX, newY;

            if(PaperWrap.Width > Paper.Width)
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
        private Point lastMousePosition = new Point(0, 0);

        int PAPER_GLOBAL_W = 0;
        int PAPER_GLOBAL_H = 0;

        public MainForm()
        {
            InitializeComponent();
            LivePreview.mainForm = this;

            MouseOverPaperWrap = false;
            MouseOverPaper = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set paper size to origine
            ResizePaper(Config.PAPER_WIDTH_A4);

            PAPER_GLOBAL_W = Paper.Width;
            PAPER_GLOBAL_H = Paper.Height;

            x_pos.Minimum = 0;
            x_pos.Maximum = Paper.Width;

            y_pos.Minimum = 0;
            y_pos.Maximum = Paper.Height;

            lastMousePosition = new Point(PAPER_GLOBAL_W / 2,
                                          200);

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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (CurrentSelectedID < 0)
                    return;

                StringEditor form = new StringEditor();

                form.textBox.Text = itemsList[CurrentSelectedID].Title;
                form.textBox.SelectAll();
                form.ShowDialog();

                if (form.DialogResult != DialogResult.OK)
                    return;

                itemsList[CurrentSelectedID].Title = form.textBox.Text;
                layers[layer_name.Index, CurrentSelectedID].Value = form.textBox.Text;
                GeneratePageContent();
            }

            if (e.KeyCode == Keys.F5)
            {
                e.SuppressKeyPress = true;
                GeneratePageContent();
            }

            if (e.KeyCode == Keys.F10)
            {
                e.SuppressKeyPress = true;
                GeneratePageContent(true);
            }

            if (e.KeyCode == Keys.Left && !x_center.Checked)
            {
                e.SuppressKeyPress = true;
                x_pos.Value = Max(x_pos.Value - 1, x_pos.Minimum);
                if(e.Shift) x_pos.Value = Max(x_pos.Value - 9, x_pos.Minimum);
            }

            if (e.KeyCode == Keys.Right && !x_center.Checked)
            {
                e.SuppressKeyPress = true;
                x_pos.Value = Min(x_pos.Value + 1, x_pos.Maximum);
                if(e.Shift) x_pos.Value = Min(x_pos.Value + 9, x_pos.Maximum);
            }

            if (e.KeyCode == Keys.Up && !y_center.Checked)
            {
                e.SuppressKeyPress = true;
                y_pos.Value = Max(y_pos.Value - 1, y_pos.Minimum);
                if(e.Shift) y_pos.Value = Max(y_pos.Value - 9, y_pos.Minimum);
            }

            if (e.KeyCode == Keys.Down && !y_center.Checked)
            {
                e.SuppressKeyPress = true;
                y_pos.Value = Min(y_pos.Value + 1, y_pos.Maximum);
                if (e.Shift) y_pos.Value = Min(y_pos.Value + 9, y_pos.Maximum);
            }

            if (e.KeyCode == Keys.PageDown)
            {
                e.SuppressKeyPress = true;
                fontSize.Value = Max((int)(fontSize.Value - 1), (int)fontSize.Minimum);
            }

            if (e.KeyCode == Keys.PageUp)
            {
                e.SuppressKeyPress = true;
                fontSize.Value = Min((int)(fontSize.Value + 1), (int)fontSize.Maximum);
            }

            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ActiveControl = Paper;
            }

            if (e.Control && e.KeyCode == Keys.N)
            {
                e.SuppressKeyPress = true;
                btn_add_label.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                e.SuppressKeyPress = true;
                btn_duplicate.PerformClick();
            }

            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                btn_delete.PerformClick();
            }
        }

        private void MainFormMenuStrip_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            int originalWidth = PaperWrap.Width - 40;
            int targetWidth = (int)(Config.PAPER_WIDTH_A4 * zoomBar.Value / 100d);
            zoomPercent.Text = zoomBar.Value + "%";
            ResizePaper(targetWidth);
        }

        private void ResetHAlign()
        {
            btn_HAL.BackColor = btn_HAC.BackColor = btn_HAR.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void ResetVAlign()
        {
            btn_VAU.BackColor = btn_VAM.BackColor = btn_VAD.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void ToggleHAlign(object sender, EventArgs e)
        {
            ResetHAlign();
            ((Button)sender).BackColor = Color.FromArgb(115, 181, 19);

            if (CurrentSelectedID == -1)
                return;

            itemsList[CurrentSelectedID].HA = ((Button)sender).Tag.ToString();
            GeneratePageContent();

            //ActiveControl = Paper;
        }

        private void ToggleVAlign(object sender, EventArgs e)
        {
            ResetVAlign();
            ((Button)sender).BackColor = Color.FromArgb(115, 181, 19);

            if (CurrentSelectedID == -1)
                return;

            itemsList[CurrentSelectedID].VA = ((Button)sender).Tag.ToString();
            GeneratePageContent();

            //ActiveControl = Paper;
        }

        byte[] baseImageByteStream;
        Bitmap baseImageCompressed;
        Image baseImageHQ;

        Bitmap bitmap;
        Graphics G;

        private void GeneratePageContent(bool HighQuality = false)
        {
            if (bitmap != null)
                bitmap.Dispose();

            bitmap = new Bitmap(PAPER_GLOBAL_W, PAPER_GLOBAL_H);

            G = CreateGraphics();
            G = Graphics.FromImage(bitmap);
            G.Clear(Color.Transparent);

            if (HighQuality)
            {
                G.CompositingQuality = CompositingQuality.HighQuality;
                G.InterpolationMode = InterpolationMode.HighQualityBicubic;
                G.TextRenderingHint = TextRenderingHint.AntiAlias;
                G.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                G.SmoothingMode = SmoothingMode.HighSpeed;

                if (baseImageHQ != null)
                    G.DrawImage(baseImageHQ, 0, 0, PAPER_GLOBAL_W, PAPER_GLOBAL_H);
            } 
            else
            {
                G.CompositingQuality = CompositingQuality.HighSpeed;
                G.InterpolationMode = InterpolationMode.NearestNeighbor;
                G.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                G.PixelOffsetMode = PixelOffsetMode.HighQuality;
                G.SmoothingMode = SmoothingMode.AntiAlias;

                if (baseImageCompressed != null)
                    G.DrawImage(baseImageCompressed, 0, 0, PAPER_GLOBAL_W, PAPER_GLOBAL_H);
            }

            int counter = -1;
            Point TextPosition = new Point(0, 0);
            StringFormat format = new StringFormat();
            Brush br = Brushes.Black;
            Font font;

            foreach (Item o in itemsList)
            {
                counter++;

                if (!o.Visible)
                    continue;

                switch (o.Type)
                {
                    case Item.TYPE.LABEL:

                        font = new Font(F(TTF_Roboto), o.S, (FontStyle)o.FS, GraphicsUnit.Pixel);
                        TextPosition = new Point(o.X, o.Y);

                        format.Alignment = GetAlignment(o.HA);
                        format.LineAlignment = GetAlignment(o.VA);

                        G.DrawString(o.Title, font, 
                                    (CurrentSelectedID == counter && !HighQuality) ? Brushes.Red : br,
                                    TextPosition, format);
                        
                        break;

                    default:
                        break;
                }
            }

            Paper.BackgroundImage = bitmap;
            Paper.BackgroundImageLayout = ImageLayout.Zoom;
            Update();
        }

        int labelCounter = 1;

        private void btn_add_label_Click(object sender, EventArgs e)
        {
            Objects.AddLabel(Paper);

            /*
            EnableMove = false;

            Item label = new Item
            {
                Type = Item.TYPE.LABEL,
                Visible = true,

                Title = $"Label {labelCounter}",

                HA = "C",
                VA = "M",

                CX = false,
                CY = false,

                X = 100,
                Y = 100,
                S = 14,

                FS = 0,
                OF = 0
            };

            labelCounter++;
            itemsList.Add(label);
            ReloadLayers();

            SelectLastRow();
            GeneratePageContent();
            */
        }

        private void btn_duplicate_Click(object sender, EventArgs e)
        {
            if (CurrentSelectedID == -1)
                return;

            Item label = new Item();
            label = (Item)itemsList[CurrentSelectedID].Clone();
            label.Title = $"Label {labelCounter}";

            labelCounter++;
            itemsList.Add(label);
            ReloadLayers();

            SelectLastRow();
            GeneratePageContent();
        }

        private void SelectLastRow()
        {
            if (layers.Rows.Count <= 0) return;
            int lastRow = layers.Rows.Count - 1;
            layers.ClearSelection();

            layers.CurrentCell = layers.Rows[lastRow].Cells[layer_name.Index];
            layers.Rows[lastRow].Selected = true;
        }

        private void layers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Painting Handling
            e.Handled = true;

            // this means draw whole cell without focus border
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
        }

        private void ReloadLayers()
        {
            layers.Rows.Clear();
            int currentItemID = 0;

            foreach (Item o in itemsList)
            {
                layers.Rows.Add(
                    new object[]
                    {
                        currentItemID,
                        o.Visible,
                        "LAB",
                        o.Title
                    });

                currentItemID++;
            }
        }

        private void layers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int itemID = ToInt(layers[layer_id.Index, e.RowIndex].Value);
            if (itemID < 0) return;

            
            if(e.ColumnIndex == layer_visible.Index)
            {
                itemsList[itemID].Visible = (bool)layers[layer_visible.Index, e.RowIndex].Value;
                Console.WriteLine($"Set visibility for {itemID} to {itemsList[itemID].Visible}");
            }


            GeneratePageContent();
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

        private void box_x_TextChanged(object sender, EventArgs e)
        {
            int v = ToInt(box_x.Text);

            if (v < x_pos.Minimum || v > x_pos.Maximum)
            {
                box_x.Text = x_pos.Value.ToString();
                ActiveControl = null;
                return;
            }

            x_pos.Value = v;
        }

        private void x_pos_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentSelectedID == 0)
                CurrentSelectedID = 0;

            box_x.Text = x_pos.Value.ToString();

            if (CurrentSelectedID != -1)
            {
                itemsList[CurrentSelectedID].X = x_pos.Value;
                GeneratePageContent();
            }
        }

        private void box_y_TextChanged(object sender, EventArgs e)
        {
            int v = ToInt(box_y.Text);

            if (v < y_pos.Minimum || v > y_pos.Maximum)
            {
                box_y.Text = y_pos.Value.ToString();
                ActiveControl = null;
                return;
            }

            y_pos.Value = v;
        }

        private void y_pos_ValueChanged(object sender, EventArgs e)
        {
            box_y.Text = y_pos.Value.ToString();

            if (CurrentSelectedID != -1)
            {
                itemsList[CurrentSelectedID].Y = y_pos.Value;
                GeneratePageContent();
            }
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentSelectedID != -1)
            {
                itemsList[CurrentSelectedID].S = (int)fontSize.Value;
                GeneratePageContent();
            }
        }

        int CurrentSelectedID = -1;

        private void layers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CurrentSelectedID = -1;

            if (e.RowIndex < 0)
                return;

            int itemID = ToInt(layers[layer_id.Index, e.RowIndex].Value);
            if (itemID < 0) return;

            CurrentSelectedID = itemID;
            SetParams();
        }

        private void SetParams()
        {
            x_pos.Value = itemsList[CurrentSelectedID].X;
            y_pos.Value = itemsList[CurrentSelectedID].Y;

            fontSize.Value = itemsList[CurrentSelectedID].S;

            x_center.Checked = itemsList[CurrentSelectedID].CX;
            y_center.Checked = itemsList[CurrentSelectedID].CY;

            if (itemsList[CurrentSelectedID].HA == "L") btn_HAL.PerformClick();
            if (itemsList[CurrentSelectedID].HA == "C") btn_HAC.PerformClick();
            if (itemsList[CurrentSelectedID].HA == "R") btn_HAR.PerformClick();

            if (itemsList[CurrentSelectedID].VA == "U") btn_VAU.PerformClick();
            if (itemsList[CurrentSelectedID].VA == "M") btn_VAM.PerformClick();
            if (itemsList[CurrentSelectedID].VA == "D") btn_VAD.PerformClick();

            ReadFontStyle(itemsList[CurrentSelectedID].FS);
            ReadOtherFlags(itemsList[CurrentSelectedID].OF);

            GeneratePageContent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string path;

            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                if(File.Exists(path))
                {
                    Stream i = File.OpenRead(path);
                    baseImageByteStream = new byte[i.Length];
                    i.Read(baseImageByteStream, 0, (int)i.Length);
                    i.Close();

                    box_file.Text = Path.GetFileName(path);

                    if (baseImageCompressed != null)
                        baseImageCompressed.Dispose();

                    if (baseImageHQ != null)
                        baseImageHQ.Dispose();

                    baseImageHQ = Image.FromStream(new MemoryStream(baseImageByteStream));
                    baseImageCompressed = ResizeImage(baseImageHQ, COMPRESSION_RATIO);
                    GeneratePageContent();
                }
            }
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Project.NewProject();

            /*
            CurrentSelectedID = -1;

            if (baseImageHQ != null)
                baseImageHQ.Dispose();

            if (baseImageCompressed != null)
                baseImageCompressed.Dispose();

            baseImageByteStream = null;
            baseImageCompressed = null;
            baseImageHQ = null;

            layers.Rows.Clear();
            itemsList.Clear();
            box_file.Text = "";

            x_pos.Value = x_pos.Minimum;
            y_pos.Value = y_pos.Minimum;
            fontSize.Value = 14;

            btn_HAL.PerformClick();
            btn_VAD.PerformClick();

            ReadFontStyle(0);
            ReadOtherFlags(0);

            x_center.Checked = false;
            y_center.Checked = false;

            GeneratePageContent();
            labelCounter = 1;
            */
        }

        private bool EnableMove = false;
        private void Paper_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePosition = new Point(e.X, e.Y);
            EnableMove = true;
        }

        private void Paper_MouseUp(object sender, MouseEventArgs e)
        {
            if (!EnableMove) return;
            EnableMove = false;

            int dX = e.X - lastMousePosition.X;
            int dY = e.Y - lastMousePosition.Y;

            //WTF this method moves the first item when loading -_-
            //But I found it and I killed it (it just took me 1 hour)

            /*
            if (Math.Abs(dX) < 10 && Math.Abs(dY) < 10)
                return;
            */

            if(!x_center.Checked)
                x_pos.Value = Clamp(x_pos.Minimum, x_pos.Value + dX, x_pos.Maximum);

            if (!y_center.Checked)
                y_pos.Value = Clamp(y_pos.Minimum, y_pos.Value + dY, y_pos.Maximum);

            lastMousePosition = new Point(e.X, e.Y);
        }

        private void x_center_CheckedChanged(object sender, EventArgs e)
        {
            if(x_center.Checked)
            {
                x_pos.Value = (int)(PAPER_GLOBAL_W / 2d);
                box_x.Enabled = false;
                x_pos.Enabled = false;
            }
            else
            {
                x_pos.Enabled = true;
                box_x.Enabled = true;
            }

            if (CurrentSelectedID != -1)
            {
                itemsList[CurrentSelectedID].CX = x_center.Checked;
            }
        }

        private void y_center_CheckedChanged(object sender, EventArgs e)
        {
            if (y_center.Checked)
            {
                y_pos.Value = (int)(PAPER_GLOBAL_H / 2d);
                box_y.Enabled = false;
                y_pos.Enabled = false;
            }
            else
            {
                y_pos.Enabled = true;
                box_y.Enabled = true;
            }

            if (CurrentSelectedID != -1)
            {
                itemsList[CurrentSelectedID].CY = y_center.Checked;
            }
        }

        private void ReadFontStyle(int afs)
        {
            btn_FSR.BackColor = btn_FSB.BackColor = btn_FSI.BackColor = btn_FSU.BackColor =
            btn_FSS.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(255, 148, 0);

            if (afs == 0) btn_FSR.BackColor = c;
            if ((afs & (int)FontStyle.Bold) > 0) btn_FSB.BackColor = c;
            if ((afs & (int)FontStyle.Italic) > 0) btn_FSI.BackColor = c;
            if ((afs & (int)FontStyle.Underline) > 0) btn_FSU.BackColor = c;
            if ((afs & (int)FontStyle.Strikeout) > 0) btn_FSS.BackColor = c;
        }

        private void ReadOtherFlags(int aof)
        {
            btn_F1.BackColor = btn_F2.BackColor = btn_F3.BackColor = btn_F4.BackColor =
            btn_F5.BackColor = Color.FromArgb(192, 192, 192);

            Color c = Color.FromArgb(166, 62, 63);

            if ((aof & (int)LabelObject.ItemFlags.F1) > 0) btn_F1.BackColor = c;
            if ((aof & (int)LabelObject.ItemFlags.F2) > 0) btn_F2.BackColor = c;
            if ((aof & (int)LabelObject.ItemFlags.F3) > 0) btn_F3.BackColor = c;
            if ((aof & (int)LabelObject.ItemFlags.F4) > 0) btn_F4.BackColor = c;
            if ((aof & (int)LabelObject.ItemFlags.F5) > 0) btn_F5.BackColor = c;
        }

        private void ToggleFS(object sender, EventArgs e)
        {
            int afs = 0;

            if (CurrentSelectedID != -1)
                afs = itemsList[CurrentSelectedID].FS;

            switch (((Button)sender).Tag.ToString().ToUpper())
            {
                case "R":
                    afs = 0;
                    break;

                case "B":
                    afs ^= (int)FontStyle.Bold;
                    break;

                case "I":
                    afs ^= (int)FontStyle.Italic;
                    break;

                case "U":
                    afs ^= (int)FontStyle.Underline;
                    break;

                case "S":
                    afs ^= (int)FontStyle.Strikeout;
                    break;
            }

            ReadFontStyle(afs);

            if (CurrentSelectedID != -1 && itemsList[CurrentSelectedID].FS != afs)
            {
                itemsList[CurrentSelectedID].FS = afs;
                GeneratePageContent();
            }

            ActiveControl = Paper;
        }

        private void ToggleOF(object sender, EventArgs e)
        {
            int aof = 0;

            if (CurrentSelectedID != -1)
                aof = itemsList[CurrentSelectedID].OF;

            switch (((Button)sender).Text.ToUpper())
            {
                case "1":
                    aof ^= (int)LabelObject.ItemFlags.F1;
                    break;

                case "2":
                    aof ^= (int)LabelObject.ItemFlags.F2;
                    break;

                case "3":
                    aof ^= (int)LabelObject.ItemFlags.F3;
                    break;

                case "4":
                    aof ^= (int)LabelObject.ItemFlags.F4;
                    break;

                case "5":
                    aof ^= (int)LabelObject.ItemFlags.F5;
                    break;
            }

            ReadOtherFlags(aof);

            if (CurrentSelectedID != -1)
            {
                itemsList[CurrentSelectedID].OF = aof;
            }

            ActiveControl = Paper;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DocMaker Layout|*.dml";
            saveFileDialog.Title = "Save DocMaker Layout";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                SaveLayout(saveFileDialog.FileName);
            }
        }

        static Random random = new Random();

        private void SaveLayout(string sf)
        {
            if(baseImageByteStream == null)
            {
                MessageBox.Show("Can't read the original image stream, please reselect it !");
                return;
            }

            Stream f = File.Create(sf);
            //Stream l = File.OpenRead(baseImagePath);

            LayoutHeader Header;
            LayoutTextData TextData;
            byte[] buffer, itemTitle;

            Header.TYPE = 'L';
            Header.DECODER = (char)random.Next(65, 91);

            Header.SIZE = itemsList.Count;
            Header.IMGS = (Int32)baseImageByteStream.Length;

            buffer = Funcs.getBytes(Header);
            f.Write(buffer, 0, buffer.Length);

            foreach(Item o in itemsList)
            {
                itemTitle = Encoding.ASCII.GetBytes(o.Title);
                TextData.TS = (char)itemTitle.Length;

                TextData.CX = o.CX;
                TextData.CY = o.CY;

                TextData.X = (double)o.X / (double)PAPER_GLOBAL_W;
                TextData.Y = (double)o.Y / (double)PAPER_GLOBAL_H;
                TextData.S = (double)o.S / (double)PAPER_GLOBAL_H;

                TextData.VA = (char)GetAlignment(o.VA);
                TextData.HA = (char)GetAlignment(o.HA);

                TextData.FS = (char)o.FS;
                TextData.FLAGS = (char)o.OF;

                buffer = Funcs.getBytes(TextData);
                f.Write(buffer, 0, buffer.Length);

                //Write title after data
                f.Write(itemTitle, 0, itemTitle.Length);
            }

            //Set buffer to image size
            buffer = new byte[baseImageByteStream.Length];

            //Simple Image Encryption XOR 0XFF
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = (byte)(baseImageByteStream[i] ^ Header.DECODER);

            //Reverse Array for a little more security
            Array.Reverse(buffer, 0, buffer.Length);

            //Write Image to Layout file
            f.Write(buffer, 0, buffer.Length);

            f.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();

            LayoutHeader header;
            LayoutTextData textData;

            Stream layoutFile;
            byte[] buffer, itemTitle;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "DocMaker Layout|*.dml";
            openFileDialog.Title = "Open DocMaker Layout";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            if (!File.Exists(openFileDialog.FileName))
                return;

            Console.WriteLine("Starting Loading");

            //Open File
            layoutFile = File.OpenRead(openFileDialog.FileName);

            //Reading Header
            buffer = new byte[Marshal.SizeOf(typeof(LayoutHeader))];
            layoutFile.Read(buffer, 0, buffer.Length);
            header = fromBytes<LayoutHeader>(buffer);

            //Reading each layout text data
            buffer = new byte[Marshal.SizeOf(typeof(LayoutTextData))];

            for (int i = 0; i < header.SIZE; i++)
            {
                layoutFile.Read(buffer, 0, buffer.Length);
                textData = fromBytes<LayoutTextData>(buffer);

                itemTitle = new byte[textData.TS];
                layoutFile.Read(itemTitle, 0, textData.TS);

                Item label = new Item
                {
                    Type = Item.TYPE.LABEL,
                    Visible = true,

                    Title = Encoding.ASCII.GetString(itemTitle),

                    HA = GetAlignmentFromChar(textData.HA, false),
                    VA = GetAlignmentFromChar(textData.VA, true),

                    CX = textData.CX,
                    CY = textData.CY,

                    X = (int)(textData.X * (double)PAPER_GLOBAL_W),
                    Y = (int)(textData.Y * (double)PAPER_GLOBAL_H),
                    S = (int)(textData.S * (double)PAPER_GLOBAL_H),

                    FS = (int)textData.FS,
                    OF = (int)textData.FLAGS
                };

                itemsList.Add(label);
                labelCounter++;
            }

            Console.WriteLine(itemsList.Count);

            //Reading the Image
            buffer = new byte[header.IMGS];
            baseImageByteStream = new byte[header.IMGS];
            layoutFile.Read(buffer, 0, buffer.Length);

            //Close stream
            layoutFile.Close();

            //InReverse Array
            Array.Reverse(buffer, 0, buffer.Length);

            //Decode the image
            for (int i = 0; i < buffer.Length; i++)
                baseImageByteStream[i] = (byte)(buffer[i] ^ header.DECODER);

            /*
            Stream debug = File.OpenWrite("debug.png");
            debug.Write(baseImageByteStream, 0, baseImageByteStream.Length);
            debug.Close();
            */

            try
            {
                //Open stream as image
                baseImageHQ = Image.FromStream(new MemoryStream(baseImageByteStream));
                baseImageCompressed = ResizeImage(baseImageHQ, COMPRESSION_RATIO);
            }catch{
                MessageBox.Show("Unable loading Image data from layout :");
            }
 
            ReloadLayers();
            GeneratePageContent();

            Console.WriteLine("Finished loading");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (CurrentSelectedID < 0)
                return;

            if (Question("Are you sure you want to delete this item ?") != DialogResult.Yes)
                return;

            itemsList.Remove(itemsList[CurrentSelectedID]);
            ReloadLayers();

            if (itemsList.Count <= 0)
                CurrentSelectedID = -1;

            GeneratePageContent();

            
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            int ID = CurrentSelectedID;

            if (itemsList.ItemMove(ID, ID - 1))
            {
                ReloadLayers();

                layers.CurrentCell = layers.Rows[ID - 1].Cells[layer_name.Index];
                layers.Rows[ID - 1].Selected = true;
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            int ID = CurrentSelectedID;

            if (itemsList.ItemMove(ID, ID + 1))
            {
                ReloadLayers();

                layers.CurrentCell = layers.Rows[ID + 1].Cells[layer_name.Index];
                layers.Rows[ID + 1].Selected = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void layers_MouseEnter(object sender, EventArgs e)
        {
            ActiveControl = layers;
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
    }
}
