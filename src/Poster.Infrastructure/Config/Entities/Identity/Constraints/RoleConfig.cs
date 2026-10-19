using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Identity.Constraints;

namespace Poster.Infrastructure.Config.Entities.Identity.Constraints
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(k => k.Id).HasName("PKRoles");
            builder.Property(p => p.Name).IsRequired();
            builder.HasMany(ur => ur.UserRoles)
                .WithOne(r => r.Role)
                .HasForeignKey(fk => fk.RoleId)
                .IsRequired();
        }
    }
}
