using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Posts.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Posts.Common.Abstractions
{
    public abstract class PostConfig<TPost> : IEntityTypeConfiguration<TPost> 
        where TPost : Post
    {
        public virtual void Configure(EntityTypeBuilder<TPost> builder)
        {
            builder.UseTpcMappingStrategy();
            builder.HasKey(pk => pk.Id).HasName($"PK{nameof(TPost)}s");
            builder.HasIndex(i => i.Title).HasDatabaseName($"IX{nameof(TPost)}Title");
            builder.Property(p => p.CreatedOn).IsRequired();
            builder.Property(p => p.Title).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Content).IsRequired();
        }
    }
}
