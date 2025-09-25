using net8.ntier.Domain.Contracts;
using net8.ntier.Domain.Entities;

namespace net8.ntier.Domain.Services
{
    public interface IUserService : IBaseService<User>
    {
        Task<User?> GetByName(string name);
    }
}
