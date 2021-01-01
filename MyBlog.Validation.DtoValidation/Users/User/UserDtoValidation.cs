using FluentValidation;
using MyBlog.Model.DtoModel.Users.User.Dto;

namespace MyBlog.Validation.DtoValidation.Users.User
{
    public class UserDtoValidation : ValidationBase<UserDto>
    {
        public UserDtoValidation()
        {
            RuleFor(user => user.Email).NotEmpty();
            RuleFor(user => user.Email).EmailAddress();
            RuleFor(user => user.Name).NotEmpty();
            RuleFor(user => user.Name).MaximumLength(32);
            RuleFor(user => user.Surname).NotEmpty();
            RuleFor(user => user.Surname).MaximumLength(32);
            RuleFor(user => user.Password).NotEmpty();
            RuleFor(user => user.Password).MaximumLength(32);
        }
    }
}
