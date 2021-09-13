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
    public class AllBusinessTypesHandler : BaseGetCommandHandler<AllBusinessTypesRequest, List<BusinessType>>
    {
        public AllBusinessTypesHandler(IGetData<List<BusinessType>> repo) : base(repo) { }

        protected override async Task<List<BusinessType>> handle(AllBusinessTypesRequest request, CancellationToken cancellationToken)
        {
            return await this.getrepository.GetAllAsync();
        }
    }
}
