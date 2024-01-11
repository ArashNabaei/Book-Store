using FluentValidation;

namespace Application.Repositories.Command.Publishers.Create
{
    public class CreatePublisherCommandValidator : AbstractValidator<CreatePublisherCommand>
    {

        public CreatePublisherCommandValidator()
        {

            RuleFor(p => p.Name)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

            RuleFor(p => p.Address)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

            RuleFor(p => p.Information)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

        }

    }
}
