using Poster.Domain.Entities.Identity;
using Poster.Domain.Enums.Users;
using Poster.Domain.ValueObjects.Users;

namespace Poster.Infrastructure.Data.SeedData.TestData.Identity
{
    public static class UsersData
    {
        public static readonly User TestUser = new User("ivanivanovski", "useremail@example.com",
            new UserDetails("Ivan", "Ivanovski", "Bitola", "Macedonia", Gender.Male,
                new DateOnly(1990, 1, 1)))
        {
            Id = new Guid("11111111-1111-1111-1111-111111111111"),
            PasswordHash = "Password123!"
        };

        public static readonly User TestAdminUser = new User("admin", "adminemail@example.com",
            new UserDetails("Viktor", "Petrovski", "Bitola", "Macedonia", Gender.Male,
                new DateOnly(1999, 10, 10)))
        {
            Id = new Guid("22222222-2222-2222-2222-222222222222"),
            PasswordHash = "AdminPassword123!"
        };
    }
}
