using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Posts;

namespace Poster.Core.Entities.Joins.Posts.Dislikes
{
    public class UserStandardPostDislikes
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
    }
}
