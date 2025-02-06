using MPOS.Database;
using MPOS.Entities;
using MPOS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MPOS.UserControllers
{
	public partial class Employee : UserControl, IFormats
	{
		private DbDataContext dbDataContext;
		private EmployeeConnection EmployeeConnection;
		private readonly string DateFormat = "MM/dd/yyyy";
		private DataTable table;
		public Employee()
		{
			InitializeComponent();
			dbDataContext = new DbDataContext();
			EmployeeConnection = new EmployeeConnection();
			EmployeesList(EmployeeConnection.GetAll());
		}

		private struct EmployeeSale
		{
			public int InvoiceId;
			public string EmployeeName;
			public string CustomName;
			public double Amount;
			public double AmountPaid;
			public double AmountRemain;
			public DateTime Created;
		}

		private struct EmployeePurchase
		{
			public string EmployeeName;
			public string SupplierName;
			public double TotalAmount;
			public double TotalPaid;
			public double TotalRemain;
			public DateTime Created;
		}

		private void EmployeesList(List<Database.Employee> Employees)
		{
			this.EmployeesListTable.DataSource = Employees;
			this.EmployeesListTable.Text = $"Rows: {Employees.Count.ToString("#,###.0")}";
			FormatCells(this.EmployeesListTable);
			this.EmployeesListTable.CellClick += EmployeesListView_CellClick;
			this.EmployeesListTable.CellMouseDoubleClick += EmployeesListView_CellMouseDoubleClick;
		}

		private void EmployeesListView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var employeeId = int.Parse(this.EmployeesListTable.Rows[e.RowIndex].Cells[0].Value.ToString());
				GetOnlyOneEmployee(employeeId);
			}
		}

		private void EmployeesListView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) 
			{ 
				var employeeId = int.Parse(this.EmployeesListTable.Rows[e.RowIndex].Cells[0].Value.ToString());
				EmployeeDailySale(employeeId);
				EmployeeDailyPurchase(employeeId);
				ResetData();
			}
		}

		private void GetOnlyOneEmployee(int employeeId)
		{
			var employee = EmployeeConnection.GetById(employeeId);
			this.EmployeeId.Text = employee.Id.ToString();
			this.EmployeeName.Text = employee.Name;
			this.PhoneNumber.Text = employee.Phone;
			this.Address.Text = employee.Address;
			this.BaseSalary.Value = decimal.Parse(employee.Salary.ToString());
			this.Created.Text = employee.Created.ToString();
			this.Updated.Text = employee.Updated.ToString();
			this.DeleteButton.Enabled = true;
			this.ModifyButton.Text = "Update";
		}

		private void EmployeeDailySale(int EmployeeId)
		{
			var employees = dbDataContext.Sales.Where(s => s.EmployeeId == EmployeeId).ToList();
			List<EmployeeSale> employeeSales = new List<EmployeeSale>();
			foreach (var emp in employees) 
			{
				EmployeeSale employee = new EmployeeSale();
				employee.InvoiceId = emp.InvoiceId;
				employee.EmployeeName = dbDataContext.Employees.FirstOrDefault(e => e.Id.Equals(emp.EmployeeId)).Name;
				employee.CustomName = dbDataContext.Customers.FirstOrDefault(c => c.Id.Equals(emp.CustomerId)).Name;
				employee.Amount = emp.Amount;
				employee.AmountPaid = emp.AmountPaid;
				employee.AmountRemain = emp.AmountRemain;
				employee.Created = emp.Created;
				employeeSales.Add(employee);
			}

			table = new DataTable();
			table.Columns.Add("Invoice No.");
			table.Columns.Add("Employee Name");
			table.Columns.Add("Customer Name");
			table.Columns.Add("Amount");
			table.Columns.Add("Paid");
			table.Columns.Add("Remain");
			table.Columns.Add("Created");

			foreach (var employee in employeeSales) 
			{ 
				var row = table.NewRow();
				row[0] = employee.InvoiceId;
				row[1] = employee.EmployeeName;
				row[2] = employee.CustomName;
				row[3] = employee.Amount.ToString("$#,###.00");
				row[4] = employee.AmountPaid.ToString("$#,###.00");
				row[5] = employee.AmountRemain.ToString("$#,###.00");
				row[6] = employee.Created.ToShortDateString();
				table.Rows.Add(row);
			}

			this.EmployeeDailySaleTable.DataSource = table;
			this.EmployeeDailySaleTable.Columns["Invoice No."].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.EmployeeDailySaleTable.Columns["Created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeeDailySaleTable.Columns["Paid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeeDailySaleTable.Columns["Remain"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeeDailySaleTable.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeeSaleCount.Text = $"Rows: {this.EmployeeDailySaleTable.RowCount.ToString("#,###.0")}";
		}	
		private void EmployeeDailyPurchase(int EmployeeId)
		{
			var employees = dbDataContext.PurchaseOrders.Where(s => s.EmployeeId == EmployeeId).ToList();
			List<EmployeePurchase> employeePurchases = new List<EmployeePurchase>();
			foreach (var emp in employees)
			{
				EmployeePurchase employee = new EmployeePurchase();
				employee.EmployeeName = dbDataContext.Employees.FirstOrDefault(e => e.Id.Equals(emp.EmployeeId)).Name;
				employee.SupplierName = dbDataContext.Suppliers.FirstOrDefault(s => s.Id.Equals(emp.SupplierId)).Name;
				employee.TotalAmount = emp.TotalAmount;
				employee.TotalPaid = emp.TotalPaid;
				employee.TotalRemain = emp.TotalRemain;
				employee.Created = emp.Created;
				employeePurchases.Add(employee);
			}

			table = new DataTable();
			table.Columns.Add("Employee Name");
			table.Columns.Add("Supplier Name");
			table.Columns.Add("Amount");
			table.Columns.Add("Paid");
			table.Columns.Add("Remain");
			table.Columns.Add("Created");

			foreach (var employee in employeePurchases)
			{
				var row = table.NewRow();
				row[0] = employee.EmployeeName;
				row[1] = employee.SupplierName;
				row[2] = employee.TotalAmount.ToString("$#,###.00");
				row[3] = employee.TotalPaid.ToString("$#,###.00");
				row[4] = employee.TotalRemain.ToString("$#,###.00");
				row[5] = employee.Created.ToShortDateString();
				table.Rows.Add(row);
			}

			this.EmployeeDailyPurchaseTable.DataSource = table;
			this.EmployeeDailyPurchaseTable.Columns["Created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeeDailyPurchaseTable.Columns["Paid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeeDailyPurchaseTable.Columns["Remain"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeeDailyPurchaseTable.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployeePurchaseCount.Text = $"Rows: {this.EmployeeDailyPurchaseTable.RowCount.ToString("#,###.0")}";
		}

		public void ResetData()
		{
			this.EmployeeId.Text = string.Empty;
			this.EmployeeName.Text = string.Empty;
			this.PhoneNumber.Text = string.Empty;
			this.Address.Text = string.Empty;
			this.BaseSalary.Value = 0;
			this.Created.Value = DateTime.Now;
			this.Updated.Value = DateTime.Now;

			this.DeleteButton.Enabled = false;
			this.ModifyButton.Text = "Create";
		}

		public void FormatCells(DataGridView gridView)
		{
			gridView.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns["Id"].HeaderText = "Employee Id";
			gridView.Columns["Name"].HeaderText = "Employee Name";
			gridView.Columns["Created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns["Updated"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns["Created"].DefaultCellStyle.Format = DateFormat;
			gridView.Columns["Created"].HeaderText = "Working Date";
			gridView.Columns["Updated"].DefaultCellStyle.Format = DateFormat;
			gridView.Columns["Salary"].DefaultCellStyle.Format = "$#,###.00";
			gridView.Columns["Salary"].HeaderText = "Base Salary";
		}

		public void Search(TextBox text)
		{
			throw new NotImplementedException();
		}

		private void ResetButton_Click(object sender, EventArgs e) => ResetData();
	}
}
