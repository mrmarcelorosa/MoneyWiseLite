namespace MoneyWiseLite.Domain.Entities;

public class Budget: BaseEntity
{
    public decimal Amount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public long UserId { get; set; }
    public virtual User? User { get; set; }
    
}
