using Poster.Infrastructure.Config.Entities.Media.Common.Abstractions;
using Poster.Domain.Entities.Media.Posts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Poster.Infrastructure.Config.Entities.Media.Posts
{
    public class ImageConfig : BaseMediaConfig<Image>
    {
        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);

            builder.HasOne(sp => sp.StandardPost)
                .WithMany(img => img.Images)
                .HasForeignKey(fk => fk.StandardPostId)
                .HasConstraintName("FKImagesStandardPostsId")
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
