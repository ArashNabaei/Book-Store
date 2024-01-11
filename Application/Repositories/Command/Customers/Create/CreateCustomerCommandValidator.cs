

using FluentValidation;

namespace Application.Repositories.Command.Customers.Create
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {

        public CreateCustomerCommandValidator()
        {
            RuleFor(p => p.Username)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

            RuleFor(p => p.Password)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

            RuleFor(p => p.Balance)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive");

            RuleFor(p => p.Orders)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive");


        }

    }
}
