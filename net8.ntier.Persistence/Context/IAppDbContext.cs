using Microsoft.EntityFrameworkCore;
using net8.ntier.Domain.Entities;

namespace net8.ntier.Persistence.Context
{
    public interface IAppDbContext : IDisposable
    {
        // Define DbSets for your entities here
        DbSet<User> Users { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
