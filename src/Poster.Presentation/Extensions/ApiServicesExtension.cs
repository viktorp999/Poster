using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Poster.Application.Helpers.Options;
using Poster.Infrastructure.Data;

namespace Poster.Presentation.Extensions
{
    public static class ApiServicesExtension
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddControllers();
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
