using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Comments.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Comments.Common.Abstractions
{
    public abstract class CommentConfig<TComment> : IEntityTypeConfiguration<TComment>
        where TComment : Comment
    {
        public virtual void Configure(EntityTypeBuilder<TComment> builder)
        {
            builder.UseTpcMappingStrategy();
            builder.HasKey(pk => pk.Id).HasName($"PK{nameof(TComment)}s");
            builder.Property(p => p.CreatedOn).IsRequired();
            builder.Property(p => p.Content).IsRequired();
        }
    }
}
