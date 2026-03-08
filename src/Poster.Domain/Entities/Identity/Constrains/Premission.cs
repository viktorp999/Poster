namespace Poster.Domain.Entities.Identity.Constrains
{
    public class Premission
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<RolePremission> RolePremissions { get; set; }
    }
}
