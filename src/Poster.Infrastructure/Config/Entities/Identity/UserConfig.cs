using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Domain.Entities.Identity;

namespace Poster.Infrastructure.Config.Entities.Identity
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasQueryFilter(f => !f.IsDeleted);
            builder.HasKey(pk => pk.Id)
                .HasName("PKUsers");
            builder.Property(p => p.UserName)
                .HasColumnName("Username")
                .IsRequired();
            builder.Property(p => p.Email)
                .IsRequired();
            builder.Property(p => p.JoinedOn)
                .IsRequired();
            builder.Property(p => p.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
            builder.Property(p => p.DeletedAt)
                .IsRequired();
            builder.HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .IsRequired();

            builder.ComplexProperty(p => p.Details, details =>
            {
                details.Property(p => p.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FirstName")
                    .IsRequired();
                details.Property(p => p.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("LastName")
                    .IsRequired();
                details.Property(p => p.City)
                    .HasMaxLength(50)
                    .HasColumnName("City")
                    .IsRequired(false);
                details.Property(p => p.Country)
                    .HasMaxLength(50)
                    .HasColumnName("Country")
                    .IsRequired(false);
                details.Property(p => p.Gender)
                    .HasMaxLength(20)
                    .HasColumnName("Gender")
                    .IsRequired(false);
                details.Property(p => p.DateOfBirth)
                    .HasColumnName("DateOfBirth")
                    .IsRequired(false);
            });
        }
    }
}
