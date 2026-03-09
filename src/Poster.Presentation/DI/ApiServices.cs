using Microsoft.EntityFrameworkCore;
using Poster.Application.DI;
using Poster.Infrastructure.DI;
using Poster.Presentation.Middlewares.ExceptionHandlers;

namespace Poster.Presentation.DI
{
    public static class ApiServices
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddApplication();
            services.AddInfrastructure(config);
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddExceptionHandler<ValidationExceptionHandler>();
            services.AddExceptionHandler<GlobalExceptionHandler>();
            services.AddProblemDetails();

            return services;
        }
    }
}
