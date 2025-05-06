using Microsoft.EntityFrameworkCore;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;
using MoneyWiseLite.Infrastructure.Data;

namespace MoneyWiseLite.Infrastructure.Repositories;

public class CategoryRepository(ApplicationDbContext context) : GenericRepository<Category>(context), ICategoryRepository
{

    public async Task<IEnumerable<Category>> GetCategoriesByUserIdAsync(int userId)
    {
        return await _dbSet.Where(c => c.UserId == userId).ToListAsync();
    }
}
