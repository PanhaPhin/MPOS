using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPOS.DTOs
{
	public class ProductDtos
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public double CostPrice { get; set; }
	}
}
