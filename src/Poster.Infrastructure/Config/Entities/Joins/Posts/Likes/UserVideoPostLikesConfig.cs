using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Joins.Posts.Likes;

namespace Poster.Infrastructure.Config.Entities.Joins.Posts.Likes
{
    public class UserVideoPostLikesConfig : IEntityTypeConfiguration<UserVideoPostLikes>
    {
        public void Configure(EntityTypeBuilder<UserVideoPostLikes> builder)
        {
            builder.HasKey(k => new { k.UserId, k.VideoPostId });

            builder.HasOne(u => u.User)
                .WithMany(vp => vp.VideoPostLikes)
                .HasForeignKey(fk => fk.UserId);

            builder.HasOne(vp => vp.VideoPost)
                .WithMany(l => l.Likes)
                .HasForeignKey(fk => fk.VideoPostId);
        }
    }
}
