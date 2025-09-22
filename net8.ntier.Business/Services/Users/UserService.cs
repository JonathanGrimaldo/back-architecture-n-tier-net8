using net8.ntier.Persistence.Entities;
using net8.ntier.Persistence.UoW;

namespace net8.ntier.Business.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.Users.GetAllAsync(cancellationToken);
        }

        public async Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.Users.GetByIdAsync(id, cancellationToken);
        }
    }
}
