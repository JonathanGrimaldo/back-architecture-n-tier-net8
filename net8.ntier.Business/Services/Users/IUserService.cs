using net8.ntier.Persistence.Entities;

namespace net8.ntier.Business.Services.Users
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
