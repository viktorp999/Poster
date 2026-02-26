using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Comments;
using Poster.Infrastructure.Config.Entities.Comments.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Comments
{
    public class StandardPostCommentConfig : CommentConfig<StandardPostComment>
    {
        public override void Configure(EntityTypeBuilder<StandardPostComment> builder)
        {
            base.Configure(builder);
    
            builder.HasOne(sp => sp.StandardPost)
                .WithMany(c => c.Comments)
                .HasForeignKey(fk => fk.StandardPostId)
                .HasConstraintName("FKStandardPostCommentsStandardPostsStandardPostId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.User)
                .WithMany(spc => spc.StandardPostComments)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKStandardPostCommentsUsersUserId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
