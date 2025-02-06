using MPOS.Entities;
using MPOS.Services;
using System;
using System.Windows.Forms;

namespace MPOS.UserControllers
{
	public partial class Supplier : UserControl, IFormats
	{
		private SupplierConnection supplierConnection;
		private readonly string DateFormat = "MM/dd/yyyy";
		public Supplier()
		{
			InitializeComponent();
			supplierConnection = new SupplierConnection();
			GetSupplierList();
			this.DeleteButton.Enabled = false;
			this.ModifyButton.Text = "Create";
		}
		private void GetSupplierList()
		{
			var data = supplierConnection.GetAll();
			this.SuppliersListTable.DataSource = data;
			this.SupplierCount.Text = $"Rows: {data.Count.ToString("#,###.0")}";
			this.SuppliersListTable.CellClick += SuppliersListTable_CellClick ;
			FormatCells(this.SuppliersListTable);
		}
		private void GetOnlySupplier(int supplierId)
		{
			var supplier = supplierConnection.GetById(supplierId);
			this.SupplierId.Text = supplier.Id.ToString();
			this.SupplierName.Text = supplier.Name;
			this.PhoneNumber.Text = supplier.Phone;
			this.Address.Text = supplier.Address;
			this.Created.Text = supplier.Created.ToString();
			this.Updated.Text = supplier.Updated.ToString();
		}

		private void SuppliersListTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0)
			{
				var supplierId = (int)this.SuppliersListTable.Rows[e.RowIndex].Cells[0].Value;
				GetOnlySupplier(supplierId);
				this.ModifyButton.Text = "Update";
				this.DeleteButton.Enabled = true;
			}
		}

		public void ResetData()
		{
			this.SupplierId.Text = string.Empty;
			this.SupplierName.Text = string.Empty;
			this.PhoneNumber.Text = string.Empty;
			this.Address.Text = string.Empty;
			this.Created.Value = DateTime.Now;
			this.Updated.Value = DateTime.Now;
			this.SuppliersListTable.ClearSelection();
			this.DeleteButton.Enabled = false;
			this.ModifyButton.Text = "Create";
		}

		public void FormatCells(DataGridView gridView)
		{
			gridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			gridView.Columns[4].DefaultCellStyle.Format = DateFormat;
			gridView.Columns[5].DefaultCellStyle.Format = DateFormat;
		}

		private void ResetButton_Click(object sender, EventArgs e) => ResetData();

		public void Search(TextBox text)
		{
			if (!string.IsNullOrEmpty(text.Text) || !string.IsNullOrWhiteSpace(text.Text))
			{
				var suppliers = supplierConnection.GetByName(text.Text);
				if (suppliers != null)
				{
					this.SuppliersListTable.DataSource = suppliers;
					this.SupplierCount.Text = $"Rows: {suppliers.Count.ToString("#,###.0")}";
				}
				else
				{
					this.SupplierCount.Text = $"Rows: {suppliers.Count.ToString("#,###.0")}";
					this.SuppliersListTable.DataSource = null;
				}
			}
			else
				GetSupplierList();
		}

		private void SearchField_TextChanged(object sender, EventArgs e) => Search(this.SearchField);
	}
}
