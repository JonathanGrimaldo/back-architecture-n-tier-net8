using net8.ntier.Persistence.Entities;

namespace net8.ntier.Persistence.Repositories.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IEnumerable<User>> GetByName(string name, CancellationToken cancellationToken = default);
    }
}
