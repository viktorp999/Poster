using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Joins.Comments.Likes;

namespace Poster.Infrastructure.Config.Entities.Joins.Comments.Likes
{
    public class UserVideoPostCommentLikesConfig : IEntityTypeConfiguration<UserVideoPostCommentLikes>
    {
        public void Configure(EntityTypeBuilder<UserVideoPostCommentLikes> builder)
        {
            builder.HasKey(k => new { k.UserId, k.VideoPostCommentId });

            builder.HasOne(u => u.User)
                .WithMany(vpc => vpc.VideoPostCommentLikes)
                .HasForeignKey(fk => fk.UserId);

            builder.HasOne(vpc => vpc.VideoPostComment)
                .WithMany(l => l.Likes)
                .HasForeignKey(fk => fk.VideoPostCommentId);
        }
    }
}
