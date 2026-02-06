using Poster.Core.Entities.Common.Abstractions;
using Poster.Core.Entities.Identity;

namespace Poster.Core.Entities.Posts.Common.Abstractions
{
    public abstract class Post : BaseEntity<Guid>
    {
        protected Post() : base()
        {
        }

        protected Post(Guid id, string title, string content, Guid userId, 
            bool isSensitive = false, AppUser user = null)
            : base(id)
        {
            Title = title;
            Content = content;
            IsSensitive = isSensitive;
            UserId = userId;
            User = user;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsSensitive { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
