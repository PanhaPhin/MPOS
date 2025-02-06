using System.Windows.Forms;

namespace MPOS.Services
{
	public interface IFormats
	{
		void ResetData();
		void FormatCells(DataGridView gridView);
		void Search(TextBox text);
	}
}
