using ClosedXML.Excel;
using System.Data;

namespace ExportAdapter
{
	public interface IExport
	{
		void Export<T>(string fileName, T data);
	}

	public class ExportToTXT : IExport
	{
		public void Export<T>(string fileName, T data)
		{
			throw new NotImplementedException();
		}
	}

	public class ExportToDOCX : IExport
	{
		public void Export<T>(string fileName, T data)
		{
			throw new NotImplementedException();
		}
	}

	public class ExportToPDF : IExport
	{
		public void Export<T>(string fileName, T data)
		{
			throw new NotImplementedException();
		}
	}

	public class ExportToCSV : IExport
	{
		public void Export<T>(string fileName, T data)
		{
			throw new NotImplementedException();
		}
	}

	public class ExportToXLSX : IExport
	{
		public void Export<T>(string fileName, T data)
		{
			var table = data as DataTable;
			using (XLWorkbook workbook = new XLWorkbook()) 
			{
				workbook.Worksheets.Add(table,fileName);
				workbook.SaveAs(fileName);
			}
		}
	}
}
