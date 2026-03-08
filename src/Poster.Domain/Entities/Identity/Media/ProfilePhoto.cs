using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Media.Common.Abstractions;

namespace Poster.Domain.Entities.Identity.Media
{
    public sealed class ProfilePhoto : BaseMedia
    {
        public ProfilePhoto() : base()
        {
        }

        public ProfilePhoto(Guid id, string path, Guid userId, 
            AppUser user = null) 
            : base(id, path)
        {
            UserId = userId;
            User = user;
        }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
