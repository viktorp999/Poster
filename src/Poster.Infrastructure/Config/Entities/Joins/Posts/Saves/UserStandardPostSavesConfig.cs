using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Joins.Posts.Saves;

namespace Poster.Infrastructure.Config.Entities.Joins.Posts.Saves
{
    public class UserStandardPostSavesConfig : IEntityTypeConfiguration<UserStandardPostSaves>
    {
        public void Configure(EntityTypeBuilder<UserStandardPostSaves> builder)
        {
            builder.HasKey(k => new { k.UserId, k.StandardPostId });

            builder.HasOne(u => u.User)
                .WithMany(sp => sp.StandardPostSaves)
                .HasForeignKey(fk => fk.UserId);

            builder.HasOne(sp => sp.StandardPost)
                .WithMany(s => s.Saves)
                .HasForeignKey(fk => fk.StandardPostId);
        }
    }
}
