using FluentValidation;

namespace MyBlog.Validation.DtoValidation
{
    public abstract class ValidationBase<TDto> : AbstractValidator<TDto> where TDto : class
    {
        //ToDo: Burası geliştirilmeli. Validasyon mesajları tek bir yerden yönetilibilmeli
    }
}
