using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Media.Common.Abstractions;

namespace Poster.Domain.Entities.Media.Users
{
    public sealed class Avatar : BaseMedia
    {
        public Avatar() : base()
        {
        }

        public Avatar(string path, User user = null)
            : base(path)
        {
            User = user;
        }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
