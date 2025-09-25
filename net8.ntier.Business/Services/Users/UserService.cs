using net8.ntier.Business.Services.Base;
using net8.ntier.Domain.Services;
using net8.ntier.Domain.Contracts;
using net8.ntier.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace net8.ntier.Business.Services.Users
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork.Users)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User?> GetByName(string name)
        {
            return await _unitOfWork.Users.GetQueryable().AsNoTracking().Where(x => x.Name.ToLower().Contains(name.ToLower())).FirstOrDefaultAsync();
        }

        public override async Task AddAsync(User entity, CancellationToken cancellation = default)
        {
            //Todo: possibly add some events, to commit only once in some operations
            await base.AddAsync(entity, cancellation);
            await _unitOfWork.CommitChangesAsync(cancellation);
        }

        public override void Update(User entity)
        {
            base.Update(entity);
            _unitOfWork.CommitChangesAsync();
        }

        public override void Delete(User entity)
        {
            base.Delete(entity);
            _unitOfWork.CommitChangesAsync();
        }
    }
}
