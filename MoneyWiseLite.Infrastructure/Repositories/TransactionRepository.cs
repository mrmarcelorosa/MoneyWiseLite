using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Enums;
using MoneyWiseLite.Domain.Interfaces;
using MoneyWiseLite.Infrastructure.Data;

namespace MoneyWiseLite.Infrastructure.Repositories;

public class TransactionRepository(ApplicationDbContext context) : GenericRepository<Transaction>(context), ITransactionRepository
{
    

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
