

using FluentValidation;

namespace Application.Repositories.Command.Books.Create
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {

        public CreateBookCommandValidator()
        {
            RuleFor(p => p.Name)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null.");

            RuleFor(p => p.Price)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive.");

            RuleFor(p => p.Genre)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null.");
        }
    }
}
