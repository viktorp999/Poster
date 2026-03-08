using Poster.Domain.Entities.Common.Abstractions;
using Poster.Domain.Entities.Identity;

namespace Poster.Domain.Entities.Comments.Common.Abstractions
{
    public abstract class Comment : BaseEntity<Guid>
    {
        protected Comment() : base()
        {
        }

        protected Comment(Guid id, string content, Guid userId, 
            AppUser user = null)
            : base(id)
        {
            Content = content;
            UserId = userId;
            User = user;
        }

        public string Content { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
