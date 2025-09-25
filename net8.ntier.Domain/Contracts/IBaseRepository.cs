namespace net8.ntier.Domain.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetQueryable(); //made that is create an anti-pattern todo: add params
        Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
