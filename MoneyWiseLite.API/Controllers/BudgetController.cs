using Microsoft.AspNetCore.Components;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.API.Controllers;

[Route("api/[controller]")]
public class BudgetController(IBudgetService budgetService) :GenericController<Budget>(budgetService)
{
}
