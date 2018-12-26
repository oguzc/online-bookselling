using System.Collections.Generic;

namespace OnlineBookselling.Repositories
{
    public interface IRepository<T, K>
    {
        List<T> GetAll();
        T GetById(K id);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}