using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Identity.Media;
using Poster.Infrastructure.Config.Entities.Media.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Identity.Media
{
    public class ProfilePhotoConfig : BaseMediaConfig<ProfilePhoto>
    {
        public override void Configure(EntityTypeBuilder<ProfilePhoto> builder)
        {
            base.Configure(builder);

            builder.HasOne(u => u.User)
                .WithOne(p => p.Photo)
                .HasForeignKey<ProfilePhoto>(fk => fk.UserId)
                .HasConstraintName("FKProfilePhotosUsersUserId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
