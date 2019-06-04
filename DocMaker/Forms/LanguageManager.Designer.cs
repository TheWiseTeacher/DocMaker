namespace DocMaker
{
    partial class LanguageManager
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
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.languagesTable = new System.Windows.Forms.DataGridView();
            this.grid_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove_lang = new System.Windows.Forms.Button();
            this.btn_add_lang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.languagesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(380, 238);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(192, 32);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(560, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can use any language code you want, but you need to set it in your project co" +
    "de to use it";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languagesTable
            // 
            this.languagesTable.AllowUserToAddRows = false;
            this.languagesTable.AllowUserToDeleteRows = false;
            this.languagesTable.AllowUserToResizeColumns = false;
            this.languagesTable.AllowUserToResizeRows = false;
            this.languagesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.languagesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.languagesTable.ColumnHeadersHeight = 26;
            this.languagesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.languagesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_id,
            this.grid_language});
            this.languagesTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.languagesTable.Location = new System.Drawing.Point(12, 46);
            this.languagesTable.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.languagesTable.MultiSelect = false;
            this.languagesTable.Name = "languagesTable";
            this.languagesTable.ReadOnly = true;
            this.languagesTable.RowHeadersVisible = false;
            this.languagesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.languagesTable.Size = new System.Drawing.Size(362, 224);
            this.languagesTable.TabIndex = 7;
            // 
            // grid_id
            // 
            this.grid_id.HeaderText = "ID";
            this.grid_id.Name = "grid_id";
            this.grid_id.ReadOnly = true;
            this.grid_id.Width = 80;
            // 
            // grid_language
            // 
            this.grid_language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_language.HeaderText = "Language code";
            this.grid_language.Name = "grid_language";
            this.grid_language.ReadOnly = true;
            // 
            // btn_remove_lang
            // 
            this.btn_remove_lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove_lang.Location = new System.Drawing.Point(380, 84);
            this.btn_remove_lang.Name = "btn_remove_lang";
            this.btn_remove_lang.Size = new System.Drawing.Size(192, 32);
            this.btn_remove_lang.TabIndex = 5;
            this.btn_remove_lang.Text = "Remove language";
            this.btn_remove_lang.UseVisualStyleBackColor = true;
            this.btn_remove_lang.Click += new System.EventHandler(this.Btn_remove_lang_Click);
            // 
            // btn_add_lang
            // 
            this.btn_add_lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_lang.Location = new System.Drawing.Point(380, 46);
            this.btn_add_lang.Name = "btn_add_lang";
            this.btn_add_lang.Size = new System.Drawing.Size(192, 32);
            this.btn_add_lang.TabIndex = 6;
            this.btn_add_lang.Text = "Add new language";
            this.btn_add_lang.UseVisualStyleBackColor = true;
            this.btn_add_lang.Click += new System.EventHandler(this.Btn_add_lang_Click);
            // 
            // LanguageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 282);
            this.Controls.Add(this.languagesTable);
            this.Controls.Add(this.btn_remove_lang);
            this.Controls.Add(this.btn_add_lang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanguageManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LanguageManager";
            this.Load += new System.EventHandler(this.LanguageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languagesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView languagesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_language;
        private System.Windows.Forms.Button btn_remove_lang;
        private System.Windows.Forms.Button btn_add_lang;
    }
}