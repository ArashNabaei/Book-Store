
using FluentValidation;

namespace Application.Repositories.Command.Publishers.Delete
{
    public class DeletePublisherCommandValidator : AbstractValidator<DeletePublisherCommand>
    {

        public DeletePublisherCommandValidator()
        {
            RuleFor(p => p.Id)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive");
        }

    }
}
