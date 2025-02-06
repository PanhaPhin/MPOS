using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace MPOS.ViewReports
{
	public partial class ViewReport : Form
	{
		public ViewReport()
		{
			InitializeComponent();
		}

		private void ViewReport_Load(object sender, EventArgs e)
		{

			this.reportViewer.RefreshReport();
        }
    }
}
