
namespace Poster.Domain.Entities.Common.Abstractions
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.CreateVersion7();
            CreatedAt = DateTime.UtcNow.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        public Guid Id { get; private init; }
        public string CreatedAt { get; private init; }
    }
}
