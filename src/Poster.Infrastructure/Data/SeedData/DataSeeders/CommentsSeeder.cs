using Microsoft.EntityFrameworkCore;
using Poster.Infrastructure.Data.SeedData.TestData.Comments;

namespace Poster.Infrastructure.Data.SeedData.DataSeeders
{
    public static class CommentsSeeder
    {
        
        public static async Task SeedStandardPostsCommentsAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.StandardPostComments.AnyAsync(cancellationToken))
            {
                await context.StandardPostComments.AddRangeAsync(StandardPostsCommentsData.StandardPostsCommentsTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        public static async Task SeedVideoPostsCommentsAsync(PosterDbContext context,
            CancellationToken cancellationToken = default)
        {
            if (!await context.VideoPostComments.AnyAsync(cancellationToken))
            {
                await context.VideoPostComments.AddRangeAsync(VideoPostsCommentsData.VideoPostsCommentsTestData, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
