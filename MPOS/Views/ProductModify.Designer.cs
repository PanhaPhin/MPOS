namespace MPOS.Views
{
	partial class ProductModify
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModify));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.productId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.productName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.category = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.costPrice = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.unit = new System.Windows.Forms.TextBox();
			this.sellingPrice = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.created = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.updated = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.createButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.image = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.nameRequired = new System.Windows.Forms.ErrorProvider(this.components);
			this.costPriceRequired = new System.Windows.Forms.ErrorProvider(this.components);
			this.sellingPriceRequired = new System.Windows.Forms.ErrorProvider(this.components);
			this.unitRequired = new System.Windows.Forms.ErrorProvider(this.components);
			this.createdRequired = new System.Windows.Forms.ErrorProvider(this.components);
			this.updatedRequired = new System.Windows.Forms.ErrorProvider(this.components);
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.costPrice)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sellingPrice)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nameRequired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.costPriceRequired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sellingPriceRequired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitRequired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.createdRequired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updatedRequired)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel5);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 21);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 433);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.productId);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(399, 55);
			this.panel1.TabIndex = 1;
			// 
			// productId
			// 
			this.productId.BackColor = System.Drawing.SystemColors.Window;
			this.productId.Enabled = false;
			this.productId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productId.Location = new System.Drawing.Point(24, 27);
			this.productId.Name = "productId";
			this.productId.ReadOnly = true;
			this.productId.Size = new System.Drawing.Size(152, 25);
			this.productId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product Id";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.productName);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(3, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(399, 55);
			this.panel2.TabIndex = 2;
			// 
			// productName
			// 
			this.productName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productName.Location = new System.Drawing.Point(24, 27);
			this.productName.Name = "productName";
			this.productName.Size = new System.Drawing.Size(328, 25);
			this.productName.TabIndex = 1;
			this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Product Name";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.category);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(3, 125);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(399, 55);
			this.panel3.TabIndex = 3;
			// 
			// category
			// 
			this.category.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.category.FormattingEnabled = true;
			this.category.Location = new System.Drawing.Point(24, 27);
			this.category.Name = "category";
			this.category.Size = new System.Drawing.Size(192, 25);
			this.category.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Choose Category";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.costPrice);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(3, 186);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(399, 55);
			this.panel4.TabIndex = 5;
			// 
			// costPrice
			// 
			this.costPrice.DecimalPlaces = 2;
			this.costPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.costPrice.Location = new System.Drawing.Point(24, 27);
			this.costPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.costPrice.Name = "costPrice";
			this.costPrice.Size = new System.Drawing.Size(152, 25);
			this.costPrice.TabIndex = 1;
			this.costPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.costPrice.ValueChanged += new System.EventHandler(this.costPrice_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Cost Price";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.unit);
			this.panel5.Controls.Add(this.sellingPrice);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Location = new System.Drawing.Point(3, 247);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(399, 55);
			this.panel5.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(212, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 17);
			this.label9.TabIndex = 3;
			this.label9.Text = "Unit";
			// 
			// unit
			// 
			this.unit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unit.Location = new System.Drawing.Point(215, 26);
			this.unit.Name = "unit";
			this.unit.Size = new System.Drawing.Size(123, 25);
			this.unit.TabIndex = 2;
			this.unit.TextChanged += new System.EventHandler(this.unit_TextChanged);
			// 
			// sellingPrice
			// 
			this.sellingPrice.DecimalPlaces = 2;
			this.sellingPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sellingPrice.Location = new System.Drawing.Point(24, 27);
			this.sellingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.sellingPrice.Name = "sellingPrice";
			this.sellingPrice.Size = new System.Drawing.Size(152, 25);
			this.sellingPrice.TabIndex = 1;
			this.sellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sellingPrice.ValueChanged += new System.EventHandler(this.sellingPrice_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Selling Price";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.created);
			this.panel6.Controls.Add(this.label6);
			this.panel6.Location = new System.Drawing.Point(3, 308);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(399, 55);
			this.panel6.TabIndex = 7;
			// 
			// created
			// 
			this.created.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.created.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.created.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.created.Location = new System.Drawing.Point(24, 27);
			this.created.Name = "created";
			this.created.Size = new System.Drawing.Size(122, 25);
			this.created.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(21, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Created";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.updated);
			this.panel7.Controls.Add(this.label7);
			this.panel7.Location = new System.Drawing.Point(3, 369);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(399, 55);
			this.panel7.TabIndex = 8;
			// 
			// updated
			// 
			this.updated.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updated.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.updated.Location = new System.Drawing.Point(24, 27);
			this.updated.Name = "updated";
			this.updated.Size = new System.Drawing.Size(122, 25);
			this.updated.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(21, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Updated";
			// 
			// createButton
			// 
			this.createButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createButton.Image = ((System.Drawing.Image)(resources.GetObject("createButton.Image")));
			this.createButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.createButton.Location = new System.Drawing.Point(308, 585);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(106, 36);
			this.createButton.TabIndex = 1;
			this.createButton.Text = "Create";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
			this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.resetButton.Location = new System.Drawing.Point(196, 585);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(106, 36);
			this.resetButton.TabIndex = 1;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// image
			// 
			this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
			this.image.Location = new System.Drawing.Point(34, 501);
			this.image.Name = "image";
			this.image.Size = new System.Drawing.Size(120, 120);
			this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.image.TabIndex = 40;
			this.image.TabStop = false;
			this.image.Click += new System.EventHandler(this.image_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(47, 475);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 17);
			this.label8.TabIndex = 41;
			this.label8.Text = "Choose Image";
			// 
			// nameRequired
			// 
			this.nameRequired.ContainerControl = this;
			this.nameRequired.Icon = ((System.Drawing.Icon)(resources.GetObject("nameRequired.Icon")));
			// 
			// costPriceRequired
			// 
			this.costPriceRequired.ContainerControl = this;
			this.costPriceRequired.Icon = ((System.Drawing.Icon)(resources.GetObject("costPriceRequired.Icon")));
			// 
			// sellingPriceRequired
			// 
			this.sellingPriceRequired.ContainerControl = this;
			this.sellingPriceRequired.Icon = ((System.Drawing.Icon)(resources.GetObject("sellingPriceRequired.Icon")));
			// 
			// unitRequired
			// 
			this.unitRequired.ContainerControl = this;
			this.unitRequired.Icon = ((System.Drawing.Icon)(resources.GetObject("unitRequired.Icon")));
			// 
			// createdRequired
			// 
			this.createdRequired.ContainerControl = this;
			this.createdRequired.Icon = ((System.Drawing.Icon)(resources.GetObject("createdRequired.Icon")));
			// 
			// updatedRequired
			// 
			this.updatedRequired.ContainerControl = this;
			this.updatedRequired.Icon = ((System.Drawing.Icon)(resources.GetObject("updatedRequired.Icon")));
			// 
			// ProductModify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(438, 649);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.image);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProductModify";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Product";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.costPrice)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sellingPrice)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nameRequired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.costPriceRequired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sellingPriceRequired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitRequired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.createdRequired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updatedRequired)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.TextBox productId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.TextBox productName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.ComboBox category;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.NumericUpDown costPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.NumericUpDown sellingPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Button resetButton;
		public System.Windows.Forms.PictureBox image;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.TextBox unit;
		public System.Windows.Forms.DateTimePicker created;
		public System.Windows.Forms.DateTimePicker updated;
		private System.Windows.Forms.ErrorProvider nameRequired;
		private System.Windows.Forms.ErrorProvider costPriceRequired;
		private System.Windows.Forms.ErrorProvider sellingPriceRequired;
		private System.Windows.Forms.ErrorProvider unitRequired;
		private System.Windows.Forms.ErrorProvider createdRequired;
		private System.Windows.Forms.ErrorProvider updatedRequired;
	}
}