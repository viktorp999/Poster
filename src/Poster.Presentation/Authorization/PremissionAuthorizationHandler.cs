using Microsoft.AspNetCore.Authorization;
using Poster.Presentation.Authorization.Helpers;

namespace Poster.Presentation.Authorization
{
    public class PremissionAuthorizationHandler : AuthorizationHandler<PremissionRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
        PremissionRequirement requirement)
        {
            var permissions = context.User.FindAll("permission").Select(x => x.Value);

            if (permissions.Contains(requirement.Permission))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
