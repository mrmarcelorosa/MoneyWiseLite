using MoneyWiseLite.Domain.Entities;

namespace MoneyWiseLite.Domain.Interfaces;

public interface ICategoryService : IService<Category>
{
    Task<IEnumerable<Category>> GetCategoriesByUserIdAsync(int userId);
}
