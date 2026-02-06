using Poster.Core.Entities.Comments.Common.Abstractions;
using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Posts;

namespace Poster.Core.Entities.Comments
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
    }
}
