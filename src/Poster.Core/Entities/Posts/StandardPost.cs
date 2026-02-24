using Poster.Core.Entities.Comments;
using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Joins.Posts.Likes;
using Poster.Core.Entities.Joins.Posts.Saves;
using Poster.Core.Entities.Posts.Common.Abstractions;
using Poster.Core.Entities.Posts.Media;

namespace Poster.Core.Entities.Posts
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
