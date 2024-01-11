
using FluentValidation;

namespace Application.Repositories.Command.Publishers.Update
{
    public class UpdatePublisherCommandValidator : AbstractValidator<UpdatePublisherCommand>
    {

        public UpdatePublisherCommandValidator()
        {
            RuleFor(p => p.Id)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive");

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
