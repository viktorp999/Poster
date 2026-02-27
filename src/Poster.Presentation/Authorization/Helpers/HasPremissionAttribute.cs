using Microsoft.AspNetCore.Authorization;

namespace Poster.Presentation.Authorization.Helpers
{
    public class HasPremissionAttribute : AuthorizeAttribute
    {
        public HasPremissionAttribute(string permission)
        {
            Policy = permission;
        }
    }
}
