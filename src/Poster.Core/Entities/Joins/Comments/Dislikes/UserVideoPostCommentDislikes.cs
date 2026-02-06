using Poster.Core.Entities.Comments;
using Poster.Core.Entities.Identity;

namespace Poster.Core.Entities.Joins.Comments.Dislikes
{
    public class UserVideoPostCommentDislikes
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid VideoPostCommentId { get; set; }
        public VideoPostComment VideoPostComment { get; set; }
    }
}
