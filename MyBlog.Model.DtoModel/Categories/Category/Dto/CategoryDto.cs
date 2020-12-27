using MyBlog.Model.DtoModel.Articles.Article.Dto;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyBlog.Model.DtoModel.Categories.Category.Dto
{
    public class CategoryDto : BlogBaseDto
    {
        public CategoryDto()
        {
            Articles = new Collection<ArticleDto>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ArticleDto> Articles { get; set; }
    }
}
