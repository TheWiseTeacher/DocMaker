namespace DocMaker
{
    partial class ResourceManager
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
            this.btn_addResource = new System.Windows.Forms.Button();
            this.resourceList = new System.Windows.Forms.ListBox();
            this.imageFrame = new System.Windows.Forms.Panel();
            this.btn_deleteResource = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addResource
            // 
            this.btn_addResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addResource.Location = new System.Drawing.Point(0, 0);
            this.btn_addResource.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_addResource.Name = "btn_addResource";
            this.btn_addResource.Size = new System.Drawing.Size(157, 27);
            this.btn_addResource.TabIndex = 1;
            this.btn_addResource.Text = "Add an image";
            this.btn_addResource.UseVisualStyleBackColor = true;
            this.btn_addResource.Click += new System.EventHandler(this.btn_addResource_Click);
            // 
            // resourceList
            // 
            this.resourceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceList.FormattingEnabled = true;
            this.resourceList.ItemHeight = 17;
            this.resourceList.Location = new System.Drawing.Point(12, 12);
            this.resourceList.Name = "resourceList";
            this.resourceList.Size = new System.Drawing.Size(332, 293);
            this.resourceList.TabIndex = 2;
            this.resourceList.SelectedValueChanged += new System.EventHandler(this.ResourceList_SelectedValueChanged);
            // 
            // imageFrame
            // 
            this.imageFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageFrame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imageFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFrame.Location = new System.Drawing.Point(351, 12);
            this.imageFrame.Name = "imageFrame";
            this.imageFrame.Size = new System.Drawing.Size(156, 200);
            this.imageFrame.TabIndex = 3;
            this.imageFrame.Click += new System.EventHandler(this.ImageFrame_Click);
            // 
            // btn_deleteResource
            // 
            this.btn_deleteResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteResource.Location = new System.Drawing.Point(0, 30);
            this.btn_deleteResource.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btn_deleteResource.Name = "btn_deleteResource";
            this.btn_deleteResource.Size = new System.Drawing.Size(157, 27);
            this.btn_deleteResource.TabIndex = 1;
            this.btn_deleteResource.Text = "Delete image";
            this.btn_deleteResource.UseVisualStyleBackColor = true;
            this.btn_deleteResource.Click += new System.EventHandler(this.Btn_deleteResource_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_deleteResource, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_addResource, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(350, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 87);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(0, 60);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(157, 27);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // ResourceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 318);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.imageFrame);
            this.Controls.Add(this.resourceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResourceManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resource manager";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResourceManager_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addResource;
        private System.Windows.Forms.ListBox resourceList;
        private System.Windows.Forms.Panel imageFrame;
        private System.Windows.Forms.Button btn_deleteResource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_close;
    }
}