using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Joins.Users;

namespace Poster.Infrastructure.Config.Entities.Joins.Users
{
    public class VideoPostLikesConfig : IEntityTypeConfiguration<VideoPostLikes>
    {
        public void Configure(EntityTypeBuilder<VideoPostLikes> builder)
        {
            builder.HasKey(k => new 
            { 
                k.VideoPostId, 
                k.UserId 
            });

            builder.HasOne(vp => vp.VideoPost)
                .WithMany(l => l.Likes)
                .HasForeignKey(fk => fk.VideoPostId)
                .HasConstraintName("FKVideoPostLikesVideoPostsId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.User)
                .WithMany(lv => lv.LikedVideos)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKVideoPostLikesUsersId");
        }
    }
}
