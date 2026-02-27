using Microsoft.AspNetCore.Identity;

namespace Poster.Core.Entities.Identity.Constrains
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public AppUser User { get; set; }
        public Role Role { get; set; }
    }
}
