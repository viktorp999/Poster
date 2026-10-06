using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Posts;

namespace Poster.Domain.Entities.Joins.Users
{
    public class VideoPostSaves
    {
        public Guid VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
