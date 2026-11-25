
namespace Poster.Infrastructure.Data.SeedData.DataSeeders.Common
{
    public static class DataSeeder
    {
        public static async Task SeedDataAsync(PosterDbContext context, 
            CancellationToken cancellationToken = default)
        {
            await PostsSeeder.SeedStandardPostsAsync(context, cancellationToken);
            await PostsSeeder.SeedVideoPostsAsync(context, cancellationToken);
            await CommentsSeeder.SeedStandardPostsCommentsAsync(context, cancellationToken);
            await CommentsSeeder.SeedVideoPostsCommentsAsync(context, cancellationToken);
            await MediaSeeder.SeedPostImagesAsync(context, cancellationToken);
            await MediaSeeder.SeedVideosAsync(context, cancellationToken);
            await MediaSeeder.SeedAvatarsAsync(context, cancellationToken);
            await JoinsSeeder.SeedStandardPostLikesAsync(context, cancellationToken);
            await JoinsSeeder.SeedStandardPostSavesAsync(context, cancellationToken);
            await JoinsSeeder.SeedVideoPostLikesAsync(context, cancellationToken);
            await JoinsSeeder.SeedVideoPostSavesAsync(context, cancellationToken);
        }
    }
}
