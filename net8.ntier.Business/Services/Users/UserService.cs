using net8.ntier.Domain.Contracts;
using net8.ntier.Domain.Entities;

namespace net8.ntier.Business.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<User?> GetByName(string name)
        {
            return _unitOfWork.Users.GetQueryable().Where(x => x.Name == name).FirstOrDefault();
        }

        public async Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.Users.GetByIdAsync(id, cancellationToken);
        }
    }
}
