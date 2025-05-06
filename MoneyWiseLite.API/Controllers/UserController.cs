using Microsoft.AspNetCore.Mvc;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.API.Controllers;

[Route("api/[controller]")]
public class UserController(IUserService userService) : GenericController<User>(userService)
{
}
