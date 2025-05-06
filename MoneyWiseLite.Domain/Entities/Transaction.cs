using System.ComponentModel.DataAnnotations;

namespace MoneyWiseLite.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public long CategoryId { get; set; }

        public Category? Category { get; set; }

        [Required]
        public long UserId { get; set; }

        public virtual User? User { get; set; }

        public string? Notes { get; set; }
    }
}
