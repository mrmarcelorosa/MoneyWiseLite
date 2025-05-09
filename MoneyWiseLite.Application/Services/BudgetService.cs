using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.Application.Services;

public class BudgetService : GenericService<Budget>, IBudgetService
{
    private readonly IBudgetRepository _budgetRepository;
    public BudgetService(IBudgetRepository budgetRepository) : base(budgetRepository)
    {
        _budgetRepository = budgetRepository;
    }
}

