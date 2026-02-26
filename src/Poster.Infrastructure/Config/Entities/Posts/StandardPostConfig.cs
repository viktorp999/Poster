using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Posts;
using Poster.Infrastructure.Config.Entities.Posts.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Posts
{
    public class StandardPostConfig : PostConfig<StandardPost>
    {
        public override void Configure(EntityTypeBuilder<StandardPost> builder)
        {
            base.Configure(builder);

            builder.HasOne(u => u.User)
                .WithMany(sp => sp.StandardPosts)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKStandardPostsUsersUserId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
