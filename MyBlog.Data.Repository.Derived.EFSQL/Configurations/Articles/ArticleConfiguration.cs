using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Data.Model.Infrastructure.Articles.Article.Entity;

namespace MyBlog.Data.Repository.Derived.EFSQL.Configurations.Articles
{
    public class ArticleConfiguration : IEntityTypeConfiguration<ArticleEntity>
    {
        public void Configure(EntityTypeBuilder<ArticleEntity> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.Title).IsRequired().HasMaxLength(64);
            builder.Property(m => m.Content).IsRequired();
            builder.HasOne(m => m.Category).WithMany().HasForeignKey(m => m.CategoryId);
            builder.ToTable("Article", "Article");
        }
    }
}
