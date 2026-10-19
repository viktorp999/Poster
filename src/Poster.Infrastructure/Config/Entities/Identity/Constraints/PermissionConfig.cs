using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Identity.Constraints;

namespace Poster.Infrastructure.Config.Entities.Identity.Constraints
{
    public class PermissionConfig : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(k => k.Id).HasName("PKPermissions");
            builder.HasIndex(i => i.Name).IsUnique().IsClustered(false).HasDatabaseName("IXPermissionName");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(256);
        }
    }
}
