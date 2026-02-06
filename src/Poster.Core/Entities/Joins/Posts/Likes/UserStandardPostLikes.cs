using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Posts;

namespace Poster.Core.Entities.Joins.Posts.Likes
{
    public class UserStandardPostLikes
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
    }
}
