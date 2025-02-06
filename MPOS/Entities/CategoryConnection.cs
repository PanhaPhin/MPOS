using MPOS.Database;
using MPOS.Services;
using System.Collections.Generic;
using System.Linq;

namespace MPOS.Entities
{
	public class CategoryConnection : GetByOperation<Category> ,ICrudService<Category>
	{
		DbDataContext dbDataContext = new DbDataContext();

		public string Delete(int Id)
		{
			var category = dbDataContext.Categories.FirstOrDefault(c => c.Id == Id);
			if (category != null)
				return "Category Deleted.";
			return "Category not found.";
		}

		public List<Category> GetAll() => dbDataContext.Categories.ToList();

		public override Category GetById(int Id)
		{
			var category = dbDataContext.Categories.FirstOrDefault(c => c.Id == Id);
			if (category == null)
				return null;

			return category;
		}

		public override List<Category> GetByName(string Name) => dbDataContext.Categories.Where(c => c.Name.ToLower().StartsWith(Name.ToLower())).ToList();

		public string Insert(Category type)
		{
			var categoryName = dbDataContext.Categories.FirstOrDefault(c=>c.Name == type.Name);
			if (categoryName == null)
			{
				dbDataContext.Categories.InsertOnSubmit(type);
				dbDataContext.SubmitChanges();
				return "Add 1 row.";
			}
			else
				return "Category Duplicated";
		}


		public string Update(Category type, int Id)
		{
			var category = dbDataContext.Categories.FirstOrDefault(c => c.Id == Id);
			if (category != null)
			{
				category.Id = Id;
				category.Name = type.Name;
				category.Created = type.Created;
				category.Updated = System.DateTime.Now;
				dbDataContext.SubmitChanges();
				return "Category Updated.";
			}
			else
				return "Category not found.";
		}
	}
}
