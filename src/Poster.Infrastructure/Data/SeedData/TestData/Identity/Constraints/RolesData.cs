using Poster.Domain.Entities.Identity.Constraints;
using Poster.Domain.Enums.Users;

namespace Poster.Infrastructure.Data.SeedData.TestData.Identity.Constraints
{
    public static class RolesData
    {
        public static readonly List<Role> RolesTestData =
        [
            new Role
            {
                Id = new Guid("11111111-1111-1111-1111-111111111111"),
                Name = Roles.User.ToString()
            },

            new Role
            {
                Id = new Guid("22222222-2222-2222-2222-222222222222"),
                Name = Roles.Admin.ToString()
            }
        ];  
    }
}
