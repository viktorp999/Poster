using Microsoft.AspNetCore.Identity;
using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity.Constrains;
using Poster.Domain.Entities.Identity.Media;
using Poster.Domain.Entities.Joins.Comments.Likes;
using Poster.Domain.Entities.Joins.Posts.Likes;
using Poster.Domain.Entities.Joins.Posts.Saves;
using Poster.Domain.Entities.Posts;
using Poster.Domain.Enums.Users;
using Poster.Domain.ValueObjects.Users;

namespace Poster.Domain.Entities.Identity
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public AppUser() : base()
        {
        }

        private AppUser(string userName)
            : base(userName)
        {
        }

        public AppUser(string userName, string firstName, string lastName, DateOnly dateOfBirth,
            Gender gender, Address address = null, ProfilePhoto photo = null)
            : this(userName)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            JoinedOn = DateOnly.FromDateTime(DateTime.UtcNow);
            Gender = gender;
            Address = address ?? new Address(string.Empty, string.Empty);
            Photo = photo;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateOnly JoinedOn { get; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
        public ProfilePhoto Photo { get; set; }
        public IEnumerable<StandardPost> StandardPosts { get; set; }
        public IEnumerable<VideoPost> VideoPosts { get; set; }
        public IEnumerable<StandardPostComment> StandardPostComments { get; set; }
        public IEnumerable<VideoPostComment> VideoPostComments { get; set; }
        public IEnumerable<UserStandardPostSaves> StandardPostSaves { get; set; }
        public IEnumerable<UserVideoPostSaves> VideoPostSaves { get; set; }
        public IEnumerable<UserStandardPostLikes> StandardPostLikes { get; set; }
        public IEnumerable<UserVideoPostLikes> VideoPostLikes { get; set; }
        public IEnumerable<UserStandardPostCommentLikes> StandardPostCommentLikes { get; set; }
        public IEnumerable<UserVideoPostCommentLikes> VideoPostCommentLikes { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
