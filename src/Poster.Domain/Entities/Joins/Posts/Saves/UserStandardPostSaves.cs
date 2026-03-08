using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Joins.Posts.Saves
{
    public class UserStandardPostSaves
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
    }
}
