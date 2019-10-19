namespace DocMaker
{
    partial class LineEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lineThickness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_color = new System.Windows.Forms.TableLayoutPanel();
            this.lab_color = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.pan_LineSize = new System.Windows.Forms.TableLayoutPanel();
            this.sizeMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pan_LineOrientation = new System.Windows.Forms.TableLayoutPanel();
            this.radioHorizontal = new System.Windows.Forms.RadioButton();
            this.radioVertical = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tb_key = new DocMaker.CustomTextBox();
            this.tb_color_r = new DocMaker.CustomTextBox();
            this.tb_color_b = new DocMaker.CustomTextBox();
            this.tb_color_g = new DocMaker.CustomTextBox();
            this.lineLength = new DocMaker.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pan_color.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pan_LineSize.SuspendLayout();
            this.pan_LineOrientation.SuspendLayout();
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
            this.tb_name.Validated += new System.EventHandler(this.Tb_name_Validated);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MinimumSize = new System.Drawing.Size(0, 28);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.label2, "The object key name.\r\nThis name is used in your project to edit the configuration" +
        " in real time.");
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
            this.label6.Text = "Line style";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineThickness
            // 
            this.lineThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineThickness.Location = new System.Drawing.Point(110, 214);
            this.lineThickness.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lineThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.lineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineThickness.Name = "lineThickness";
            this.lineThickness.Size = new System.Drawing.Size(148, 20);
            this.lineThickness.TabIndex = 4;
            this.lineThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineThickness.ValueChanged += new System.EventHandler(this.LineThickness_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.MinimumSize = new System.Drawing.Size(0, 28);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Line thickness";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(12, 318);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 28);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_confirm.Location = new System.Drawing.Point(122, 318);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(152, 28);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_key, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pan_color, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pan_LineSize, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lineThickness, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.pan_LineOrientation, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 300);
            this.tableLayoutPanel1.TabIndex = 14;
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
            this.label4.MinimumSize = new System.Drawing.Size(0, 28);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Line Color";
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
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.MinimumSize = new System.Drawing.Size(0, 28);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Line lengh";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pan_LineSize.Controls.Add(this.lineLength, 0, 0);
            this.pan_LineSize.Location = new System.Drawing.Point(106, 176);
            this.pan_LineSize.Margin = new System.Windows.Forms.Padding(0);
            this.pan_LineSize.Name = "pan_LineSize";
            this.pan_LineSize.RowCount = 1;
            this.pan_LineSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_LineSize.Size = new System.Drawing.Size(156, 32);
            this.pan_LineSize.TabIndex = 13;
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
            this.sizeMode.TabIndex = 14;
            this.sizeMode.SelectedIndexChanged += new System.EventHandler(this.SizeMode_SelectedIndexChanged);
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
            this.label8.MinimumSize = new System.Drawing.Size(0, 28);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(106, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Line orientation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_LineOrientation
            // 
            this.pan_LineOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_LineOrientation.ColumnCount = 2;
            this.pan_LineOrientation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pan_LineOrientation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pan_LineOrientation.Controls.Add(this.radioHorizontal, 0, 0);
            this.pan_LineOrientation.Controls.Add(this.radioVertical, 1, 0);
            this.pan_LineOrientation.Location = new System.Drawing.Point(110, 148);
            this.pan_LineOrientation.Margin = new System.Windows.Forms.Padding(4);
            this.pan_LineOrientation.Name = "pan_LineOrientation";
            this.pan_LineOrientation.RowCount = 1;
            this.pan_LineOrientation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pan_LineOrientation.Size = new System.Drawing.Size(148, 24);
            this.pan_LineOrientation.TabIndex = 14;
            // 
            // radioHorizontal
            // 
            this.radioHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioHorizontal.AutoSize = true;
            this.radioHorizontal.Location = new System.Drawing.Point(4, 4);
            this.radioHorizontal.Margin = new System.Windows.Forms.Padding(4, 4, 0, 3);
            this.radioHorizontal.Name = "radioHorizontal";
            this.radioHorizontal.Size = new System.Drawing.Size(72, 17);
            this.radioHorizontal.TabIndex = 2;
            this.radioHorizontal.Text = "Horizontal";
            this.radioHorizontal.UseVisualStyleBackColor = true;
            this.radioHorizontal.CheckedChanged += new System.EventHandler(this.RadioHorizontal_CheckedChanged);
            // 
            // radioVertical
            // 
            this.radioVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioVertical.AutoSize = true;
            this.radioVertical.Location = new System.Drawing.Point(80, 4);
            this.radioVertical.Margin = new System.Windows.Forms.Padding(4, 4, 0, 3);
            this.radioVertical.Name = "radioVertical";
            this.radioVertical.Size = new System.Drawing.Size(68, 17);
            this.radioVertical.TabIndex = 2;
            this.radioVertical.Text = "Vertical";
            this.radioVertical.UseVisualStyleBackColor = true;
            this.radioVertical.CheckedChanged += new System.EventHandler(this.RadioVertical_CheckedChanged);
            // 
            // tb_key
            // 
            this.tb_key.AllowSpace = false;
            this.tb_key.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_key.Location = new System.Drawing.Point(110, 62);
            this.tb_key.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_key.MaximumValue = 10000;
            this.tb_key.MaxLength = 32;
            this.tb_key.MinimumValue = 1;
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(148, 20);
            this.tb_key.TabIndex = 12;
            this.tb_key.TabStop = false;
            this.tb_key.UsedFilter = DocMaker.CustomTextBox.Filter.Special;
            this.tb_key.Value = 1;
            this.tb_key.Wheel_StepValue = 4;
            this.tb_key.Validated += new System.EventHandler(this.Tb_key_Validated);
            // 
            // tb_color_r
            // 
            this.tb_color_r.AllowSpace = false;
            this.tb_color_r.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_color_r.Location = new System.Drawing.Point(0, 2);
            this.tb_color_r.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tb_color_r.MaximumValue = 255;
            this.tb_color_r.MaxLength = 3;
            this.tb_color_r.MinimumValue = 0;
            this.tb_color_r.Name = "tb_color_r";
            this.tb_color_r.Size = new System.Drawing.Size(47, 20);
            this.tb_color_r.TabIndex = 1;
            this.tb_color_r.TabStop = false;
            this.tb_color_r.Text = "0";
            this.tb_color_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_color_r.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.tb_color_r.Value = 0;
            this.tb_color_r.Wheel_StepValue = 5;
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
            this.tb_color_b.MaximumValue = 255;
            this.tb_color_b.MaxLength = 3;
            this.tb_color_b.MinimumValue = 0;
            this.tb_color_b.Name = "tb_color_b";
            this.tb_color_b.Size = new System.Drawing.Size(48, 20);
            this.tb_color_b.TabIndex = 3;
            this.tb_color_b.TabStop = false;
            this.tb_color_b.Text = "0";
            this.tb_color_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_color_b.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.tb_color_b.Value = 0;
            this.tb_color_b.Wheel_StepValue = 5;
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
            this.tb_color_g.MaximumValue = 255;
            this.tb_color_g.MaxLength = 3;
            this.tb_color_g.MinimumValue = 0;
            this.tb_color_g.Name = "tb_color_g";
            this.tb_color_g.Size = new System.Drawing.Size(47, 20);
            this.tb_color_g.TabIndex = 2;
            this.tb_color_g.TabStop = false;
            this.tb_color_g.Text = "0";
            this.tb_color_g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_color_g.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.tb_color_g.Value = 0;
            this.tb_color_g.Wheel_StepValue = 5;
            this.tb_color_g.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingColorInput);
            // 
            // lineLength
            // 
            this.lineLength.AllowSpace = false;
            this.lineLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineLength.Location = new System.Drawing.Point(4, 6);
            this.lineLength.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lineLength.MaximumValue = 10000;
            this.lineLength.MaxLength = 32;
            this.lineLength.MinimumValue = 1;
            this.lineLength.Name = "lineLength";
            this.lineLength.Size = new System.Drawing.Size(98, 20);
            this.lineLength.TabIndex = 12;
            this.lineLength.TabStop = false;
            this.lineLength.Text = "50";
            this.lineLength.UsedFilter = DocMaker.CustomTextBox.Filter.DigitsOnly;
            this.lineLength.Value = 50;
            this.lineLength.Wheel_StepValue = 5;
            this.lineLength.TextChanged += new System.EventHandler(this.LineLength_TextChanged);
            this.lineLength.Validated += new System.EventHandler(this.LineLength_Validated);
            // 
            // LineEditor
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(286, 358);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Line editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LabelEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.lineThickness)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pan_color.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pan_LineSize.ResumeLayout(false);
            this.pan_LineSize.PerformLayout();
            this.pan_LineOrientation.ResumeLayout(false);
            this.pan_LineOrientation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lineThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_color;
        private CustomTextBox tb_key;
        private System.Windows.Forms.TableLayoutPanel pan_color;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomTextBox tb_color_r;
        private CustomTextBox tb_color_b;
        private CustomTextBox tb_color_g;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel pan_LineSize;
        private System.Windows.Forms.ComboBox sizeMode;
        private CustomTextBox lineLength;
        private System.Windows.Forms.TableLayoutPanel pan_LineOrientation;
        private System.Windows.Forms.RadioButton radioHorizontal;
        private System.Windows.Forms.RadioButton radioVertical;
        private System.Windows.Forms.Label label8;
    }
}