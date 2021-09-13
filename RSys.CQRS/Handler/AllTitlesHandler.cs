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
    public class AllTitlesHandler : BaseGetCommandHandler<AllTitlesRequest, List<Title>>
    {
        public AllTitlesHandler(IGetData<List<Title>> repo) : base(repo) { }

        protected override async Task<List<Title>> handle(AllTitlesRequest request, CancellationToken cancellationToken)
        {
            return await this.getrepository.GetAllAsync();
        }
    }
}
