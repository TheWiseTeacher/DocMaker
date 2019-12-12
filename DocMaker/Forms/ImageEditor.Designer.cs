namespace DocMaker
{
    partial class ImageEditor
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_size = new System.Windows.Forms.Label();
            this.cb_link = new System.Windows.Forms.CheckBox();
            this.imageFrame = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resourceComboList = new System.Windows.Forms.ComboBox();
            this.tb_key = new DocMaker.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pan_rotation = new System.Windows.Forms.TableLayoutPanel();
            this.btn_rotate_r = new System.Windows.Forms.Button();
            this.btn_rotate_l = new System.Windows.Forms.Button();
            this.lab_angle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pan_LineSize = new System.Windows.Forms.TableLayoutPanel();
            this.sizeMode = new System.Windows.Forms.ComboBox();
            this.drawingModeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_width = new DocMaker.MagicalTextBox();
            this.customTextBox1 = new DocMaker.CustomTextBox();
            this.tb_height = new DocMaker.MagicalTextBox();
            this.customTextBox2 = new DocMaker.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageFrame)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pan_rotation.SuspendLayout();
            this.pan_LineSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(353, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 28);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_confirm.Location = new System.Drawing.Point(463, 322);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(152, 28);
            this.btn_confirm.TabIndex = 12;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
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
            // lab_size
            // 
            this.lab_size.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_size.AutoSize = true;
            this.lab_size.BackColor = System.Drawing.Color.DodgerBlue;
            this.lab_size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_size.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_size.ForeColor = System.Drawing.Color.White;
            this.lab_size.Location = new System.Drawing.Point(258, 0);
            this.lab_size.Margin = new System.Windows.Forms.Padding(0);
            this.lab_size.Name = "lab_size";
            this.lab_size.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_size.Size = new System.Drawing.Size(71, 24);
            this.lab_size.TabIndex = 2;
            this.lab_size.Text = "ImageSize";
            this.lab_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lab_size, "Set the object size to the real image size");
            this.lab_size.Click += new System.EventHandler(this.Lab_size_Click);
            // 
            // cb_link
            // 
            this.cb_link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_link.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_link.Location = new System.Drawing.Point(109, 37);
            this.cb_link.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_link.Name = "cb_link";
            this.cb_link.Size = new System.Drawing.Size(44, 22);
            this.cb_link.TabIndex = 10;
            this.cb_link.Text = "link";
            this.cb_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.cb_link, "Link the size to the original image aspect ratio");
            this.cb_link.UseVisualStyleBackColor = true;
            this.cb_link.CheckedChanged += new System.EventHandler(this.cb_link_CheckedChanged);
            // 
            // imageFrame
            // 
            this.imageFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageFrame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.SetColumnSpan(this.imageFrame, 2);
            this.imageFrame.Location = new System.Drawing.Point(0, 24);
            this.imageFrame.Margin = new System.Windows.Forms.Padding(0);
            this.imageFrame.Name = "imageFrame";
            this.imageFrame.Size = new System.Drawing.Size(329, 314);
            this.imageFrame.TabIndex = 15;
            this.imageFrame.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.imageFrame, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lab_size, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(329, 338);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(258, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Image preview";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.customTextBox2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.customTextBox1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.resourceComboList, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_key, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pan_rotation, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pan_LineSize, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.drawingModeCombo, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(353, 12);
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
            this.tableLayoutPanel1.TabIndex = 17;
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
            this.tb_name.Validated += new System.EventHandler(this.Tb_name_Validated);
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
            this.label6.Text = "Image properties";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resourceComboList
            // 
            this.resourceComboList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceComboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceComboList.FormattingEnabled = true;
            this.resourceComboList.Items.AddRange(new object[] {
            "Px",
            "%"});
            this.resourceComboList.Location = new System.Drawing.Point(110, 118);
            this.resourceComboList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 5);
            this.resourceComboList.Name = "resourceComboList";
            this.resourceComboList.Size = new System.Drawing.Size(148, 21);
            this.resourceComboList.TabIndex = 3;
            this.resourceComboList.SelectedIndexChanged += new System.EventHandler(this.ResourceComboList_SelectedIndexChanged);
            // 
            // tb_key
            // 
            this.tb_key.AllowDecimal = false;
            this.tb_key.AllowSpace = false;
            this.tb_key.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_key.IgnoreClampig = false;
            this.tb_key.Location = new System.Drawing.Point(110, 62);
            this.tb_key.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_key.MaximumValue = 10000;
            this.tb_key.MaxLength = 32;
            this.tb_key.MinimumValue = 1;
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(148, 20);
            this.tb_key.TabIndex = 2;
            this.tb_key.UsedFilter = DocMaker.CustomTextBox.Filter.Special;
            this.tb_key.Wheel_StepValue = 5;
            this.tb_key.Validated += new System.EventHandler(this.Tb_key_Validated);
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
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(106, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Resource file";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(106, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Image rotation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pan_rotation.Location = new System.Drawing.Point(110, 148);
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
            this.btn_rotate_r.TabStop = false;
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
            this.btn_rotate_l.TabStop = false;
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(106, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Size mode";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_LineSize
            // 
            this.pan_LineSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_LineSize.ColumnCount = 2;
            this.pan_LineSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_LineSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pan_LineSize.Controls.Add(this.sizeMode, 1, 0);
            this.pan_LineSize.Controls.Add(this.cb_link, 1, 1);
            this.pan_LineSize.Controls.Add(this.tb_width, 0, 0);
            this.pan_LineSize.Controls.Add(this.tb_height, 0, 1);
            this.pan_LineSize.Location = new System.Drawing.Point(106, 208);
            this.pan_LineSize.Margin = new System.Windows.Forms.Padding(0);
            this.pan_LineSize.Name = "pan_LineSize";
            this.pan_LineSize.RowCount = 1;
            this.tableLayoutPanel1.SetRowSpan(this.pan_LineSize, 2);
            this.pan_LineSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pan_LineSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pan_LineSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pan_LineSize.Size = new System.Drawing.Size(156, 64);
            this.pan_LineSize.TabIndex = 17;
            // 
            // sizeMode
            // 
            this.sizeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeMode.FormattingEnabled = true;
            this.sizeMode.Items.AddRange(new object[] {
            "Px",
            "%"});
            this.sizeMode.Location = new System.Drawing.Point(110, 6);
            this.sizeMode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 5);
            this.sizeMode.Name = "sizeMode";
            this.sizeMode.Size = new System.Drawing.Size(42, 21);
            this.sizeMode.TabIndex = 8;
            this.sizeMode.SelectedIndexChanged += new System.EventHandler(this.SizeMode_SelectedIndexChanged);
            // 
            // sizeModeCombo
            // 
            this.drawingModeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawingModeCombo.FormattingEnabled = true;
            this.drawingModeCombo.Items.AddRange(new object[] {
            "Px",
            "%"});
            this.drawingModeCombo.Location = new System.Drawing.Point(110, 182);
            this.drawingModeCombo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 5);
            this.drawingModeCombo.Name = "sizeModeCombo";
            this.drawingModeCombo.Size = new System.Drawing.Size(148, 21);
            this.drawingModeCombo.TabIndex = 6;
            this.drawingModeCombo.SelectedIndexChanged += new System.EventHandler(this.DrawingModeCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Width";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Height";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_width
            // 
            this.tb_width.AllowDecimal = false;
            this.tb_width.AllowNegative = false;
            this.tb_width.AllowSpaces = false;
            this.tb_width.IgnoreClamping = true;
            this.tb_width.Location = new System.Drawing.Point(4, 6);
            this.tb_width.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_width.Maximum = 3.402823E+38F;
            this.tb_width.Minimum = -3.402823E+38F;
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(98, 20);
            this.tb_width.TabIndex = 11;
            this.tb_width.UsedFilter = DocMaker.MagicalTextBox.Filter.LettersAndDigits;
            this.tb_width.TextChanged += new System.EventHandler(this.Tb_width_TextChanged);
            // 
            // customTextBox1
            // 
            this.customTextBox1.AllowDecimal = false;
            this.customTextBox1.AllowSpace = false;
            this.customTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox1.IgnoreClampig = false;
            this.customTextBox1.Location = new System.Drawing.Point(110, 278);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customTextBox1.MaximumValue = 10000;
            this.customTextBox1.MaxLength = 32;
            this.customTextBox1.MinimumValue = 1;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(148, 20);
            this.customTextBox1.TabIndex = 18;
            this.customTextBox1.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.customTextBox1.Wheel_StepValue = 5;
            // 
            // tb_height
            // 
            this.tb_height.AllowDecimal = false;
            this.tb_height.AllowNegative = false;
            this.tb_height.AllowSpaces = false;
            this.tb_height.IgnoreClamping = true;
            this.tb_height.Location = new System.Drawing.Point(4, 38);
            this.tb_height.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_height.Maximum = 3.402823E+38F;
            this.tb_height.Minimum = -3.402823E+38F;
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(98, 20);
            this.tb_height.TabIndex = 11;
            this.tb_height.UsedFilter = DocMaker.MagicalTextBox.Filter.LettersAndDigits;
            this.tb_height.TextChanged += new System.EventHandler(this.Tb_height_TextChanged);
            // 
            // customTextBox2
            // 
            this.customTextBox2.AllowDecimal = false;
            this.customTextBox2.AllowSpace = false;
            this.customTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTextBox2.IgnoreClampig = false;
            this.customTextBox2.Location = new System.Drawing.Point(4, 278);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customTextBox2.MaximumValue = 10000;
            this.customTextBox2.MaxLength = 32;
            this.customTextBox2.MinimumValue = 1;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Size = new System.Drawing.Size(98, 20);
            this.customTextBox2.TabIndex = 19;
            this.customTextBox2.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.customTextBox2.Wheel_StepValue = 5;
            // 
            // ImageEditor
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(627, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LabelEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imageFrame)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pan_rotation.ResumeLayout(false);
            this.pan_LineSize.ResumeLayout(false);
            this.pan_LineSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox imageFrame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pan_LineSize;
        private System.Windows.Forms.ComboBox sizeMode;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private CustomTextBox tb_key;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel pan_rotation;
        private System.Windows.Forms.Button btn_rotate_r;
        private System.Windows.Forms.Button btn_rotate_l;
        private System.Windows.Forms.Label lab_angle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox resourceComboList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox drawingModeCombo;
        private System.Windows.Forms.CheckBox cb_link;
        private CustomTextBox customTextBox1;
        private MagicalTextBox tb_width;
        private CustomTextBox customTextBox2;
        private MagicalTextBox tb_height;
    }
}