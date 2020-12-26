using MyBlog.Model.DtoModel.Categories.Category.Dto;

namespace MyBlog.Model.DtoModel.Articles.Article.Dto
{
    public class ArticleDto : BlogBaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
        public int CategoryId { get; set; }
    }
}
