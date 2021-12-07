using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations.FluentValidation
{
    public class CarValidator :AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage(Messages.InvalidPrice);
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage(Messages.DailyPriceEmpty);
            RuleFor(c => c.Description).NotEmpty().WithMessage(Messages.DescriptionEmpty);
            RuleFor(c => c.ModelName).MinimumLength(2).WithMessage(Messages.ModelNameLengthError);
        }

    }
}
