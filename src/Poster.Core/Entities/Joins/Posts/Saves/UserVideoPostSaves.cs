using Poster.Core.Entities.Identity;
using Poster.Core.Entities.Posts;

namespace Poster.Core.Entities.Joins.Posts.Saves
{
    public class UserVideoPostSaves
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
