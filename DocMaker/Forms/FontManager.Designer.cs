namespace DocMaker
{
    partial class FontManager
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
            this.fontsTable = new System.Windows.Forms.DataGridView();
            this.grid_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_sys_font = new System.Windows.Forms.Button();
            this.btn_add_ext_font = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_preview = new System.Windows.Forms.Label();
            this.btn_size_up = new System.Windows.Forms.Button();
            this.btn_size_down = new System.Windows.Forms.Button();
            this.lab_preview_size = new System.Windows.Forms.Label();
            this.btn_edit_name = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fontsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontsTable
            // 
            this.fontsTable.AllowUserToAddRows = false;
            this.fontsTable.AllowUserToDeleteRows = false;
            this.fontsTable.AllowUserToResizeColumns = false;
            this.fontsTable.AllowUserToResizeRows = false;
            this.fontsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontsTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.fontsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fontsTable.ColumnHeadersHeight = 26;
            this.fontsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fontsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_id,
            this.grid_name});
            this.fontsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fontsTable.Location = new System.Drawing.Point(12, 12);
            this.fontsTable.MultiSelect = false;
            this.fontsTable.Name = "fontsTable";
            this.fontsTable.ReadOnly = true;
            this.fontsTable.RowHeadersVisible = false;
            this.fontsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fontsTable.Size = new System.Drawing.Size(388, 205);
            this.fontsTable.TabIndex = 0;
            this.fontsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FontsTable_CellDoubleClick);
            this.fontsTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.FontsTable_RowEnter);
            this.fontsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.FontsTable_RowsAdded);
            // 
            // grid_id
            // 
            this.grid_id.HeaderText = "ID";
            this.grid_id.Name = "grid_id";
            this.grid_id.ReadOnly = true;
            // 
            // grid_name
            // 
            this.grid_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_name.HeaderText = "Font name";
            this.grid_name.Name = "grid_name";
            this.grid_name.ReadOnly = true;
            // 
            // btn_add_sys_font
            // 
            this.btn_add_sys_font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_sys_font.Location = new System.Drawing.Point(406, 12);
            this.btn_add_sys_font.Name = "btn_add_sys_font";
            this.btn_add_sys_font.Size = new System.Drawing.Size(164, 32);
            this.btn_add_sys_font.TabIndex = 1;
            this.btn_add_sys_font.Text = "Add from system\'s fonts";
            this.btn_add_sys_font.UseVisualStyleBackColor = true;
            this.btn_add_sys_font.Click += new System.EventHandler(this.Btn_add_sys_font_Click);
            // 
            // btn_add_ext_font
            // 
            this.btn_add_ext_font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_ext_font.Location = new System.Drawing.Point(406, 50);
            this.btn_add_ext_font.Name = "btn_add_ext_font";
            this.btn_add_ext_font.Size = new System.Drawing.Size(164, 32);
            this.btn_add_ext_font.TabIndex = 1;
            this.btn_add_ext_font.Text = "Add from font file";
            this.btn_add_ext_font.UseVisualStyleBackColor = true;
            this.btn_add_ext_font.Click += new System.EventHandler(this.Btn_add_ext_font_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(406, 126);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(164, 32);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete font";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(406, 281);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(164, 32);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_size_down);
            this.panel1.Controls.Add(this.btn_size_up);
            this.panel1.Controls.Add(this.lab_preview_size);
            this.panel1.Controls.Add(this.lab_preview);
            this.panel1.Location = new System.Drawing.Point(12, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 90);
            this.panel1.TabIndex = 2;
            // 
            // lab_preview
            // 
            this.lab_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_preview.BackColor = System.Drawing.SystemColors.Control;
            this.lab_preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_preview.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_preview.Location = new System.Drawing.Point(0, 0);
            this.lab_preview.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lab_preview.Name = "lab_preview";
            this.lab_preview.Size = new System.Drawing.Size(356, 88);
            this.lab_preview.TabIndex = 0;
            this.lab_preview.Text = "Preview تجربة";
            this.lab_preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_preview.Click += new System.EventHandler(this.Lab_preview_Click);
            // 
            // btn_size_up
            // 
            this.btn_size_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_size_up.Location = new System.Drawing.Point(359, 3);
            this.btn_size_up.Name = "btn_size_up";
            this.btn_size_up.Size = new System.Drawing.Size(24, 24);
            this.btn_size_up.TabIndex = 3;
            this.btn_size_up.Text = "+";
            this.btn_size_up.UseVisualStyleBackColor = true;
            this.btn_size_up.Click += new System.EventHandler(this.Btn_size_up_Click);
            // 
            // btn_size_down
            // 
            this.btn_size_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_size_down.Location = new System.Drawing.Point(359, 61);
            this.btn_size_down.Name = "btn_size_down";
            this.btn_size_down.Size = new System.Drawing.Size(24, 24);
            this.btn_size_down.TabIndex = 3;
            this.btn_size_down.Text = "-";
            this.btn_size_down.UseVisualStyleBackColor = true;
            this.btn_size_down.Click += new System.EventHandler(this.Btn_size_down_Click);
            // 
            // lab_preview_size
            // 
            this.lab_preview_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_preview_size.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_preview_size.Location = new System.Drawing.Point(359, 33);
            this.lab_preview_size.Margin = new System.Windows.Forms.Padding(3);
            this.lab_preview_size.Name = "lab_preview_size";
            this.lab_preview_size.Size = new System.Drawing.Size(24, 22);
            this.lab_preview_size.TabIndex = 0;
            this.lab_preview_size.Text = "12";
            this.lab_preview_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_edit_name
            // 
            this.btn_edit_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_name.Location = new System.Drawing.Point(406, 88);
            this.btn_edit_name.Name = "btn_edit_name";
            this.btn_edit_name.Size = new System.Drawing.Size(164, 32);
            this.btn_edit_name.TabIndex = 1;
            this.btn_edit_name.Text = "Edit font\'s name";
            this.btn_edit_name.UseVisualStyleBackColor = true;
            this.btn_edit_name.Click += new System.EventHandler(this.Btn_edit_name_Click);
            // 
            // FontManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(582, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_edit_name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add_ext_font);
            this.Controls.Add(this.btn_add_sys_font);
            this.Controls.Add(this.fontsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fonts Manager";
            this.Load += new System.EventHandler(this.FontManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fontsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_name;
        private System.Windows.Forms.Button btn_add_sys_font;
        private System.Windows.Forms.Button btn_add_ext_font;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_preview;
        private System.Windows.Forms.Button btn_size_down;
        private System.Windows.Forms.Button btn_size_up;
        private System.Windows.Forms.Label lab_preview_size;
        private System.Windows.Forms.Button btn_edit_name;
    }
}