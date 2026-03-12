using Poster.Application.Specifications.Common.Abstractions.Interfaces;
using Poster.Domain.Entities.Common.Abstractions;
using System.Linq.Expressions;

namespace Poster.Application.Specifications.Common.Abstractions
{
    public abstract class BaseSpecification<T> : ISpecification<T> where T : BaseEntity<Guid>
    {
        protected BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        protected BaseSpecification() 
        {

        }

        public Expression<Func<T, bool>> Criteria { get; }
        public List<Expression<Func<T, object>>> Includes { get; } = new();
        public Expression<Func<T, object>> OrderBy { get; private set; }
        public Expression<Func<T, object>> OrderByDescending { get; private set; }
        public int Take { get; private set; }
        public int Skip { get; private set; }
        public bool IsPagingEnabled { get; private set; }
        public bool IsSplitQuery { get; protected set; }
        public bool IsAsNoTracking { get; protected set; }

        protected void AddInclude(Expression<Func<T, object>> include)
        {
            Includes.Add(include);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderBy)
        {
            OrderBy = orderBy;
        }

        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDesc)
        {
            OrderByDescending = orderByDesc;
        }

        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}
