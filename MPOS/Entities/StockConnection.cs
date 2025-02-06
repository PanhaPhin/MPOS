using MPOS.Database;
using System.Collections.Generic;
using System.Linq;

namespace MPOS.Entities
{
	public class StockConnection
	{
		DbDataContext dbDataContext = new DbDataContext();
		public List<getProductInStockResult> ProductsInStock() => dbDataContext.getProductInStock().ToList();
		public List<getInStockResult> getInStocks() => dbDataContext.getInStock().ToList();
		public List<getOutStockResult> getOutStocks() => dbDataContext.getOutStock().ToList();
	}
}
