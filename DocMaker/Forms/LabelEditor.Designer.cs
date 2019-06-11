namespace DocMaker
{
    partial class LabelEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.textTable = new System.Windows.Forms.DataGridView();
            this.grid_lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_old_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_F1 = new System.Windows.Forms.Button();
            this.btn_F2 = new System.Windows.Forms.Button();
            this.btn_F3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_F5 = new System.Windows.Forms.Button();
            this.btn_F4 = new System.Windows.Forms.Button();
            this.btn_FSR = new System.Windows.Forms.Button();
            this.btn_FSB = new System.Windows.Forms.Button();
            this.btn_FSI = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_FSS = new System.Windows.Forms.Button();
            this.btn_FSU = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fontList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pan_rotation = new System.Windows.Forms.TableLayoutPanel();
            this.btn_rotate_r = new System.Windows.Forms.Button();
            this.btn_rotate_l = new System.Windows.Forms.Button();
            this.lab_angle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_Flags = new System.Windows.Forms.TableLayoutPanel();
            this.pan_FontStyle = new System.Windows.Forms.TableLayoutPanel();
            this.tb_key = new DocMaker.CustomTextBox();
            this.pan_color = new System.Windows.Forms.TableLayoutPanel();
            this.lab_color = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_color_r = new DocMaker.CustomTextBox();
            this.tb_color_b = new DocMaker.CustomTextBox();
            this.tb_color_g = new DocMaker.CustomTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pan_rotation.SuspendLayout();
            this.pan_Flags.SuspendLayout();
            this.pan_FontStyle.SuspendLayout();
            this.pan_color.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.label1, "The local name for this object.\r\nName used to identify object in the object list." +
        "");
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.Location = new System.Drawing.Point(110, 30);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(148, 20);
            this.tb_name.TabIndex = 1;
            // 
            // textTable
            // 
            this.textTable.AllowUserToAddRows = false;
            this.textTable.AllowUserToDeleteRows = false;
            this.textTable.AllowUserToResizeColumns = false;
            this.textTable.AllowUserToResizeRows = false;
            this.textTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.textTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.textTable.ColumnHeadersHeight = 26;
            this.textTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.textTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_lang,
            this.grid_content,
            this.grid_old_value});
            this.textTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.textTable.Location = new System.Drawing.Point(12, 12);
            this.textTable.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.textTable.MultiSelect = false;
            this.textTable.Name = "textTable";
            this.textTable.ReadOnly = true;
            this.textTable.RowHeadersVisible = false;
            this.textTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.textTable.Size = new System.Drawing.Size(406, 338);
            this.textTable.TabIndex = 2;
            this.textTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TextTable_CellDoubleClick);
            this.textTable.Enter += new System.EventHandler(this.TextTable_Enter);
            // 
            // grid_lang
            // 
            this.grid_lang.HeaderText = "Language";
            this.grid_lang.Name = "grid_lang";
            this.grid_lang.ReadOnly = true;
            this.grid_lang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grid_content
            // 
            this.grid_content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_content.HeaderText = "Displayed text";
            this.grid_content.Name = "grid_content";
            this.grid_content.ReadOnly = true;
            this.grid_content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grid_old_value
            // 
            this.grid_old_value.HeaderText = "Entry Original Value";
            this.grid_old_value.Name = "grid_old_value";
            this.grid_old_value.ReadOnly = true;
            this.grid_old_value.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.label2, "The object key name.\r\nThis name is used in your project to edit the configuration" +
        " in real time.");
            // 
            // btn_F1
            // 
            this.btn_F1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F1.BackColor = System.Drawing.Color.Silver;
            this.btn_F1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F1.FlatAppearance.BorderSize = 0;
            this.btn_F1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F1.ForeColor = System.Drawing.Color.Black;
            this.btn_F1.Location = new System.Drawing.Point(0, 0);
            this.btn_F1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_F1.Name = "btn_F1";
            this.btn_F1.Size = new System.Drawing.Size(28, 24);
            this.btn_F1.TabIndex = 1;
            this.btn_F1.Text = "1";
            this.btn_F1.UseVisualStyleBackColor = false;
            this.btn_F1.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // btn_F2
            // 
            this.btn_F2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F2.BackColor = System.Drawing.Color.Silver;
            this.btn_F2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F2.FlatAppearance.BorderSize = 0;
            this.btn_F2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F2.ForeColor = System.Drawing.Color.Black;
            this.btn_F2.Location = new System.Drawing.Point(30, 0);
            this.btn_F2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_F2.Name = "btn_F2";
            this.btn_F2.Size = new System.Drawing.Size(28, 24);
            this.btn_F2.TabIndex = 2;
            this.btn_F2.Text = "2";
            this.btn_F2.UseVisualStyleBackColor = false;
            this.btn_F2.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // btn_F3
            // 
            this.btn_F3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F3.BackColor = System.Drawing.Color.Silver;
            this.btn_F3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F3.FlatAppearance.BorderSize = 0;
            this.btn_F3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F3.ForeColor = System.Drawing.Color.Black;
            this.btn_F3.Location = new System.Drawing.Point(60, 0);
            this.btn_F3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_F3.Name = "btn_F3";
            this.btn_F3.Size = new System.Drawing.Size(28, 24);
            this.btn_F3.TabIndex = 3;
            this.btn_F3.Text = "3";
            this.btn_F3.UseVisualStyleBackColor = false;
            this.btn_F3.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(0, 272);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.MinimumSize = new System.Drawing.Size(0, 28);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(106, 32);
            this.label12.TabIndex = 2;
            this.label12.Text = "Flags";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Visible = false;
            // 
            // btn_F5
            // 
            this.btn_F5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F5.BackColor = System.Drawing.Color.Silver;
            this.btn_F5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F5.FlatAppearance.BorderSize = 0;
            this.btn_F5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F5.ForeColor = System.Drawing.Color.Black;
            this.btn_F5.Location = new System.Drawing.Point(120, 0);
            this.btn_F5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_F5.Name = "btn_F5";
            this.btn_F5.Size = new System.Drawing.Size(28, 24);
            this.btn_F5.TabIndex = 5;
            this.btn_F5.Text = "5";
            this.btn_F5.UseVisualStyleBackColor = false;
            this.btn_F5.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // btn_F4
            // 
            this.btn_F4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F4.BackColor = System.Drawing.Color.Silver;
            this.btn_F4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F4.FlatAppearance.BorderSize = 0;
            this.btn_F4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F4.ForeColor = System.Drawing.Color.Black;
            this.btn_F4.Location = new System.Drawing.Point(90, 0);
            this.btn_F4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_F4.Name = "btn_F4";
            this.btn_F4.Size = new System.Drawing.Size(28, 24);
            this.btn_F4.TabIndex = 4;
            this.btn_F4.Text = "4";
            this.btn_F4.UseVisualStyleBackColor = false;
            this.btn_F4.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // btn_FSR
            // 
            this.btn_FSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSR.BackColor = System.Drawing.Color.Silver;
            this.btn_FSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSR.FlatAppearance.BorderSize = 0;
            this.btn_FSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSR.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSR.ForeColor = System.Drawing.Color.Black;
            this.btn_FSR.Location = new System.Drawing.Point(0, 0);
            this.btn_FSR.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_FSR.Name = "btn_FSR";
            this.btn_FSR.Size = new System.Drawing.Size(28, 24);
            this.btn_FSR.TabIndex = 1;
            this.btn_FSR.Tag = "R";
            this.btn_FSR.Text = "R";
            this.btn_FSR.UseVisualStyleBackColor = false;
            this.btn_FSR.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // btn_FSB
            // 
            this.btn_FSB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSB.BackColor = System.Drawing.Color.Silver;
            this.btn_FSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSB.FlatAppearance.BorderSize = 0;
            this.btn_FSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSB.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSB.Location = new System.Drawing.Point(30, 0);
            this.btn_FSB.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_FSB.Name = "btn_FSB";
            this.btn_FSB.Size = new System.Drawing.Size(28, 24);
            this.btn_FSB.TabIndex = 2;
            this.btn_FSB.Tag = "B";
            this.btn_FSB.Text = "B";
            this.btn_FSB.UseVisualStyleBackColor = false;
            this.btn_FSB.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // btn_FSI
            // 
            this.btn_FSI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSI.BackColor = System.Drawing.Color.Silver;
            this.btn_FSI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSI.FlatAppearance.BorderSize = 0;
            this.btn_FSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSI.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSI.Location = new System.Drawing.Point(60, 0);
            this.btn_FSI.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_FSI.Name = "btn_FSI";
            this.btn_FSI.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btn_FSI.Size = new System.Drawing.Size(28, 24);
            this.btn_FSI.TabIndex = 3;
            this.btn_FSI.Tag = "I";
            this.btn_FSI.Text = "I";
            this.btn_FSI.UseVisualStyleBackColor = false;
            this.btn_FSI.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(106, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Font style";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_FSS
            // 
            this.btn_FSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSS.BackColor = System.Drawing.Color.Silver;
            this.btn_FSS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSS.FlatAppearance.BorderSize = 0;
            this.btn_FSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSS.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSS.Location = new System.Drawing.Point(120, 0);
            this.btn_FSS.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FSS.Name = "btn_FSS";
            this.btn_FSS.Size = new System.Drawing.Size(28, 24);
            this.btn_FSS.TabIndex = 5;
            this.btn_FSS.Tag = "S";
            this.btn_FSS.Text = "T";
            this.btn_FSS.UseVisualStyleBackColor = false;
            this.btn_FSS.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // btn_FSU
            // 
            this.btn_FSU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSU.BackColor = System.Drawing.Color.Silver;
            this.btn_FSU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSU.FlatAppearance.BorderSize = 0;
            this.btn_FSU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSU.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSU.Location = new System.Drawing.Point(90, 0);
            this.btn_FSU.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_FSU.Name = "btn_FSU";
            this.btn_FSU.Size = new System.Drawing.Size(28, 24);
            this.btn_FSU.TabIndex = 4;
            this.btn_FSU.Tag = "U";
            this.btn_FSU.Text = "U";
            this.btn_FSU.UseVisualStyleBackColor = false;
            this.btn_FSU.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(127)))), ((int)(((byte)(187)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(262, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Label style";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fontList
            // 
            this.fontList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontList.FormattingEnabled = true;
            this.fontList.Location = new System.Drawing.Point(110, 182);
            this.fontList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 5);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(148, 21);
            this.fontList.TabIndex = 3;
            this.fontList.SelectedIndexChanged += new System.EventHandler(this.FontList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Font";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fontSize
            // 
            this.fontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSize.Location = new System.Drawing.Point(110, 150);
            this.fontSize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fontSize.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(148, 20);
            this.fontSize.TabIndex = 4;
            this.fontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.FontSize_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Font size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(430, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 28);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_confirm.Location = new System.Drawing.Point(540, 322);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(152, 28);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.pan_rotation, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pan_Flags, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pan_FontStyle, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tb_key, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.fontSize, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pan_color, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.fontList, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(430, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 304);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // pan_rotation
            // 
            this.pan_rotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_rotation.ColumnCount = 3;
            this.pan_rotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_rotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_rotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pan_rotation.Controls.Add(this.btn_rotate_r, 2, 0);
            this.pan_rotation.Controls.Add(this.btn_rotate_l, 1, 0);
            this.pan_rotation.Controls.Add(this.lab_angle, 0, 0);
            this.pan_rotation.Location = new System.Drawing.Point(110, 244);
            this.pan_rotation.Margin = new System.Windows.Forms.Padding(4);
            this.pan_rotation.Name = "pan_rotation";
            this.pan_rotation.RowCount = 1;
            this.pan_rotation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_rotation.Size = new System.Drawing.Size(148, 24);
            this.pan_rotation.TabIndex = 15;
            // 
            // btn_rotate_r
            // 
            this.btn_rotate_r.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rotate_r.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.btn_rotate_r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rotate_r.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.btn_rotate_r.FlatAppearance.BorderSize = 0;
            this.btn_rotate_r.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.btn_rotate_r.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btn_rotate_r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate_r.Image = global::DocMaker.Properties.Resources.ico_rotate_right;
            this.btn_rotate_r.Location = new System.Drawing.Point(120, 0);
            this.btn_rotate_r.Margin = new System.Windows.Forms.Padding(0);
            this.btn_rotate_r.Name = "btn_rotate_r";
            this.btn_rotate_r.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_rotate_r.Size = new System.Drawing.Size(28, 24);
            this.btn_rotate_r.TabIndex = 5;
            this.btn_rotate_r.Tag = "R";
            this.btn_rotate_r.UseVisualStyleBackColor = false;
            this.btn_rotate_r.Click += new System.EventHandler(this.Btn_rotate_r_Click);
            // 
            // btn_rotate_l
            // 
            this.btn_rotate_l.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rotate_l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.btn_rotate_l.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rotate_l.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.btn_rotate_l.FlatAppearance.BorderSize = 0;
            this.btn_rotate_l.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.btn_rotate_l.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.btn_rotate_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate_l.Image = global::DocMaker.Properties.Resources.ico_rotate_left;
            this.btn_rotate_l.Location = new System.Drawing.Point(90, 0);
            this.btn_rotate_l.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btn_rotate_l.Name = "btn_rotate_l";
            this.btn_rotate_l.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn_rotate_l.Size = new System.Drawing.Size(28, 24);
            this.btn_rotate_l.TabIndex = 4;
            this.btn_rotate_l.Tag = "L";
            this.btn_rotate_l.UseVisualStyleBackColor = false;
            this.btn_rotate_l.Click += new System.EventHandler(this.Btn_rotate_l_Click);
            // 
            // lab_angle
            // 
            this.lab_angle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_angle.BackColor = System.Drawing.Color.White;
            this.lab_angle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_angle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_angle.ForeColor = System.Drawing.Color.Black;
            this.lab_angle.Location = new System.Drawing.Point(0, 0);
            this.lab_angle.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lab_angle.Name = "lab_angle";
            this.lab_angle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_angle.Size = new System.Drawing.Size(88, 24);
            this.lab_angle.TabIndex = 2;
            this.lab_angle.Text = "0 °";
            this.lab_angle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(262, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Object identification";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_Flags
            // 
            this.pan_Flags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_Flags.ColumnCount = 5;
            this.pan_Flags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_Flags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_Flags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_Flags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_Flags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pan_Flags.Controls.Add(this.btn_F5, 4, 0);
            this.pan_Flags.Controls.Add(this.btn_F3, 2, 0);
            this.pan_Flags.Controls.Add(this.btn_F4, 3, 0);
            this.pan_Flags.Controls.Add(this.btn_F2, 1, 0);
            this.pan_Flags.Controls.Add(this.btn_F1, 0, 0);
            this.pan_Flags.Location = new System.Drawing.Point(110, 276);
            this.pan_Flags.Margin = new System.Windows.Forms.Padding(4);
            this.pan_Flags.Name = "pan_Flags";
            this.pan_Flags.RowCount = 1;
            this.pan_Flags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_Flags.Size = new System.Drawing.Size(148, 24);
            this.pan_Flags.TabIndex = 7;
            this.pan_Flags.Visible = false;
            // 
            // pan_FontStyle
            // 
            this.pan_FontStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_FontStyle.ColumnCount = 5;
            this.pan_FontStyle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_FontStyle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_FontStyle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_FontStyle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pan_FontStyle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.pan_FontStyle.Controls.Add(this.btn_FSS, 4, 0);
            this.pan_FontStyle.Controls.Add(this.btn_FSR, 0, 0);
            this.pan_FontStyle.Controls.Add(this.btn_FSB, 1, 0);
            this.pan_FontStyle.Controls.Add(this.btn_FSU, 3, 0);
            this.pan_FontStyle.Controls.Add(this.btn_FSI, 2, 0);
            this.pan_FontStyle.Location = new System.Drawing.Point(110, 212);
            this.pan_FontStyle.Margin = new System.Windows.Forms.Padding(4);
            this.pan_FontStyle.Name = "pan_FontStyle";
            this.pan_FontStyle.RowCount = 1;
            this.pan_FontStyle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_FontStyle.Size = new System.Drawing.Size(148, 24);
            this.pan_FontStyle.TabIndex = 6;
            // 
            // tb_key
            // 
            this.tb_key.AllowSpace = false;
            this.tb_key.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_key.Location = new System.Drawing.Point(110, 62);
            this.tb_key.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_key.MaxLength = 32;
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(148, 20);
            this.tb_key.TabIndex = 12;
            this.tb_key.UsedFilter = DocMaker.CustomTextBox.Filter.Special;
            this.tb_key.Validated += new System.EventHandler(this.Tb_key_Validated);
            // 
            // pan_color
            // 
            this.pan_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_color.ColumnCount = 2;
            this.pan_color.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_color.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pan_color.Controls.Add(this.lab_color, 1, 0);
            this.pan_color.Controls.Add(this.label4, 0, 0);
            this.pan_color.Location = new System.Drawing.Point(0, 112);
            this.pan_color.Margin = new System.Windows.Forms.Padding(0);
            this.pan_color.Name = "pan_color";
            this.pan_color.RowCount = 1;
            this.pan_color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_color.Size = new System.Drawing.Size(106, 32);
            this.pan_color.TabIndex = 13;
            // 
            // lab_color
            // 
            this.lab_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_color.BackColor = System.Drawing.Color.Red;
            this.lab_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_color.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_color.Location = new System.Drawing.Point(86, 7);
            this.lab_color.Margin = new System.Windows.Forms.Padding(0, 7, 2, 7);
            this.lab_color.Name = "lab_color";
            this.lab_color.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lab_color.Size = new System.Drawing.Size(18, 18);
            this.lab_color.TabIndex = 2;
            this.lab_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_color.Click += new System.EventHandler(this.Lab_color_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Text color";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.Controls.Add(this.tb_color_r, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_color_b, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_color_g, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(110, 116);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(148, 24);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tb_color_r
            // 
            this.tb_color_r.AllowSpace = false;
            this.tb_color_r.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_color_r.Location = new System.Drawing.Point(0, 2);
            this.tb_color_r.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tb_color_r.MaxLength = 3;
            this.tb_color_r.Name = "tb_color_r";
            this.tb_color_r.Size = new System.Drawing.Size(47, 20);
            this.tb_color_r.TabIndex = 1;
            this.tb_color_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_color_r.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.tb_color_r.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingColorInput);
            // 
            // tb_color_b
            // 
            this.tb_color_b.AllowSpace = false;
            this.tb_color_b.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_color_b.Location = new System.Drawing.Point(100, 2);
            this.tb_color_b.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.tb_color_b.MaxLength = 3;
            this.tb_color_b.Name = "tb_color_b";
            this.tb_color_b.Size = new System.Drawing.Size(48, 20);
            this.tb_color_b.TabIndex = 3;
            this.tb_color_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_color_b.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.tb_color_b.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingColorInput);
            // 
            // tb_color_g
            // 
            this.tb_color_g.AllowSpace = false;
            this.tb_color_g.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_color_g.Location = new System.Drawing.Point(50, 2);
            this.tb_color_g.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.tb_color_g.MaxLength = 3;
            this.tb_color_g.Name = "tb_color_g";
            this.tb_color_g.Size = new System.Drawing.Size(47, 20);
            this.tb_color_g.TabIndex = 2;
            this.tb_color_g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_color_g.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.tb_color_g.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingColorInput);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(106, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Text rotation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelEditor
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(704, 362);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.textTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Label editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LabelEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.textTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pan_rotation.ResumeLayout(false);
            this.pan_Flags.ResumeLayout(false);
            this.pan_FontStyle.ResumeLayout(false);
            this.pan_color.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DataGridView textTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_FSR;
        private System.Windows.Forms.Button btn_FSB;
        private System.Windows.Forms.Button btn_FSI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_FSS;
        private System.Windows.Forms.Button btn_FSU;
        private System.Windows.Forms.Button btn_F1;
        private System.Windows.Forms.Button btn_F2;
        private System.Windows.Forms.Button btn_F3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_F5;
        private System.Windows.Forms.Button btn_F4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fontList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel pan_Flags;
        private System.Windows.Forms.TableLayoutPanel pan_FontStyle;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_color;
        private CustomTextBox tb_key;
        private System.Windows.Forms.TableLayoutPanel pan_color;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomTextBox tb_color_r;
        private CustomTextBox tb_color_b;
        private CustomTextBox tb_color_g;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel pan_rotation;
        private System.Windows.Forms.Button btn_rotate_r;
        private System.Windows.Forms.Button btn_rotate_l;
        private System.Windows.Forms.Label lab_angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_old_value;
    }
}