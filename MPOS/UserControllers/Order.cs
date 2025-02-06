using MPOS.Database;
using MPOS.Entities;
using MPOS.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MPOS.UserControllers
{
	public partial class Order : UserControl
	{
		private ComponentHelper componentsHelper;
		private readonly string iconDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Resources\\Icons");
		DbDataContext dataContext;
		public Order()
		{
			InitializeComponent();

			btnAllCategory.Enabled = false;
			btnAllCategory.BackColor = SystemColors.ControlLight;

			dataContext = new DbDataContext();
			componentsHelper = new ComponentHelper();
			currentDate.Text = DateTime.Now.ToLongDateString();
			search_combo.SelectedIndex = 0;
			productInStock();
		}


		
		private void productInStock()
		{
			productContainer.Controls.Clear();
			var products = dataContext.getProductSaleInStock().ToList();
			productCard(products);

			//for (int i = 0; i < 10; i++)
			//{
			//	CardOrder card = new CardOrder();
			//	orderContainer.Controls.Add(card);
			//}

			ProductsCount.Text = $"Products: {productContainer.Controls.Count.ToString("#,###.0")}";
		}

		private void productCard(List<getProductSaleInStockResult> products)
		{
			foreach (var product in products)
			{
				ProductCard card = new ProductCard();
				card.productName.Text = product.Name;
				card.quantity.Text = $"Qty: {product.Quantity.ToString("#,###.0")}";
				card.price.Text = product.SellingPrice.ToString("C2");
				card.productImage.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "no-image-x300.png")));
				productContainer.Controls.Add(card);
			}
		}

		private void submitButton_Click(object sender, EventArgs e)
		{

		}

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
			searchProduct.Text = string.Empty;
			searchProduct.Select();
		}

		private void searchProduct_TextChanged(object sender, EventArgs e)
		{
			if (search_combo.SelectedIndex.Equals(0))
			{
				// Check if the text contains numbers when search by No.
				var isContain = componentsHelper.CheckTextContainsNumbers(search_combo.SelectedIndex, searchProduct, searchButton);
				if (!isContain)
				{
					productContainer.Controls.Clear();
					var products = dataContext.getProductSaleInStock().Where(product => product.Id.Equals(Int32.Parse(searchProduct.Text))).ToList();
					productCard(products);
				}
				else
				{
					productInStock();
				}
			}
			else
			{
				if (string.IsNullOrEmpty(searchProduct.Text) || string.IsNullOrWhiteSpace(searchProduct.Text))
				{
					// Reset border color to white when the textbox is empty
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					productInStock();
				}
				else if (search_combo.SelectedIndex.Equals(1))
				{
					// Reset border color to default when no numbers are present
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					productContainer.Controls.Clear();
					var products = dataContext.getProductSaleInStock().Where(product => product.Name.ToLower().StartsWith(searchProduct.Text.ToLower()) || product.Name.ToLower().EndsWith(searchProduct.Text.ToLower())).ToList();
					productCard(products);
				}
				else if (search_combo.SelectedIndex.Equals(2))
				{
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					productContainer.Controls.Clear();
					var products = dataContext.getProductSaleInStock().Where(product => product.Category.ToLower().StartsWith(searchProduct.Text.ToLower()) || product.Category.ToLower().EndsWith(searchProduct.Text.ToLower())).ToList();
					productCard(products);
				}
				else
				{
					searchProduct.ForeColor = SystemColors.WindowText;
					searchButton.Enabled = true;
					productInStock();
				}
			}
		}

		private void receiptButton_Click(object sender, EventArgs e)
		{
			MPOS.ViewReports.ViewReport reports = new MPOS.ViewReports.ViewReport();
			reports.Show();
		}
		private void CancelButton_Click(object sender, EventArgs e)
		{
			orderContainer.Controls.Clear();
			ComponentHelper.productOrderCount = 0;
			productOrderCount.Text = $"Subtotal: {ComponentHelper.productOrderCount.ToString("0.0")}";
		}
	}
}
