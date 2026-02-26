using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Joins.Posts.Saves;

namespace Poster.Infrastructure.Config.Entities.Joins.Posts.Saves
{
    public class UserVideoPostSavesConfig : IEntityTypeConfiguration<UserVideoPostSaves>
    {
        public void Configure(EntityTypeBuilder<UserVideoPostSaves> builder)
        {
            builder.HasKey(k => new { k.UserId, k.VideoPostId });

            builder.HasOne(u => u.User)
                .WithMany(vp => vp.VideoPostSaves)
                .HasForeignKey(fk => fk.UserId);

            builder.HasOne(vp => vp.VideoPost)
                .WithMany(s => s.Saves)
                .HasForeignKey(fk => fk.VideoPostId);
        }
    }
}
