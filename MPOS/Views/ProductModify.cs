using MPOS.Database;
using MPOS.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MPOS.DTOs.StaticComponents;

namespace MPOS.Views
{
	public partial class ProductModify : Form
	{
		private CategoryConnection categoryConnection;
		private ProductConnection productConnection;
		private int id;
		private string imageSource = string.Empty;
		private string imageFolderPath = string.Empty;
		private readonly string imagesDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Images");
		private readonly string iconDirectoryPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Resources\\Icons");
		public ProductModify()
		{
			InitializeComponent();
			categoryConnection = new CategoryConnection();
			productConnection = new ProductConnection();
			productName.Select();
			getCategories();

			id = productConnection.GetAllProducts().Count + 1;
			productId.Text = id.ToString();
		}

		private void getCategories()
		{
			foreach (var c in categoryConnection.GetAll())
			{
				category.Items.Add(c.Name);
			}
			category.SelectedIndex = 0;
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			modifyProduct(product);
		}

		private void modifyProduct(Product product)
		{
			product.Id = id;

			if (!string.IsNullOrEmpty(productName.Text))
				product.Name = productName.Text;
			else
			{
				nameRequired.SetError(productName, "Name is required.");
				return;
			}

			product.CategoryId = category.SelectedIndex + 1;
			if (costPrice.Value > 0)
				product.CostPrice = (double)costPrice.Value;
			else
			{
				costPriceRequired.SetError(costPrice, "Cost price must be bigger than 0");
				return;
			}

			if (sellingPrice.Value > 0)
				product.SellingPrice = (double)sellingPrice.Value;
			else
			{
				sellingPriceRequired.SetError(sellingPrice, "Sell price must be bigger than 0");
				return;
			}

			if (!string.IsNullOrEmpty(unit.Text))
				product.Unit = unit.Text.ToUpper();
			else
			{
				unitRequired.SetError(unit, "Unit is required.");
				return;
			}

			product.Created = created.Value;
			product.Updated = DateTime.Now;

			if (createButton.Text.Equals("Create"))
			{
				var message = productConnection.Insert(product);
				Toast toast = new Toast(Entities.Notification.Accept, "Created", message);
				toast.Show();
				searchProduct.Text = string.Empty;
				resetFields();
			}
			else
			{
				var message = productConnection.Update(product, Int32.Parse(productId.Text));
				Toast toast = new Toast(Entities.Notification.Warring, "Updated", message);
				toast.Show();
				this.Hide();
				Task.Delay(2300).Wait();
				this.Close();
				searchProduct.Text = string.Empty;
			}
		}

		private void resetFields()
		{
			id = productConnection.GetAllProducts().Count + 1;
			countProduct.Text = $"Rows: {(id-1).ToString("#,###.0")}";

			productId.Text = id.ToString();
			productName.Text = string.Empty;
			category.SelectedIndex = 0;
			costPrice.Value = 0;
			sellingPrice.Value = 0;
			unit.Text = string.Empty;
			created.Value = DateTime.Now;
			updated.Value = DateTime.Now;
			image.Image = new Bitmap(Image.FromFile(Path.Combine(iconDirectoryPath, "no-image-x300.png")));

			nameRequired.SetError(productName, string.Empty);
			costPriceRequired.SetError(costPrice, string.Empty);
			sellingPriceRequired.SetError(sellingPrice, string.Empty);
			unitRequired.SetError(unit, string.Empty);

		}

		private void resetButton_Click(object sender, EventArgs e) => resetFields();

		private void productName_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(productName.Text))
			{
				nameRequired.SetError(productName, string.Empty);
			}
		}

		private void costPrice_ValueChanged(object sender, EventArgs e)
		{
			if (costPrice.Value > 0)
				costPriceRequired.SetError(costPrice, string.Empty);
		}

		private void sellingPrice_ValueChanged(object sender, EventArgs e)
		{
			if (sellingPrice.Value > 0)
				sellingPriceRequired.SetError(sellingPrice, string.Empty);
		}

		private void unit_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(unit.Text))
				unitRequired.SetError(unit, string.Empty);
		}

		private void image_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						var imageSource = new Bitmap(dialog.FileName);
						image.Image = new Bitmap(imageSource, new Size(100, 100));
						imageFolderPath = Path.Combine(imagesDirectoryPath, Path.GetFileName(dialog.FileName));
						this.imageSource = dialog.FileName;
						//File.Copy(this.imageSource, imageFolderPath, true);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Exception of image source {ex.Message}");
					}
				}
			}
		}
	}
}
