using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Identity.Constrains;

namespace Poster.Infrastructure.Config.Entities.Identity.Constrains
{
    public class UserRoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(k => new { k.UserId, k.RoleId });
            builder.ToTable("UserRoles");

            builder.HasOne(u => u.User)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(fk => fk.UserId);
            
            builder.HasOne(r => r.Role)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(fk => fk.RoleId);
        }
    }
}
