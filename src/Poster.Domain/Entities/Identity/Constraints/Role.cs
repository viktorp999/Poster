using Microsoft.AspNetCore.Identity;

namespace Poster.Domain.Entities.Identity.Constraints
{
    public sealed class Role : IdentityRole<Guid>
    {
        ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
