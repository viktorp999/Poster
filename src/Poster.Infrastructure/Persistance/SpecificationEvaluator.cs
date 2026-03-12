using Microsoft.EntityFrameworkCore;
using Poster.Application.Specifications.Common.Abstractions.Interfaces;
using Poster.Domain.Entities.Common.Abstractions;

namespace Poster.Infrastructure.Persistance
{
    internal sealed class SpecificationEvaluator<T> where T : BaseEntity<Guid>
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery,
        ISpecification<T> spec)
        {
            var query = inputQuery;

            if (spec.Criteria is not null)
                query = query.Where(spec.Criteria);

            if (spec.OrderBy is not null)
                query = query.OrderBy(spec.OrderBy);

            if (spec.OrderByDescending is not null)
                query = query.OrderByDescending(spec.OrderByDescending);

            if (spec.IsPagingEnabled)
                query = query.Skip(spec.Skip).Take(spec.Take);

            if (spec.IsSplitQuery)
                query = query.AsSplitQuery();

            if (spec.IsAsNoTracking)
                query = query.AsNoTracking();

            query = spec.Includes.Aggregate(query,
                (current, include) => current.Include(include));

            return query;
        }
    }
}
