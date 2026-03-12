using Poster.Domain.Entities.Common.Abstractions;
using System.Linq.Expressions;

namespace Poster.Application.Specifications.Common.Abstractions.Interfaces
{
    public interface ISpecification<T> where T : BaseEntity<Guid>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
        bool IsSplitQuery { get; }
        bool IsAsNoTracking { get; }
    }
}
