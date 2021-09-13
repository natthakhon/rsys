using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RSys.Repository
{
    public interface IGetData<TResult>
    {
        Task<TResult> GetAllAsync();
    }
}
