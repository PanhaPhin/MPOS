using MPOS.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MPOS.UserControllers
{
	public partial class Dashboard : UserControl
	{
		ProductConnection productConnection;	
		EmployeeConnection employeeConnection;
		string imagesDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Images");
		string iconDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Resources\\Icons");
		public Dashboard()
		{
			InitializeComponent();
			productConnection = new ProductConnection();
			employeeConnection = new EmployeeConnection();

			getBestSellingProducts();
			getTopEmployees();
			showCharts();
		}

		private void showCharts()
		{
			totalOnboardChart.Series["Total Onboard"].Points.AddXY("April", 120);
			totalOnboardChart.Series["Total Onboard"].Points.AddXY("May", 75);
			totalOnboardChart.Series["Total Onboard"].Points.AddXY("June", 80);
			totalOnboardChart.Series["Total Onboard"].Points.AddXY("July", 95);
			totalOnboardChart.Series["Total Onboard"].Points.AddXY("Last Month", 65);
			totalOnboardChart.Series["Total Onboard"].Points.AddXY("This Month", 110);

			saleChart.Series["Total Sold Products"].Points.AddXY("Last Day", 89);
			saleChart.Series["Total Sold Products"].Points.AddXY("Yesterday", 75);
			saleChart.Series["Total Sold Products"].Points.AddXY("Today", 45);

		}

		private void getTopEmployees()
		{
			var count = employeeConnection.getTopEmployees();
			topEmployeeTable.DataSource = count;
			//topEmployeeTable.Columns[1].Width = 200;
			topEmployeeTable.Columns["TotalAmount"].HeaderText = "Total Amount";
			topEmployeeTable.Columns["Name"].HeaderText = "Employee Name";
			topEmployeeTable.Columns["TotalAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			topEmployeeTable.Columns["TotalAmount"].DefaultCellStyle.Format = "C";
			topEmployeeTable.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

			topEmployeeCount.Text += count.Count.ToString("#,###.0");
		}

		private void getBestSellingProducts()
		{
			var count = productConnection.GetProducts().ToList();
			bestSellingProductTable.DataSource = count;


			//DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
			//imageColumn.HeaderText = "Cover";
			//Image image = new Bitmap(Image.FromFile(Path.Combine(imagesDirectoryPath, "hambeger.png")), new Size(30, 30));
			//imageColumn.Image = image;
			//imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			//bestSellingProductTable.Columns.Add(imageColumn);

			//DataGridViewImageColumn edit = new DataGridViewImageColumn();
			//edit.HeaderText = "Edit";
			//edit.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-edit-24.png")), new Size(20, 20));
			//edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			//bestSellingProductTable.Columns.Add(edit);

			//DataGridViewImageColumn delete = new DataGridViewImageColumn();
			//delete.HeaderText = "Delete";
			//delete.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-delete-24.png")), new Size(20, 20));
			//delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			//bestSellingProductTable.Columns.Add(delete);

			//bestSellingProductTable.CellClick += BestSellingProductTable_CellClick;

			bestSellingProductsCount.Text += count.Count.ToString("#,###.0");
			//bestSellingProductTable.Columns[1].Width = 200;
			//bestSellingProductTable.Columns[5].Width = 200;

			bestSellingProductTable.Columns["InvoiceId"].HeaderText = "Invoice No.";
			bestSellingProductTable.Columns["ProductName"].HeaderText = "Product Name";
			bestSellingProductTable.Columns["TotalPrice"].HeaderText = "Total Price";
			bestSellingProductTable.Columns["Created"].HeaderText = "Create Date";

			bestSellingProductTable.Columns["InvoiceId"].AutoSizeMode= DataGridViewAutoSizeColumnMode.ColumnHeader;
			bestSellingProductTable.Columns["TotalPrice"].DefaultCellStyle.Format = "C";
			bestSellingProductTable.Columns["Quantity"].DefaultCellStyle.Format = "#,###.0";
			bestSellingProductTable.Columns["Created"].DefaultCellStyle.Format = "MM/dd/yyyy";
		}


		private void BestSellingProductTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (bestSellingProductTable.Columns[e.ColumnIndex].HeaderText == "Edit" && e.RowIndex >=0)
			{
				MessageBox.Show(bestSellingProductTable.Rows[e.RowIndex].Cells[3].Value.ToString());
			}
		}
	}
}
