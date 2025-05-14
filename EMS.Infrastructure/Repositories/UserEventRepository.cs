using EMS.Domain.Abstractions.IRepositories;
using EMS.Domain.Entities;
using EMS.Infrastructure.Persistence;

namespace EMS.Infrastructure.Repositories
{
    public class UserEventRepository : BaseRepository<UserBookedEvent>, IUserEventRepository
    {
        public UserEventRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
