using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Joins.Users
{
    public class StandardPostSaves
    {
        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
