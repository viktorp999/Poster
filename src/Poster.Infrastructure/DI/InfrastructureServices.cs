using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Poster.Application.Helpers.Options;
using Poster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Poster.Infrastructure.DI
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddOptions<ConnectionStringsOptions>()
                .Bind(config.GetSection(ConnectionStringsOptions.SectionName))
                .ValidateDataAnnotations()
                .ValidateOnStart();

            services.Configure<ConnectionStringsOptions>(config.GetSection(ConnectionStringsOptions.SectionName));
            services.AddDbContext<PosterDbContext>((provider, options) =>
            {
                var dbOptions = provider.GetRequiredService<IOptions<ConnectionStringsOptions>>().Value;
                options.UseSqlServer(dbOptions.PosterConnection);
            });

            return services;
        }
    }
}
