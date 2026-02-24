using Poster.Core.Entities.Comments.Common.Abstractions;
using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Joins.Comments.Likes;
using Poster.Core.Entities.Posts;

namespace Poster.Core.Entities.Comments
{
    public sealed class VideoPostComment : Comment
    {
        public VideoPostComment() : base()
        {
        }

        public VideoPostComment(Guid id, string content, Guid userId, Guid videoPostId, 
            AppUser user = null, VideoPost videoPost = null) 
            : base(id, content, userId, user)
        {
                VideoPostId = videoPostId;
                VideoPost = videoPost;
        }

        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
        public IEnumerable<UserVideoPostCommentLikes> Likes { get; set; }
    }
}
