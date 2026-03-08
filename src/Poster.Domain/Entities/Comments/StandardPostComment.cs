using Poster.Domain.Entities.Comments.Common.Abstractions;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Joins.Comments.Likes;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Comments
{
    public sealed class StandardPostComment : Comment
    {
        public StandardPostComment() : base()
        {
        }

        public StandardPostComment(Guid id, string content, Guid userId, Guid standardPostId, 
            AppUser user = null, StandardPost standardPost = null) 
            : base(id, content, userId, user)
        {
                StandardPostId = standardPostId;
                StandardPost = standardPost;
        }

        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
        public IEnumerable<UserStandardPostCommentLikes> Likes { get; set; }
    }
}
