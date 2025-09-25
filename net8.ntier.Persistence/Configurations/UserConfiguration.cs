using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net8.ntier.Domain.Entities;

namespace net8.ntier.Persistence.Configurations
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(u => u.SecondLastName);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(u => u.Password);

            builder.Property(u => u.IsActive)
                .HasDefaultValue(false)
                .IsUnicode(false);

            builder.Property(u => u.IsDeleted)
                .HasDefaultValue(false)
                .IsUnicode(false);

            builder.Property(u => u.IsLocked)
                .HasDefaultValue(false)
                .IsUnicode(false);

            builder.Property(u => u.LastLogin);

            builder.Property(u => u.FailedLoginAttempts)
                .HasDefaultValue(0);

            builder.Property(u => u.CreatedAt)
                .IsRequired();

            builder.Property(u => u.CreatedBy);

            builder.Property(u => u.UpdatedAt);

            builder.Property(u => u.UpdatedBy);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            //builder.HasQueryFilter(u => !u.IsDeleted);
        }
    }
}
