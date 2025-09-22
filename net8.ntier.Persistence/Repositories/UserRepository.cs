using Microsoft.EntityFrameworkCore;
using net8.ntier.Persistence.Context;
using net8.ntier.Persistence.Entities;
using net8.ntier.Persistence.Repositories.IRepositories;

namespace net8.ntier.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IAppDbContext _context;
        public UserRepository(IAppDbContext context) : base(context)
        {
            _context = context;
        }

        //Example of custom method, you can add your own methods here or even not use GenericRepository at all
        public async Task<IEnumerable<User>> GetByName(string name, CancellationToken cancellationToken = default)
        {
            return await _context.Set<User>().AsNoTracking().Where(x => x.Name.ToLower().Contains(name.ToLower())).ToListAsync(cancellationToken);
        }
    }
}
