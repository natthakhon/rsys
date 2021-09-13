using FluentValidation;
using RSys.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Domain.Validators
{
    public class OccupationValidator : AbstractValidator<Occupation>
    {
        public OccupationValidator(IBusinessTypeValidator businessTypeValidator, IProfessionValidator professionValidator)
        {
            RuleFor(p => p.Profession)
                .Must(prof => prof!= null && professionValidator.IsProfessionExistedAsync(prof.Id).Result)
                .WithMessage("Invalid Profession");

            RuleFor(p => p.JobTitle)
                .NotEmpty()
                .WithMessage("JobTitle must not be empty");

            RuleFor(p => p.BusinessType)
                .Must(type => type!= null && businessTypeValidator.IsBusinessTypeExistedAsync(type.BusinessTypeId).Result)
                .WithMessage("Invalid Business type");
        }
    }
}
