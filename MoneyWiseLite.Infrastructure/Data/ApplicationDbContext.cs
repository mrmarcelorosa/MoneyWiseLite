using System.Transactions;
using Microsoft.EntityFrameworkCore;
using MoneyWiseLite.Domain.Entities;

namespace MoneyWiseLite.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Transaction> Transactions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker
            .Entries<BaseEntity>();

        var now = DateTime.UtcNow;

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = now;
                entry.Entity.LastUpdatedAt = now;
            }
            else if (entry.State == EntityState.Modified)
            {
                entry.Entity.LastUpdatedAt = now;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
