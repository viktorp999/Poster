using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Identity.Constrains;

namespace Poster.Infrastructure.Config.Entities.Identity.Constrains
{
    public class PremissionConfig : IEntityTypeConfiguration<Premission>
    {
        public void Configure(EntityTypeBuilder<Premission> builder)
        {
            builder.HasKey(pk => pk.Id).HasName("PKPremissions");
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
