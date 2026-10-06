using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Joins.Users;
using Poster.Domain.Entities.Media.Posts;
using Poster.Domain.Entities.Posts.Common.Abstractions;
using Poster.Domain.Enums.Posts;

namespace Poster.Domain.Entities.Posts
{
    public sealed class VideoPost : Post
    {
        public VideoPost() : base()
        { 
        }

        public VideoPost(string title, string content, PostCategory category, User user = null,
            Video video = null, IEnumerable<VideoPostComment> comments = null) 
            : base(title, content, category, user)
        {
            Video = video;
            Comments = comments;
        }

        public Video Video { get; set; }
        public IEnumerable<VideoPostComment> Comments { get; set; }
        public IEnumerable<VideoPostLikes> Likes { get; set; }
        public IEnumerable<VideoPostSaves> Saves { get; set; }
    }
}
