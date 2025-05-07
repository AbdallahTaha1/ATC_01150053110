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

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Events = new EventRepository(context);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            await _context.SaveChangesAsync();

        public void Dispose() =>
            _context.Dispose();
    }
}
