using System.Collections.Generic;

namespace MPOS.Services
{
	// interface
	public interface ICrudService<T>
	{
		List<T> GetAll();
		string Insert(T type);
		string Update(T type, int Id);
		string Delete(int Id);
	}

	// abstraction 
	public abstract class GetByOperation<T>
{
		//public abstract List<T> GetAll();
		//public abstract string Insert(T type);
		//public abstract string Update(T type, int Id);
		//public abstract string Delete(int Id);
		public abstract T GetById(int Id);
		public abstract List<T> GetByName(string Name);
	}
}
