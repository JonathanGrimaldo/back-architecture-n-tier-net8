using net8.ntier.Domain.Repositories;

namespace net8.ntier.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        //Define entities repositories here
        IUserRepository Users { get; }


        Task<int> CommitChangesAsync(CancellationToken cancellationToken = default);
    }
}
