
namespace Poster.Core.Entities.Identity.Constrains
{
    public class RolePremission
    {
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public Guid PremissionId { get; set; }
        public Premission Premission { get; set; }
    }
}
