using EMS.Domain.Abstractions.IRepositories;

namespace EMS.Domain.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IEventRepository Events { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
