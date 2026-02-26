using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Media.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Media.Common.Abstractions
{
    public abstract class BaseMediaConfig<TBaseMedia> : IEntityTypeConfiguration<TBaseMedia>
         where TBaseMedia : BaseMedia
    {
        public virtual void Configure(EntityTypeBuilder<TBaseMedia> builder)
        {
            builder.UseTpcMappingStrategy();
            builder.HasKey(pk => pk.Id).HasName($"PK{nameof(TBaseMedia)}s");
            builder.Property(p => p.CreatedOn).IsRequired();
            builder.Property(p => p.Path).IsRequired();
        }
    }
}
