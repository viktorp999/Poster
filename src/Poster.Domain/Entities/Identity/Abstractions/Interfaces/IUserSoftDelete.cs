
namespace Poster.Domain.Entities.Identity.Abstractions.Interfaces
{
    public interface IUserSoftDelete
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
