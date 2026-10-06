using Microsoft.AspNetCore.Identity;
using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity.Abstractions.Interfaces;
using Poster.Domain.Entities.Identity.Constraints;
using Poster.Domain.Entities.Joins.Users;
using Poster.Domain.Entities.Media.Users;
using Poster.Domain.Entities.Posts;
using Poster.Domain.Enums.Users;
using Poster.Domain.ValueObjects.Users;

namespace Poster.Domain.Entities.Identity
{
    public sealed class User : IdentityUser<Guid>, IUserSoftDelete
    {
        public User() : base()
        {
            JoinedOn = DateTime.UtcNow.ToString("d-MMMM-yyyy");
        }

        public User(string username, string firstName, string lastName, Address address, Gender gender, 
            DateOnly dateOfBirth, Avatar avatar)
            : this(username, firstName, lastName, address)
        {
            Gender = gender;
            DateOfBirth = dateOfBirth.ToString("d-MMMM-yyyy");
            Avatar = avatar;
            JoinedOn = DateTime.UtcNow.ToString("d-MMMM-yyyy");
        }

        private User(string username, string firstName, string lastName, Address address)
            : base(username)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Gender Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string JoinedOn { get; init; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public Avatar Avatar { get; set; }
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
