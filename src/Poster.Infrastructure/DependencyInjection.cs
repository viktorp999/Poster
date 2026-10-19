using Microsoft.Extensions.DependencyInjection;
using Poster.Infrastructure.Data;
using Poster.Infrastructure.Persistance.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Poster.Application.Helpers.Options;

namespace Poster.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<SoftDeleteInterceptor>();
            services.AddDbContext<PosterDbContext>((sp, options) =>
            {
                var dbOptions = sp.GetRequiredService<IOptions<ConnectionStringsOptions>>().Value;

                options.UseSqlServer(dbOptions.PosterConnectionString)
                   .AddInterceptors(sp.GetRequiredService<SoftDeleteInterceptor>());
            });

            return services;
        }
    }
}
