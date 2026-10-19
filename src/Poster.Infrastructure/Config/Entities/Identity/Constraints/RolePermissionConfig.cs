using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Identity.Constraints;

namespace Poster.Infrastructure.Config.Entities.Identity.Constraints
{
    public class RolePermissionConfig : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.HasKey(k => new 
            { 
                k.RoleId, 
                k.PermissionId
            })
                .HasName("PKRolePermissions");

            builder.HasOne(r => r.Role)
                .WithMany(rp => rp.RolePremissions)
                .HasForeignKey(fk => fk.RoleId)
                .HasConstraintName("FKRolePermissionsRoleId")
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Permission)
                .WithMany(rp => rp.RolePermissions)
                .HasForeignKey(fk => fk.PermissionId)
                .HasConstraintName("FKRolePermissionsPermissionId")
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
