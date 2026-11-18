using Microsoft.EntityFrameworkCore;
using Poster.Infrastructure.Data.SeedData.TestData.Posts;

namespace Poster.Infrastructure.Data.SeedData.DataSeeders
{
    public static class PostsSeeder
    {
        public static async Task SeedStandardPostsAsync(PosterDbContext context, 
            CancellationToken cancellationToken = default)
        {
            if (!await context.StandardPosts.AnyAsync(cancellationToken))
            {
                await context.StandardPosts.AddRangeAsync(StandardPostsData.StandardPostsTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        public static async Task SeedVideoPostsAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.VideoPosts.AnyAsync(cancellationToken))
            {
                await context.VideoPosts.AddRangeAsync(VideoPostsData.VideoPostsTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
           