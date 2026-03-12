using Poster.Application.Repositories.Common.Abstractions.Interfaces;
using Poster.Domain.Entities.Common.Abstractions;

namespace Poster.Infrastructure.Persistance.Common.Interfaces
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> Repository<T>() where T : BaseEntity<Guid>;
        Task<int> Complete(CancellationToken cancellationToken = default);
    }
}
