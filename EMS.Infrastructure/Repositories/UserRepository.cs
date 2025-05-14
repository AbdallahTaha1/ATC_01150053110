using EMS.Domain.Abstractions.IRepositories;
using EMS.Domain.Entities;
using EMS.Infrastructure.Persistence;

namespace EMS.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
