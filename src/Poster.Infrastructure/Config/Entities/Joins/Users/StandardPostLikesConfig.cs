using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Joins.Users;

namespace Poster.Infrastructure.Config.Entities.Joins.Users
{
    public class StandardPostLikesConfig : IEntityTypeConfiguration<StandardPostLikes>
    {
        public void Configure(EntityTypeBuilder<StandardPostLikes> builder)
        {
            builder.HasKey(k => new 
            { 
                k.StandardPostId, 
                k.UserId 
            })
                .HasName("PKStandardPostLikes");

            builder.HasOne(sp => sp.StandardPost)
                .WithMany(l => l.Likes)
                .HasForeignKey(fk => fk.StandardPostId)
                .HasConstraintName("FKStandardPostLikesStandardPostsId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.User)
                .WithMany(lp => lp.LikedPosts)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKStandardPostLikesUsersId")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
