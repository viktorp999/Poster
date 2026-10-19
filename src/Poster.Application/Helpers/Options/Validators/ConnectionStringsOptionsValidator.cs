using Microsoft.Extensions.Options;

namespace Poster.Application.Helpers.Options.Validators
{
    public class ConnectionStringsOptionsValidator : IValidateOptions<ConnectionStringsOptions>
    {
        public ValidateOptionsResult Validate(string name, ConnectionStringsOptions options)
        {
            var failures = new List<string>();

            if (string.IsNullOrWhiteSpace(options.PosterConnectionString))
            {
                failures.Add("ConnectionString is required and cannot be empty.");
            }

            return failures.Count > 0
                ? ValidateOptionsResult.Fail(failures)
                : ValidateOptionsResult.Success;
        }
    }
}
