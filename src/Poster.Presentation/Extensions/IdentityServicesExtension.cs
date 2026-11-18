using Microsoft.AspNetCore.Identity;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Identity.Constraints;
using Poster.Infrastructure.Data;

namespace Poster.Presentation.Extensions
{
    public static class IdentityServicesExtension
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddAuthentication();
            services.AddAuthorization();
            services.AddIdentityCore<User>()
                .AddRoles<Role>()
                .AddSignInManager<SignInManager<User>>()
                .AddRoleManager<RoleManager<Role>>()
                .AddEntityFrameworkStores<PosterDbContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
