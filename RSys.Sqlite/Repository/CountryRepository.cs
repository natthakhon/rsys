using Microsoft.EntityFrameworkCore;
using RSys.Domain.Models;
using RSys.Domain.Validators;
using RSys.Repository;
using RSys.Sqlite.Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Repository
{
    public class CountryRepository : IGetData<List<Model.Country>>, ICountryValidator
    {
        private QuestionnaireContext questionnaireContext = new QuestionnaireContext();

        public CountryRepository() { }
        public async Task<List<Country>> GetAllAsync()
        {
            List<DTO.CountryDTO> countries = await this.questionnaireContext.Country.ToListAsync();
            List<Model.Country> result = new List<Model.Country>();

            foreach (var country in countries)
            {
                CountryDTOModelMapper mapper = new CountryDTOModelMapper(country);
                result.Add(mapper.Destination);
            }

            return result;
        }

        public async Task<bool> IsCountryExistedAsync(int country)
        {
            return (await this.questionnaireContext.Country.FirstOrDefaultAsync(p => p.ContryId == country) != null);
        }
    }
}
