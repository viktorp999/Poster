using Poster.Domain.Entities.Common.Abstractions;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Enums.Posts;

namespace Poster.Domain.Entities.Posts.Common.Abstractions
{
    public abstract class Post : BaseEntity
    {
        protected Post() : base()
        {

        }

        protected Post(string title, string content, PostCategory category, User user = null) 
            : base()
        {
            Title = title;
            Content = content;
            Category = category;
            User = user;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public PostCategory Category { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
