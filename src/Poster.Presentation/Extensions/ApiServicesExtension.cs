using Poster.Application;
using Poster.Application.Helpers.Options;
using Poster.Infrastructure;

namespace Poster.Presentation.Extensions
{
    public static class ApiServicesExtension
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure();
            services.AddOptions<ConnectionStringsOptions>()
                .BindConfiguration(ConnectionStringsOptions.SectionName);
            
            return services;
        }
    }
}
