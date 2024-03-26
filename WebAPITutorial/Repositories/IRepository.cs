using System.Linq.Expressions;

namespace WebAPITutorial.Repositories;

public interface IRepository<T> where T : class
{
	IEnumerable<T> GetAll();
	IEnumerable<T> Get(Expression<Func<T, bool>> expression);
	bool Add(T entity);
	bool AddRange(IEnumerable<T> entities);
	bool Remove(T entity);
	bool RemoveRange(IEnumerable<T> entities);
	Task<int> Save();
}
