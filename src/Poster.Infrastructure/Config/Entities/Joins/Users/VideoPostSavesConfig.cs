using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Joins.Users;

namespace Poster.Infrastructure.Config.Entities.Joins.Users
{
    public class VideoPostSavesConfig : IEntityTypeConfiguration<VideoPostSaves>
    {
        public void Configure(EntityTypeBuilder<VideoPostSaves> builder)
        {
            builder.HasKey(k => new 
            { 
                k.VideoPostId, 
                k.UserId 
            }).HasName("PKVideoPostSaves");

            builder.HasOne(vp => vp.VideoPost)
                .WithMany(s => s.Saves)
                .HasForeignKey(fk => fk.VideoPostId)
                .HasConstraintName("FKVideoPostSavesVideoPostsId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.User)
                .WithMany(sv => sv.SavedVideos)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKVideoPostSavesUsersId")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
