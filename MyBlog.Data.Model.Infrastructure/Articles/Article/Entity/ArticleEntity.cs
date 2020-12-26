using MyBlog.Data.Model.Infrastructure.Categories.Category.Entity;

namespace MyBlog.Data.Model.Infrastructure.Articles.Article.Entity
{
    public class ArticleEntity : BlogBaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public CategoryEntity Category { get; set; }
        public int CategoryId { get; set; }
    }
}
