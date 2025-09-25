using net8.ntier.Domain.Contracts;
using net8.ntier.Domain.Repositories;
using net8.ntier.Persistence.Context;

namespace net8.ntier.Persistence.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IAppDbContext _context;

        //Add repositories as you need
        public IUserRepository Users { get; }


        public UnitOfWork(
            IAppDbContext context, 
            IUserRepository userRepository)
        {
            _context = context;
            Users = userRepository;
        }

        public async Task<int> CommitChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
