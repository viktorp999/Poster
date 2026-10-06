using Poster.Domain.Entities.Common.Abstractions;
using Poster.Domain.Entities.Identity;

namespace Poster.Domain.Entities.Comments.Common.Abstractions
{
    public abstract class Comment : BaseEntity
    {
        protected Comment() : base()
        {
        }

        protected Comment(string content, User user = null) 
            : base()
        {
            Content = content;
            User = user;
        }

        public string Content { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
