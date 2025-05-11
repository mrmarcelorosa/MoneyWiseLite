using Microsoft.EntityFrameworkCore;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;
using MoneyWiseLite.Infrastructure.Data;

namespace MoneyWiseLite.Infrastructure.Repositories;

public class GenericRepository<T> : IRepository<T> where T : BaseEntity
{

    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet
            .Where(e => e.DeletedAt == null)
            .ToListAsync();
    }

    public async Task<T?> GetByIdAsync(long id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        _dbSet.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(long id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            entity.DeletedAt = DateTime.UtcNow;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<T>> GetDeletedAsync()
    {
        return await _dbSet
            .IgnoreQueryFilters()
            .Where(e => e.DeletedAt != null)
            .ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllPagedAsync(int pageNumber, int pageSize)
    {
        return await _dbSet
            .Where(e => e.DeletedAt == null)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IEnumerable<T>> GetDeletedPagedAsync(int pageNumber, int pageSize)
    {
        return await _dbSet
            .IgnoreQueryFilters()
            .Where(e => e.DeletedAt != null)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}
