using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity;

namespace Poster.Domain.Entities.Joins.Comments.Likes
{
    public class UserStandardPostCommentLikes
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; } 
        public Guid StandardPostCommentId { get; set; }
        public StandardPostComment StandardPostComment { get; set; }
    }
}
