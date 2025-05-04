using MoneyWiseLite.Domain.Entities;

namespace MoneyWiseLite.Domain.Interfaces;

public interface IUserService : IService<User>
{
    Task<User?> GetUserByEmailAsync(string email);
    Task<bool> CheckUserExistsAsync(string email);
}
