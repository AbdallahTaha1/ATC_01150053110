using EMS.Domain.Abstractions.IRepositories;

namespace EMS.Domain.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IEventRepository Events { get; }

        IUserEventRepository UserEvents { get; }
        IUserRepository Users { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
