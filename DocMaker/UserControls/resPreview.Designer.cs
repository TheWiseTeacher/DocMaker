namespace DocMaker
{
    partial class resPreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureFrame = new System.Windows.Forms.Panel();
            this.lab_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureFrame
            // 
            this.pictureFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureFrame.Location = new System.Drawing.Point(0, 18);
            this.pictureFrame.Margin = new System.Windows.Forms.Padding(0);
            this.pictureFrame.Name = "pictureFrame";
            this.pictureFrame.Size = new System.Drawing.Size(128, 146);
            this.pictureFrame.TabIndex = 1;
            // 
            // lab_name
            // 
            this.lab_name.BackColor = System.Drawing.Color.SteelBlue;
            this.lab_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_name.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_name.Location = new System.Drawing.Point(0, 0);
            this.lab_name.Margin = new System.Windows.Forms.Padding(0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lab_name.Size = new System.Drawing.Size(128, 18);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "res_0001";
            this.lab_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureFrame);
            this.Controls.Add(this.lab_name);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "resPreview";
            this.Size = new System.Drawing.Size(128, 164);
            this.Click += new System.EventHandler(this.ResPreview_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pictureFrame;
        private System.Windows.Forms.Label lab_name;
    }
}
