using FluentValidation;
using RSys.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Domain.Validators
{
    public class PersonalInfoValidator : AbstractValidator<PersonalInfo>
    {
        public PersonalInfoValidator(ITitleValidator titleValidator, ICountryValidator countryValidator)
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Name must not be empty");

            RuleFor(p => p.Lastname)
                .NotEmpty()
                .WithMessage("Lastname must not be empty");

            RuleFor(p => p.Country)
                .Must(country => country!= null && countryValidator.IsCountryExistedAsync(country.ContryId).Result)
                .WithMessage("Invalid country");

            RuleFor(p => p.Title)
                .Must(title => title != null && titleValidator.IsTitleExistedAsync(title.TitleId).Result)
                .WithMessage("Invalid title");
        }
    }
}
