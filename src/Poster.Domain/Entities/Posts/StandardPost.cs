using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Joins.Posts.Likes;
using Poster.Domain.Entities.Joins.Posts.Saves;
using Poster.Domain.Entities.Posts.Common.Abstractions;
using Poster.Domain.Entities.Posts.Media;

namespace Poster.Domain.Entities.Posts
{
    public sealed class StandardPost : Post
    {
        public StandardPost() : base()
        {
        }

        public StandardPost(Guid id, string title, string content, Guid userId, AppUser user = null, 
            IEnumerable<Image> images = null, IEnumerable<StandardPostComment> comments = null) 
            : base(id, title, content, userId, user)
        {
            Images = images;
            Comments = comments;
        }

        public IEnumerable<Image> Images { get; set; }
        public IEnumerable<StandardPostComment> Comments { get; set; }
        public IEnumerable<UserStandardPostLikes> Likes { get; set; }
        public IEnumerable<UserStandardPostSaves> Saves { get; set; }
    }
}
