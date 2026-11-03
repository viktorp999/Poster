using Poster.Application.Helpers.Errors.Common.Enums;

namespace Poster.Application.Helpers.Errors.Common
{
    public sealed record ValidationError : Error
    {
        public IReadOnlyList<SubError> Errors { get; }

        public ValidationError(IReadOnlyList<SubError> errors)
            : base("Validation.Error", 
                  "One or more validation failures occurred.", 
                  ErrorType.Validation)
        {
            Errors = errors;
        }
    }
}
