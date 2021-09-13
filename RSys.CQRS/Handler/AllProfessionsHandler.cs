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
    public class AllProfessionsHandler : BaseGetCommandHandler<AllProfessionsRequest, List<Profession>>
    {
        public AllProfessionsHandler(IGetData<List<Profession>> repo) : base(repo) { }

        protected override async Task<List<Profession>> handle(AllProfessionsRequest request, CancellationToken cancellationToken)
        {
            return await this.getrepository.GetAllAsync();
        }
    }
}
