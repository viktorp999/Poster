using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Joins.Posts.Saves
{
    public class UserVideoPostSaves
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
