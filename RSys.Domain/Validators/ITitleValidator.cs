using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RSys.Domain.Validators
{
    public interface ITitleValidator
    {
        Task<bool> IsTitleExistedAsync(int title);
    }
}
