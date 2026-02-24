using Poster.Core.Entities.Comments;
using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Joins.Posts.Likes;
using Poster.Core.Entities.Joins.Posts.Saves;
using Poster.Core.Entities.Posts.Common.Abstractions;
using Poster.Core.Entities.Posts.Media;

namespace Poster.Core.Entities.Posts
{
    public sealed class VideoPost : Post
    {
        public VideoPost() : base()
        {
        }

        public VideoPost(Guid id, string title, string content, Guid userId, AppUser user = null, 
            Video video = null, IEnumerable<VideoPostComment> comments = null) 
            : base(id, title, content, userId, user)
        {
            Video = video;
            Comments = comments;
        }

        public Video Video { get; set; }
        public IEnumerable<VideoPostComment> Comments { get; set; }
        public IEnumerable<UserVideoPostLikes> Likes { get; set; }
        public IEnumerable<UserVideoPostSaves> Saves { get; set; }
    }
}
