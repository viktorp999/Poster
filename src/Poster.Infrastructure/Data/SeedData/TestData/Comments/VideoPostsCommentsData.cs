using Poster.Domain.Entities.Comments;

namespace Poster.Infrastructure.Data.SeedData.TestData.Comments
{
    public static class VideoPostsCommentsData
    {
        public static readonly List<VideoPostComment> VideoPostsCommentsTestData =
        [
            new VideoPostComment("Comment 1 Test", new Guid("11111111-1111-1111-1111-111111111111"),
                new Guid("11111111-1111-1111-1111-111111111111"))
            {
                Id = new Guid("11111111-1111-1111-1111-111111111111")
            },

            new VideoPostComment("Comment 2 Test", new Guid("11111111-1111-1111-1111-111111111111"),
                new Guid("22222222-2222-2222-2222-222222222222"))
            {
                Id = new Guid("22222222-2222-2222-2222-222222222222")
            },

            new VideoPostComment("Comment 3 Test", new Guid("11111111-1111-1111-1111-111111111111"),
                new Guid("33333333-3333-3333-3333-333333333333"))
            {
                Id = new Guid("33333333-3333-3333-3333-333333333333")
            }
        ];
    }
}
