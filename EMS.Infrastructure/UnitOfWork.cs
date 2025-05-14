using EMS.Domain.Abstractions;
using EMS.Domain.Abstractions.IRepositories;
using EMS.Infrastructure.Persistence;
using EMS.Infrastructure.Repositories;

namespace EMS.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IEventRepository Events { get; private set; }
        public IUserEventRepository UserEvents { get; private set; }
        public IUserRepository Users { get; private set; }

        public UnitOfWork(ApplicationDbContext context, IUserEventRepository userEvents, IUserRepository users)
        {
            _context = context;

            Events = new EventRepository(context);
            UserEvents = userEvents;
            Users = users;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            await _context.SaveChangesAsync();

        public void Dispose() =>
            _context.Dispose();
    }
}
