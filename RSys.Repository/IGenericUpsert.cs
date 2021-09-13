using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RSys.Repository
{
    public interface IGenericUpsert<TModel> where TModel:class
    {
        Task<TModel> InsertAsync(TModel model);
        Task<TModel> UpdateAsync(TModel modify);
    }
}
