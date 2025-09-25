using net8.ntier.Domain.Entities;

namespace net8.ntier.Business.Services.Users
{
    public interface IUserService
    {
        Task<User?> GetByName(string name);
        Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
