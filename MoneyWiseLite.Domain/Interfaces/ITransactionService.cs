using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Enums;

namespace MoneyWiseLite.Domain.Interfaces;

public interface ITransactionService : IService<Transaction>
{
    Task<IEnumerable<Transaction>> GetTransactionsByCategoryIdAsync(int categoryId);
    Task<IEnumerable<Transaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<IEnumerable<Transaction>> GetTransactionsByTypeAsync(TransactionType type);
    Task<IEnumerable<Transaction>> GetTransactionsByAmountRangeAsync(decimal minAmount, decimal maxAmount);
}

