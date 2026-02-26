using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Joins.Comments.Likes;

namespace Poster.Infrastructure.Config.Entities.Joins.Comments.Likes
{
    public class UserStandardPostCommentLikesConfig : IEntityTypeConfiguration<UserStandardPostCommentLikes>
    {
        public void Configure(EntityTypeBuilder<UserStandardPostCommentLikes> builder)
        {
            builder.HasKey(k => new { k.UserId, k.StandardPostCommentId });

            builder.HasOne(u => u.User)
                .WithMany(spc => spc.StandardPostCommentLikes)
                .HasForeignKey(fk => fk.UserId);

            builder.HasOne(spc => spc.StandardPostComment)
                .WithMany(l => l.Likes)
                .HasForeignKey(fk => fk.StandardPostCommentId);
        }
    }
}
