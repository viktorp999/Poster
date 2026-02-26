using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Posts;
using Poster.Infrastructure.Config.Entities.Posts.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Posts
{
    public class VideoPostConfig : PostConfig<VideoPost>
    {
        public override void Configure(EntityTypeBuilder<VideoPost> builder)
        {
            base.Configure(builder);
            
            builder.HasOne(u => u.User)
                .WithMany(vp => vp.VideoPosts)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKVideoPostsUsersUserId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
