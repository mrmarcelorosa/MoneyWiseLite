using MoneyWiseLite.Domain.Entities;

namespace MoneyWiseLite.Domain.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(long id);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(long id);
    Task<IEnumerable<T>> GetDeletedAsync();

    Task <IEnumerable<T>> GetAllPagedAsync(int pageNumber, int pageSize);
    Task<IEnumerable<T>> GetDeletedPagedAsync(int pageNumber, int pageSize);

}

