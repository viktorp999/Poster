
namespace Poster.Core.Entities.Common.Abstractions
{
    public abstract class BaseEntity<TKey>
    {
        protected BaseEntity()
        {
            CreatedOn = DateTime.UtcNow;
        }

        protected BaseEntity(TKey id)
        {
            Id = id;
            CreatedOn = DateTime.UtcNow;
        }

        public TKey Id { get; set; }
        public DateTime CreatedOn { get; }
    }
}
