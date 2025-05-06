using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Enums;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.Application.Services;

public class TransactionService(ITransactionRepository transactionRepository) : GenericService<Transaction>(transactionRepository), ITransactionService
{
    private readonly ITransactionRepository _transactionRepository = transactionRepository;

    public Task<IEnumerable<Transaction>> GetTransactionsByAmountRangeAsync(decimal minAmount, decimal maxAmount)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Transaction>> GetTransactionsByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Transaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Transaction>> GetTransactionsByTypeAsync(TransactionType type)
    {
        throw new NotImplementedException();
    }
}

