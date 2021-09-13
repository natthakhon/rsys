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
    public class AllCoutriesHandler : BaseGetCommandHandler<AllCountriesRequest, List<Country>>
    {
        public AllCoutriesHandler(IGetData<List<Country>> repo) : base(repo) { }

        protected override async Task<List<Country>> handle(AllCountriesRequest request, CancellationToken cancellationToken)
        {
            return await this.getrepository.GetAllAsync(); 
        }
    }
}
