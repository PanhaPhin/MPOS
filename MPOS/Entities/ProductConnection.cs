using MPOS.Database;
using MPOS.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MPOS.Entities
{
	public class ProductConnection : ICrudService<Product>
	{
		DbDataContext dbDataContext = new DbDataContext();

		public List<vTopProduct> GetProducts() => dbDataContext.vTopProducts.ToList();
		public List<getProductsResult> GetAllProducts() => dbDataContext.getProducts().ToList();
		public List<Product> GetAll() => dbDataContext.Products.ToList();

		public string Insert(Product type)
		{
			dbDataContext.Products.InsertOnSubmit(type);
			dbDataContext.SubmitChanges();
			return "Add 1 row.";
		}

		public string Update(Product type, int Id)
		{
			var existingProduct = dbDataContext.Products.FirstOrDefault(p => p.Id == Id);
			if (existingProduct != null)
			{
				existingProduct.Name = type.Name;
				existingProduct.CategoryId = type.CategoryId;
				existingProduct.SellingPrice = type.SellingPrice;
				existingProduct.CostPrice = type.CostPrice;
				existingProduct.Unit = type.Unit;
				existingProduct.Created = type.Created;
				existingProduct.Updated = type.Updated;

				dbDataContext.SubmitChanges();
				return "Product Updated";
			}
			else return "Product not found.";
		}

		public string Delete(int Id)
		{
			var product = dbDataContext.Products.FirstOrDefault(p => p.Id == Id);
			if (product != null)
			{
				dbDataContext.Products.DeleteOnSubmit(product);
				dbDataContext.SubmitChanges();
				return "Product Deleted";
			}
			else
				return "Product not found.";
		}
	}
}
