using Microsoft.AspNetCore.Identity;
using Poster.Domain.Entities.Identity;

namespace Poster.Domain.Entities.Identity.Constrains
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public AppUser User { get; set; }
        public Role Role { get; set; }
    }
}
