using Microsoft.AspNetCore.Identity;

namespace Poster.Core.Entities.Identity.Constrains
{
    public class Role : IdentityRole<Guid>
    {
        public ICollection<RolePremission> RolePremissions { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
