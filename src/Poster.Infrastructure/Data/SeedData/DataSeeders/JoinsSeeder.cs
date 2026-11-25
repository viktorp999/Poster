using Microsoft.EntityFrameworkCore;
using Poster.Infrastructure.Data.SeedData.TestData.Joins.Users;

namespace Poster.Infrastructure.Data.SeedData.DataSeeders
{
    public static class JoinsSeeder
    {
        public static async Task SeedStandardPostLikesAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.StandardPostLikes.AnyAsync(cancellationToken))
            {
                await context.StandardPostLikes.AddRangeAsync(StandardPostLikesData.StandardPostLikesTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        public static async Task SeedStandardPostSavesAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.StandardPostSaves.AnyAsync(cancellationToken))
            {
                await context.StandardPostSaves.AddRangeAsync(StandardPostSavesData.StandardPostSavesTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        public static async Task SeedVideoPostLikesAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.VideoPostLikes.AnyAsync(cancellationToken))
            {
                await context.VideoPostLikes.AddRangeAsync(VideoPostLikesData.VideoPostLikesTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        public static async Task SeedVideoPostSavesAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.VideoPostSaves.AnyAsync(cancellationToken))
            {
                await context.VideoPostSaves.AddRangeAsync(VideoPostSavesData.VideoPostSavesTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
