using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Joins.Users;
using Poster.Domain.Entities.Media.Posts;
using Poster.Domain.Entities.Posts.Common.Abstractions;
using Poster.Domain.Enums.Posts;

namespace Poster.Domain.Entities.Posts
{
    public sealed class StandardPost : Post
    {
        public StandardPost() : base()
        { 
        }

        public StandardPost(string title, string content, PostCategory category, User user = null,
            IEnumerable<Image> images = null, IEnumerable<StandardPostComment> comments = null) 
            : base(title, content, category, user)
        {
            Images = images;
            Comments = comments;
        }

        public IEnumerable<Image> Images { get; set; }
        public IEnumerable<StandardPostComment> Comments { get; set; }
        public IEnumerable<StandardPostLikes> Likes { get; set; }
        public IEnumerable<StandardPostSaves> Saves { get; set; }
    }
}
