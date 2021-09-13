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
    public class TitleRepository : IGetData<List<Model.Title>>, ITitleValidator
    {
        private QuestionnaireContext questionnaireContext = new QuestionnaireContext();

        public TitleRepository() { }

        public async Task<List<Title>> GetAllAsync()
        {
            List<DTO.TitleDTO> titles = await this.questionnaireContext.Title.ToListAsync();
            List<Model.Title> result = new List<Model.Title>();

            foreach (var title in titles)
            {
                TitleDTOModelMapper mapper = new TitleDTOModelMapper(title);
                result.Add(mapper.Destination);
            }

            return result;
        }

        public async Task<bool> IsTitleExistedAsync(int title)
        {
            return (await this.questionnaireContext.Title.FirstOrDefaultAsync(p => p.TitleId == title) != null);
        }
    }
}
