using Poster.Application.Specifications.Common.Abstractions.Interfaces;
using Poster.Domain.Entities.Common.Abstractions;

namespace Poster.Application.Repositories.Common.Abstractions.Interfaces
{
    public interface IRepository<T> where T : BaseEntity<Guid>
    {
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
        Task<IEnumerable<T>> Get(ISpecification<T> spec, CancellationToken cancellationToken);
        Task<T> GetEntityWithSpec(ISpecification<T> spec, CancellationToken cancellationToken);
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
        Task<int> CountAsync(ISpecification<T> spec, CancellationToken cancellationToken);
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        Task Update(T entity);
        Task Delete(Guid id);
        Task DeleteRange(IEnumerable<T> entities);
    }
}
