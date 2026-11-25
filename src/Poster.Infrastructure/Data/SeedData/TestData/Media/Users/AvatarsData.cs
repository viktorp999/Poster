using Poster.Domain.Entities.Media.Users;

namespace Poster.Infrastructure.Data.SeedData.TestData.Media.Users
{
    public static class AvatarsData
    {
        public static readonly Avatar UserAvatar = new Avatar("User Avatar Test",
            "media/avatars/user-avatar.jpg", "jpg", new Guid("11111111-1111-1111-1111-111111111111"))
        {
            Id = new Guid("11111111-1111-1111-1111-111111111111")
        };

        public static readonly Avatar AdminAvatar = new Avatar("Admin Avatar Test",
            "media/avatars/admin-avatar.jpg", "jpg", new Guid("22222222-2222-2222-2222-222222222222"))
        {
            Id = new Guid("22222222-2222-2222-2222-222222222222")
        };
    }
}
