namespace MPOS.UserControllers
{
	partial class Supplier
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
			this.SearchField = new System.Windows.Forms.TextBox();
			this.SupplierCount = new System.Windows.Forms.Label();
			this.SuppliersListTable = new System.Windows.Forms.DataGridView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SupplierId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SupplierName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.PhoneNumber = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Address = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.Created = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.Updated = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.image = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.ModifyButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.SuppliersListTable)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchField
			// 
			this.SearchField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchField.Location = new System.Drawing.Point(243, 65);
			this.SearchField.Multiline = true;
			this.SearchField.Name = "SearchField";
			this.SearchField.Size = new System.Drawing.Size(426, 29);
			this.SearchField.TabIndex = 98;
			this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
			// 
			// SupplierCount
			// 
			this.SupplierCount.AutoSize = true;
			this.SupplierCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SupplierCount.Location = new System.Drawing.Point(43, 922);
			this.SupplierCount.Name = "SupplierCount";
			this.SupplierCount.Size = new System.Drawing.Size(48, 19);
			this.SupplierCount.TabIndex = 96;
			this.SupplierCount.Text = "Rows: ";
			// 
			// SuppliersListTable
			// 
			this.SuppliersListTable.AllowUserToAddRows = false;
			this.SuppliersListTable.AllowUserToDeleteRows = false;
			this.SuppliersListTable.AllowUserToResizeRows = false;
			this.SuppliersListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.SuppliersListTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.SuppliersListTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SuppliersListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.SuppliersListTable.DefaultCellStyle = dataGridViewCellStyle2;
			this.SuppliersListTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.SuppliersListTable.GridColor = System.Drawing.SystemColors.Window;
			this.SuppliersListTable.Location = new System.Drawing.Point(30, 112);
			this.SuppliersListTable.MultiSelect = false;
			this.SuppliersListTable.Name = "SuppliersListTable";
			this.SuppliersListTable.ReadOnly = true;
			this.SuppliersListTable.RowHeadersVisible = false;
			this.SuppliersListTable.RowTemplate.Height = 30;
			this.SuppliersListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.SuppliersListTable.Size = new System.Drawing.Size(1029, 779);
			this.SuppliersListTable.TabIndex = 95;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(1109, 68);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 367);
			this.flowLayoutPanel1.TabIndex = 91;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.SupplierId);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(470, 55);
			this.panel1.TabIndex = 1;
			// 
			// SupplierId
			// 
			this.SupplierId.BackColor = System.Drawing.SystemColors.Window;
			this.SupplierId.Enabled = false;
			this.SupplierId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SupplierId.Location = new System.Drawing.Point(24, 27);
			this.SupplierId.Name = "SupplierId";
			this.SupplierId.ReadOnly = true;
			this.SupplierId.Size = new System.Drawing.Size(152, 25);
			this.SupplierId.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Supplier Id";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.SupplierName);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(3, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(470, 55);
			this.panel2.TabIndex = 2;
			// 
			// SupplierName
			// 
			this.SupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SupplierName.Location = new System.Drawing.Point(24, 27);
			this.SupplierName.Name = "SupplierName";
			this.SupplierName.Size = new System.Drawing.Size(424, 25);
			this.SupplierName.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Supplier Name";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.PhoneNumber);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(3, 125);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(470, 55);
			this.panel3.TabIndex = 9;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PhoneNumber.Location = new System.Drawing.Point(24, 27);
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.Size = new System.Drawing.Size(424, 25);
			this.PhoneNumber.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Phone Number";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.Address);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(3, 186);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(470, 55);
			this.panel4.TabIndex = 10;
			// 
			// Address
			// 
			this.Address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Address.Location = new System.Drawing.Point(24, 27);
			this.Address.Name = "Address";
			this.Address.Size = new System.Drawing.Size(424, 25);
			this.Address.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(21, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Address";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.Created);
			this.panel6.Controls.Add(this.label8);
			this.panel6.Location = new System.Drawing.Point(3, 247);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(470, 55);
			this.panel6.TabIndex = 7;
			// 
			// Created
			// 
			this.Created.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Created.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Created.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Created.Location = new System.Drawing.Point(24, 27);
			this.Created.Name = "Created";
			this.Created.Size = new System.Drawing.Size(122, 25);
			this.Created.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(21, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Created";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.Updated);
			this.panel7.Controls.Add(this.label10);
			this.panel7.Location = new System.Drawing.Point(3, 308);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(470, 55);
			this.panel7.TabIndex = 8;
			// 
			// Updated
			// 
			this.Updated.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updated.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Updated.Location = new System.Drawing.Point(24, 27);
			this.Updated.Name = "Updated";
			this.Updated.Size = new System.Drawing.Size(122, 25);
			this.Updated.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(21, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 17);
			this.label10.TabIndex = 0;
			this.label10.Text = "Updated";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 21);
			this.label1.TabIndex = 89;
			this.label1.Text = "Suppliers List";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1139, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 21);
			this.label2.TabIndex = 87;
			this.label2.Text = "Add-Modify Supplier";
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(14, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(1062, 942);
			this.button1.TabIndex = 86;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button6.Location = new System.Drawing.Point(1094, 15);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(504, 605);
			this.button6.TabIndex = 85;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(1125, 455);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 17);
			this.label7.TabIndex = 103;
			this.label7.Text = "Choose Image";
			// 
			// image
			// 
			this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
			this.image.Location = new System.Drawing.Point(1112, 479);
			this.image.Name = "image";
			this.image.Size = new System.Drawing.Size(120, 120);
			this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.image.TabIndex = 102;
			this.image.TabStop = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(786, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 100;
			this.button2.Text = "PDF";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(876, 64);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 32);
			this.button4.TabIndex = 99;
			this.button4.Text = "Import";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btnExcel
			// 
			this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(966, 64);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(84, 32);
			this.btnExcel.TabIndex = 101;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = true;
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
			this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.Location = new System.Drawing.Point(675, 63);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(95, 32);
			this.searchButton.TabIndex = 97;
			this.searchButton.Text = "Search";
			this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
			this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DeleteButton.Location = new System.Drawing.Point(1249, 563);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(106, 36);
			this.DeleteButton.TabIndex = 93;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			// 
			// ResetButton
			// 
			this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
			this.ResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ResetButton.Location = new System.Drawing.Point(1361, 563);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(106, 36);
			this.ResetButton.TabIndex = 94;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// ModifyButton
			// 
			this.ModifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ModifyButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifyButton.Image")));
			this.ModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ModifyButton.Location = new System.Drawing.Point(1473, 563);
			this.ModifyButton.Name = "ModifyButton";
			this.ModifyButton.Size = new System.Drawing.Size(106, 36);
			this.ModifyButton.TabIndex = 92;
			this.ModifyButton.Text = "Create";
			this.ModifyButton.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(30, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 90;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(1109, 29);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 88;
			this.pictureBox3.TabStop = false;
			// 
			// Supplier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.image);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.SearchField);
			this.Controls.Add(this.SupplierCount);
			this.Controls.Add(this.SuppliersListTable);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.ModifyButton);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button6);
			this.Name = "Supplier";
			this.Size = new System.Drawing.Size(1613, 972);
			((System.ComponentModel.ISupportInitialize)(this.SuppliersListTable)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox SearchField;
		private System.Windows.Forms.Label SupplierCount;
		private System.Windows.Forms.DataGridView SuppliersListTable;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button ResetButton;
		public System.Windows.Forms.Button ModifyButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.TextBox SupplierId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.TextBox SupplierName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel6;
		public System.Windows.Forms.DateTimePicker Created;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel7;
		public System.Windows.Forms.DateTimePicker Updated;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.TextBox PhoneNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.TextBox Address;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.PictureBox image;
	}
}
