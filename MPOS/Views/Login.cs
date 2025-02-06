using MPOS.Database;
using System;
using System.Linq;
using System.Windows.Forms;
using static MPOS.Views.MPOS;

namespace MPOS.Views
{
	public partial class Login : Form
	{
		private DbDataContext dbDataContext;
		public static string Username { get; set; }
		public static string Password { get; set; }

		public Login()
		{
			InitializeComponent();
			dbDataContext = new DbDataContext();

			this.txtPassword.KeyPress += TxtPassword_KeyPressEnter;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUsername.Text))
				usernameProvider.SetError(txtUsername, "Username required.");
			else
			{
				usernameProvider.SetError(txtUsername, string.Empty);
				Username = txtUsername.Text;
			}
			if (string.IsNullOrEmpty(txtPassword.Text))
				passwordProvider.SetError(txtPassword, "Password required.");
			else
			{
				passwordProvider.SetError(txtPassword, string.Empty);
				Password = txtPassword.Text;
			}

			var person = dbDataContext.Users.Where(p => p.Username.Equals(Username) && p.Password.Equals(Password)).FirstOrDefault();
			if (person != null) 
			{ 
				this.Hide();
				mPOS = new MPOS();
				mPOS.Show();
				Toast toast = new Toast(Entities.Notification.Accept, "Login", "Login Successfully.");
				toast.Show();
			}
			else
			{
				Toast toast = new Toast(Entities.Notification.Error, "Login", "Username or Password not correct.");
				toast.Show();
				txtUsername.Select();
			}
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtUsername.Text))
				usernameProvider.SetError(txtUsername, string.Empty);
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtPassword.Text))
				passwordProvider.SetError(txtPassword, string.Empty);
		}
		private void TxtPassword_KeyPressEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.GetHashCode().Equals(851981)) // Keys.Enter
			{
				// MessageBox.Show(e.KeyChar.GetHashCode().ToString());
				btnLogin_Click(sender, e);
			}
		}
	}
}
