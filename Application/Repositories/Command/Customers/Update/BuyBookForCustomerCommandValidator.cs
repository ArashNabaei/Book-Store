using FluentValidation;

namespace Application.Repositories.Command.Customers.Update
{
    public class BuyBookForCustomerCommandValidator : AbstractValidator<BuyBookForCustomerCommand>
    {

        public BuyBookForCustomerCommandValidator()
        {
            RuleFor(p => p.CustomerId)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive");

            RuleFor(p => p.BookId)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive");
        }

    }
}
