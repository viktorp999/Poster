using Poster.Domain.Entities.Comments.Common.Abstractions;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Comments
{
    public sealed class VideoPostComment : Comment
    {
        public VideoPostComment() : base()
        {
        }

        public VideoPostComment(string content, User user = null,
            VideoPost videoPost = null)
            : base(content, user)
        {
            VideoPost = videoPost;
        }

        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
