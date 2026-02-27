using Microsoft.AspNetCore.Authorization;

namespace Poster.Presentation.Authorization.Helpers
{
    public class PremissionRequirement : IAuthorizationRequirement
    {
        public string Permission { get; }

        public PremissionRequirement(string permission)
        {
            Permission = permission;
        }
    }
}
