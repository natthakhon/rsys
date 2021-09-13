using Microsoft.EntityFrameworkCore;
using RSys.Domain.Validators;
using RSys.Repository;
using RSys.Sqlite.DTO;
using RSys.Sqlite.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Repository
{
    public class BusinessTypeRepository : IGetData<List<Model.BusinessType>>, IBusinessTypeValidator
    {
        private QuestionnaireContext questionnaireContext = new QuestionnaireContext();

        public BusinessTypeRepository() { }        

        public async Task<List<Model.BusinessType>> GetAllAsync()
        {
            List<DTO.BusinessType> types = await this.questionnaireContext.BusinessType.ToListAsync();
            List<Model.BusinessType> result = new List<Model.BusinessType>();

            foreach (var type in types)
            {
                BusinessTypeDTOModelMapper mapper = new BusinessTypeDTOModelMapper(type);
                result.Add(mapper.Destination);
            }

            return result;
        }

        public async Task<bool> IsBusinessTypeExistedAsync(int businessType)
        {
            return (await this.questionnaireContext.BusinessType.FirstOrDefaultAsync(p => p.BusinessTypeId == businessType) != null);
        }
    }
}
