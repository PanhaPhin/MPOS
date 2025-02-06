using MPOS.UserControllers;
using static MPOS.Views.MPOS;

namespace MPOS.Views
{
	partial class MPOS
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
				// mPOS.Show();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MPOS));
			this.menuSlider = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dashboardTab = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.orderTab = new System.Windows.Forms.Button();
			this.menuProduct = new System.Windows.Forms.Panel();
			this.categoryTab = new System.Windows.Forms.Button();
			this.supplierTab = new System.Windows.Forms.Button();
			this.purchaseTab = new System.Windows.Forms.Button();
			this.stockTab = new System.Windows.Forms.Button();
			this.productTab = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.customerTab = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.employeeTab = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.analyticTab = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.settingTab = new System.Windows.Forms.Button();
			this.productSliderTransition = new System.Windows.Forms.Timer(this.components);
			this.orderSliderTransition = new System.Windows.Forms.Timer(this.components);
			this.panel8 = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.container = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.txtUsername = new System.Windows.Forms.Label();
			this.userButton = new System.Windows.Forms.Button();
			this.menuSlider.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.menuProduct.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuSlider
			// 
			this.menuSlider.Controls.Add(this.panel1);
			this.menuSlider.Controls.Add(this.panel2);
			this.menuSlider.Controls.Add(this.panel3);
			this.menuSlider.Controls.Add(this.menuProduct);
			this.menuSlider.Controls.Add(this.panel5);
			this.menuSlider.Controls.Add(this.panel4);
			this.menuSlider.Controls.Add(this.panel6);
			this.menuSlider.Controls.Add(this.panel7);
			this.menuSlider.Location = new System.Drawing.Point(0, 0);
			this.menuSlider.Margin = new System.Windows.Forms.Padding(0);
			this.menuSlider.Name = "menuSlider";
			this.menuSlider.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.menuSlider.Size = new System.Drawing.Size(287, 948);
			this.menuSlider.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(263, 47);
			this.panel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Management";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "MPOS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(38, 38);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dashboardTab);
			this.panel2.Location = new System.Drawing.Point(13, 66);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(263, 58);
			this.panel2.TabIndex = 3;
			// 
			// dashboardTab
			// 
			this.dashboardTab.FlatAppearance.BorderSize = 0;
			this.dashboardTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashboardTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashboardTab.Image = ((System.Drawing.Image)(resources.GetObject("dashboardTab.Image")));
			this.dashboardTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dashboardTab.Location = new System.Drawing.Point(3, 3);
			this.dashboardTab.Name = "dashboardTab";
			this.dashboardTab.Size = new System.Drawing.Size(257, 52);
			this.dashboardTab.TabIndex = 0;
			this.dashboardTab.Text = "          Dashboard";
			this.dashboardTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dashboardTab.UseVisualStyleBackColor = true;
			this.dashboardTab.Click += new System.EventHandler(this.dashboardTab_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.orderTab);
			this.panel3.Location = new System.Drawing.Point(13, 130);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(263, 58);
			this.panel3.TabIndex = 4;
			// 
			// orderTab
			// 
			this.orderTab.FlatAppearance.BorderSize = 0;
			this.orderTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.orderTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orderTab.Image = ((System.Drawing.Image)(resources.GetObject("orderTab.Image")));
			this.orderTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.orderTab.Location = new System.Drawing.Point(3, 3);
			this.orderTab.Name = "orderTab";
			this.orderTab.Size = new System.Drawing.Size(257, 52);
			this.orderTab.TabIndex = 0;
			this.orderTab.Text = "          Orders";
			this.orderTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.orderTab.UseVisualStyleBackColor = true;
			this.orderTab.Click += new System.EventHandler(this.orderTab_Click);
			// 
			// menuProduct
			// 
			this.menuProduct.Controls.Add(this.categoryTab);
			this.menuProduct.Controls.Add(this.supplierTab);
			this.menuProduct.Controls.Add(this.purchaseTab);
			this.menuProduct.Controls.Add(this.stockTab);
			this.menuProduct.Controls.Add(this.productTab);
			this.menuProduct.Location = new System.Drawing.Point(13, 194);
			this.menuProduct.Name = "menuProduct";
			this.menuProduct.Size = new System.Drawing.Size(263, 58);
			this.menuProduct.TabIndex = 5;
			// 
			// categoryTab
			// 
			this.categoryTab.FlatAppearance.BorderSize = 0;
			this.categoryTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.categoryTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.categoryTab.Image = ((System.Drawing.Image)(resources.GetObject("categoryTab.Image")));
			this.categoryTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.categoryTab.Location = new System.Drawing.Point(31, 235);
			this.categoryTab.Name = "categoryTab";
			this.categoryTab.Size = new System.Drawing.Size(229, 52);
			this.categoryTab.TabIndex = 11;
			this.categoryTab.Text = "          Category";
			this.categoryTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.categoryTab.UseVisualStyleBackColor = true;
			this.categoryTab.Click += new System.EventHandler(this.CategoryTab_Click);
			// 
			// supplierTab
			// 
			this.supplierTab.FlatAppearance.BorderSize = 0;
			this.supplierTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supplierTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.supplierTab.Image = ((System.Drawing.Image)(resources.GetObject("supplierTab.Image")));
			this.supplierTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.supplierTab.Location = new System.Drawing.Point(31, 177);
			this.supplierTab.Name = "supplierTab";
			this.supplierTab.Size = new System.Drawing.Size(229, 52);
			this.supplierTab.TabIndex = 10;
			this.supplierTab.Text = "          Supplier";
			this.supplierTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.supplierTab.UseVisualStyleBackColor = true;
			this.supplierTab.Click += new System.EventHandler(this.SupplierTab_Click);
			// 
			// purchaseTab
			// 
			this.purchaseTab.FlatAppearance.BorderSize = 0;
			this.purchaseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.purchaseTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.purchaseTab.Image = ((System.Drawing.Image)(resources.GetObject("purchaseTab.Image")));
			this.purchaseTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.purchaseTab.Location = new System.Drawing.Point(31, 119);
			this.purchaseTab.Name = "purchaseTab";
			this.purchaseTab.Size = new System.Drawing.Size(229, 52);
			this.purchaseTab.TabIndex = 9;
			this.purchaseTab.Text = "          Purchase";
			this.purchaseTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.purchaseTab.UseVisualStyleBackColor = true;
			this.purchaseTab.Click += new System.EventHandler(this.PurchaseTab_Click);
			// 
			// stockTab
			// 
			this.stockTab.FlatAppearance.BorderSize = 0;
			this.stockTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stockTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stockTab.Image = ((System.Drawing.Image)(resources.GetObject("stockTab.Image")));
			this.stockTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.stockTab.Location = new System.Drawing.Point(31, 61);
			this.stockTab.Name = "stockTab";
			this.stockTab.Size = new System.Drawing.Size(229, 52);
			this.stockTab.TabIndex = 9;
			this.stockTab.Text = "          Stock";
			this.stockTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.stockTab.UseVisualStyleBackColor = true;
			this.stockTab.Click += new System.EventHandler(this.StockTab_Click);
			// 
			// productTab
			// 
			this.productTab.FlatAppearance.BorderSize = 0;
			this.productTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.productTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productTab.Image = ((System.Drawing.Image)(resources.GetObject("productTab.Image")));
			this.productTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.productTab.Location = new System.Drawing.Point(3, 3);
			this.productTab.Name = "productTab";
			this.productTab.Size = new System.Drawing.Size(257, 52);
			this.productTab.TabIndex = 0;
			this.productTab.Text = "          Products";
			this.productTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.productTab.UseVisualStyleBackColor = true;
			this.productTab.Click += new System.EventHandler(this.productTab_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.customerTab);
			this.panel5.Location = new System.Drawing.Point(13, 258);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(263, 58);
			this.panel5.TabIndex = 6;
			// 
			// customerTab
			// 
			this.customerTab.FlatAppearance.BorderSize = 0;
			this.customerTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customerTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerTab.Image = ((System.Drawing.Image)(resources.GetObject("customerTab.Image")));
			this.customerTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customerTab.Location = new System.Drawing.Point(3, 3);
			this.customerTab.Name = "customerTab";
			this.customerTab.Size = new System.Drawing.Size(257, 52);
			this.customerTab.TabIndex = 0;
			this.customerTab.Text = "          Customers";
			this.customerTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customerTab.UseVisualStyleBackColor = true;
			this.customerTab.Click += new System.EventHandler(this.customerTab_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.employeeTab);
			this.panel4.Location = new System.Drawing.Point(13, 322);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(263, 58);
			this.panel4.TabIndex = 7;
			// 
			// employeeTab
			// 
			this.employeeTab.FlatAppearance.BorderSize = 0;
			this.employeeTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.employeeTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeTab.Image = ((System.Drawing.Image)(resources.GetObject("employeeTab.Image")));
			this.employeeTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.employeeTab.Location = new System.Drawing.Point(3, 3);
			this.employeeTab.Name = "employeeTab";
			this.employeeTab.Size = new System.Drawing.Size(257, 52);
			this.employeeTab.TabIndex = 0;
			this.employeeTab.Text = "          Employees";
			this.employeeTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.employeeTab.UseVisualStyleBackColor = true;
			this.employeeTab.Click += new System.EventHandler(this.employeeTab_Click);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.analyticTab);
			this.panel6.Location = new System.Drawing.Point(13, 386);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(263, 58);
			this.panel6.TabIndex = 7;
			// 
			// analyticTab
			// 
			this.analyticTab.FlatAppearance.BorderSize = 0;
			this.analyticTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.analyticTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.analyticTab.Image = ((System.Drawing.Image)(resources.GetObject("analyticTab.Image")));
			this.analyticTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.analyticTab.Location = new System.Drawing.Point(3, 3);
			this.analyticTab.Name = "analyticTab";
			this.analyticTab.Size = new System.Drawing.Size(257, 52);
			this.analyticTab.TabIndex = 0;
			this.analyticTab.Text = "          Analytics";
			this.analyticTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.analyticTab.UseVisualStyleBackColor = true;
			this.analyticTab.Click += new System.EventHandler(this.analyticTab_Click);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.settingTab);
			this.panel7.Location = new System.Drawing.Point(13, 450);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(263, 58);
			this.panel7.TabIndex = 8;
			// 
			// settingTab
			// 
			this.settingTab.FlatAppearance.BorderSize = 0;
			this.settingTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingTab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settingTab.Image = ((System.Drawing.Image)(resources.GetObject("settingTab.Image")));
			this.settingTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.settingTab.Location = new System.Drawing.Point(3, 3);
			this.settingTab.Name = "settingTab";
			this.settingTab.Size = new System.Drawing.Size(257, 52);
			this.settingTab.TabIndex = 0;
			this.settingTab.Text = "          Settings";
			this.settingTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.settingTab.UseVisualStyleBackColor = true;
			this.settingTab.Click += new System.EventHandler(this.settingTab_Click);
			// 
			// productSliderTransition
			// 
			this.productSliderTransition.Interval = 10;
			this.productSliderTransition.Tick += new System.EventHandler(this.productSliderTransition_Tick);
			// 
			// orderSliderTransition
			// 
			this.orderSliderTransition.Interval = 10;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.button7);
			this.panel8.Location = new System.Drawing.Point(13, 971);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(263, 58);
			this.panel8.TabIndex = 9;
			// 
			// button7
			// 
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new System.Drawing.Point(3, 3);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(257, 52);
			this.button7.TabIndex = 0;
			this.button7.Text = "          LOG OUT";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.UseVisualStyleBackColor = true;
			// 
			// container
			// 
			this.container.Location = new System.Drawing.Point(290, 66);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(1613, 972);
			this.container.TabIndex = 10;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.txtUsername);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(1535, 23);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 22);
			this.flowLayoutPanel1.TabIndex = 12;
			// 
			// txtUsername
			// 
			this.txtUsername.AutoSize = true;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.txtUsername.Location = new System.Drawing.Point(244, 0);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(53, 20);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.Text = "Admin";
			this.txtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// userButton
			// 
			this.userButton.FlatAppearance.BorderSize = 0;
			this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.userButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
			this.userButton.Location = new System.Drawing.Point(1841, 8);
			this.userButton.Name = "userButton";
			this.userButton.Size = new System.Drawing.Size(40, 52);
			this.userButton.TabIndex = 13;
			this.userButton.UseVisualStyleBackColor = true;
			// 
			// MPOS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1904, 1041);
			this.Controls.Add(this.userButton);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.container);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.menuSlider);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MPOS";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MPOS";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MPOS_FormClosed);
			this.menuSlider.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.menuProduct.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel menuSlider;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button dashboardTab;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button orderTab;
		private System.Windows.Forms.Panel menuProduct;
		private System.Windows.Forms.Button productTab;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button customerTab;
		private System.Windows.Forms.Button purchaseTab;
		private System.Windows.Forms.Button stockTab;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button analyticTab;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button settingTab;
		private System.Windows.Forms.Button categoryTab;
		private System.Windows.Forms.Button supplierTab;
		private System.Windows.Forms.Timer productSliderTransition;
		private System.Windows.Forms.Timer orderSliderTransition;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button employeeTab;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Panel container;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button userButton;
		private System.Windows.Forms.Label txtUsername;
	}
}