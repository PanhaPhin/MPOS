using MPOS.Database;
using MPOS.Services;
using System.Collections.Generic;
using System.Linq;

namespace MPOS.Entities
{
	public class SettingConnection : GetByOperation<User>, ICrudService<User>
	{
		private DbDataContext dataContext = new DbDataContext();
		public string Delete(int Id)
		{
			throw new System.NotImplementedException();
		}

		public List<User> GetAll()
		{
			throw new System.NotImplementedException();
		}

		public override User GetById(int Id) => dataContext.Users.FirstOrDefault(u => u.UserId == Id);

		public override List<User> GetByName(string Name) => dataContext.Users.Where(u => u.Username.ToLower().StartsWith(Name.ToLower())).ToList();

		public string Insert(User type)
		{
			var user = dataContext.Users.FirstOrDefault(u => u.Username == type.Username);
			if (user == null)
			{
				dataContext.Users.InsertOnSubmit(type);
				dataContext.SubmitChanges();
				return "Add 1 row.";
			}
			else
				return "User Duplicated.";
		}

		public string Update(User type, int Id)
		{
			throw new System.NotImplementedException();
		}
	}
}
