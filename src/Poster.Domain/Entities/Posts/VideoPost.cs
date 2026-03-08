using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Joins.Posts.Likes;
using Poster.Domain.Entities.Joins.Posts.Saves;
using Poster.Domain.Entities.Posts.Common.Abstractions;
using Poster.Domain.Entities.Posts.Media;

namespace Poster.Domain.Entities.Posts
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
