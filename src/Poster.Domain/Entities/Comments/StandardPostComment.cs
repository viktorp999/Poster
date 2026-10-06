using Poster.Domain.Entities.Comments.Common.Abstractions;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Comments
{
    public sealed class StandardPostComment : Comment
    {
        public StandardPostComment() : base()
        {
        }

        public StandardPostComment(string content, User user = null,
            StandardPost standardPost = null) 
            : base(content, user)
        {
            StandardPost = standardPost;
        }

        public Guid StandardPostId { get; set; }
        public StandardPost StandardPost { get; set; }
    }
}
