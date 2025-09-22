using Microsoft.EntityFrameworkCore;

namespace net8.ntier.Persistence.Abstractions
{
    public interface IPersistenceContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
