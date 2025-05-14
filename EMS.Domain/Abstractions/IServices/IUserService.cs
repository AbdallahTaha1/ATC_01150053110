using EMS.Domain.Entities;

namespace EMS.Domain.Abstractions.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<ApplicationUser>?> GetUsersAsync();
    }
}
