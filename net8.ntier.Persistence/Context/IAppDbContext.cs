using Microsoft.EntityFrameworkCore;
using net8.ntier.Persistence.Abstractions;
using net8.ntier.Persistence.Entities;

namespace net8.ntier.Persistence.Context
{
    public interface IAppDbContext : IPersistenceContext
    {
        DbSet<User> Users { get; set; }
        
    }
}
