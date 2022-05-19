using System.Collections.Generic;

namespace SinavSistemi.Common
{
    public interface IORM<T> where T : class
    {
        Result<T> GetByID(int id);
        Result<List<T>> Select();
        Result<bool> Insert(T entity);
        Result<bool> Update(T entity);
        Result<bool> Delete(T entity);
        Result<bool> AddRange(List<T> entities);
        Result<bool> RemoveRange(List<T> entities);
    }
}
