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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.textTable = new System.Windows.Forms.DataGridView();
            this.grid_lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_F1 = new System.Windows.Forms.Button();
            this.btn_F2 = new System.Windows.Forms.Button();
            this.btn_F3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_F5 = new System.Windows.Forms.Button();
            this.btn_F4 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_FSR = new System.Windows.Forms.Button();
            this.btn_FSB = new System.Windows.Forms.Button();
            this.btn_FSI = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_FSS = new System.Windows.Forms.Button();
            this.btn_FSU = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fontList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_VAU = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_VAD = new System.Windows.Forms.Button();
            this.btn_VAM = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_HAL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_HAR = new System.Windows.Forms.Button();
            this.btn_HAC = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(122, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(270, 20);
            this.tb_name.TabIndex = 1;
            // 
            // textTable
            // 
            this.textTable.AllowUserToAddRows = false;
            this.textTable.AllowUserToDeleteRows = false;
            this.textTable.AllowUserToResizeColumns = false;
            this.textTable.AllowUserToResizeRows = false;
            this.textTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.textTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.textTable.ColumnHeadersHeight = 26;
            this.textTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.textTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_lang,
            this.grid_content});
            this.textTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.textTable.Location = new System.Drawing.Point(12, 68);
            this.textTable.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.textTable.MultiSelect = false;
            this.textTable.Name = "textTable";
            this.textTable.ReadOnly = true;
            this.textTable.RowHeadersVisible = false;
            this.textTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.textTable.Size = new System.Drawing.Size(380, 252);
            this.textTable.TabIndex = 2;
            this.textTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TextTable_CellDoubleClick);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(122, 38);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(270, 20);
            this.tb_key.TabIndex = 1;
            this.tb_key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_key_KeyPress);
            this.tb_key.Validated += new System.EventHandler(this.Tb_key_Validated);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(401, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 278);
            this.panel1.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.btn_F1);
            this.panel12.Controls.Add(this.btn_F2);
            this.panel12.Controls.Add(this.btn_F3);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.btn_F5);
            this.panel12.Controls.Add(this.btn_F4);
            this.panel12.Location = new System.Drawing.Point(5, 208);
            this.panel12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(246, 24);
            this.panel12.TabIndex = 13;
            // 
            // btn_F1
            // 
            this.btn_F1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F1.BackColor = System.Drawing.Color.Silver;
            this.btn_F1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F1.ForeColor = System.Drawing.Color.Black;
            this.btn_F1.Location = new System.Drawing.Point(122, 0);
            this.btn_F1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_F1.Name = "btn_F1";
            this.btn_F1.Size = new System.Drawing.Size(24, 24);
            this.btn_F1.TabIndex = 3;
            this.btn_F1.Text = "1";
            this.btn_F1.UseVisualStyleBackColor = false;
            this.btn_F1.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // btn_F2
            // 
            this.btn_F2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F2.BackColor = System.Drawing.Color.Silver;
            this.btn_F2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F2.ForeColor = System.Drawing.Color.Black;
            this.btn_F2.Location = new System.Drawing.Point(147, 0);
            this.btn_F2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_F2.Name = "btn_F2";
            this.btn_F2.Size = new System.Drawing.Size(24, 24);
            this.btn_F2.TabIndex = 3;
            this.btn_F2.Text = "2";
            this.btn_F2.UseVisualStyleBackColor = false;
            this.btn_F2.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // btn_F3
            // 
            this.btn_F3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F3.BackColor = System.Drawing.Color.Silver;
            this.btn_F3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F3.ForeColor = System.Drawing.Color.Black;
            this.btn_F3.Location = new System.Drawing.Point(172, 0);
            this.btn_F3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_F3.Name = "btn_F3";
            this.btn_F3.Size = new System.Drawing.Size(24, 24);
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
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Flags";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_F5
            // 
            this.btn_F5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F5.BackColor = System.Drawing.Color.Silver;
            this.btn_F5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F5.ForeColor = System.Drawing.Color.Black;
            this.btn_F5.Location = new System.Drawing.Point(222, 0);
            this.btn_F5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_F5.Name = "btn_F5";
            this.btn_F5.Size = new System.Drawing.Size(24, 24);
            this.btn_F5.TabIndex = 3;
            this.btn_F5.Text = "5";
            this.btn_F5.UseVisualStyleBackColor = false;
            this.btn_F5.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // btn_F4
            // 
            this.btn_F4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_F4.BackColor = System.Drawing.Color.Silver;
            this.btn_F4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_F4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_F4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F4.ForeColor = System.Drawing.Color.Black;
            this.btn_F4.Location = new System.Drawing.Point(197, 0);
            this.btn_F4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_F4.Name = "btn_F4";
            this.btn_F4.Size = new System.Drawing.Size(24, 24);
            this.btn_F4.TabIndex = 3;
            this.btn_F4.Text = "4";
            this.btn_F4.UseVisualStyleBackColor = false;
            this.btn_F4.Click += new System.EventHandler(this.Flags_OnClick);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.btn_FSR);
            this.panel11.Controls.Add(this.btn_FSB);
            this.panel11.Controls.Add(this.btn_FSI);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.btn_FSS);
            this.panel11.Controls.Add(this.btn_FSU);
            this.panel11.Location = new System.Drawing.Point(5, 179);
            this.panel11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(246, 24);
            this.panel11.TabIndex = 12;
            // 
            // btn_FSR
            // 
            this.btn_FSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSR.BackColor = System.Drawing.Color.Silver;
            this.btn_FSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSR.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSR.ForeColor = System.Drawing.Color.Black;
            this.btn_FSR.Location = new System.Drawing.Point(122, 0);
            this.btn_FSR.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FSR.Name = "btn_FSR";
            this.btn_FSR.Size = new System.Drawing.Size(24, 24);
            this.btn_FSR.TabIndex = 3;
            this.btn_FSR.Tag = "R";
            this.btn_FSR.Text = "R";
            this.btn_FSR.UseVisualStyleBackColor = false;
            this.btn_FSR.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // btn_FSB
            // 
            this.btn_FSB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSB.BackColor = System.Drawing.Color.Silver;
            this.btn_FSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSB.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSB.Location = new System.Drawing.Point(147, 0);
            this.btn_FSB.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FSB.Name = "btn_FSB";
            this.btn_FSB.Size = new System.Drawing.Size(24, 24);
            this.btn_FSB.TabIndex = 3;
            this.btn_FSB.Tag = "B";
            this.btn_FSB.Text = "B";
            this.btn_FSB.UseVisualStyleBackColor = false;
            this.btn_FSB.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // btn_FSI
            // 
            this.btn_FSI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSI.BackColor = System.Drawing.Color.Silver;
            this.btn_FSI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSI.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSI.Location = new System.Drawing.Point(172, 0);
            this.btn_FSI.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FSI.Name = "btn_FSI";
            this.btn_FSI.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btn_FSI.Size = new System.Drawing.Size(24, 24);
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
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Font Style";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_FSS
            // 
            this.btn_FSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSS.BackColor = System.Drawing.Color.Silver;
            this.btn_FSS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSS.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSS.Location = new System.Drawing.Point(222, 0);
            this.btn_FSS.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FSS.Name = "btn_FSS";
            this.btn_FSS.Size = new System.Drawing.Size(24, 24);
            this.btn_FSS.TabIndex = 3;
            this.btn_FSS.Tag = "S";
            this.btn_FSS.Text = "T";
            this.btn_FSS.UseVisualStyleBackColor = false;
            this.btn_FSS.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // btn_FSU
            // 
            this.btn_FSU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FSU.BackColor = System.Drawing.Color.Silver;
            this.btn_FSU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FSU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_FSU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FSU.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FSU.Location = new System.Drawing.Point(197, 0);
            this.btn_FSU.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_FSU.Name = "btn_FSU";
            this.btn_FSU.Size = new System.Drawing.Size(24, 24);
            this.btn_FSU.TabIndex = 3;
            this.btn_FSU.Tag = "U";
            this.btn_FSU.Text = "U";
            this.btn_FSU.UseVisualStyleBackColor = false;
            this.btn_FSU.Click += new System.EventHandler(this.FontStyle_OnClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(127)))), ((int)(((byte)(187)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(0, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(256, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Font styling";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(127)))), ((int)(((byte)(187)))));
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(256, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Text alignment";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.fontList);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(5, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 24);
            this.panel2.TabIndex = 10;
            // 
            // fontList
            // 
            this.fontList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontList.FormattingEnabled = true;
            this.fontList.Location = new System.Drawing.Point(122, 1);
            this.fontList.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(124, 21);
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
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Font";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.fontSize);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(5, 150);
            this.panel8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(246, 24);
            this.panel8.TabIndex = 10;
            // 
            // fontSize
            // 
            this.fontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontSize.Location = new System.Drawing.Point(122, 2);
            this.fontSize.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
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
            this.fontSize.Size = new System.Drawing.Size(123, 20);
            this.fontSize.TabIndex = 1;
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
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Font size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btn_VAU);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btn_VAD);
            this.panel4.Controls.Add(this.btn_VAM);
            this.panel4.Location = new System.Drawing.Point(5, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 24);
            this.panel4.TabIndex = 6;
            // 
            // btn_VAU
            // 
            this.btn_VAU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VAU.BackColor = System.Drawing.Color.Silver;
            this.btn_VAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VAU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_VAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VAU.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VAU.Image = ((System.Drawing.Image)(resources.GetObject("btn_VAU.Image")));
            this.btn_VAU.Location = new System.Drawing.Point(171, 0);
            this.btn_VAU.Margin = new System.Windows.Forms.Padding(0);
            this.btn_VAU.Name = "btn_VAU";
            this.btn_VAU.Padding = new System.Windows.Forms.Padding(0, 0, 2, 5);
            this.btn_VAU.Size = new System.Drawing.Size(24, 24);
            this.btn_VAU.TabIndex = 3;
            this.btn_VAU.Tag = "U";
            this.btn_VAU.UseVisualStyleBackColor = false;
            this.btn_VAU.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vertical alignment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_VAD
            // 
            this.btn_VAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VAD.BackColor = System.Drawing.Color.Silver;
            this.btn_VAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VAD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_VAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VAD.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VAD.Image = ((System.Drawing.Image)(resources.GetObject("btn_VAD.Image")));
            this.btn_VAD.Location = new System.Drawing.Point(221, 0);
            this.btn_VAD.Margin = new System.Windows.Forms.Padding(0);
            this.btn_VAD.Name = "btn_VAD";
            this.btn_VAD.Padding = new System.Windows.Forms.Padding(0, 3, 2, 0);
            this.btn_VAD.Size = new System.Drawing.Size(24, 24);
            this.btn_VAD.TabIndex = 3;
            this.btn_VAD.Tag = "D";
            this.btn_VAD.UseVisualStyleBackColor = false;
            this.btn_VAD.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_VAM
            // 
            this.btn_VAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VAM.BackColor = System.Drawing.Color.Silver;
            this.btn_VAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VAM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_VAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VAM.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VAM.Image = ((System.Drawing.Image)(resources.GetObject("btn_VAM.Image")));
            this.btn_VAM.Location = new System.Drawing.Point(196, 0);
            this.btn_VAM.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_VAM.Name = "btn_VAM";
            this.btn_VAM.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btn_VAM.Size = new System.Drawing.Size(24, 24);
            this.btn_VAM.TabIndex = 3;
            this.btn_VAM.Tag = "M";
            this.btn_VAM.UseVisualStyleBackColor = false;
            this.btn_VAM.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btn_HAL);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_HAR);
            this.panel3.Controls.Add(this.btn_HAC);
            this.panel3.Location = new System.Drawing.Point(5, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 24);
            this.panel3.TabIndex = 5;
            // 
            // btn_HAL
            // 
            this.btn_HAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HAL.BackColor = System.Drawing.Color.Silver;
            this.btn_HAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HAL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_HAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HAL.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HAL.Image = global::DocMaker.Properties.Resources.icons8_align_left_18;
            this.btn_HAL.Location = new System.Drawing.Point(171, 0);
            this.btn_HAL.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HAL.Name = "btn_HAL";
            this.btn_HAL.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btn_HAL.Size = new System.Drawing.Size(24, 24);
            this.btn_HAL.TabIndex = 3;
            this.btn_HAL.Tag = "L";
            this.btn_HAL.UseVisualStyleBackColor = false;
            this.btn_HAL.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horizontal alignment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_HAR
            // 
            this.btn_HAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HAR.BackColor = System.Drawing.Color.Silver;
            this.btn_HAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_HAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HAR.Image = global::DocMaker.Properties.Resources.icons8_align_right_18;
            this.btn_HAR.Location = new System.Drawing.Point(221, 0);
            this.btn_HAR.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HAR.Name = "btn_HAR";
            this.btn_HAR.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btn_HAR.Size = new System.Drawing.Size(24, 24);
            this.btn_HAR.TabIndex = 3;
            this.btn_HAR.Tag = "R";
            this.btn_HAR.UseVisualStyleBackColor = false;
            this.btn_HAR.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_HAC
            // 
            this.btn_HAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HAC.BackColor = System.Drawing.Color.Silver;
            this.btn_HAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HAC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_HAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HAC.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HAC.Image = global::DocMaker.Properties.Resources.icons8_align_center_18;
            this.btn_HAC.Location = new System.Drawing.Point(196, 0);
            this.btn_HAC.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_HAC.Name = "btn_HAC";
            this.btn_HAC.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.btn_HAC.Size = new System.Drawing.Size(24, 24);
            this.btn_HAC.TabIndex = 3;
            this.btn_HAC.Tag = "C";
            this.btn_HAC.UseVisualStyleBackColor = false;
            this.btn_HAC.Click += new System.EventHandler(this.Alignment_OnClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(398, 296);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 24);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.Location = new System.Drawing.Point(514, 296);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(144, 24);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // LabelEditor
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(669, 332);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textTable);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Label editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LabelEditor_FormClosing);
            this.Click += new System.EventHandler(this.Alignment_OnClick);
            ((System.ComponentModel.ISupportInitialize)(this.textTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DataGridView textTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_HAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_HAR;
        private System.Windows.Forms.Button btn_HAC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_VAU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_VAD;
        private System.Windows.Forms.Button btn_VAM;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_FSR;
        private System.Windows.Forms.Button btn_FSB;
        private System.Windows.Forms.Button btn_FSI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_FSS;
        private System.Windows.Forms.Button btn_FSU;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_F1;
        private System.Windows.Forms.Button btn_F2;
        private System.Windows.Forms.Button btn_F3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_F5;
        private System.Windows.Forms.Button btn_F4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fontList;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_content;
    }
}