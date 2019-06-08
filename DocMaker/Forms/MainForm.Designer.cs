namespace DocMaker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.TableLayoutPanel();
            this.pan_zoom = new System.Windows.Forms.TableLayoutPanel();
            this.comboZoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusIcon = new System.Windows.Forms.PictureBox();
            this.lab_paperSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_x_pos = new System.Windows.Forms.Label();
            this.lab_y_pos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_line = new System.Windows.Forms.Button();
            this.btn_add_label = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_AlignmentBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btn_LM = new System.Windows.Forms.Button();
            this.btn_LU = new System.Windows.Forms.Button();
            this.btn_CM = new System.Windows.Forms.Button();
            this.btn_RM = new System.Windows.Forms.Button();
            this.btn_CU = new System.Windows.Forms.Button();
            this.btn_LD = new System.Windows.Forms.Button();
            this.btn_CD = new System.Windows.Forms.Button();
            this.btn_RD = new System.Windows.Forms.Button();
            this.btn_RU = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.layers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.span_SidePanel = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.y_center = new System.Windows.Forms.CheckBox();
            this.box_y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.y_pos = new System.Windows.Forms.TrackBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.x_center = new System.Windows.Forms.CheckBox();
            this.box_x = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.x_pos = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pan_MainSide = new System.Windows.Forms.TableLayoutPanel();
            this.PaperWrap = new DocMaker.CustomPanel();
            this.Paper = new System.Windows.Forms.Panel();
            this.layer_visible = new System.Windows.Forms.DataGridViewImageColumn();
            this.layer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layer_object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainFormMenuStrip.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.pan_zoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pan_AlignmentBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layers)).BeginInit();
            this.span_SidePanel.Panel1.SuspendLayout();
            this.span_SidePanel.Panel2.SuspendLayout();
            this.span_SidePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y_pos)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_pos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.pan_MainSide.SuspendLayout();
            this.PaperWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainFormMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.MainFormMenuStrip.TabIndex = 0;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paperSizeToolStripMenuItem,
            this.languageManagerToolStripMenuItem,
            this.addFontToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNewLabelToolStripMenuItem,
            this.addNewImageToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // paperSizeToolStripMenuItem
            // 
            this.paperSizeToolStripMenuItem.Name = "paperSizeToolStripMenuItem";
            this.paperSizeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.paperSizeToolStripMenuItem.Text = "Change paper size";
            this.paperSizeToolStripMenuItem.Click += new System.EventHandler(this.PaperSizeToolStripMenuItem_Click);
            // 
            // languageManagerToolStripMenuItem
            // 
            this.languageManagerToolStripMenuItem.Name = "languageManagerToolStripMenuItem";
            this.languageManagerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.languageManagerToolStripMenuItem.Text = "Language manager";
            this.languageManagerToolStripMenuItem.Click += new System.EventHandler(this.LanguageManagerToolStripMenuItem_Click);
            // 
            // addFontToolStripMenuItem
            // 
            this.addFontToolStripMenuItem.Name = "addFontToolStripMenuItem";
            this.addFontToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addFontToolStripMenuItem.Text = "Font manager";
            this.addFontToolStripMenuItem.Click += new System.EventHandler(this.AddFontToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // addNewLabelToolStripMenuItem
            // 
            this.addNewLabelToolStripMenuItem.Name = "addNewLabelToolStripMenuItem";
            this.addNewLabelToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewLabelToolStripMenuItem.Text = "Add new label";
            // 
            // addNewImageToolStripMenuItem
            // 
            this.addNewImageToolStripMenuItem.Name = "addNewImageToolStripMenuItem";
            this.addNewImageToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewImageToolStripMenuItem.Text = "Add new image";
            // 
            // StatusBar
            // 
            this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StatusBar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.StatusBar.ColumnCount = 9;
            this.pan_MainSide.SetColumnSpan(this.StatusBar, 3);
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.StatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StatusBar.Controls.Add(this.pan_zoom, 8, 0);
            this.StatusBar.Controls.Add(this.StatusIcon, 0, 0);
            this.StatusBar.Controls.Add(this.lab_paperSize, 1, 0);
            this.StatusBar.Controls.Add(this.label2, 3, 0);
            this.StatusBar.Controls.Add(this.lab_x_pos, 4, 0);
            this.StatusBar.Controls.Add(this.lab_y_pos, 5, 0);
            this.StatusBar.Location = new System.Drawing.Point(0, 726);
            this.StatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RowCount = 1;
            this.StatusBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StatusBar.Size = new System.Drawing.Size(884, 32);
            this.StatusBar.TabIndex = 2;
            // 
            // pan_zoom
            // 
            this.pan_zoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_zoom.AutoSize = true;
            this.pan_zoom.ColumnCount = 2;
            this.pan_zoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pan_zoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_zoom.Controls.Add(this.comboZoom, 1, 0);
            this.pan_zoom.Controls.Add(this.label5, 0, 0);
            this.pan_zoom.Location = new System.Drawing.Point(782, 2);
            this.pan_zoom.Margin = new System.Windows.Forms.Padding(0);
            this.pan_zoom.Name = "pan_zoom";
            this.pan_zoom.RowCount = 1;
            this.pan_zoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_zoom.Size = new System.Drawing.Size(100, 28);
            this.pan_zoom.TabIndex = 6;
            // 
            // comboZoom
            // 
            this.comboZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZoom.FormattingEnabled = true;
            this.comboZoom.Location = new System.Drawing.Point(43, 3);
            this.comboZoom.Name = "comboZoom";
            this.comboZoom.Size = new System.Drawing.Size(54, 21);
            this.comboZoom.TabIndex = 3;
            this.comboZoom.SelectedIndexChanged += new System.EventHandler(this.ComboZoom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Zoom";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusIcon
            // 
            this.StatusIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StatusIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusIcon.Location = new System.Drawing.Point(7, 7);
            this.StatusIcon.Margin = new System.Windows.Forms.Padding(5);
            this.StatusIcon.Name = "StatusIcon";
            this.StatusIcon.Size = new System.Drawing.Size(18, 18);
            this.StatusIcon.TabIndex = 0;
            this.StatusIcon.TabStop = false;
            // 
            // lab_paperSize
            // 
            this.lab_paperSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_paperSize.AutoSize = true;
            this.lab_paperSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_paperSize.ForeColor = System.Drawing.Color.Black;
            this.lab_paperSize.Location = new System.Drawing.Point(32, 2);
            this.lab_paperSize.Margin = new System.Windows.Forms.Padding(0);
            this.lab_paperSize.Name = "lab_paperSize";
            this.lab_paperSize.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lab_paperSize.Size = new System.Drawing.Size(68, 28);
            this.lab_paperSize.TabIndex = 2;
            this.lab_paperSize.Text = "Paper size :";
            this.lab_paperSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(304, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_x_pos
            // 
            this.lab_x_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_x_pos.AutoSize = true;
            this.lab_x_pos.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_x_pos.ForeColor = System.Drawing.Color.Black;
            this.lab_x_pos.Location = new System.Drawing.Point(366, 2);
            this.lab_x_pos.Margin = new System.Windows.Forms.Padding(0);
            this.lab_x_pos.Name = "lab_x_pos";
            this.lab_x_pos.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lab_x_pos.Size = new System.Drawing.Size(50, 28);
            this.lab_x_pos.TabIndex = 2;
            this.lab_x_pos.Text = "x_pos";
            this.lab_x_pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_y_pos
            // 
            this.lab_y_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_y_pos.AutoSize = true;
            this.lab_y_pos.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_y_pos.ForeColor = System.Drawing.Color.Black;
            this.lab_y_pos.Location = new System.Drawing.Point(418, 2);
            this.lab_y_pos.Margin = new System.Windows.Forms.Padding(0);
            this.lab_y_pos.Name = "lab_y_pos";
            this.lab_y_pos.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lab_y_pos.Size = new System.Drawing.Size(50, 28);
            this.lab_y_pos.TabIndex = 2;
            this.lab_y_pos.Text = "y_pos";
            this.lab_y_pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_add_line);
            this.panel1.Controls.Add(this.btn_add_label);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 726);
            this.panel1.TabIndex = 3;
            // 
            // btn_add_line
            // 
            this.btn_add_line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_add_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_line.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_add_line.FlatAppearance.BorderSize = 0;
            this.btn_add_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_line.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_line.Location = new System.Drawing.Point(2, 36);
            this.btn_add_line.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btn_add_line.Name = "btn_add_line";
            this.btn_add_line.Size = new System.Drawing.Size(32, 32);
            this.btn_add_line.TabIndex = 3;
            this.btn_add_line.Text = "\\";
            this.toolTip.SetToolTip(this.btn_add_line, "Duplicate label");
            this.btn_add_line.UseVisualStyleBackColor = false;
            this.btn_add_line.Click += new System.EventHandler(this.Btn_add_line_Click);
            // 
            // btn_add_label
            // 
            this.btn_add_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_add_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_label.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_add_label.FlatAppearance.BorderSize = 0;
            this.btn_add_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_label.Location = new System.Drawing.Point(2, 2);
            this.btn_add_label.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btn_add_label.Name = "btn_add_label";
            this.btn_add_label.Size = new System.Drawing.Size(32, 32);
            this.btn_add_label.TabIndex = 3;
            this.btn_add_label.Text = "T";
            this.toolTip.SetToolTip(this.btn_add_label, "Add label");
            this.btn_add_label.UseVisualStyleBackColor = false;
            this.btn_add_label.Click += new System.EventHandler(this.btn_add_label_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(2, 70);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(32, 32);
            this.btn_delete.TabIndex = 3;
            this.toolTip.SetToolTip(this.btn_delete, "Delete label");
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pan_AlignmentBtns, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 109);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Object alignment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_AlignmentBtns
            // 
            this.pan_AlignmentBtns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_AlignmentBtns.ColumnCount = 4;
            this.pan_AlignmentBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_AlignmentBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.pan_AlignmentBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.pan_AlignmentBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.pan_AlignmentBtns.Controls.Add(this.btn_LM, 1, 1);
            this.pan_AlignmentBtns.Controls.Add(this.btn_LU, 1, 0);
            this.pan_AlignmentBtns.Controls.Add(this.btn_CM, 2, 1);
            this.pan_AlignmentBtns.Controls.Add(this.btn_RM, 3, 1);
            this.pan_AlignmentBtns.Controls.Add(this.btn_CU, 2, 0);
            this.pan_AlignmentBtns.Controls.Add(this.btn_LD, 1, 2);
            this.pan_AlignmentBtns.Controls.Add(this.btn_CD, 2, 2);
            this.pan_AlignmentBtns.Controls.Add(this.btn_RD, 3, 2);
            this.pan_AlignmentBtns.Controls.Add(this.btn_RU, 3, 0);
            this.pan_AlignmentBtns.Controls.Add(this.label13, 0, 0);
            this.pan_AlignmentBtns.Location = new System.Drawing.Point(5, 30);
            this.pan_AlignmentBtns.Margin = new System.Windows.Forms.Padding(5);
            this.pan_AlignmentBtns.Name = "pan_AlignmentBtns";
            this.pan_AlignmentBtns.RowCount = 3;
            this.pan_AlignmentBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.pan_AlignmentBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.pan_AlignmentBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.pan_AlignmentBtns.Size = new System.Drawing.Size(250, 74);
            this.pan_AlignmentBtns.TabIndex = 3;
            // 
            // btn_LM
            // 
            this.btn_LM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LM.BackColor = System.Drawing.Color.Silver;
            this.btn_LM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LM.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_LM.FlatAppearance.BorderSize = 0;
            this.btn_LM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LM.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LM.Image = global::DocMaker.Properties.Resources.ico_alignment_LM;
            this.btn_LM.Location = new System.Drawing.Point(176, 25);
            this.btn_LM.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btn_LM.Name = "btn_LM";
            this.btn_LM.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_LM.Size = new System.Drawing.Size(24, 24);
            this.btn_LM.TabIndex = 3;
            this.btn_LM.Tag = "LM";
            this.toolTip.SetToolTip(this.btn_LM, "Align Top");
            this.btn_LM.UseVisualStyleBackColor = false;
            this.btn_LM.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_LU
            // 
            this.btn_LU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LU.BackColor = System.Drawing.Color.Silver;
            this.btn_LU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LU.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_LU.FlatAppearance.BorderSize = 0;
            this.btn_LU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LU.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LU.Image = global::DocMaker.Properties.Resources.ico_alignment_LU;
            this.btn_LU.Location = new System.Drawing.Point(176, 0);
            this.btn_LU.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LU.Name = "btn_LU";
            this.btn_LU.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_LU.Size = new System.Drawing.Size(24, 24);
            this.btn_LU.TabIndex = 3;
            this.btn_LU.Tag = "LU";
            this.toolTip.SetToolTip(this.btn_LU, "Align Left");
            this.btn_LU.UseVisualStyleBackColor = false;
            this.btn_LU.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_CM
            // 
            this.btn_CM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CM.BackColor = System.Drawing.Color.Silver;
            this.btn_CM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CM.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CM.FlatAppearance.BorderSize = 0;
            this.btn_CM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CM.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CM.Image = global::DocMaker.Properties.Resources.ico_alignment_CM;
            this.btn_CM.Location = new System.Drawing.Point(201, 25);
            this.btn_CM.Margin = new System.Windows.Forms.Padding(1);
            this.btn_CM.Name = "btn_CM";
            this.btn_CM.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_CM.Size = new System.Drawing.Size(24, 24);
            this.btn_CM.TabIndex = 3;
            this.btn_CM.Tag = "CM";
            this.toolTip.SetToolTip(this.btn_CM, "Align Middle");
            this.btn_CM.UseVisualStyleBackColor = false;
            this.btn_CM.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_RM
            // 
            this.btn_RM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RM.BackColor = System.Drawing.Color.Silver;
            this.btn_RM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RM.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_RM.FlatAppearance.BorderSize = 0;
            this.btn_RM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RM.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RM.Image = global::DocMaker.Properties.Resources.ico_alignment_RM;
            this.btn_RM.Location = new System.Drawing.Point(226, 25);
            this.btn_RM.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btn_RM.Name = "btn_RM";
            this.btn_RM.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_RM.Size = new System.Drawing.Size(24, 24);
            this.btn_RM.TabIndex = 3;
            this.btn_RM.Tag = "RM";
            this.toolTip.SetToolTip(this.btn_RM, "Align Bottom");
            this.btn_RM.UseVisualStyleBackColor = false;
            this.btn_RM.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_CU
            // 
            this.btn_CU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CU.BackColor = System.Drawing.Color.Silver;
            this.btn_CU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CU.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CU.FlatAppearance.BorderSize = 0;
            this.btn_CU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CU.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CU.Image = global::DocMaker.Properties.Resources.ico_alignment_CU;
            this.btn_CU.Location = new System.Drawing.Point(201, 0);
            this.btn_CU.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_CU.Name = "btn_CU";
            this.btn_CU.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_CU.Size = new System.Drawing.Size(24, 24);
            this.btn_CU.TabIndex = 3;
            this.btn_CU.Tag = "CU";
            this.toolTip.SetToolTip(this.btn_CU, "Align Center");
            this.btn_CU.UseVisualStyleBackColor = false;
            this.btn_CU.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_LD
            // 
            this.btn_LD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LD.BackColor = System.Drawing.Color.Silver;
            this.btn_LD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_LD.FlatAppearance.BorderSize = 0;
            this.btn_LD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LD.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LD.Image = global::DocMaker.Properties.Resources.ico_alignment_LD;
            this.btn_LD.Location = new System.Drawing.Point(176, 50);
            this.btn_LD.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LD.Name = "btn_LD";
            this.btn_LD.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_LD.Size = new System.Drawing.Size(24, 24);
            this.btn_LD.TabIndex = 3;
            this.btn_LD.Tag = "LD";
            this.btn_LD.UseVisualStyleBackColor = false;
            this.btn_LD.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_CD
            // 
            this.btn_CD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CD.BackColor = System.Drawing.Color.Silver;
            this.btn_CD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_CD.FlatAppearance.BorderSize = 0;
            this.btn_CD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CD.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CD.Image = global::DocMaker.Properties.Resources.ico_alignment_CD;
            this.btn_CD.Location = new System.Drawing.Point(201, 50);
            this.btn_CD.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_CD.Name = "btn_CD";
            this.btn_CD.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_CD.Size = new System.Drawing.Size(24, 24);
            this.btn_CD.TabIndex = 3;
            this.btn_CD.Tag = "CD";
            this.btn_CD.UseVisualStyleBackColor = false;
            this.btn_CD.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_RD
            // 
            this.btn_RD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RD.BackColor = System.Drawing.Color.Silver;
            this.btn_RD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_RD.FlatAppearance.BorderSize = 0;
            this.btn_RD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RD.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RD.Image = global::DocMaker.Properties.Resources.ico_alignment_RD;
            this.btn_RD.Location = new System.Drawing.Point(226, 50);
            this.btn_RD.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RD.Name = "btn_RD";
            this.btn_RD.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_RD.Size = new System.Drawing.Size(24, 24);
            this.btn_RD.TabIndex = 3;
            this.btn_RD.Tag = "RD";
            this.btn_RD.UseVisualStyleBackColor = false;
            this.btn_RD.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_RU
            // 
            this.btn_RU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RU.BackColor = System.Drawing.Color.Silver;
            this.btn_RU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RU.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_RU.FlatAppearance.BorderSize = 0;
            this.btn_RU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RU.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RU.Image = global::DocMaker.Properties.Resources.ico_alignment_RU;
            this.btn_RU.Location = new System.Drawing.Point(226, 0);
            this.btn_RU.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RU.Name = "btn_RU";
            this.btn_RU.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_RU.Size = new System.Drawing.Size(24, 24);
            this.btn_RU.TabIndex = 3;
            this.btn_RU.Tag = "RU";
            this.toolTip.SetToolTip(this.btn_RU, "Align Right");
            this.btn_RU.UseVisualStyleBackColor = false;
            this.btn_RU.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pan_AlignmentBtns.SetRowSpan(this.label13, 3);
            this.label13.Size = new System.Drawing.Size(171, 74);
            this.label13.TabIndex = 2;
            this.label13.Text = "The point where the \r\nobject is drawn from";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layers
            // 
            this.layers.AllowUserToAddRows = false;
            this.layers.AllowUserToDeleteRows = false;
            this.layers.AllowUserToResizeColumns = false;
            this.layers.AllowUserToResizeRows = false;
            this.layers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.layers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.layers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.layers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.layers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.layers.ColumnHeadersHeight = 30;
            this.layers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.layers.ColumnHeadersVisible = false;
            this.layers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layer_visible,
            this.layer_name,
            this.layer_object});
            this.layers.Cursor = System.Windows.Forms.Cursors.Default;
            this.layers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.layers.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.layers.Location = new System.Drawing.Point(0, 25);
            this.layers.Margin = new System.Windows.Forms.Padding(0);
            this.layers.MultiSelect = false;
            this.layers.Name = "layers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.layers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.layers.RowHeadersVisible = false;
            this.layers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.layers.RowTemplate.Height = 30;
            this.layers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.layers.ShowCellErrors = false;
            this.layers.ShowEditingIcon = false;
            this.layers.ShowRowErrors = false;
            this.layers.Size = new System.Drawing.Size(260, 319);
            this.layers.TabIndex = 5;
            this.layers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Layers_CellContentClick);
            this.layers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Layers_CellContentClick);
            this.layers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Layers_CellDoubleClick);
            this.layers.SelectionChanged += new System.EventHandler(this.Layers_SelectionChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Layers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // span_SidePanel
            // 
            this.span_SidePanel.BackColor = System.Drawing.Color.DarkGray;
            this.span_SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.span_SidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.span_SidePanel.Location = new System.Drawing.Point(620, 0);
            this.span_SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.span_SidePanel.Name = "span_SidePanel";
            this.span_SidePanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // span_SidePanel.Panel1
            // 
            this.span_SidePanel.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.span_SidePanel.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.span_SidePanel.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // span_SidePanel.Panel2
            // 
            this.span_SidePanel.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.span_SidePanel.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.span_SidePanel.Size = new System.Drawing.Size(264, 726);
            this.span_SidePanel.SplitterDistance = 376;
            this.span_SidePanel.SplitterIncrement = 10;
            this.span_SidePanel.SplitterWidth = 2;
            this.span_SidePanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 109);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 144);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(260, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Object position";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.y_center);
            this.panel7.Controls.Add(this.box_y);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.y_pos);
            this.panel7.Location = new System.Drawing.Point(5, 89);
            this.panel7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(247, 50);
            this.panel7.TabIndex = 9;
            // 
            // y_center
            // 
            this.y_center.BackColor = System.Drawing.Color.Silver;
            this.y_center.ForeColor = System.Drawing.Color.Black;
            this.y_center.Location = new System.Drawing.Point(79, 8);
            this.y_center.Margin = new System.Windows.Forms.Padding(0);
            this.y_center.Name = "y_center";
            this.y_center.Size = new System.Drawing.Size(62, 17);
            this.y_center.TabIndex = 9;
            this.y_center.Text = "center";
            this.y_center.UseVisualStyleBackColor = false;
            // 
            // box_y
            // 
            this.box_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.box_y.Location = new System.Drawing.Point(143, 6);
            this.box_y.Margin = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.box_y.Name = "box_y";
            this.box_y.Size = new System.Drawing.Size(95, 20);
            this.box_y.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Position Y";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // y_pos
            // 
            this.y_pos.AutoSize = false;
            this.y_pos.Location = new System.Drawing.Point(5, 31);
            this.y_pos.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.y_pos.Name = "y_pos";
            this.y_pos.Size = new System.Drawing.Size(233, 14);
            this.y_pos.TabIndex = 7;
            this.y_pos.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.x_center);
            this.panel6.Controls.Add(this.box_x);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.x_pos);
            this.panel6.Location = new System.Drawing.Point(5, 29);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(247, 50);
            this.panel6.TabIndex = 9;
            // 
            // x_center
            // 
            this.x_center.BackColor = System.Drawing.Color.Silver;
            this.x_center.ForeColor = System.Drawing.Color.Black;
            this.x_center.Location = new System.Drawing.Point(79, 8);
            this.x_center.Margin = new System.Windows.Forms.Padding(0);
            this.x_center.Name = "x_center";
            this.x_center.Size = new System.Drawing.Size(62, 17);
            this.x_center.TabIndex = 9;
            this.x_center.Text = "center";
            this.x_center.UseVisualStyleBackColor = false;
            // 
            // box_x
            // 
            this.box_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.box_x.Location = new System.Drawing.Point(143, 6);
            this.box_x.Margin = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.box_x.Name = "box_x";
            this.box_x.Size = new System.Drawing.Size(95, 20);
            this.box_x.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Position X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // x_pos
            // 
            this.x_pos.AutoSize = false;
            this.x_pos.Location = new System.Drawing.Point(5, 31);
            this.x_pos.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.x_pos.Name = "x_pos";
            this.x_pos.Size = new System.Drawing.Size(233, 14);
            this.x_pos.TabIndex = 7;
            this.x_pos.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.layers, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 344);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // pan_MainSide
            // 
            this.pan_MainSide.ColumnCount = 3;
            this.pan_MainSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pan_MainSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_MainSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.pan_MainSide.Controls.Add(this.PaperWrap, 1, 0);
            this.pan_MainSide.Controls.Add(this.StatusBar, 0, 1);
            this.pan_MainSide.Controls.Add(this.panel1, 0, 0);
            this.pan_MainSide.Controls.Add(this.span_SidePanel, 2, 0);
            this.pan_MainSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_MainSide.Location = new System.Drawing.Point(0, 24);
            this.pan_MainSide.Margin = new System.Windows.Forms.Padding(0);
            this.pan_MainSide.Name = "pan_MainSide";
            this.pan_MainSide.RowCount = 2;
            this.pan_MainSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_MainSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.pan_MainSide.Size = new System.Drawing.Size(884, 758);
            this.pan_MainSide.TabIndex = 6;
            // 
            // PaperWrap
            // 
            this.PaperWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaperWrap.AutoScroll = true;
            this.PaperWrap.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.PaperWrap.AutoScrollMinSize = new System.Drawing.Size(20, 20);
            this.PaperWrap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PaperWrap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaperWrap.Controls.Add(this.Paper);
            this.PaperWrap.Location = new System.Drawing.Point(40, 0);
            this.PaperWrap.Margin = new System.Windows.Forms.Padding(0);
            this.PaperWrap.Name = "PaperWrap";
            this.PaperWrap.Size = new System.Drawing.Size(580, 726);
            this.PaperWrap.TabIndex = 1;
            this.PaperWrap.Click += new System.EventHandler(this.PaperWrap_OnClick);
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.White;
            this.Paper.Location = new System.Drawing.Point(20, 20);
            this.Paper.Margin = new System.Windows.Forms.Padding(0);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(43, 55);
            this.Paper.TabIndex = 0;
            this.Paper.Click += new System.EventHandler(this.PaperWrap_OnClick);
            // 
            // layer_visible
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.layer_visible.DefaultCellStyle = dataGridViewCellStyle1;
            this.layer_visible.HeaderText = "visible";
            this.layer_visible.Name = "layer_visible";
            this.layer_visible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.layer_visible.Width = 30;
            // 
            // layer_name
            // 
            this.layer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.layer_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.layer_name.HeaderText = "name";
            this.layer_name.Name = "layer_name";
            this.layer_name.ReadOnly = true;
            // 
            // layer_object
            // 
            this.layer_object.HeaderText = "Object";
            this.layer_object.Name = "layer_object";
            this.layer_object.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 782);
            this.Controls.Add(this.pan_MainSide);
            this.Controls.Add(this.MainFormMenuStrip);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocMaker v1.1 Beta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.pan_zoom.ResumeLayout(false);
            this.pan_zoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pan_AlignmentBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layers)).EndInit();
            this.span_SidePanel.Panel1.ResumeLayout(false);
            this.span_SidePanel.Panel2.ResumeLayout(false);
            this.span_SidePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y_pos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_pos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pan_MainSide.ResumeLayout(false);
            this.PaperWrap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewImageToolStripMenuItem;
        private CustomPanel PaperWrap;
        private System.Windows.Forms.Panel Paper;
        private System.Windows.Forms.TableLayoutPanel StatusBar;
        private System.Windows.Forms.PictureBox StatusIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView layers;
        private System.Windows.Forms.Button btn_add_label;
        private System.Windows.Forms.TextBox box_x;
        private System.Windows.Forms.TrackBar x_pos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox box_y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar y_pos;
        private System.Windows.Forms.CheckBox x_center;
        private System.Windows.Forms.Button btn_add_line;
        private System.Windows.Forms.CheckBox y_center;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem languageManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paperSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lab_paperSize;
        private System.Windows.Forms.ComboBox comboZoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel pan_AlignmentBtns;
        private System.Windows.Forms.Button btn_LU;
        private System.Windows.Forms.Button btn_RU;
        private System.Windows.Forms.Button btn_CM;
        private System.Windows.Forms.Button btn_RM;
        private System.Windows.Forms.Button btn_CU;
        private System.Windows.Forms.Button btn_LD;
        private System.Windows.Forms.Button btn_RD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_LM;
        private System.Windows.Forms.Button btn_CD;
        private System.Windows.Forms.SplitContainer span_SidePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel pan_MainSide;
        private System.Windows.Forms.TableLayoutPanel pan_zoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_x_pos;
        private System.Windows.Forms.Label lab_y_pos;
        private System.Windows.Forms.DataGridViewImageColumn layer_visible;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer_object;
    }
}

