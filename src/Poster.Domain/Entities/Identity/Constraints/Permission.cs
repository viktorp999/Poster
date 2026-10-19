
namespace Poster.Domain.Entities.Identity.Constraints
{
    public sealed class Permission
    {
        public Permission()
        {
            Id = Guid.CreateVersion7();
        }

        public Permission(string name)
        {
            Id = Guid.CreateVersion7();
            Name = name;
        }
        public Guid Id { get; private init; }
        public string Name { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; } = [];
    }
}
