using Microsoft.AspNetCore.Identity;

namespace Poster.Domain.Entities.Identity.Constraints
{
    public sealed class Role : IdentityRole<Guid>
    {
        public Role() : base()
        {

        }

        public Role(string name)
            : base()
        {
            Name = name;
            NormalizedName = name.ToUpperInvariant();
        }

        public ICollection<UserRole> UserRoles { get; set; } = [];
        public ICollection<RolePermission> RolePremissions { get; set; } = [];
    }
}
