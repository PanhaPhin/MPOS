using MPOS.Database;
using MPOS.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static MPOS.DTOs.StaticComponents;
using static MPOS.UserControllers.Setting;

namespace MPOS.Views
{
	public partial class EmployeeListView : Form, IFormats
	{
		private DbDataContext dbDataContext;
		private readonly string DateFormat = "MM/dd/yyyy";
		public EmployeeListView()
		{
			InitializeComponent();
			dbDataContext = new DbDataContext();
			EmployeesList(dbDataContext.Employees.ToList());
		}

		public void FormatCells(DataGridView gridView)
		{
			gridView.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns["Created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns["Updated"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns["Created"].DefaultCellStyle.Format = DateFormat;
			gridView.Columns["Updated"].DefaultCellStyle.Format = DateFormat;
			gridView.Columns["Salary"].DefaultCellStyle.Format = "$#,###.00";
		}

		public void ResetData()
		{
			throw new System.NotImplementedException();
		}

		public void Search(TextBox text)
		{
			if (!string.IsNullOrEmpty(text.Text) || !string.IsNullOrWhiteSpace(text.Text))
			{
				var employees = dbDataContext.Employees.Where(e => e.Name.ToLower().StartsWith(text.Text.ToLower())).ToList();
				if (employees != null) 
					EmployeesList(employees);
				else
				{
					this.EmployeesListView.DataSource = null;
					this.EmployeesListViewCount.Text = $"Rows: {employees.Count.ToString("#,###.0")}";
				}
			}else
				EmployeesList(dbDataContext.Employees.ToList());
		}

		private void EmployeesList(List<Employee> Employees)
		{
			this.EmployeesListView.DataSource = Employees;
			this.EmployeesListViewCount.Text = $"Rows: {Employees.Count.ToString("#,###.0")}";
			FormatCells(this.EmployeesListView);
			this.EmployeesListView.CellClick += EmployeesListView_CellClick;
			this.EmployeesListView.CellMouseDoubleClick += EmployeesListView_CellMouseDoubleClick;
		}

		private void EmployeesListView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) => this.Dispose();

		private void EmployeesListView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (EmployeeName.Items.Count > 0)
					EmployeeName.Items.Clear();
				EmployeeName.Items.Add(this.EmployeesListView.Rows[e.RowIndex].Cells[1].Value.ToString());
				Username.Text = this.EmployeesListView.Rows[e.RowIndex].Cells[1].Value.ToString();
				EmployeeName.SelectedIndex = 0;
			}
		}

		private void SearchField_TextChanged(object sender, System.EventArgs e) => Search(this.SearchField);
	}
}
