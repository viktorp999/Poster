using Poster.Domain.Entities.Media.Posts;

namespace Poster.Infrastructure.Data.SeedData.TestData.Media.Posts
{
    public static class PostImagesData
    {
        public static readonly List<Image> PostImagesTestData = 
        [
            new Image("Image 1 Test", "media/images/image1.jpg",
                "jpg", new Guid("11111111-1111-1111-1111-111111111111"))
            {
                Id = new Guid("11111111-1111-1111-1111-111111111111")
            },

            new Image("Image 2 Test", "media/images/image2.jpg",
                "jpg", new Guid("22222222-2222-2222-2222-222222222222"))
            {
                Id = new Guid("22222222-2222-2222-2222-222222222222")
            },

            new Image("Image 3 Test", "media/images/image3.jpg",
                "jpg", new Guid("33333333-3333-3333-3333-333333333333"))
            {
                Id = new Guid("33333333-3333-3333-3333-333333333333")
            }
        ];
    }
}
