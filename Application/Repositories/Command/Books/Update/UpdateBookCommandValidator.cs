using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Books.Update
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {

        public UpdateBookCommandValidator()
        {

            RuleFor(p => p.Id)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive.");

            RuleFor(p => p.Name)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

            RuleFor(p => p.Genre)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

            RuleFor(p => p.Price)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive.");
        }

    }
}
