using Microsoft.EntityFrameworkCore;
using RSys.Domain.Models;
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
    public class QuestionnaireRepository : IGenericUpsert<Model.Questionnaire> , IGetData<List<Model.Questionnaire>>
    {
        private QuestionnaireContext questionnaireContext = new QuestionnaireContext();

        public QuestionnaireRepository() { }

        public async Task<List<Questionnaire>> GetAllAsync()
        {
            List<DTO.QuestionnaireDTO> qnaires = await this.questionnaireContext.Questionnaire
                .Include(p=>p.Address)
                .Include(p=>p.Occupation).Include(p=>p.Occupation.BusinessType).Include(p=>p.Occupation.Profession)
                .Include(p=>p.PersonalInfo).Include(p=>p.PersonalInfo.Country).Include(p=>p.PersonalInfo.Title)
                .ToListAsync();
            
            List<Model.Questionnaire> result = new List<Model.Questionnaire>();

            foreach (var q in qnaires)
            {
                QuestionnaireDTOModelMapper mapper = new QuestionnaireDTOModelMapper(q);
                result.Add(mapper.Destination);
            }

            return result;
        }

        public async Task<Questionnaire> InsertAsync(Questionnaire model)
        {
            var questionDTO = new QuestionnaireModelDTOMapper(model).Destination;
            await this.questionnaireContext.AddAsync(questionDTO);
            this.questionnaireContext.Entry(questionDTO.Occupation.BusinessType).State = EntityState.Unchanged;
            this.questionnaireContext.Entry(questionDTO.Occupation.Profession).State = EntityState.Unchanged;
            this.questionnaireContext.Entry(questionDTO.PersonalInfo.Country).State = EntityState.Unchanged;
            this.questionnaireContext.Entry(questionDTO.PersonalInfo.Title).State = EntityState.Unchanged;            
            await this.questionnaireContext.SaveChangesAsync();
            return model;
        }

        public Task<Questionnaire> UpdateAsync(Questionnaire modify)
        {
            throw new NotImplementedException();
        }
    }
}
