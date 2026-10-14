using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Media.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Media.Common.Abstractions
{
    public abstract class BaseMediaConfig<TMedia> : IEntityTypeConfiguration<TMedia>
        where TMedia : BaseMedia
    {
        public virtual void Configure(EntityTypeBuilder<TMedia> builder)
        {
            builder.UseTpcMappingStrategy();
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.CreatedAt)
                .IsRequired();
            builder.Property(p => p.Path)
                .IsRequired();
            builder.Property(p => p.Name)
                .IsRequired();
            builder.Property(p => p.ContentType)
                .IsRequired();
            builder.Property(p => p.Size)
                .IsRequired();
        }
    }
}
