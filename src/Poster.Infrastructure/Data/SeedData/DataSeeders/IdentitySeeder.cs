using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Identity.Constraints;
using Poster.Domain.Enums.Users;
using Poster.Infrastructure.Data.SeedData.TestData.Identity;

namespace Poster.Infrastructure.Data.SeedData.DataSeeders
{
    public static class IdentitySeeder
    {
        public static async Task SeedIdentityAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roles = new[] { Roles.Admin, Roles.User };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role.ToString()))
                {
                    await roleManager.CreateAsync(new Role(role.ToString()));
                }
            }

            var adminEmail = UsersData.TestAdminUser.Email;
            var userEmail = UsersData.TestUser.Email;
            var adminUserExist = await userManager.FindByEmailAsync(adminEmail);
            var userExist = await userManager.FindByEmailAsync(userEmail);

            if (adminUserExist == null)
            {
                var adminUser = UsersData.TestAdminUser;
                var adminUserResult = await userManager.CreateAsync(adminUser);

                if (adminUserResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, Roles.Admin.ToString());
                }
            }

            if (userExist == null)
            {
                var user = UsersData.TestUser;
                var userResult = await userManager.CreateAsync(user);

                if (userResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Roles.User.ToString());
                }
            }
        }
    }
}
