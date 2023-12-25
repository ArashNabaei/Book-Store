using FluentValidation;

namespace Application.Repositories.Command.Authors.Create
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {

        public CreateAuthorCommandValidator()
        {
            RuleFor(p => p.Username)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null.");

            RuleFor(p => p.Password)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null.");
        }

    }
}
