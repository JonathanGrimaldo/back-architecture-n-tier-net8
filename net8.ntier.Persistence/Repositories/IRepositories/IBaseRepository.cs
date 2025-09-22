namespace net8.ntier.Persistence.Repositories.IRepositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        void UpdateAsync(TEntity entity);
        void DeleteAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
        void DeleteRangeAsync(IEnumerable<TEntity> entities);
    }
}
