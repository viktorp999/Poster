using Microsoft.EntityFrameworkCore;
using Poster.Application.Repositories.Common.Abstractions.Interfaces;
using Poster.Domain.Entities.Common.Abstractions;
using Poster.Infrastructure.Persistance.Common.Interfaces;
using Poster.Infrastructure.Persistance.Repositories.Common.Abstractions;
using System.Collections;

namespace Poster.Infrastructure.Persistance.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private Hashtable _repositories;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IRepository<T> Repository<T>() where T : BaseEntity<Guid>
        {
            _repositories ??= [];

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(BaseRepository<>);

                var repositoryInstance =
                    Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }

        public async Task<int> Complete(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
