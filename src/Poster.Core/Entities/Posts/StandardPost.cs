using Poster.Core.Entities.Comments;
using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Posts.Common.Abstractions;
using Poster.Core.Entities.Posts.Media;

namespace Poster.Core.Entities.Posts
{
    public sealed class StandardPost : Post
    {
        public StandardPost() : base()
        {
        }

        public StandardPost(Guid id, string title, string content, Guid userId,
            bool isSensitive = false, AppUser user = null, 
            IEnumerable<Image> images = null, IEnumerable<StandardPostComment> comments = null) 
            : base(id, title, content, userId, isSensitive, user)
        {
            Images = images;
            Comments = comments;
        }

        public IEnumerable<Image> Images { get; set; }
        public IEnumerable<StandardPostComment> Comments { get; set; }
    }
}
