namespace MPOS.UserControllers
{
	partial class Category
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
			this.button6 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.categoryId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.categoryName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.created = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.updated = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.CategoryTable = new System.Windows.Forms.DataGridView();
			this.CategoryCount = new System.Windows.Forms.Label();
			this.nameRequired = new System.Windows.Forms.ErrorProvider(this.components);
			this.deleteButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.modifyButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.SearchField = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nameRequired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// button6
			// 
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button6.Location = new System.Drawing.Point(1093, 14);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(504, 424);
			this.button6.TabIndex = 36;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(13, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(1062, 942);
			this.button1.TabIndex = 37;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1138, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 21);
			this.label2.TabIndex = 47;
			this.label2.Text = "Add-Modify Category";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 21);
			this.label1.TabIndex = 49;
			this.label1.Text = "All Categories";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(1108, 67);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 245);
			this.flowLayoutPanel1.TabIndex = 51;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.categoryId);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(470, 55);
			this.panel1.TabIndex = 1;
			// 
			// categoryId
			// 
			this.categoryId.BackColor = System.Drawing.SystemColors.Window;
			this.categoryId.Enabled = false;
			this.categoryId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.categoryId.Location = new System.Drawing.Point(24, 27);
			this.categoryId.Name = "categoryId";
			this.categoryId.ReadOnly = true;
			this.categoryId.Size = new System.Drawing.Size(152, 25);
			this.categoryId.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Category Id";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.categoryName);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(3, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(470, 55);
			this.panel2.TabIndex = 2;
			// 
			// categoryName
			// 
			this.categoryName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.categoryName.Location = new System.Drawing.Point(24, 27);
			this.categoryName.Name = "categoryName";
			this.categoryName.Size = new System.Drawing.Size(424, 25);
			this.categoryName.TabIndex = 1;
			this.categoryName.TextChanged += new System.EventHandler(this.categoryName_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(21, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Category Name";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.created);
			this.panel6.Controls.Add(this.label8);
			this.panel6.Location = new System.Drawing.Point(3, 125);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(470, 55);
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
			this.panel7.Controls.Add(this.updated);
			this.panel7.Controls.Add(this.label10);
			this.panel7.Location = new System.Drawing.Point(3, 186);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(470, 55);
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
			// CategoryTable
			// 
			this.CategoryTable.AllowUserToAddRows = false;
			this.CategoryTable.AllowUserToDeleteRows = false;
			this.CategoryTable.AllowUserToResizeRows = false;
			this.CategoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CategoryTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.CategoryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CategoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CategoryTable.DefaultCellStyle = dataGridViewCellStyle2;
			this.CategoryTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.CategoryTable.GridColor = System.Drawing.SystemColors.Window;
			this.CategoryTable.Location = new System.Drawing.Point(30, 112);
			this.CategoryTable.MultiSelect = false;
			this.CategoryTable.Name = "CategoryTable";
			this.CategoryTable.ReadOnly = true;
			this.CategoryTable.RowHeadersVisible = false;
			this.CategoryTable.RowTemplate.Height = 30;
			this.CategoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CategoryTable.Size = new System.Drawing.Size(1025, 779);
			this.CategoryTable.TabIndex = 54;
			// 
			// CategoryCount
			// 
			this.CategoryCount.AutoSize = true;
			this.CategoryCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CategoryCount.Location = new System.Drawing.Point(31, 921);
			this.CategoryCount.Name = "CategoryCount";
			this.CategoryCount.Size = new System.Drawing.Size(48, 19);
			this.CategoryCount.TabIndex = 55;
			this.CategoryCount.Text = "Rows: ";
			// 
			// nameRequired
			// 
			this.nameRequired.ContainerControl = this;
			this.nameRequired.Icon = ((System.Drawing.Icon)(resources.GetObject("nameRequired.Icon")));
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deleteButton.Location = new System.Drawing.Point(1164, 371);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(106, 36);
			this.deleteButton.TabIndex = 53;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.Image")));
			this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.resetButton.Location = new System.Drawing.Point(1293, 371);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(106, 36);
			this.resetButton.TabIndex = 53;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// modifyButton
			// 
			this.modifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifyButton.Image = ((System.Drawing.Image)(resources.GetObject("modifyButton.Image")));
			this.modifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.modifyButton.Location = new System.Drawing.Point(1422, 371);
			this.modifyButton.Name = "modifyButton";
			this.modifyButton.Size = new System.Drawing.Size(106, 36);
			this.modifyButton.TabIndex = 52;
			this.modifyButton.Text = "Create";
			this.modifyButton.UseVisualStyleBackColor = true;
			this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(30, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 50;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(1108, 28);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 48;
			this.pictureBox3.TabStop = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(784, 63);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 87;
			this.button2.Text = "PDF";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(874, 63);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 32);
			this.button4.TabIndex = 88;
			this.button4.Text = "Import";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btnExcel
			// 
			this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(964, 63);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(84, 32);
			this.btnExcel.TabIndex = 89;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = true;
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
			this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.Location = new System.Drawing.Point(673, 62);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(95, 32);
			this.searchButton.TabIndex = 85;
			this.searchButton.Text = "Search";
			this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// SearchField
			// 
			this.SearchField.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchField.Location = new System.Drawing.Point(241, 64);
			this.SearchField.Multiline = true;
			this.SearchField.Name = "SearchField";
			this.SearchField.Size = new System.Drawing.Size(426, 29);
			this.SearchField.TabIndex = 86;
			this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
			// 
			// Category
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.SearchField);
			this.Controls.Add(this.CategoryCount);
			this.Controls.Add(this.CategoryTable);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.modifyButton);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button6);
			this.Name = "Category";
			this.Size = new System.Drawing.Size(1613, 972);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nameRequired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.TextBox categoryId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.TextBox categoryName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel6;
		public System.Windows.Forms.DateTimePicker created;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel7;
		public System.Windows.Forms.DateTimePicker updated;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.Button modifyButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.DataGridView CategoryTable;
		private System.Windows.Forms.Label CategoryCount;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ErrorProvider nameRequired;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox SearchField;
	}
}
