using System.Windows.Forms;

namespace MPOS.Controllers
{
	public class Options
	{
		public void ShowUserControl<T> (Panel panel, T t)
		{
			var control = t as UserControl;
			if (control is null)
			{
				control.BackColor = System.Drawing.SystemColors.Window;
				control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
				control.Location = new System.Drawing.Point(3, 3);
				control.Name = t.ToString().ToLower();
				control.Size = new System.Drawing.Size(1613, 966);
				control.TabIndex = 0;
			}
			if (!panel.Controls.Contains(control))
			{
				panel.Controls.Add (control);
				control.BringToFront();
			}
			control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			control.Show();
			//MessageBox.Show(control.Name);
		}

		public void HideUserControl<T>(Panel panel, T t)
		{
			var control = t as UserControl;
			if (control != null)
				panel.Controls.Remove(control);
		}
	}
}
