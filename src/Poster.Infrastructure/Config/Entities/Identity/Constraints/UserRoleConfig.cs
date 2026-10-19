using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Identity.Constraints;

namespace Poster.Infrastructure.Config.Entities.Identity.Constraints
{
    public class UserRoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(k => new
            {
                k.UserId,
                k.RoleId
            })
                .HasName("PKUserRoles");

            builder.HasOne(r => r.Role)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(fk => fk.RoleId)
                .HasConstraintName("FKUserRoleRoleId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.User)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKUserRoleUserId")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
