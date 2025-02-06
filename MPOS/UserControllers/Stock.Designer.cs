namespace MPOS.UserControllers
{
	partial class Stock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button6 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchProduct = new System.Windows.Forms.TextBox();
			this.search_combo = new System.Windows.Forms.ComboBox();
			this.stockTable = new System.Windows.Forms.DataGridView();
			this.rowCount = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.stockInTable = new System.Windows.Forms.DataGridView();
			this.stockOutTable = new System.Windows.Forms.DataGridView();
			this.btnExcel = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stockTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stockInTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stockOutTable)).BeginInit();
			this.SuspendLayout();
			// 
			// button6
			// 
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button6.Location = new System.Drawing.Point(18, 19);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(905, 934);
			this.button6.TabIndex = 36;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(944, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(650, 456);
			this.button1.TabIndex = 37;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(37, 38);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 45;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 21);
			this.label1.TabIndex = 44;
			this.label1.Text = "All Product In Stock";
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
			this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.Location = new System.Drawing.Point(633, 72);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(95, 32);
			this.searchButton.TabIndex = 53;
			this.searchButton.Text = "Search";
			this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchProduct
			// 
			this.searchProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchProduct.Location = new System.Drawing.Point(201, 74);
			this.searchProduct.Multiline = true;
			this.searchProduct.Name = "searchProduct";
			this.searchProduct.Size = new System.Drawing.Size(426, 29);
			this.searchProduct.TabIndex = 54;
			// 
			// search_combo
			// 
			this.search_combo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_combo.FormattingEnabled = true;
			this.search_combo.Items.AddRange(new object[] {
            "No.",
            "Product Name",
            "Category",
            "Unit"});
			this.search_combo.Location = new System.Drawing.Point(37, 74);
			this.search_combo.Name = "search_combo";
			this.search_combo.Size = new System.Drawing.Size(158, 29);
			this.search_combo.TabIndex = 52;
			// 
			// stockTable
			// 
			this.stockTable.AllowUserToAddRows = false;
			this.stockTable.AllowUserToDeleteRows = false;
			this.stockTable.AllowUserToResizeRows = false;
			this.stockTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.stockTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.stockTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.stockTable.DefaultCellStyle = dataGridViewCellStyle1;
			this.stockTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.stockTable.GridColor = System.Drawing.SystemColors.Window;
			this.stockTable.Location = new System.Drawing.Point(37, 119);
			this.stockTable.Name = "stockTable";
			this.stockTable.ReadOnly = true;
			this.stockTable.RowHeadersVisible = false;
			this.stockTable.RowTemplate.Height = 30;
			this.stockTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.stockTable.Size = new System.Drawing.Size(866, 781);
			this.stockTable.TabIndex = 55;
			// 
			// rowCount
			// 
			this.rowCount.AutoSize = true;
			this.rowCount.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.rowCount.Location = new System.Drawing.Point(34, 919);
			this.rowCount.Name = "rowCount";
			this.rowCount.Size = new System.Drawing.Size(48, 19);
			this.rowCount.TabIndex = 56;
			this.rowCount.Text = "Rows: ";
			// 
			// button2
			// 
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(944, 497);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(650, 456);
			this.button2.TabIndex = 57;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(957, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 59;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(987, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 21);
			this.label2.TabIndex = 58;
			this.label2.Text = "Stock In";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(957, 515);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 61;
			this.pictureBox3.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(987, 517);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 21);
			this.label3.TabIndex = 60;
			this.label3.Text = "Stock Out";
			// 
			// stockInTable
			// 
			this.stockInTable.AllowUserToAddRows = false;
			this.stockInTable.AllowUserToDeleteRows = false;
			this.stockInTable.AllowUserToResizeRows = false;
			this.stockInTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.stockInTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.stockInTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stockInTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.stockInTable.DefaultCellStyle = dataGridViewCellStyle2;
			this.stockInTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.stockInTable.GridColor = System.Drawing.SystemColors.Window;
			this.stockInTable.Location = new System.Drawing.Point(956, 76);
			this.stockInTable.Name = "stockInTable";
			this.stockInTable.ReadOnly = true;
			this.stockInTable.RowHeadersVisible = false;
			this.stockInTable.RowTemplate.Height = 30;
			this.stockInTable.Size = new System.Drawing.Size(625, 386);
			this.stockInTable.TabIndex = 62;
			// 
			// stockOutTable
			// 
			this.stockOutTable.AllowUserToAddRows = false;
			this.stockOutTable.AllowUserToDeleteRows = false;
			this.stockOutTable.AllowUserToResizeRows = false;
			this.stockOutTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.stockOutTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.stockOutTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stockOutTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.stockOutTable.DefaultCellStyle = dataGridViewCellStyle3;
			this.stockOutTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.stockOutTable.GridColor = System.Drawing.SystemColors.Window;
			this.stockOutTable.Location = new System.Drawing.Point(956, 554);
			this.stockOutTable.Name = "stockOutTable";
			this.stockOutTable.ReadOnly = true;
			this.stockOutTable.RowHeadersVisible = false;
			this.stockOutTable.RowTemplate.Height = 30;
			this.stockOutTable.Size = new System.Drawing.Size(625, 386);
			this.stockOutTable.TabIndex = 63;
			// 
			// btnExcel
			// 
			this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(832, 71);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(71, 32);
			this.btnExcel.TabIndex = 64;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(755, 71);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(71, 32);
			this.button4.TabIndex = 64;
			this.button4.Text = "PDF";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// Stock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.stockOutTable);
			this.Controls.Add(this.stockInTable);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.rowCount);
			this.Controls.Add(this.stockTable);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchProduct);
			this.Controls.Add(this.search_combo);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button6);
			this.Name = "Stock";
			this.Size = new System.Drawing.Size(1613, 972);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stockTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stockInTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stockOutTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchProduct;
		private System.Windows.Forms.ComboBox search_combo;
		private System.Windows.Forms.DataGridView stockTable;
		private System.Windows.Forms.Label rowCount;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView stockInTable;
		private System.Windows.Forms.DataGridView stockOutTable;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button button4;
	}
}
