using net8.ntier.Persistence.Context;
using net8.ntier.Persistence.Repositories;
using net8.ntier.Persistence.Repositories.IRepositories;

namespace net8.ntier.Persistence.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IAppDbContext _context;
        public IUserRepository Users { get; private set; }



        public UnitOfWork(IAppDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
