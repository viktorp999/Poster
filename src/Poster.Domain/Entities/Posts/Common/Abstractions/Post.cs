using Poster.Domain.Entities.Common.Abstractions;
using Poster.Domain.Entities.Identity;

namespace Poster.Domain.Entities.Posts.Common.Abstractions
{
    public abstract class Post : BaseEntity<Guid>
    {
        protected Post() : base()
        {
        }

        protected Post(Guid id, string title, string content, Guid userId, 
            AppUser user = null)
            : base(id)
        {
            Title = title;
            Content = content;
            UserId = userId;
            User = user;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
