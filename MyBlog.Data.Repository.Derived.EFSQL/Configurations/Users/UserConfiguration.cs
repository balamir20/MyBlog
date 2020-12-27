using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Data.Model.Infrastructure.Users.User.Entity;

namespace MyBlog.Data.Repository.Derived.EFSQL.Configurations.Users
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(32);
            builder.Property(m => m.Email).IsRequired().HasMaxLength(32);
            builder.Property(m => m.Password).IsRequired().HasMaxLength(32);
            builder.ToTable("User", "User");
        }
    }
}
