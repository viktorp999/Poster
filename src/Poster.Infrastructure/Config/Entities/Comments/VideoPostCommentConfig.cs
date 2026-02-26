using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Comments;
using Poster.Infrastructure.Config.Entities.Comments.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Comments
{
    public class VideoPostCommentConfig : CommentConfig<VideoPostComment>
    {
        public override void Configure(EntityTypeBuilder<VideoPostComment> builder)
        {
            base.Configure(builder);

            builder.HasOne(vp => vp.VideoPost)
                .WithMany(c => c.Comments)
                .HasForeignKey(fk => fk.VideoPostId)
                .HasConstraintName("FKVideoPostCommentsVideoPostsVideoPostId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.User)
                .WithMany(vpc => vpc.VideoPostComments)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKVideoPostCommentsUsersUserId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
