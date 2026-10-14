using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Media.Common.Abstractions;

namespace Poster.Domain.Entities.Media.Users
{
    public sealed class Avatar : BaseMedia
    {
        public Avatar() : base()
        {
        }

        public Avatar(string name, string path, string contentType, 
            Guid userId, User user = null)
            : base(name, path, contentType)
        {
            UserId = userId;
            User = user;
        }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
