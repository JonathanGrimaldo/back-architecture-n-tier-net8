using Microsoft.EntityFrameworkCore;
using net8.ntier.Domain.Entities;
using net8.ntier.Domain.Repositories;
using net8.ntier.Persistence.Context;

namespace net8.ntier.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IAppDbContext context) : base(context)
        {
        }


        //Example of custom method, you can add your own methods here or even not use GenericRepository at all
        public async Task<IEnumerable<User>> GetByName(string name, CancellationToken cancellationToken = default)
        {
            return await GetQueryable().AsNoTracking().Where(u => u.Name.ToLower().Contains(name.ToLower())).ToListAsync(cancellationToken);
        }
    }
}
