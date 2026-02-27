using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Identity.Constrains;

namespace Poster.Infrastructure.Config.Entities.Identity.Constrains
{
    public class RolePremissionConfig : IEntityTypeConfiguration<RolePremission>
    {
        public void Configure(EntityTypeBuilder<RolePremission> builder)
        {
            builder.HasKey(k => new { k.RoleId, k.PremissionId });

            builder.HasOne(r => r.Role)
                .WithMany(rp => rp.RolePremissions)
                .HasForeignKey(fk => fk.RoleId);

            builder.HasOne(p => p.Premission)
                .WithMany(rp => rp.RolePremissions)
                .HasForeignKey(fk => fk.PremissionId);
        }
    }
}
