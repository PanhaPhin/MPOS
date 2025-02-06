using MPOS.Database;
using MPOS.Services;
using System.Collections.Generic;
using System.Linq;

namespace MPOS.Entities
{
	public class EmployeeConnection : GetByOperation<Employee>, ICrudService<Employee>
	{
		DbDataContext dbDataContext = new DbDataContext();
		public List<getTopEmployeesResult> getTopEmployees() => dbDataContext.getTopEmployees().ToList();

		public string Delete(int Id)
		{
			throw new System.NotImplementedException();
		}

		public List<Employee> GetAll() => dbDataContext.Employees.ToList();


		public string Insert(Employee type)
		{
			throw new System.NotImplementedException();
		}

		public string Update(Employee type, int Id)
		{
			throw new System.NotImplementedException();
		}

		public override Employee GetById(int Id) => dbDataContext.Employees.FirstOrDefault(e => e.Id == Id);

		public override List<Employee> GetByName(string Name) => dbDataContext.Employees.Where(e => e.Name.ToLower().StartsWith(Name.ToLower())).ToList();
	}
}
