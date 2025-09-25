using Microsoft.EntityFrameworkCore;
using net8.ntier.Domain.Contracts;
using net8.ntier.Persistence.Context;

namespace net8.ntier.Persistence.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly IAppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository(IAppDbContext context)
        {
            _context = context;
            var dbContext = (DbContext)_context;
            _dbSet = dbContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetQueryable()
        {
            return _dbSet;
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        }

        public virtual async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddRangeAsync(entities, cancellationToken);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
