using Business.Constants;
using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations.FluentValidation
{
    public class UserValidatior : AbstractValidator<User>
    {
        public UserValidatior()
        {
            RuleFor(u => u.Email).NotNull().WithMessage(Messages.EmailNull);
            RuleFor(u => u.FirstName).NotNull().WithMessage(Messages.FirstNameNull);
            RuleFor(u => u.LastName).NotNull().WithMessage(Messages.LastNameNull);
        }
    }
}
