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
    public class ProfessionRepository : IGetData<List<Model.Profession>>, IProfessionValidator
    {
        private QuestionnaireContext questionnaireContext = new QuestionnaireContext();

        public ProfessionRepository() { }
        
        public async Task<List<Profession>> GetAllAsync()
        {
            List<DTO.ProfessionDTO> professions = await this.questionnaireContext.Profession.ToListAsync();
            List<Model.Profession> result = new List<Model.Profession>();

            foreach (var profession in professions)
            {
                ProfessionDTOModelMapper mapper = new ProfessionDTOModelMapper(profession);
                result.Add(mapper.Destination);
            }

            return result;
        }

        public async Task<bool> IsProfessionExistedAsync(int proffession)
        {
            return (await this.questionnaireContext.Profession.FirstOrDefaultAsync(p => p.Id == proffession) != null);
        }
    }
}
