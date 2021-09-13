using FluentValidation;
using FluentValidation.Results;
using RSys.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RSys.Domain.Validators
{
    public class InfoValidator : AbstractValidator<Questionnaire>
    {
        public InfoValidator(IValidator<Occupation> ocuupationValidator
            , IValidator<PersonalInfo> personalInfoValidator )
        {            
            RuleFor(p => p.InfoId)
                .NotEmpty()
                .WithMessage("InfoId must not be empty");

            RuleFor(p => p)
                .Must(info =>
                {
                    if (!info.PersonalInfo.Country.IsAllowed && info.Address != null)
                    {
                        return false;
                    }

                    if (!info.PersonalInfo.Country.IsAllowed && info.Occupation != null)
                    {
                        return false;
                    }
                    return true;
                }).WithMessage("Invalid Country for address or occupation");


            RuleFor(p => p.PersonalInfo).SetValidator(personalInfoValidator);
            RuleFor(p => p.Occupation).SetValidator(ocuupationValidator);
        }
    }
    
}
