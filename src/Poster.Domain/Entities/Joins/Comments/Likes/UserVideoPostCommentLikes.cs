using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity;

namespace Poster.Domain.Entities.Joins.Comments.Likes
{
    public class UserVideoPostCommentLikes
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid VideoPostCommentId { get; set; }
        public VideoPostComment VideoPostComment { get; set; }
    }
}
