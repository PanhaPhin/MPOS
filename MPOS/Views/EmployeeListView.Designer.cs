namespace MPOS.Views
{
	partial class EmployeeListView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListView));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.searchButton = new System.Windows.Forms.Button();
			this.SearchField = new System.Windows.Forms.TextBox();
			this.EmployeesListViewCount = new System.Windows.Forms.Label();
			this.EmployeesListView = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// searchButton
			// 
			resources.ApplyResources(this.searchButton, "searchButton");
			this.searchButton.Name = "searchButton";
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// SearchField
			// 
			resources.ApplyResources(this.SearchField, "SearchField");
			this.SearchField.Name = "SearchField";
			this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
			// 
			// EmployeesListViewCount
			// 
			resources.ApplyResources(this.EmployeesListViewCount, "EmployeesListViewCount");
			this.EmployeesListViewCount.Name = "EmployeesListViewCount";
			// 
			// EmployeesListView
			// 
			this.EmployeesListView.AllowUserToAddRows = false;
			this.EmployeesListView.AllowUserToDeleteRows = false;
			this.EmployeesListView.AllowUserToResizeRows = false;
			this.EmployeesListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.EmployeesListView.BackgroundColor = System.Drawing.SystemColors.Window;
			this.EmployeesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EmployeesListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.EmployeesListView.DefaultCellStyle = dataGridViewCellStyle2;
			resources.ApplyResources(this.EmployeesListView, "EmployeesListView");
			this.EmployeesListView.GridColor = System.Drawing.SystemColors.Window;
			this.EmployeesListView.MultiSelect = false;
			this.EmployeesListView.Name = "EmployeesListView";
			this.EmployeesListView.ReadOnly = true;
			this.EmployeesListView.RowHeadersVisible = false;
			this.EmployeesListView.RowTemplate.Height = 30;
			this.EmployeesListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// EmployeeListView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.SearchField);
			this.Controls.Add(this.EmployeesListViewCount);
			this.Controls.Add(this.EmployeesListView);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EmployeeListView";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			((System.ComponentModel.ISupportInitialize)(this.EmployeesListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox SearchField;
		private System.Windows.Forms.Label EmployeesListViewCount;
		private System.Windows.Forms.DataGridView EmployeesListView;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}