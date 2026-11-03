using Poster.Application;
using Poster.Application.Helpers.Options;
using Poster.Infrastructure;
using Poster.Presentation.Middlewares;
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

            services.AddProblemDetails(options =>
            {
                options.CustomizeProblemDetails = ctx =>
                {
                    ctx.ProblemDetails.Extensions["timestamp"] = DateTime.UtcNow;
                    ctx.ProblemDetails.Instance = $"{ctx.HttpContext.Request.Method} {ctx.HttpContext.Request.Path}";
                };
            });

            services.AddExceptionHandler<GlobalExceptionHandler>();
              
            return services;
        }
    }
}
