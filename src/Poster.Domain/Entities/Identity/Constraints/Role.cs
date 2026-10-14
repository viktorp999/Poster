using Microsoft.AspNetCore.Identity;

namespace Poster.Domain.Entities.Identity.Constraints
{
    public sealed class Role : IdentityRole<Guid>
    {
       public ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
