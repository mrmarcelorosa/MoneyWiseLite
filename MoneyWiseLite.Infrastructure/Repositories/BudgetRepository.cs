using Microsoft.EntityFrameworkCore;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;
using MoneyWiseLite.Infrastructure.Data;

namespace MoneyWiseLite.Infrastructure.Repositories;

public class BudgetRepository(ApplicationDbContext context) : GenericRepository<Budget>(context), IBudgetRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Budget?> GetBudgetByUserIdAsync(long userId)
    {
        return await _context.Budgets
            .FirstOrDefaultAsync(b => b.UserId == userId);
    }
}

