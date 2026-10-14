using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Joins.Users;

namespace Poster.Infrastructure.Config.Entities.Joins.Users
{
    public class StandardPostSavesConfig : IEntityTypeConfiguration<StandardPostSaves>
    {
        public void Configure(EntityTypeBuilder<StandardPostSaves> builder)
        {
            builder.HasKey(k => new 
            { 
                k.StandardPostId, 
                k.UserId 
            });

            builder.HasOne(sp => sp.StandardPost)
                .WithMany(s => s.Saves)
                .HasForeignKey(fk => fk.StandardPostId)
                .HasConstraintName("FKStandardPostSavesStandardPostsId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.User)
                .WithMany(sp => sp.SavedPosts)
                .HasForeignKey(fk => fk.UserId)
                .HasConstraintName("FKStandardPostSavesUsersId");
        }
    }
}
