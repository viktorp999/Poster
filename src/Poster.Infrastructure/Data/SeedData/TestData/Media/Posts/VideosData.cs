using Poster.Domain.Entities.Media.Posts;

namespace Poster.Infrastructure.Data.SeedData.TestData.Media.Posts
{
    public static class VideosData
    {
        public static readonly List<Video> VideosTestData =
        [
            new Video("Video 1 Test", "media/videos/video1.mp4",
                "mp4", new Guid("11111111-1111-1111-1111-111111111111"))
            {
                Id = new Guid("11111111-1111-1111-1111-111111111111")
            },

            new Video("Video 2 Test", "media/videos/video2.mp4",
                "mp4", new Guid("22222222-2222-2222-2222-222222222222"))
            {
                Id = new Guid("22222222-2222-2222-2222-222222222222")
            },

            new Video("Video 3 Test", "media/videos/video3.mp4",
                "mp4", new Guid("33333333-3333-3333-3333-333333333333"))
            {
                Id = new Guid("33333333-3333-3333-3333-333333333333")
            }
        ];
    }
}
