using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Poster.Domain.Entities.Comments;
using Poster.Domain.Entities.Identity;
using Poster.Domain.Entities.Identity.Constraints;
using Poster.Domain.Entities.Joins.Users;
using Poster.Domain.Entities.Media.Posts;
using Poster.Domain.Entities.Media.Users;
using Poster.Domain.Entities.Posts;
using System.Reflection;

namespace Poster.Infrastructure.Data
{
    public class PosterDbContext : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, 
        UserRole, IdentityUserLogin<Guid>, 
        IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public PosterDbContext()
        {
        }

        public PosterDbContext(DbContextOptions<PosterDbContext> options) 
            : base(options)
        {
        }

        public DbSet<StandardPost> StandardPosts { get; set; }
        public DbSet<VideoPost> VideoPosts { get; set; }
        public DbSet<StandardPostComment> StandardPostComments { get; set; }
        public DbSet<VideoPostComment> VideoPostComments { get; set; }
        public DbSet<Image> PostImages { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Avatar> UserAvatars { get; set; }
        public DbSet<StandardPostLikes> StandardPostLikes { get; set; }
        public DbSet<StandardPostSaves> StandardPostSaves { get; set; }
        public DbSet<VideoPostLikes> VideoPostLikes { get; set; }
        public DbSet<VideoPostSaves> VideoPostSaves { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityUserClaim<Guid>>()
                .ToTable("UserClaims");

            builder.Entity<IdentityUserLogin<Guid>>()
                .ToTable("UserLogins");

            builder.Entity<IdentityRoleClaim<Guid>>()
                .ToTable("RoleClaims");

            builder.Entity<IdentityUserToken<Guid>>()
                .ToTable("UserTokens");
        }
    }
}
