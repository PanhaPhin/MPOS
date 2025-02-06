using MPOS.Database;
using MPOS.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MPOS.Entities
{
	public class SupplierConnection : GetByOperation<Supplier>, ICrudService<Supplier>
	{
		private DbDataContext dbDataContext = new DbDataContext();
		public string Delete(int Id)
		{
			throw new NotImplementedException();
		}

		public List<Supplier> GetAll() => dbDataContext.Suppliers.ToList();

		public override Supplier GetById(int Id)
		{
			return dbDataContext.Suppliers.FirstOrDefault(s => s.Id == Id);
		}

		public override List<Supplier> GetByName(string Name) => dbDataContext.Suppliers.Where(s => s.Name.ToLower().StartsWith(Name.ToLower())).ToList();

		public string Insert(Supplier type)
		{
			throw new NotImplementedException();
		}

		public string Update(Supplier type, int Id)
		{
			throw new NotImplementedException();
		}
	}
}
