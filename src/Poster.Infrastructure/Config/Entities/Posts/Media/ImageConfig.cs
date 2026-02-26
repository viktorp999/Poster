using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Posts.Media;
using Poster.Infrastructure.Config.Entities.Media.Common.Abstractions;

namespace Poster.Infrastructure.Config.Entities.Posts.Media
{
    public class ImageConfig : BaseMediaConfig<Image>
    {
        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);

            builder.HasOne(sp => sp.StandardPost)
                .WithMany(img => img.Images)
                .HasForeignKey(fk => fk.StandardPostId)
                .HasConstraintName("FKImagesStandardPostsStandardPostId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
