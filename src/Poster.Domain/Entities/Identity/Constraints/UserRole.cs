using Microsoft.AspNetCore.Identity;

namespace Poster.Domain.Entities.Identity.Constraints
{
    public sealed class UserRole : IdentityUserRole<Guid>
    {
        public User User { get; set; } = null!;
        public Role Role { get; set; } = null!;
    }
}
