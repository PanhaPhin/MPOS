using System;

namespace MPOS.UserControllers
{
	partial class Order
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
			this.button7 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.productContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.ProductsCount = new System.Windows.Forms.Label();
			this.currentDate = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			orderContainer = new System.Windows.Forms.FlowLayoutPanel();
			productOrderCount = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.search_combo = new System.Windows.Forms.ComboBox();
			this.searchProduct = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.productCard13 = new MPOS.UserControllers.ProductCard();
			this.productCard14 = new MPOS.UserControllers.ProductCard();
			this.productCard15 = new MPOS.UserControllers.ProductCard();
			this.productCard16 = new MPOS.UserControllers.ProductCard();
			this.productCard18 = new MPOS.UserControllers.ProductCard();
			this.productCard1 = new MPOS.UserControllers.ProductCard();
			this.productCard2 = new MPOS.UserControllers.ProductCard();
			this.productCard3 = new MPOS.UserControllers.ProductCard();
			this.productCard4 = new MPOS.UserControllers.ProductCard();
			this.productCard5 = new MPOS.UserControllers.ProductCard();
			this.productCard6 = new MPOS.UserControllers.ProductCard();
			this.productCard7 = new MPOS.UserControllers.ProductCard();
			this.productCard8 = new MPOS.UserControllers.ProductCard();
			this.productCard9 = new MPOS.UserControllers.ProductCard();
			this.productCard10 = new MPOS.UserControllers.ProductCard();
			this.productCard11 = new MPOS.UserControllers.ProductCard();
			this.productCard12 = new MPOS.UserControllers.ProductCard();
			this.productCard17 = new MPOS.UserControllers.ProductCard();
			this.productCard19 = new MPOS.UserControllers.ProductCard();
			this.productCard20 = new MPOS.UserControllers.ProductCard();
			this.button3 = new System.Windows.Forms.Button();
			this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
			this.btnAllCategory = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.ReceiptButton = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.txtPayableAmount = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flpCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.Window;
			this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button7.Location = new System.Drawing.Point(15, 14);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(1051, 944);
			this.button7.TabIndex = 38;
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Window;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(1083, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(514, 944);
			this.button1.TabIndex = 39;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(31, 30);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 45;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 21);
			this.label1.TabIndex = 44;
			this.label1.Text = "Products In Stock";
			// 
			// productContainer
			// 
			this.productContainer.AutoScroll = true;
			this.productContainer.BackColor = System.Drawing.SystemColors.Window;
			this.productContainer.Location = new System.Drawing.Point(66, 207);
			this.productContainer.Name = "productContainer";
			this.productContainer.Size = new System.Drawing.Size(950, 703);
			this.productContainer.TabIndex = 46;
			// 
			// ProductsCount
			// 
			this.ProductsCount.AutoSize = true;
			this.ProductsCount.BackColor = System.Drawing.SystemColors.Window;
			this.ProductsCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProductsCount.Location = new System.Drawing.Point(27, 923);
			this.ProductsCount.Name = "ProductsCount";
			this.ProductsCount.Size = new System.Drawing.Size(70, 19);
			this.ProductsCount.TabIndex = 47;
			this.ProductsCount.Text = "Products: ";
			// 
			// currentDate
			// 
			this.currentDate.AutoSize = true;
			this.currentDate.BackColor = System.Drawing.SystemColors.Window;
			this.currentDate.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentDate.Location = new System.Drawing.Point(850, 35);
			this.currentDate.Name = "currentDate";
			this.currentDate.Size = new System.Drawing.Size(172, 19);
			this.currentDate.TabIndex = 48;
			this.currentDate.Text = "Thursday, August 29 2024";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Window;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(1096, 70);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(489, 742);
			this.button2.TabIndex = 49;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1098, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 51;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1128, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 21);
			this.label2.TabIndex = 50;
			this.label2.Text = "Products Order";
			// 
			// orderContainer
			// 
			orderContainer.AutoScroll = true;
			orderContainer.BackColor = System.Drawing.SystemColors.Window;
			orderContainer.Location = new System.Drawing.Point(1107, 84);
			orderContainer.Name = "orderContainer";
			orderContainer.Size = new System.Drawing.Size(466, 714);
			orderContainer.TabIndex = 52;
			// 
			// productOrderCount
			// 
			productOrderCount.AutoSize = true;
			productOrderCount.BackColor = System.Drawing.SystemColors.Window;
			productOrderCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			productOrderCount.Location = new System.Drawing.Point(1103, 815);
			productOrderCount.Name = "productOrderCount";
			productOrderCount.Size = new System.Drawing.Size(86, 19);
			productOrderCount.TabIndex = 53;
			productOrderCount.Text = "Subtotal: 0.0";
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
			this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cancelButton.Location = new System.Drawing.Point(1098, 910);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(95, 32);
			this.cancelButton.TabIndex = 55;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// search_combo
			// 
			this.search_combo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_combo.FormattingEnabled = true;
			this.search_combo.Items.AddRange(new object[] {
            "No.",
            "Product Name",
            "Category"});
			this.search_combo.Location = new System.Drawing.Point(67, 79);
			this.search_combo.Name = "search_combo";
			this.search_combo.Size = new System.Drawing.Size(158, 29);
			this.search_combo.TabIndex = 43;
			this.search_combo.SelectedIndexChanged += new System.EventHandler(this.search_combo_SelectedIndexChanged);
			// 
			// searchProduct
			// 
			this.searchProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchProduct.Location = new System.Drawing.Point(231, 79);
			this.searchProduct.Multiline = true;
			this.searchProduct.Name = "searchProduct";
			this.searchProduct.Size = new System.Drawing.Size(426, 29);
			this.searchProduct.TabIndex = 51;
			this.searchProduct.TextChanged += new System.EventHandler(this.searchProduct_TextChanged);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
			this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.Location = new System.Drawing.Point(663, 77);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(95, 32);
			this.searchButton.TabIndex = 45;
			this.searchButton.Text = "Search";
			this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// productCard13
			// 
			this.productCard13.BackColor = System.Drawing.SystemColors.Window;
			this.productCard13.Location = new System.Drawing.Point(3, 3);
			this.productCard13.Name = "productCard13";
			this.productCard13.Size = new System.Drawing.Size(180, 226);
			this.productCard13.TabIndex = 42;
			// 
			// productCard14
			// 
			this.productCard14.BackColor = System.Drawing.SystemColors.Window;
			this.productCard14.Location = new System.Drawing.Point(189, 3);
			this.productCard14.Name = "productCard14";
			this.productCard14.Size = new System.Drawing.Size(180, 226);
			this.productCard14.TabIndex = 43;
			// 
			// productCard15
			// 
			this.productCard15.BackColor = System.Drawing.SystemColors.Window;
			this.productCard15.Location = new System.Drawing.Point(375, 3);
			this.productCard15.Name = "productCard15";
			this.productCard15.Size = new System.Drawing.Size(180, 226);
			this.productCard15.TabIndex = 44;
			// 
			// productCard16
			// 
			this.productCard16.BackColor = System.Drawing.SystemColors.Window;
			this.productCard16.Location = new System.Drawing.Point(561, 3);
			this.productCard16.Name = "productCard16";
			this.productCard16.Size = new System.Drawing.Size(180, 226);
			this.productCard16.TabIndex = 45;
			// 
			// productCard18
			// 
			this.productCard18.BackColor = System.Drawing.SystemColors.Window;
			this.productCard18.Location = new System.Drawing.Point(747, 3);
			this.productCard18.Name = "productCard18";
			this.productCard18.Size = new System.Drawing.Size(180, 226);
			this.productCard18.TabIndex = 47;
			// 
			// productCard1
			// 
			this.productCard1.BackColor = System.Drawing.SystemColors.Window;
			this.productCard1.Location = new System.Drawing.Point(3, 235);
			this.productCard1.Name = "productCard1";
			this.productCard1.Size = new System.Drawing.Size(180, 226);
			this.productCard1.TabIndex = 48;
			// 
			// productCard2
			// 
			this.productCard2.BackColor = System.Drawing.SystemColors.Window;
			this.productCard2.Location = new System.Drawing.Point(189, 235);
			this.productCard2.Name = "productCard2";
			this.productCard2.Size = new System.Drawing.Size(180, 226);
			this.productCard2.TabIndex = 49;
			// 
			// productCard3
			// 
			this.productCard3.BackColor = System.Drawing.SystemColors.Window;
			this.productCard3.Location = new System.Drawing.Point(375, 235);
			this.productCard3.Name = "productCard3";
			this.productCard3.Size = new System.Drawing.Size(180, 226);
			this.productCard3.TabIndex = 50;
			// 
			// productCard4
			// 
			this.productCard4.BackColor = System.Drawing.SystemColors.Window;
			this.productCard4.Location = new System.Drawing.Point(561, 235);
			this.productCard4.Name = "productCard4";
			this.productCard4.Size = new System.Drawing.Size(180, 226);
			this.productCard4.TabIndex = 51;
			// 
			// productCard5
			// 
			this.productCard5.BackColor = System.Drawing.SystemColors.Window;
			this.productCard5.Location = new System.Drawing.Point(747, 235);
			this.productCard5.Name = "productCard5";
			this.productCard5.Size = new System.Drawing.Size(180, 226);
			this.productCard5.TabIndex = 52;
			// 
			// productCard6
			// 
			this.productCard6.BackColor = System.Drawing.SystemColors.Window;
			this.productCard6.Location = new System.Drawing.Point(3, 467);
			this.productCard6.Name = "productCard6";
			this.productCard6.Size = new System.Drawing.Size(180, 226);
			this.productCard6.TabIndex = 53;
			// 
			// productCard7
			// 
			this.productCard7.BackColor = System.Drawing.SystemColors.Window;
			this.productCard7.Location = new System.Drawing.Point(189, 467);
			this.productCard7.Name = "productCard7";
			this.productCard7.Size = new System.Drawing.Size(180, 226);
			this.productCard7.TabIndex = 54;
			// 
			// productCard8
			// 
			this.productCard8.BackColor = System.Drawing.SystemColors.Window;
			this.productCard8.Location = new System.Drawing.Point(375, 467);
			this.productCard8.Name = "productCard8";
			this.productCard8.Size = new System.Drawing.Size(180, 226);
			this.productCard8.TabIndex = 55;
			// 
			// productCard9
			// 
			this.productCard9.BackColor = System.Drawing.SystemColors.Window;
			this.productCard9.Location = new System.Drawing.Point(561, 467);
			this.productCard9.Name = "productCard9";
			this.productCard9.Size = new System.Drawing.Size(180, 226);
			this.productCard9.TabIndex = 56;
			// 
			// productCard10
			// 
			this.productCard10.BackColor = System.Drawing.SystemColors.Window;
			this.productCard10.Location = new System.Drawing.Point(747, 467);
			this.productCard10.Name = "productCard10";
			this.productCard10.Size = new System.Drawing.Size(180, 226);
			this.productCard10.TabIndex = 57;
			// 
			// productCard11
			// 
			this.productCard11.BackColor = System.Drawing.SystemColors.Window;
			this.productCard11.Location = new System.Drawing.Point(3, 699);
			this.productCard11.Name = "productCard11";
			this.productCard11.Size = new System.Drawing.Size(180, 226);
			this.productCard11.TabIndex = 58;
			// 
			// productCard12
			// 
			this.productCard12.BackColor = System.Drawing.SystemColors.Window;
			this.productCard12.Location = new System.Drawing.Point(189, 699);
			this.productCard12.Name = "productCard12";
			this.productCard12.Size = new System.Drawing.Size(180, 226);
			this.productCard12.TabIndex = 59;
			// 
			// productCard17
			// 
			this.productCard17.BackColor = System.Drawing.SystemColors.Window;
			this.productCard17.Location = new System.Drawing.Point(375, 699);
			this.productCard17.Name = "productCard17";
			this.productCard17.Size = new System.Drawing.Size(180, 226);
			this.productCard17.TabIndex = 60;
			// 
			// productCard19
			// 
			this.productCard19.BackColor = System.Drawing.SystemColors.Window;
			this.productCard19.Location = new System.Drawing.Point(561, 699);
			this.productCard19.Name = "productCard19";
			this.productCard19.Size = new System.Drawing.Size(180, 226);
			this.productCard19.TabIndex = 61;
			// 
			// productCard20
			// 
			this.productCard20.BackColor = System.Drawing.SystemColors.Window;
			this.productCard20.Location = new System.Drawing.Point(747, 699);
			this.productCard20.Name = "productCard20";
			this.productCard20.Size = new System.Drawing.Size(180, 226);
			this.productCard20.TabIndex = 62;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Window;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(65, 143);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(951, 56);
			this.button3.TabIndex = 56;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// flpCategory
			// 
			this.flpCategory.AutoScroll = true;
			this.flpCategory.Controls.Add(this.btnAllCategory);
			this.flpCategory.Controls.Add(this.button5);
			this.flpCategory.Controls.Add(this.button6);
			this.flpCategory.Controls.Add(this.button8);
			this.flpCategory.Controls.Add(this.button9);
			this.flpCategory.Controls.Add(this.button10);
			this.flpCategory.Location = new System.Drawing.Point(72, 149);
			this.flpCategory.Name = "flpCategory";
			this.flpCategory.Size = new System.Drawing.Size(938, 45);
			this.flpCategory.TabIndex = 57;
			// 
			// btnAllCategory
			// 
			this.btnAllCategory.FlatAppearance.BorderSize = 0;
			this.btnAllCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAllCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAllCategory.Location = new System.Drawing.Point(3, 3);
			this.btnAllCategory.Name = "btnAllCategory";
			this.btnAllCategory.Size = new System.Drawing.Size(150, 39);
			this.btnAllCategory.TabIndex = 0;
			this.btnAllCategory.Text = "All";
			this.btnAllCategory.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(159, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(150, 39);
			this.button5.TabIndex = 1;
			this.button5.Text = "Toyota";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(315, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(150, 39);
			this.button6.TabIndex = 2;
			this.button6.Text = "Yamaha";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(471, 3);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(150, 39);
			this.button8.TabIndex = 3;
			this.button8.Text = "Jeep";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(627, 3);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(150, 39);
			this.button9.TabIndex = 4;
			this.button9.Text = "Saturn";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(783, 3);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(150, 39);
			this.button10.TabIndex = 5;
			this.button10.Text = "Chrysler";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(69, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 19);
			this.label3.TabIndex = 58;
			this.label3.Text = "Category";
			// 
			// ReceiptButton
			// 
			this.ReceiptButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReceiptButton.Image = ((System.Drawing.Image)(resources.GetObject("ReceiptButton.Image")));
			this.ReceiptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ReceiptButton.Location = new System.Drawing.Point(1490, 910);
			this.ReceiptButton.Name = "ReceiptButton";
			this.ReceiptButton.Size = new System.Drawing.Size(95, 32);
			this.ReceiptButton.TabIndex = 55;
			this.ReceiptButton.Text = "Receipt";
			this.ReceiptButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ReceiptButton.UseVisualStyleBackColor = true;
			this.ReceiptButton.Click += new System.EventHandler(this.receiptButton_Click);
			// 
			// button12
			// 
			this.button12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
			this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button12.Location = new System.Drawing.Point(1389, 910);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(95, 32);
			this.button12.TabIndex = 55;
			this.button12.Text = "Payment";
			this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// txtPayableAmount
			// 
			this.txtPayableAmount.AutoSize = true;
			this.txtPayableAmount.BackColor = System.Drawing.SystemColors.Window;
			this.txtPayableAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPayableAmount.Location = new System.Drawing.Point(1103, 864);
			this.txtPayableAmount.Name = "txtPayableAmount";
			this.txtPayableAmount.Size = new System.Drawing.Size(160, 21);
			this.txtPayableAmount.TabIndex = 53;
			this.txtPayableAmount.Text = "Payable Amount: $0.0";
			// 
			// txtDiscount
			// 
			this.txtDiscount.AutoSize = true;
			this.txtDiscount.BackColor = System.Drawing.SystemColors.Window;
			this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.txtDiscount.Location = new System.Drawing.Point(1103, 834);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(97, 19);
			this.txtDiscount.TabIndex = 53;
			this.txtDiscount.Text = "Discount: $0.0";
			// 
			// Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.flpCategory);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.searchProduct);
			this.Controls.Add(this.search_combo);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.ReceiptButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.txtDiscount);
			this.Controls.Add(this.txtPayableAmount);
			this.Controls.Add(productOrderCount);
			this.Controls.Add(orderContainer);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.currentDate);
			this.Controls.Add(this.ProductsCount);
			this.Controls.Add(this.productContainer);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Name = "Order";
			this.Size = new System.Drawing.Size(1613, 972);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flpCategory.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label ProductsCount;
		private System.Windows.Forms.Label currentDate;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ComboBox search_combo;
		private System.Windows.Forms.TextBox searchProduct;
		private System.Windows.Forms.Button searchButton;
		private ProductCard productCard13;
		private ProductCard productCard14;
		private ProductCard productCard15;
		private ProductCard productCard16;
		private ProductCard productCard18;
		private ProductCard productCard1;
		private ProductCard productCard2;
		private ProductCard productCard3;
		private ProductCard productCard4;
		private ProductCard productCard5;
		private ProductCard productCard6;
		private ProductCard productCard7;
		private ProductCard productCard8;
		private ProductCard productCard9;
		private ProductCard productCard10;
		private ProductCard productCard11;
		private ProductCard productCard12;
		private ProductCard productCard17;
		private ProductCard productCard19;
		private ProductCard productCard20;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnAllCategory;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ReceiptButton;
		private System.Windows.Forms.Button button12;
		public System.Windows.Forms.Label txtPayableAmount;
		public System.Windows.Forms.Label txtDiscount;
		public System.Windows.Forms.FlowLayoutPanel flpCategory;
		public System.Windows.Forms.FlowLayoutPanel productContainer;
		public static System.Windows.Forms.FlowLayoutPanel orderContainer;
		public static System.Windows.Forms.Label productOrderCount;
	}
}
