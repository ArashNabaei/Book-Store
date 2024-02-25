using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Authors.Update
{
    public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {

        public UpdateAuthorCommandValidator()
        {
            RuleFor(p => p.Id)
                .Cascade(CascadeMode.Stop)
                .GreaterThan(0).WithMessage("{PropertyName} must be positive.");

            RuleFor(p => p.UserName)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null");

            RuleFor(p => p.Password)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("{PropertyName} must not be null.");
        }

    }

}
