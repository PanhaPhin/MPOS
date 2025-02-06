using iTextSharp.text;
using MPOS.Adapters;
using MPOS.Database;
using MPOS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MPOS.UserControllers
{
	public partial class Stock : UserControl
	{
		private StockConnection stockConnection;
		private DbDataContext dbDataContext;
		public Stock()
		{
			InitializeComponent();
			stockConnection = new StockConnection();
			dbDataContext = new DbDataContext();
			getProductIntoStock();
			getStockIn();
			getStockOut();
			search_combo.SelectedIndex = 0;
		}

		private void getStockOut()
		{
			var products = stockConnection.getOutStocks();
			stockOutTable.DataSource = products;
			formatRows("-", stockOutTable);
		}

		private void getProductIntoStock()
		{
			var products = stockConnection.ProductsInStock();
			stockTable.DataSource = products;
			rowCount.Text = $"Rows: {products.Count.ToString("#,###.0")}";
			formatRows();
		}

		private void getStockIn()
		{
			var products = stockConnection.getInStocks();
			stockInTable.DataSource = products;
			formatRows("+", stockInTable);
		}

		private void formatRows(string format, DataGridView table)
		{
			table.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			table.Columns["Quantity"].DefaultCellStyle.Format = $"{format}#,###.0";
			table.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			table.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			table.Columns["Updated"].HeaderText = "Transfer Date";
			table.Columns["Updated"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			table.Columns["Updated"].DefaultCellStyle.Format = "MM/dd/yyyy";
		}

		private void formatRows()
		{
			stockTable.Columns["Id"].HeaderText = "No.";
			stockTable.Columns["Name"].HeaderText = "Product Name";
			stockTable.Columns["Quantity"].DefaultCellStyle.Format = "#,###.0";

			stockTable.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			stockTable.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog dialog = new SaveFileDialog())
			{
				dialog.Filter = "Export file |*.xlsx";
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						var context = stockConnection.ProductsInStock();
						var data = GetDataTable(context);
						var fileName = dialog.FileName;
						if (data.Rows.Count > 0)
						{
							IExport export = new ExportToXLSX();
							export.Export(fileName, data);
						}
						else
						{

						}
					}
					catch (Exception ex) 
					{
						MessageBox.Show(ex.Message);
					}
				}
			}

		}

		private DataTable GetDataTable(List<getProductInStockResult> context)
		{
			DataTable table = new DataTable();
			table.Columns.Add("No.");
			table.Columns.Add("Product Name");
			table.Columns.Add("Category");
			table.Columns.Add("Unit");
			table.Columns.Add("Quantity");

			foreach (var item in context) 
			{ 
				var row = table.NewRow();
				row[0] = item.Id;
				row[1] = item.Name;
				row[2] = item.Category;
				row[3] = item.Unit;
				row[4] = item.Quantity;
				
				table.Rows.Add(row);   
			}
			return table;
		}
	}
}
