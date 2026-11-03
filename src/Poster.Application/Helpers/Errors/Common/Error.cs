using Poster.Application.Helpers.Errors.Common.Enums;

namespace Poster.Application.Helpers.Errors.Common
{
    public record Error(string Code, string Description, ErrorType Type)
    {
        public static readonly Error None = new(string.Empty, string.Empty, ErrorType.Failure);

        public static Error NotFound(string code, string description) => new(code, description, ErrorType.NotFound);
        public static Error Conflict(string code, string description) => new(code, description, ErrorType.Conflict);
        public static Error Forbidden(string code, string description) => new(code, description, ErrorType.Forbidden);
        public static Error Unauthorized(string code, string description) => new(code, description, ErrorType.Unauthorized);
        public static ValidationError Validation(IReadOnlyList<SubError> subErrors) => new(subErrors);
    }
}
