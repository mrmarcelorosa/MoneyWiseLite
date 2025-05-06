using MoneyWiseLite.Domain.Entities;

namespace MoneyWiseLite.Domain.Interfaces;

public interface ICategoryRepository : IRepository<Category>
{
    Task<IEnumerable<Category>> GetCategoriesByUserIdAsync(int userId);
}
