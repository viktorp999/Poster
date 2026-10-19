using Microsoft.AspNetCore.Identity;
using Poster.Domain.Abstractions.Interfaces;
using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity.Constraints;
using Poster.Domain.Entities.Joins.Users;
using Poster.Domain.Entities.Media.Users;
using Poster.Domain.Entities.Posts;
using Poster.Domain.ValueObjects.Users;

namespace Poster.Domain.Entities.Identity
{
    public sealed class User : IdentityUser<Guid>, ISoftDelete
    {
        public User() : base()
        {
            JoinedOn = DateTime.UtcNow.ToString("dd-MMMM-yyyy");
        }

        public User(string username, string email, 
            UserDetails details = null, Avatar avatar = null)
            : this(username, email, details)
        {
            Avatar = avatar;
            JoinedOn = DateTime.UtcNow.ToString("d-MMMM-yyyy");
        }

        private User(string username, string email, UserDetails details)
            : base(username)
        {
            NormalizedUserName = username.ToUpperInvariant();
            Email = email;
            NormalizedEmail = email.ToUpperInvariant();
            Details = details;
        }

        public UserDetails Details { get; set; }
        public string JoinedOn { get; private init; }
        public Avatar Avatar { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DeletedAt { get; set; }
        public IEnumerable<StandardPost> Posts { get; set; }
        public IEnumerable<VideoPost> Videos { get; set; }
        public IEnumerable<StandardPostComment> PostComments { get; set; }
        public IEnumerable<VideoPostComment> VideoComments { get; set; }
        public IEnumerable<StandardPostLikes> LikedPosts { get; set; }
        public IEnumerable<VideoPostLikes> LikedVideos { get; set; }
        public IEnumerable<StandardPostSaves> SavedPosts { get; set; }
        public IEnumerable<VideoPostSaves> SavedVideos { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
