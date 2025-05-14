using EMS.Domain.Abstractions;
using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;

namespace EMS.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ApplicationUser>?> GetUsersAsync()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }
    }
}
