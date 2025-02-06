namespace MPOS.UserControllers
{
	partial class ProductCard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
			this.card = new System.Windows.Forms.Button();
			this.productImage = new System.Windows.Forms.PictureBox();
			this.productName = new System.Windows.Forms.Label();
			this.quantity = new System.Windows.Forms.Label();
			this.price = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// card
			// 
			this.card.Location = new System.Drawing.Point(0, 0);
			this.card.Name = "card";
			this.card.Size = new System.Drawing.Size(180, 226);
			this.card.TabIndex = 0;
			this.card.UseVisualStyleBackColor = false;
			this.card.Click += new System.EventHandler(this.card_Click);
			// 
			// productImage
			// 
			this.productImage.Image = ((System.Drawing.Image)(resources.GetObject("productImage.Image")));
			this.productImage.Location = new System.Drawing.Point(15, 14);
			this.productImage.Name = "productImage";
			this.productImage.Size = new System.Drawing.Size(150, 150);
			this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.productImage.TabIndex = 1;
			this.productImage.TabStop = false;
			// 
			// productName
			// 
			this.productName.AutoSize = true;
			this.productName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productName.Location = new System.Drawing.Point(12, 167);
			this.productName.Name = "productName";
			this.productName.Size = new System.Drawing.Size(82, 17);
			this.productName.TabIndex = 2;
			this.productName.Text = "Ranger 2024";
			// 
			// quantity
			// 
			this.quantity.AutoSize = true;
			this.quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quantity.Location = new System.Drawing.Point(12, 191);
			this.quantity.Name = "quantity";
			this.quantity.Size = new System.Drawing.Size(52, 17);
			this.quantity.TabIndex = 3;
			this.quantity.Text = "Qty: 5.0";
			// 
			// price
			// 
			this.price.AutoSize = true;
			this.price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.price.Location = new System.Drawing.Point(39, 0);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(53, 17);
			this.price.TabIndex = 4;
			this.price.Text = "$515.00";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.price);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 191);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(95, 24);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// ProductCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.quantity);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.productName);
			this.Controls.Add(this.productImage);
			this.Controls.Add(this.card);
			this.Name = "ProductCard";
			this.Size = new System.Drawing.Size(180, 226);
			((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}



		#endregion

		private System.Windows.Forms.Button card;
		public	System.Windows.Forms.PictureBox productImage;
		public	System.Windows.Forms.Label productName;
		public	System.Windows.Forms.Label quantity;
		public	System.Windows.Forms.Label price;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
