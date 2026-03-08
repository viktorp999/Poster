using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Joins.Posts.Likes;
using Poster.Domain.Entities.Identity.Constrains;
using Poster.Domain.Entities.Joins.Comments.Likes;
using Poster.Domain.Entities.Joins.Posts.Saves;
using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Posts;
using Poster.Domain.Entities.Posts.Media;
using Poster.Domain.Entities.Identity.Media;


namespace Poster.Infrastructure.Data
{
    public class PosterDbContext : IdentityDbContext<AppUser, Role, Guid,
        IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>,
        IdentityUserToken<Guid>>
    {
        public PosterDbContext(DbContextOptions<PosterDbContext> options) 
            : base(options)
        {
        }

        public DbSet<StandardPost> StandardPosts { get; set; }
        public DbSet<VideoPost> VideoPosts { get; set; }
        public DbSet<StandardPostComment> StandardPostComments { get; set; }
        public DbSet<VideoPostComment> VideoPostComments { get; set; }
        public DbSet<UserStandardPostLikes> UserStandardPostLikes { get; set; }
        public DbSet<UserVideoPostLikes> UserVideoPostLikes { get; set; }
        public DbSet<UserStandardPostSaves> UserStandardPostSaves { get; set; }
        public DbSet<UserVideoPostSaves> UserVideoPostSaves { get; set; }
        public DbSet<UserStandardPostCommentLikes> UserStandardPostCommentLikes { get; set; }
        public DbSet<UserVideoPostCommentLikes> UserVideoPostCommentLikes { get; set; }
        public DbSet<Image> PostImages { get; set; }
        public DbSet<Video> PostVideos { get; set; }
        public DbSet<ProfilePhoto> UserProfilePhotos { get; set; }
        public DbSet<Premission> Premissions { get; set; }
        public DbSet<RolePremission> RolePremissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
