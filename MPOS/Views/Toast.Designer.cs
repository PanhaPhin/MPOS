namespace MPOS.Views
{
	partial class Toast
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
			this.plStatus = new System.Windows.Forms.Panel();
			this.txtType = new System.Windows.Forms.Label();
			this.icon = new System.Windows.Forms.PictureBox();
			this.txtMessage = new System.Windows.Forms.Label();
			this.timeAlert = new System.Windows.Forms.Timer(this.components);
			this.timerClose = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.SuspendLayout();
			// 
			// plStatus
			// 
			this.plStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.plStatus.Location = new System.Drawing.Point(0, 0);
			this.plStatus.Name = "plStatus";
			this.plStatus.Size = new System.Drawing.Size(8, 65);
			this.plStatus.TabIndex = 0;
			// 
			// txtType
			// 
			this.txtType.AutoSize = true;
			this.txtType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtType.Location = new System.Drawing.Point(48, 9);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(104, 17);
			this.txtType.TabIndex = 1;
			this.txtType.Text = "Create Message";
			// 
			// icon
			// 
			this.icon.Image = global::MPOS.Properties.Resources.icons8_accept_48;
			this.icon.Location = new System.Drawing.Point(14, 12);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(28, 28);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.icon.TabIndex = 2;
			this.icon.TabStop = false;
			// 
			// txtMessage
			// 
			this.txtMessage.AutoSize = true;
			this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMessage.Location = new System.Drawing.Point(48, 26);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(93, 15);
			this.txtMessage.TabIndex = 1;
			this.txtMessage.Text = "Product Created";
			// 
			// timeAlert
			// 
			this.timeAlert.Enabled = true;
			this.timeAlert.Interval = 10;
			this.timeAlert.Tick += new System.EventHandler(this.timeAlert_Tick);
			// 
			// timerClose
			// 
			this.timerClose.Interval = 10;
			this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
			// 
			// Toast
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(260, 51);
			this.Controls.Add(this.icon);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.plStatus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Toast";
			this.Text = "Toast";
			this.Load += new System.EventHandler(this.Toast_Load);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plStatus;
		private System.Windows.Forms.Label txtType;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Label txtMessage;
		private System.Windows.Forms.Timer timeAlert;
		private System.Windows.Forms.Timer timerClose;
	}
}