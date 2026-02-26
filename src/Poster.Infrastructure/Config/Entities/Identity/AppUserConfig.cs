using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poster.Core.Entities.Identity;

namespace Poster.Infrastructure.Config.Entities.Identity
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("Users");
            builder.HasIndex(i => i.UserName).HasDatabaseName("IXUsername").IsUnique();
            builder.HasIndex(i => i.Email).HasDatabaseName("IXEmail").IsUnique();
            builder.HasIndex(i => i.PhoneNumber).HasDatabaseName("IXPhoneNumber").IsUnique();
            builder.Property(p => p.UserName).HasColumnName("Username").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(50).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired(false);
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired(false);
            builder.Property(p => p.DateOfBirth).IsRequired(false);
            builder.Property(p => p.JoinedOn).IsRequired();
            builder.Property(p => p.Gender).HasConversion<string>().IsRequired(false);

            builder.ComplexProperty(p => p.Address, a =>
            {
                a.Property(p => p.Country).HasMaxLength(50).IsRequired(false);
                a.Property(p => p.City).HasMaxLength(50).IsRequired(false);
            });           
        }
    }
}
