using MoneyWiseLite.Domain.Enums;

namespace MoneyWiseLite.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public TransactionType TransactionType { get; set; }
    public long UserId { get; set; }
    public virtual User? User { get; set; }
}
