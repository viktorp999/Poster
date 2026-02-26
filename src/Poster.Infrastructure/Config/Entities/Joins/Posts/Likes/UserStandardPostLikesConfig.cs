using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Joins.Posts.Likes;

namespace Poster.Infrastructure.Config.Entities.Joins.Posts.Likes
{
    public class UserStandardPostLikesConfig : IEntityTypeConfiguration<UserStandardPostLikes>
    {
        public void Configure(EntityTypeBuilder<UserStandardPostLikes> builder)
        {
            builder.HasKey(k => new { k.UserId, k.StandardPostId });

            builder.HasOne(u => u.User)
                .WithMany(sp => sp.StandardPostLikes)
                .HasForeignKey(fk => fk.UserId);

            builder.HasOne(sp => sp.StandardPost)
                .WithMany(l => l.Likes)
                .HasForeignKey(fk => fk.StandardPostId);
        }
    }
}
