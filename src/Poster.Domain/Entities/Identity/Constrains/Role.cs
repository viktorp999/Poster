using Microsoft.AspNetCore.Identity;

namespace Poster.Domain.Entities.Identity.Constrains
{
    public class Role : IdentityRole<Guid>
    {
        public ICollection<RolePremission> RolePremissions { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
