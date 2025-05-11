using MoneyWiseLite.Domain.Entities;

namespace MoneyWiseLite.Domain.Interfaces;

public interface IService<T> where T : BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task<IEnumerable<T>> GetDeletedAsync();
    Task<IEnumerable<T>> GetAllPagedAsync(int pageNumber, int pageSize);
    Task<IEnumerable<T>> GetDeletedPagedAsync(int pageNumber, int pageSize);
}

