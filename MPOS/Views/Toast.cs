using MPOS.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MPOS.Views
{

	public partial class Toast : Form
	{
		private int toastX;
		private int toastY;
		public Toast(Notification type, string title, string message)
		{
			InitializeComponent();
			ToastType(type, title, message);
		}

		private void ToastType(Notification type, string title, string message)
		{
			this.txtType.Text = title;
			this.txtMessage.Text = message;
			switch (type) 
			{
				case Notification.Accept:
					{
						this.icon.Image = Properties.Resources.icons8_accept_48;
						this.plStatus.BackColor = Color.FromArgb(57, 155, 53);
						break;
					}
				case Notification.Warring:
					{
						this.icon.Image = Properties.Resources.icons8_warning_48;
						this.plStatus.BackColor = Color.FromArgb(245, 171, 35);
						break;
					}
				case Notification.Error:
					{
						this.icon.Image = Properties.Resources.icons8_error_48;
						this.plStatus.BackColor = Color.FromArgb(227, 50, 45);
						break;
					}
			}
		}

		private void Toast_Load(object sender, EventArgs e)
		{
			Position();
		}

		private void Position()
		{
			var width = Screen.PrimaryScreen.WorkingArea.Width;
			var height = Screen.PrimaryScreen.WorkingArea.Height;

			toastX = width - this.Width - 10;
			//toastY = height - this.Height - 50;
			toastY = 30;
			this.Location = new Point(toastX, toastY);
		}

		private void timeAlert_Tick(object sender, EventArgs e)
		{
			toastY += 10;
			this.Location = new Point(toastX, toastY);
			if(toastY >= 30)
			{
				timeAlert.Stop();	
				timerClose.Start();
			}
		}
		int timeSpan = 100;
		private void timerClose_Tick(object sender, EventArgs e)
		{
			timeSpan--;
			if (timeSpan <= 0)
			{
				toastY--;
				this.Location = new Point(toastX, toastY -= 10);
				if (toastY <= -100)
				{
					timerClose.Stop();
					timeSpan = 100;
					this.Close();
				}
			}
		}
	}
}
