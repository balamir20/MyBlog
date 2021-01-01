using FluentValidation;
using MyBlog.Model.DtoModel.Articles.Article.Dto;
using MyBlog.Validation.DtoValidation.Categories.Category;

namespace MyBlog.Validation.DtoValidation.Articles.Article
{
    public class ArticleDtoValidation : ValidationBase<ArticleDto>
    {
        public ArticleDtoValidation()
        {
            RuleFor(article => article.Title).NotEmpty();
            RuleFor(article => article.Title).MaximumLength(64);
            RuleFor(article => article.Content).NotEmpty();
            RuleFor(article => article.Category).SetValidator(new CategoryDtoValidation());
        }
    }
}
