using RSys.CQRS.Query;
using RSys.Domain.Models;
using RSys.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSys.CQRS.Handler
{
    public class AllQnairesHandler : BaseGetCommandHandler<AllQnairesRequest, List<Questionnaire>>
    {
        public AllQnairesHandler(IGetData<List<Questionnaire>> repo) : base(repo) { }
        protected override async Task<List<Questionnaire>> handle(AllQnairesRequest request, CancellationToken cancellationToken)
        {
            return await this.getrepository.GetAllAsync();
        }
    }
}
