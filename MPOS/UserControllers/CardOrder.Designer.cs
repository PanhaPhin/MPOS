using MPOS.Properties;

namespace MPOS.UserControllers
{
	partial class CardOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardOrder));
			this.button1 = new System.Windows.Forms.Button();
			this.productImage = new System.Windows.Forms.PictureBox();
			this.productName = new System.Windows.Forms.Label();
			this.price = new System.Windows.Forms.Label();
			this.quantity = new System.Windows.Forms.Label();
			this.decre = new System.Windows.Forms.Button();
			this.incre = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(441, 83);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// productImage
			// 
			this.productImage.Image = ((System.Drawing.Image)(resources.GetObject("productImage.Image")));
			this.productImage.Location = new System.Drawing.Point(4, 4);
			this.productImage.Name = "productImage";
			this.productImage.Size = new System.Drawing.Size(75, 75);
			this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.productImage.TabIndex = 2;
			this.productImage.TabStop = false;
			// 
			// productName
			// 
			this.productName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productName.Location = new System.Drawing.Point(91, 14);
			this.productName.Name = "productName";
			this.productName.Size = new System.Drawing.Size(170, 23);
			this.productName.TabIndex = 7;
			this.productName.Text = "Ranger 2024";
			// 
			// price
			// 
			this.price.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.price.Location = new System.Drawing.Point(91, 44);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(71, 31);
			this.price.TabIndex = 5;
			this.price.Text = "$515.00";
			this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// quantity
			// 
			this.quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quantity.Location = new System.Drawing.Point(292, 38);
			this.quantity.Name = "quantity";
			this.quantity.Size = new System.Drawing.Size(76, 35);
			this.quantity.TabIndex = 3;
			this.quantity.Text = " 3.0";
			this.quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// decre
			// 
			this.decre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decre.Location = new System.Drawing.Point(250, 38);
			this.decre.Name = "decre";
			this.decre.Size = new System.Drawing.Size(36, 35);
			this.decre.TabIndex = 3;
			this.decre.Text = "-";
			this.decre.UseVisualStyleBackColor = true;
			// 
			// incre
			// 
			this.incre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.incre.Location = new System.Drawing.Point(374, 38);
			this.incre.Name = "incre";
			this.incre.Size = new System.Drawing.Size(36, 35);
			this.incre.TabIndex = 8;
			this.incre.Text = "+";
			this.incre.UseVisualStyleBackColor = true;
			this.incre.Click += new System.EventHandler(this.incre_Click);
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = Properties.Resources.icons8_cancel_24;
			this.btnClose.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
			this.btnClose.Location = new System.Drawing.Point(411, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(27, 24);
			this.btnClose.TabIndex = 8;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.incre_Click);
			// 
			// CardOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.productName);
			this.Controls.Add(this.price);
			this.Controls.Add(this.quantity);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.incre);
			this.Controls.Add(this.decre);
			this.Controls.Add(this.productImage);
			this.Controls.Add(this.button1);
			this.Name = "CardOrder";
			this.Size = new System.Drawing.Size(441, 83);
			((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.PictureBox productImage;
		public System.Windows.Forms.Label productName;
		public System.Windows.Forms.Label price;
		public System.Windows.Forms.Label quantity;
		private System.Windows.Forms.Button decre;
		private System.Windows.Forms.Button incre;
		private System.Windows.Forms.Button btnClose;
	}
}
