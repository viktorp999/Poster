using Asp.Versioning.ApiExplorer;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

namespace Poster.Presentation.OpenApi
{
    public sealed class DescriptionTransformer : IOpenApiDocumentTransformer
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public DescriptionTransformer(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public Task TransformAsync(OpenApiDocument document, 
            OpenApiDocumentTransformerContext context, 
            CancellationToken cancellationToken)
        {
            var documentName = context.DocumentName;

            var description = _provider.ApiVersionDescriptions
                .FirstOrDefault(d => string.Equals(d.GroupName, documentName, StringComparison.OrdinalIgnoreCase));

            if (description == null)
            {
                return Task.CompletedTask;
            }

            document.Info.Version = description.ApiVersion.ToString();
            document.Info.Title = $"Poster API - {description.GroupName.ToUpperInvariant()}";
            document.Info.Description = description.IsDeprecated
                ? "This API version has been deprecated."
                : "Active development version.";

            return Task.CompletedTask;
        }
    }
}
