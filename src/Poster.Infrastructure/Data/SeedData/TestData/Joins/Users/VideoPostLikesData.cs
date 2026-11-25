using Poster.Domain.Entities.Joins.Users;

namespace Poster.Infrastructure.Data.SeedData.TestData.Joins.Users
{
    public static class VideoPostLikesData
    {
        public static readonly List<VideoPostLikes> VideoPostLikesTestData =
        [
            new VideoPostLikes
            {
                VideoPostId = new Guid("11111111-1111-1111-1111-111111111111"),
                UserId = new Guid("11111111-1111-1111-1111-111111111111")
            },

            new VideoPostLikes
            {
                VideoPostId = new Guid("22222222-2222-2222-2222-222222222222"),
                UserId = new Guid("11111111-1111-1111-1111-111111111111")
            },

            new VideoPostLikes
            {
                VideoPostId = new Guid("33333333-3333-3333-3333-333333333333"),
                UserId = new Guid("11111111-1111-1111-1111-111111111111")
            }
        ];
    }
}
