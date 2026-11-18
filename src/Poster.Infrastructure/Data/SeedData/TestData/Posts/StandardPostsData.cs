using Poster.Domain.Entities.Posts;
using Poster.Domain.Enums.Posts;

namespace Poster.Infrastructure.Data.SeedData.TestData.Posts
{
    public static class StandardPostsData
    {
        public static readonly List<StandardPost> StandardPostsTestData =
        [
            new StandardPost("Title 1 Test", "Content 1 Test", 
                PostCategory.Funny, new Guid("11111111-1111-1111-1111-111111111111"))
            {
                Id = new Guid("11111111-1111-1111-1111-111111111111")
            },

            new StandardPost("Title 2 Test", "Content 2 Test",
                PostCategory.Interesting, new Guid("11111111-1111-1111-1111-111111111111"))
            {
                Id = new Guid("22222222-2222-2222-2222-222222222222")
            },

            new StandardPost("Title 3 Test", "Content 3 Test", 
                PostCategory.Sad, new Guid("11111111-1111-1111-1111-111111111111"), true)
            {
                Id = new Guid("33333333-3333-3333-3333-333333333333")
            }
        ];
    }
}
