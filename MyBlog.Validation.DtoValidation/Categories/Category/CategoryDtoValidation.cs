using FluentValidation;
using MyBlog.Model.DtoModel.Categories.Category.Dto;
using MyBlog.Validation.DtoValidation.Articles.Article;

namespace MyBlog.Validation.DtoValidation.Categories.Category
{
    public class CategoryDtoValidation : ValidationBase<CategoryDto>
    {
        public CategoryDtoValidation()
        {
            RuleFor(category => category.Name).NotEmpty();
            RuleFor(category => category.Name).MaximumLength(64);
            RuleFor(category => category.Articles).NotNull();
            RuleForEach(category => category.Articles).SetValidator(new ArticleDtoValidation());
        }
    }
}
