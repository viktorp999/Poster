using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace Poster.Presentation.Middlewares.ExceptionHandlers
{
    public class ValidationExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<ValidationExceptionHandler> _logger;
        private readonly IProblemDetailsService _problemDetailsService;

        public ValidationExceptionHandler(ILogger<ValidationExceptionHandler> logger, 
            IProblemDetailsService problemDetailsService)
        {
            _logger = logger;
            _problemDetailsService = problemDetailsService;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, 
            CancellationToken cancellationToken)
        {
            if (exception is not ValidationException validationException)
            {
                return false;
            }

            _logger.LogError(exception, "Unhandled exception occurred");

            httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;

            var context = new ProblemDetailsContext
            {
                HttpContext = httpContext,
                Exception = exception,
                ProblemDetails = new ProblemDetails
                {
                    Detail = "One or more validation errors occurred",
                    Status = StatusCodes.Status400BadRequest
                }
            };

            var errors = validationException.Errors
                .GroupBy(e => e.PropertyName)
                .ToDictionary(
                    g => g.Key.ToLowerInvariant(),
                    g => g.Select(e => e.ErrorMessage).ToArray()
                );

            context.ProblemDetails.Extensions.Add("errors", errors);

            return await _problemDetailsService.TryWriteAsync(context);
        }
    }
}
