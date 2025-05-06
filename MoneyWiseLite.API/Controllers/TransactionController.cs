using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.API.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
public class TransactionController(ITransactionService transactionService): GenericController<Transaction>(transactionService)
{

}
