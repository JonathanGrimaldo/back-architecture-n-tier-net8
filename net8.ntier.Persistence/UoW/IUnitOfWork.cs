using net8.ntier.Persistence.Repositories.IRepositories;

namespace net8.ntier.Persistence.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        //Define entities repositories here
        IUserRepository Users { get; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
