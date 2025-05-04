using Microsoft.EntityFrameworkCore;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;
using MoneyWiseLite.Infrastructure.Data;

namespace MoneyWiseLite.Infrastructure.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
    }
}
