using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MPOS.Helpers
{
	public class ComponentHelper
	{
		bool isContain = false;
		public static int productOrderCount { get; set; } = 0;
		public bool CheckTextContainsNumbers(int index, TextBox text, Button button)
		{
			if (TextContain(text.Text) && (index.Equals(0)))
			{
				text.ForeColor = Color.OrangeRed;
				button.Enabled = false;
				isContain = true;
			}
			else if (string.IsNullOrEmpty(text.Text) || string.IsNullOrWhiteSpace(text.Text))
			{
				// Reset border color to white when the textbox is empty
				text.ForeColor = SystemColors.WindowText;
				button.Enabled = true;
				isContain = true;
			}
			else
			{
				// Reset border color to default when no numbers are present
				text.ForeColor = SystemColors.WindowText;
				button.Enabled = true;
				isContain = false;
			}
			return isContain;
		}

		public void CheckTextMaxThenThree(int index, TextBox text, Button button)
		{
			if (text.Text.Count() > 2 && (index.Equals(3)))
			{
				text.ForeColor = Color.OrangeRed;
				button.Enabled = false;
			}
			else if (string.IsNullOrEmpty(text.Text))
			{
				// Reset border color to white when the textbox is empty
				text.ForeColor = SystemColors.WindowText;
				button.Enabled = true;
			}
			else
			{
				// Reset border color to default when no numbers are present
				text.ForeColor = SystemColors.WindowText;
				button.Enabled = true;
			}
		}

		private bool TextContain(string text)
		{
			if (!string.IsNullOrEmpty(text))
			{
				foreach (char c in text)
				{
					if (!char.IsDigit(c))
						return true;
				}
			}
			return false;
		}
	}
}
