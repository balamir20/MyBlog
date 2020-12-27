using MyBlog.Data.Model.Infrastructure.Articles.Article.Entity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyBlog.Data.Model.Infrastructure.Categories.Category.Entity
{
    public class CategoryEntity : BlogBaseEntity
    {
        public CategoryEntity()
        {
            Articles = new Collection<ArticleEntity>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ArticleEntity> Articles { get; set; }
    }
}
