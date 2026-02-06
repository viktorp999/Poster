using Poster.Core.Entities.Comments;
using Poster.Core.Entities.Identity;

namespace Poster.Core.Entities.Joins.Comments.Dislikes
{
    public class UserStandardPostCommentDislikes
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid StandardPostCommentId { get; set; }
        public StandardPostComment StandardPostComment { get; set; }
    }
}
