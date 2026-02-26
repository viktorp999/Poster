using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Posts.Media;
using Poster.Infrastructure.Config.Entities.Media.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Posts.Media
{
    public class VideoConfig : BaseMediaConfig<Video>
    {
        public override void Configure(EntityTypeBuilder<Video> builder)
        {
            base.Configure(builder);

            builder.HasOne(vp => vp.VideoPost)
                .WithOne(v => v.Video)
                .HasForeignKey<Video>(fk => fk.VideoPostId)
                .HasConstraintName("FKVideosVideoPostsVideoPostId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
