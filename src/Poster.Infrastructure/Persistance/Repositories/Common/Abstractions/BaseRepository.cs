using Microsoft.EntityFrameworkCore;
using Poster.Application.Repositories.Common.Abstractions.Interfaces;
using Poster.Application.Specifications.Common.Abstractions.Interfaces;
using Poster.Domain.Entities.Common.Abstractions;

namespace Poster.Infrastructure.Persistance.Repositories.Common.Abstractions
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity<Guid>
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken = default)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<T>> Get(ISpecification<T> spec, 
            CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(spec).ToListAsync(cancellationToken);
        }

        public async Task<T> GetEntityWithSpec(ISpecification<T> spec, 
            CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<T> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync([id], cancellationToken);
        }

        public async Task<int> CountAsync(ISpecification<T> spec, 
            CancellationToken cancellationToken = default)
        {
            return await ApplySpecification(spec).CountAsync(cancellationToken);
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public Task Update(T entity)
        {
            _dbSet.Update(entity);

            return Task.CompletedTask;
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            
            _dbSet.Remove(entity);
        }

        public Task DeleteRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);

            return Task.CompletedTask;
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), spec);
        }
    }
}
