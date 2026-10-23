using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

namespace Poster.Presentation.OpenApiSecurity.JWT
{
    public sealed class BearerSecuritySchemeTransformer : IOpenApiDocumentTransformer
    {
        public Task TransformAsync(OpenApiDocument document, 
            OpenApiDocumentTransformerContext context, 
            CancellationToken cancellationToken)
        {
            var scheme = new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.Http,
                Name = "Authorization",
                In = ParameterLocation.Header,
                Scheme = "bearer",
                BearerFormat = "JWT",
                Description = "Enter your JWT token in the format: Bearer {token}"
            };

            document.Components ??= new OpenApiComponents();
            document.Components.SecuritySchemes.Add("Bearer", scheme);

            var requirement = new OpenApiSecurityRequirement
            {
                [new OpenApiSecuritySchemeReference("Bearer", document)] = []
            };

            foreach (var operation in document.Paths.Values.SelectMany(p => p.Operations.Values))
            {
                operation.Security ??= [];
                operation.Security.Add(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
