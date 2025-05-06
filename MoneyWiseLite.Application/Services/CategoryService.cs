using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository) : GenericService<Category>(categoryRepository), ICategoryService
{
    private readonly ICategoryRepository _categoryRepository = categoryRepository;

    public async Task<IEnumerable<Category>> GetCategoriesByUserIdAsync(int userId)
    {
        return await _categoryRepository.GetCategoriesByUserIdAsync(userId);
    }
}

