using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Model.Infrastructure.Articles.Article.Entity;
using MyBlog.Data.Model.Infrastructure.Categories.Category.Entity;
using MyBlog.Data.Repository.Derived.EFSQL.Configurations.Articles;
using MyBlog.Data.Repository.Derived.EFSQL.Configurations.Categories;
using MyBlog.Data.Repository.Derived.EFSQL.Configurations.Users;

namespace MyBlog.Data.Repository.Derived.EFSQL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ArticleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
