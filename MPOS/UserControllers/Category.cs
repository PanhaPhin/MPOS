using MPOS.Database;
using MPOS.Entities;
using MPOS.Services;
using MPOS.Views;
using System;
using System.Windows.Forms;

namespace MPOS.UserControllers
{
	public partial class Category : UserControl, IFormats
	{
		CategoryConnection categoryConnection;
		private readonly string DateFormat = "MM/dd/yyyy";
		public Category()
		{
			InitializeComponent();
			categoryConnection = new CategoryConnection();
			CategoryDetail();
			modifyButton.Text = "Create";
			deleteButton.Enabled = false;
			this.categoryName.Select();
		}

		private void CategoryDetail()
		{
			CategoryTable.DataSource = categoryConnection.GetAll();
			CategoryTable.CellClick += CategoryTable_CellClick;
			FormatCells(this.CategoryTable);
			this.CategoryCount.Text = $"Rows: {categoryConnection.GetAll().Count.ToString("#,###.0")}";
		}

		private void CategoryTable_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0)
			{
				// MessageBox.Show(CategoryTable.Rows[e.RowIndex].Cells[0].Value.ToString());
				var categoryId = (int)CategoryTable.Rows[e.RowIndex].Cells[0].Value;
				GetOnlyCategory(categoryId);
			}
		}

		private void GetOnlyCategory(int categoryId)
		{
			var category = categoryConnection.GetById(categoryId);
			this.categoryId.Text = category.Id.ToString();
			this.categoryName.Text = category.Name.ToString();
			this.created.Text = category.Created.ToString();
			modifyButton.Text = "Update";
			deleteButton.Enabled = true;
		}

		private void resetButton_Click(object sender, EventArgs e) => ResetData();

		private void modifyButton_Click(object sender, EventArgs e)
		{
			if (this.modifyButton.Text.Equals("Create"))
			{
				MPOS.Database.Category category = NewCategory(DateTime.Now);
				if (this.categoryName.Text.Equals(string.Empty))
				{
					this.nameRequired.SetError(this.categoryName, "Name are required.");
					return;
				}
				else
					category.Name = this.categoryName.Text;
				var message = categoryConnection.Insert(category);
				Toast toast = new Toast(Notification.Accept, "Insert", message);
				toast.Show();
				CategoryDetail();
				ResetData();
				this.categoryName.Select();
			}
			else if (this.modifyButton.Text.Equals("Update"))
			{
				MPOS.Database.Category category = NewCategory(this.created.Value);
				if (this.categoryName.Text.Equals(string.Empty))
				{
					this.nameRequired.SetError(this.categoryName, "Name are required.");
					return;
				}
				else
					category.Name = this.categoryName.Text;
				var message = categoryConnection.Update(category, int.Parse(this.categoryId.Text));
				Toast toast = new Toast(Notification.Warring, "Update", message);
				toast.Show();
				CategoryDetail();
				ResetData();
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{

		}

		private MPOS.Database.Category NewCategory(DateTime created)
		{
			MPOS.Database.Category category = new MPOS.Database.Category();
			category.Id = categoryConnection.GetAll().Count + 2;
			category.Created = created;
			category.Updated = DateTime.Now;
			return category;
		}

		private void categoryName_TextChanged(object sender, EventArgs e) => this.nameRequired.SetError(this.categoryName, string.Empty);

		private void CategoryName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.GetHashCode().Equals(851981)) // Keys.Enter
			{
				modifyButton_Click(sender, e);
			}
		}

		public void ResetData()
		{
			this.categoryId.Text = string.Empty;
			this.categoryName.Text = string.Empty;
			this.created.Value = DateTime.Now;
			this.updated.Value = DateTime.Now;
			modifyButton.Text = "Create";
			deleteButton.Enabled = false;
			CategoryTable.ClearSelection();
		}

		public void FormatCells(DataGridView gridView)
		{
			gridView.Columns["Id"].HeaderText = "No.";
			//gridViewColumns[0].DividerWidth = 100; // create none column
			gridView.Columns["Name"].HeaderText = "Category Name";
			gridView.Columns["Created"].DefaultCellStyle.Format = DateFormat;
			gridView.Columns["Updated"].DefaultCellStyle.Format = DateFormat;
		}

		public void Search(TextBox text)
		{
			if (!string.IsNullOrEmpty(text.Text) || !string.IsNullOrWhiteSpace(text.Text))
			{
				var categories = categoryConnection.GetByName(text.Text);
				if (categories != null)
				{
					this.CategoryTable.DataSource = categories;
					this.CategoryCount.Text = $"Rows: {categories.Count.ToString("#,###.0")}";
				}
				else
				{
					this.CategoryTable.DataSource = null;
					this.CategoryCount.Text = $"Rows: {categories.Count.ToString("#,###.0")}";
				}
			}
			else
				CategoryDetail();
		}

		private void SearchField_TextChanged(object sender, EventArgs e) => Search(this.SearchField);
		
	}
}
