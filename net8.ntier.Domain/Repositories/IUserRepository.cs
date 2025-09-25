using net8.ntier.Domain.Contracts;
using net8.ntier.Domain.Entities;

namespace net8.ntier.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IEnumerable<User>> GetByName(string name, CancellationToken cancellationToken = default);
    }
}
