using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.Application.Services
{
    public class UserService(IUserRepository userRepository) : GenericService<User>(userRepository), IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;

        public Task<bool> CheckUserExistsAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

    }
}
