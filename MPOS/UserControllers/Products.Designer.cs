using MPOS.DTOs;
namespace MPOS.UserControllers
{
	partial class Products
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
			this.productsTable = new System.Windows.Forms.DataGridView();
			this.search_combo = new System.Windows.Forms.ComboBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.addNew = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			MPOS.DTOs.StaticComponents.countProduct = new System.Windows.Forms.Label();
			MPOS.DTOs.StaticComponents.searchProduct = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// productsTable
			// 
			this.productsTable.AllowUserToAddRows = false;
			this.productsTable.AllowUserToDeleteRows = false;
			this.productsTable.AllowUserToResizeRows = false;
			this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.productsTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.productsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.productsTable.DefaultCellStyle = dataGridViewCellStyle2;
			this.productsTable.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.productsTable.GridColor = System.Drawing.SystemColors.Window;
			this.productsTable.Location = new System.Drawing.Point(3, 3);
			this.productsTable.Name = "productsTable";
			this.productsTable.ReadOnly = true;
			this.productsTable.RowHeadersVisible = false;
			this.productsTable.RowTemplate.Height = 30;
			this.productsTable.Size = new System.Drawing.Size(1508, 776);
			this.productsTable.TabIndex = 42;
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
			this.search_combo.Location = new System.Drawing.Point(16, 49);
			this.search_combo.Name = "search_combo";
			this.search_combo.Size = new System.Drawing.Size(158, 29);
			this.search_combo.TabIndex = 43;
			this.search_combo.SelectedIndexChanged += new System.EventHandler(this.search_combo_SelectedIndexChanged);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
			this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.Location = new System.Drawing.Point(612, 47);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(95, 32);
			this.searchButton.TabIndex = 45;
			this.searchButton.Text = "Search";
			this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// addNew
			// 
			this.addNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNew.Image = ((System.Drawing.Image)(resources.GetObject("addNew.Image")));
			this.addNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addNew.Location = new System.Drawing.Point(1489, 47);
			this.addNew.Name = "addNew";
			this.addNew.Size = new System.Drawing.Size(105, 32);
			this.addNew.TabIndex = 45;
			this.addNew.Text = "Add New";
			this.addNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addNew.UseVisualStyleBackColor = true;
			this.addNew.Click += new System.EventHandler(this.addNew_Click);
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(16, 95);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(1578, 854);
			this.button1.TabIndex = 48;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.productsTable);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(49, 133);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1511, 806);
			this.flowLayoutPanel1.TabIndex = 49;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(MPOS.DTOs.StaticComponents.countProduct);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(49, 105);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 22);
			this.flowLayoutPanel2.TabIndex = 50;
			// 
			// searchProduct
			// 
			MPOS.DTOs.StaticComponents.searchProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			MPOS.DTOs.StaticComponents.searchProduct.Location = new System.Drawing.Point(180, 49);
			MPOS.DTOs.StaticComponents.searchProduct.Multiline = true;
			MPOS.DTOs.StaticComponents.searchProduct.Name = "textBoxSearch";
			MPOS.DTOs.StaticComponents.searchProduct.Size = new System.Drawing.Size(426, 29);
			MPOS.DTOs.StaticComponents.searchProduct.TabIndex = 51;
			MPOS.DTOs.StaticComponents.searchProduct.TextChanged += new System.EventHandler(search_product_textbox_TextChanged);
			// 
			// countProducts
			// 
			MPOS.DTOs.StaticComponents.countProduct.AutoSize = true;
			MPOS.DTOs.StaticComponents.countProduct.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			MPOS.DTOs.StaticComponents.countProduct.Location = new System.Drawing.Point(3, 0);
			MPOS.DTOs.StaticComponents.countProduct.Name = "labelRows";
			MPOS.DTOs.StaticComponents.countProduct.Size = new System.Drawing.Size(51, 20);
			MPOS.DTOs.StaticComponents.countProduct.TabIndex = 51;
			MPOS.DTOs.StaticComponents.countProduct.Text = "Rows: ";
			// 
			// Products
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(MPOS.DTOs.StaticComponents.searchProduct);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.addNew);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.search_combo);
			this.Name = "Products";
			this.Size = new System.Drawing.Size(1613, 972);
			((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView productsTable;
		private System.Windows.Forms.ComboBox search_combo;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button addNew;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
	}
}
