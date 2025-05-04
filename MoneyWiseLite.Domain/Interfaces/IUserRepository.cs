using MoneyWiseLite.Domain.Entities;

namespace MoneyWiseLite.Domain.Interfaces;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
}
