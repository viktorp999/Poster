using Microsoft.AspNetCore.Identity;

namespace Poster.Domain.Entities.Identity.Constraints
{
    public sealed class UserRole : IdentityUserRole<Guid>
    {
        User User { get; set; } = null!;
        Role Role { get; set; } = null!;
    }
}
