using MPOS.Database;
using System.Collections.Generic;
using System.Linq;

namespace MPOS.Entities
{
	public interface IData
	{
		DbDataContext context { get; }
	}

	public class GetProduct : IData
	{
		public DbDataContext context => new DbDataContext();

		protected List<getProductsResult> GetProducts() => context.getProducts().ToList();
	}
}
