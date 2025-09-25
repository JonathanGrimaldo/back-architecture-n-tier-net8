using Microsoft.EntityFrameworkCore;
using net8.ntier.Domain.Entities;
using net8.ntier.Domain.Repositories;
using net8.ntier.Persistence.Context;

namespace net8.ntier.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IAppDbContext context) : base(context) {}
    }
}
