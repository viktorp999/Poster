using Microsoft.AspNetCore.Mvc;
using Poster.Application.Helpers.Errors.Common;
using Poster.Application.Helpers.Errors.Common.Enums;
using Poster.Application.Helpers.Results;
using Poster.Application.Helpers.Results.Common;

namespace Poster.Presentation.Extensions
{
    public static class ProblemHttpResultExtension
    {
        public static IResult ToApiResult<T>(this GenericResult<T> result)
        {
            if (result.IsSuccess)
                return Results.Ok(result.Value);

            return result.Error.Type switch
            {
                ErrorType.NotFound => Results.NotFound(CreateProblemDetails(result.Error, StatusCodes.Status404NotFound)),
                ErrorType.Validation => Results.BadRequest(CreateProblemDetails(result.Error, StatusCodes.Status400BadRequest)),
                ErrorType.Conflict => Results.Conflict(CreateProblemDetails(result.Error, StatusCodes.Status409Conflict)),
                ErrorType.Unauthorized => Results.Json(
                    CreateProblemDetails(result.Error, StatusCodes.Status401Unauthorized),
                    statusCode: StatusCodes.Status401Unauthorized),
                _ => Results.BadRequest(CreateValidationProblemDetails(result.Error))
            };
        }

        public static IResult ToApiResult(this Result result, 
            object successValue = null)
        {
            if (result.IsSuccess)
                return successValue is not null
                    ? Results.Ok(successValue)
                    : Results.Ok();

            return result.Error.Type switch
            {
                ErrorType.NotFound => Results.NotFound(CreateProblemDetails(result.Error, StatusCodes.Status404NotFound)),
                ErrorType.Validation => Results.BadRequest(CreateProblemDetails(result.Error, StatusCodes.Status400BadRequest)),
                ErrorType.Conflict => Results.Conflict(CreateProblemDetails(result.Error, StatusCodes.Status409Conflict)),
                _ => Results.BadRequest(CreateValidationProblemDetails(result.Error))
            };    
        }

        public static IResult ToCreatedResult<T>(this GenericResult<T> result,
            string location)
        {
            if (result.IsSuccess)
                return Results.Created(location, result.Value);

            return result.ToApiResult();
        }

        private static ProblemDetails CreateProblemDetails(Error error, int statusCode) =>
            new()
        {
            Status = statusCode,
            Title = error.Code,
            Detail = error.Description,
            Type = $"https://httpstatuses.com/{statusCode}"
        };

        private static ValidationProblemDetails CreateValidationProblemDetails(Error error)
        {
            var validationDetails = new ValidationProblemDetails
            {
                Title = "Validation Failed",
                Status = StatusCodes.Status400BadRequest,
                Detail = error.Description
            };

            if (error is ValidationError validationError)
            {
                foreach (var group in validationError.Errors.GroupBy(e => e.PropertyName))
                {
                    validationDetails.Errors.Add(group.Key, group.ToArray().Select(e => e.ErrorMessage).ToArray());
                }
            }

            return validationDetails;
        }
    }
}
