using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Posts.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Posts.Common.Abstractions
{
    public abstract class PostConfig<TPost> : IEntityTypeConfiguration<TPost>
        where TPost : Post
    {
        public virtual void Configure(EntityTypeBuilder<TPost> builder)
        {
            builder.UseTpcMappingStrategy();
            builder.HasKey(pk => pk.Id).HasName($"PK{typeof(TPost).Name}s");
            builder.HasIndex(i => i.Title)
                .HasDatabaseName("IXPostsTitle")
                .IsUnique();
            builder.Property(p => p.CreatedAt)
                .IsRequired();
            builder.Property(p => p.Title)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Content)
                .IsRequired();
            builder.Property(p => p.Category)
                .HasConversion<string>()
                .IsRequired();
            builder.Property(p => p.IsSensitive)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
