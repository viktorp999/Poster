using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Comments.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Comments.Common.Abstractions
{
    public abstract class CommentConfig<TComment> : IEntityTypeConfiguration<TComment>
        where TComment : Comment
    {
        public virtual void Configure(EntityTypeBuilder<TComment> builder)
        {
            builder.UseTpcMappingStrategy();
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.CreatedAt)
                .IsRequired();
            builder.Property(p => p.Content)
                .IsRequired();
        }
    }
}
