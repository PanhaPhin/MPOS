using MPOS.Database;
using MPOS.Entities;
using MPOS.Helpers;
using MPOS.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static MPOS.DTOs.StaticComponents;
using static MPOS.Views.MPOS;

namespace MPOS.UserControllers
{
	public partial class Products : UserControl
	{
		private ComponentHelper componentsHelper;
		private ProductConnection productConnection;
		private DbDataContext dbDataContext;
		string iconDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Resources\\Icons");
		private List<getProductsResult> results;
		private DataTable DataTable = new DataTable();
		public Products()
		{
			InitializeComponent();

			productConnection = new ProductConnection();
			dbDataContext = new DbDataContext();
			componentsHelper = new ComponentHelper();
			search_combo.SelectedIndex = 0;
			getAllProducts();

		}

		private void GetAllProduct()
		{
			DataTable.Columns.Add("No.");
			DataTable.Columns.Add("Product Name");
			DataTable.Columns.Add("Category");
			DataTable.Columns.Add("Cost Price");
			DataTable.Columns.Add("Selling Price");
			DataTable.Columns.Add("Unit");
			DataTable.Columns.Add("Created");
			DataTable.Columns.Add("Updated");


			foreach (var product in results)
			{
				var row = DataTable.NewRow();

				row[0] = product.Id;
				row[1] = product.ProductName;
				row[2] = product.Category;
				row[3] = product.CostPrice.ToString("C2");
				row[4] = product.SellingPrice.ToString("C2");
				row[5] = product.Unit;
				row[6] = product.Created.ToShortDateString();
				row[7] = product.Updated.ToShortDateString();

				DataTable.Rows.Add(row);
			}

			productsTable.DataSource = DataTable;

			if (!productsTable.Columns[0].HeaderText.Equals("Edit") && !productsTable.Columns[1].HeaderText.Equals("Delete"))
			{
				DataGridViewImageColumn edit = new DataGridViewImageColumn();
				edit.HeaderText = "Edit";
				edit.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-edit-24.png")), new Size(20, 20));
				edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				productsTable.Columns.Add(edit);

				DataGridViewImageColumn delete = new DataGridViewImageColumn();
				delete.HeaderText = "Delete";
				delete.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-delete-24.png")), new Size(20, 20));
				delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				productsTable.Columns.Add(delete);
				edit.Width = 45;
				delete.FillWeight = 35;
				productsTable.Columns[8].Width = 150;
				productsTable.Columns[9].Width = 150;
				productsTable.CellMouseEnter += ProductsTable_CellMouseEnter;
				productsTable.CellMouseLeave += ProductsTable_CellMouseLeave;
			}
		}

		private void getAllProducts()
		{
			var allProducts = productConnection.GetAllProducts();

			var products = from product in productConnection.GetAll() where product.CategoryId == product.Category.Id 
						   select (product.Id, product.Name, product.Category.Name, product.CostPrice, product.SellingPrice, product.Unit, product.Created, product.Updated);


			productsTable.DataSource = allProducts;

			try
			{
				if (!productsTable.Columns[0].HeaderText.Equals("Edit") && !productsTable.Columns[1].HeaderText.Equals("Delete"))
				{
					DataGridViewImageColumn edit = new DataGridViewImageColumn();
					edit.HeaderText = "Edit";
					edit.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-edit-24.png")), new Size(20, 20));
					edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					productsTable.Columns.Add(edit);

					DataGridViewImageColumn delete = new DataGridViewImageColumn();
					delete.HeaderText = "Delete";
					delete.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "icons8-delete-24.png")), new Size(20, 20));
					delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					productsTable.Columns.Add(delete);
					edit.Width = 45;
					delete.FillWeight = 35;
					productsTable.Columns[8].Width = 150;
					productsTable.Columns[9].Width = 150;
					productsTable.CellMouseEnter += ProductsTable_CellMouseEnter;
					productsTable.CellMouseLeave += ProductsTable_CellMouseLeave;

					productsTable.CellClick += ProductsTable_CellClick;
				}
				//productsCount.Text = $"Rows: {allProducts.Count.ToString("#,###.0")}";
				countProduct.Text = $"Rows: {allProducts.Count.ToString("#,###.0")}";

				FormatRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ProductsTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Check if the clicked cell is a button cell
			if (productsTable.Columns[e.ColumnIndex].HeaderText.Equals("Delete") && e.RowIndex >= 0)
			{
				// var value = $"{productsTable.Rows[e.RowIndex].Cells[2].Value}, { productsTable.Rows[e.RowIndex].Cells[3].Value }"; // cell[2] is product id
				deleteProduct(e.RowIndex);
				getAllProducts();
				searchProduct.Text = string.Empty;
				// MessageBox.Show(value);
			}
			else
			if (productsTable.Columns[e.ColumnIndex].Index.Equals(0) && e.RowIndex >= 0)
			{
				editProduct(e.RowIndex);
				//EditProduct(e.RowIndex, updateForm);
			}
		}

		private void ProductsTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (productsTable.Columns[e.ColumnIndex].HeaderText.Equals("Edit") && e.RowIndex >= 0)
			{
				productsTable[e.ColumnIndex, e.RowIndex].Style.BackColor = SystemColors.ControlLight;
				productsTable[e.ColumnIndex, e.RowIndex].ToolTipText = ShowProductDetail(e.RowIndex);
				productsTable.Cursor = Cursors.Hand;
			}
			else if (productsTable.Columns[e.ColumnIndex].Index.Equals(1) && e.RowIndex >= 0)
			{
				productsTable[e.ColumnIndex, e.RowIndex].Style.BackColor = SystemColors.ControlLight;
				productsTable[e.ColumnIndex, e.RowIndex].ToolTipText = ShowProductDetail(e.RowIndex);
				productsTable.Cursor = Cursors.Hand;
			}
		}
		private void ProductsTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
			if (productsTable.Columns[e.ColumnIndex].HeaderText.Equals("Edit") && e.RowIndex >= 0)
			{
				productsTable[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White; // Reset to default color
				productsTable.Cursor = Cursors.Default;
			}
			else if (productsTable.Columns[e.ColumnIndex].Index.Equals(1) && e.RowIndex >= 0)
			{
				productsTable[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White; // Reset to default color
				productsTable.Cursor = Cursors.Default;
			}
		}
		private string ShowProductDetail(int rowIndex) => string.Format(
							   "No.: {0}\n" +
							   "Product Name: {1}\n" +
							   "Category: {2}\n" +
							   "Cost Price: {3}\n" +
							   "Selling Price: {4}\n" +
							   "Unit: {5}",
							   productsTable.Rows[rowIndex].Cells[2].Value,
							   productsTable.Rows[rowIndex].Cells[3].Value,
							   productsTable.Rows[rowIndex].Cells[4].Value,
							   (Convert.ToDouble(productsTable.Rows[rowIndex].Cells[5].Value)).ToString("C2"),
							   (Convert.ToDouble(productsTable.Rows[rowIndex].Cells[6].Value)).ToString("C2"),
							   productsTable.Rows[rowIndex].Cells[7].Value);

		private void searchButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(searchProduct.Text))
			{

			}
			else
				searchProduct.Focus();
		}

		private void search_combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (search_combo.SelectedIndex.Equals(0))
			//	search_product_textbox.PlaceholderText = "Search No.";
			//else if (search_combo.SelectedIndex.Equals(1))
			//	search_product_textbox.PlaceholderText = "Search Product Name";
			//else if (search_combo.SelectedIndex.Equals(2))
			//	search_product_textbox.PlaceholderText = "Search Category";
			//else if (search_combo.SelectedIndex.Equals(3))
			//	search_product_textbox.PlaceholderText = "Search Unit";

			//search_product_textbox.Text = string.Empty;
			searchProduct.Text = string.Empty;
			searchProduct.Select();
		}

		private void FormatRows()
		{
			productsTable.Columns["Id"].HeaderText = "No.";
			productsTable.Columns["ProductName"].HeaderText = "Product Name";
			productsTable.Columns["CostPrice"].HeaderText = "Cost Price";
			productsTable.Columns["SellingPrice"].HeaderText = "Selling Price";
			productsTable.Columns["Created"].HeaderText = "Create Date";
			productsTable.Columns["Updated"].HeaderText = "Update Date";

			productsTable.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			productsTable.Columns["CostPrice"].DefaultCellStyle.Format = "C";
			productsTable.Columns["SellingPrice"].DefaultCellStyle.Format = "C";
			productsTable.Columns["Created"].DefaultCellStyle.Format = "MM/dd/yyyy"; // "D"
			productsTable.Columns["Updated"].DefaultCellStyle.Format = "MM/dd/yyyy";
			productsTable.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
		}

		private void search_product_textbox_TextChanged(object sender, EventArgs e)
		{
			if (search_combo.SelectedIndex.Equals(0))
			{
				// Check if the text contains numbers when search by No.
				var isContain = componentsHelper.CheckTextContainsNumbers(search_combo.SelectedIndex, searchProduct, searchButton);
				if (!isContain)
				{
					var products = productConnection.GetAllProducts().Where(product => product.Id.Equals(Int32.Parse(searchProduct.Text))).ToList();
					productsTable.DataSource = products;
					FormatRows();
				}
				else
				{
					getAllProducts();
				}
			}
			else if (search_combo.SelectedIndex.Equals(3))
			{
				componentsHelper.CheckTextMaxThenThree(search_combo.SelectedIndex, searchProduct, searchButton);
				var products = productConnection.GetAllProducts().Where(product => product.Unit.ToLower().StartsWith(searchProduct.Text.ToLower()) || product.Unit.ToLower().EndsWith(searchProduct.Text.ToLower())).ToList();
				productsTable.DataSource = products;
				FormatRows();
			}
			else
			{
				if (string.IsNullOrEmpty(searchProduct.Text) || string.IsNullOrWhiteSpace(searchProduct.Text))
				{
					// Reset border color to white when the textbox is empty
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					getAllProducts();
				}
				else if (search_combo.SelectedIndex.Equals(1))
				{
					// Reset border color to default when no numbers are present
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					var products = productConnection.GetAllProducts().Where(product => product.ProductName.ToLower().StartsWith(searchProduct.Text.ToLower()) || product.ProductName.ToLower().EndsWith(searchProduct.Text.ToLower())).ToList();
					productsTable.DataSource = products;
					FormatRows();
				}
				else if (search_combo.SelectedIndex.Equals(2))
				{
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					var products = productConnection.GetAllProducts().Where(product => product.Category.ToLower().StartsWith(searchProduct.Text.ToLower()) || product.Category.ToLower().EndsWith(searchProduct.Text.ToLower())).ToList();
					productsTable.DataSource = products;
					FormatRows();
				}
				else
				{
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					getAllProducts();
				}
			}
		}

		private void addNew_Click(object sender, EventArgs e) => modifyProduct().ShowDialog();

		private ProductModify modifyProduct()
		{
			try
			{
				// validate owner page
				if (mPOS.Visible)
				{
					ProductModify modify = new ProductModify();
					modify.Owner = mPOS;
					//modify.ShowDialog();
					return modify;
				}
				else
					return null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		private void deleteProduct(int rowIndex)
		{
			var productId = Convert.ToInt32(productsTable.Rows[rowIndex].Cells[2].Value);
			var response = MessageBox.Show($"Delete Product: {productsTable.Rows[rowIndex].Cells[3].Value} ?", "Module", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (response.Equals(DialogResult.OK))
			{
				var message = productConnection.Delete(productId);
				Toast toast = new Toast(Entities.Notification.Warring, "Deleted", message);
				toast.Show();
			}
		}

		private void editProduct(int rowIndex)
		{
			using (var modify = modifyProduct())
			{
				try
				{
					modify.Text = "Update Product";
					modify.productId.Text = productsTable.Rows[rowIndex].Cells[2].Value.ToString();
					modify.productName.Text = productsTable.Rows[rowIndex].Cells[3].Value.ToString();
					modify.category.SelectedIndex = dbDataContext.Categories.FirstOrDefault(c => c.Name.Equals(productsTable.Rows[rowIndex].Cells[4].Value.ToString())).Id - 1;
					modify.costPrice.Value = Convert.ToDecimal(productsTable.Rows[rowIndex].Cells[5].Value.ToString().Trim('$'));
					modify.sellingPrice.Value = Convert.ToDecimal(productsTable.Rows[rowIndex].Cells[6].Value.ToString());
					modify.unit.Text = productsTable.Rows[rowIndex].Cells[7].Value.ToString();
					modify.created.Text = productsTable.Rows[rowIndex].Cells[8].Value.ToString();
					modify.updated.Value = DateTime.Now;

					modify.createButton.Text = "Update";

					modify.ShowDialog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			};
		}
	}
}
