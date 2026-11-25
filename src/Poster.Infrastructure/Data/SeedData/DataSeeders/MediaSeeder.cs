using Microsoft.EntityFrameworkCore;
using Poster.Infrastructure.Data.SeedData.TestData.Media.Posts;
using Poster.Infrastructure.Data.SeedData.TestData.Media.Users;

namespace Poster.Infrastructure.Data.SeedData.DataSeeders
{
    public static class MediaSeeder
    {
        public static async Task SeedPostImagesAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.PostImages.AnyAsync(cancellationToken))
            {
                await context.PostImages.AddRangeAsync(PostImagesData.PostImagesTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        public static async Task SeedVideosAsync(PosterDbContext context,
           CancellationToken cancellationToken = default)
        {
            if (!await context.Videos.AnyAsync(cancellationToken))
            {
                await context.Videos.AddRangeAsync(VideosData.VideosTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        public static async Task SeedAvatarsAsync(PosterDbContext context,
           CancellationToken cancellationToken = default)
        {
            if (!await context.UserAvatars.AnyAsync(cancellationToken))
            {
                await context.UserAvatars.AddAsync(AvatarsData.UserAvatar, cancellationToken);
                await context.UserAvatars.AddAsync(AvatarsData.AdminAvatar, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
