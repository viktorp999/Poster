using Poster.Application;
using Poster.Application.Helpers.Options;
using Poster.Infrastructure;
using Poster.Presentation.OpenApi.JWT;

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
            services.AddControllers();
            services.AddOpenApi(options =>
            {
                options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
            });
              
            return services;
        }
    }
}
