using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Media.Users;
using Poster.Infrastructure.Config.Entities.Media.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Media.Users
{
    public class AvatarConfig : BaseMediaConfig<Avatar>
    {
        public override void Configure(EntityTypeBuilder<Avatar> builder)
        {
            base.Configure(builder);

            builder.HasOne(u => u.User)
                .WithOne(a => a.Avatar)
                .HasForeignKey<Avatar>(fk => fk.UserId)
                .HasConstraintName("FKAvatarsUsersId")
                .IsRequired();
        }
    }
}
