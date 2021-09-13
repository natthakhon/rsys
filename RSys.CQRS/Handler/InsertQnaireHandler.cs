using FluentValidation;
using RSys.Domain.Models;
using RSys.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSys.CQRS.Handler
{
    public class InsertQnaireHandler : BaseCreateCommandHandler<Questionnaire>
    {
        public InsertQnaireHandler(IValidator<Questionnaire> validator, IGenericUpsert<Questionnaire> repository) : base(validator, repository) { }

        protected override async Task<Questionnaire> handle(IRequestor<Questionnaire> request, CancellationToken cancellationToken)
        {
            return await this.repository.InsertAsync(request.Item);
        }
    }
}
