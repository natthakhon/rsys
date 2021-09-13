using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class ProfessionDTOModelMapper : BaseMapper<DTO.ProfessionDTO, Model.Profession>
    {
        private QuestionnaireContext questionnaireContext = new QuestionnaireContext();

        public ProfessionDTOModelMapper(DTO.ProfessionDTO profession):base(profession) { }

        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.ProfessionDTO, Model.Profession>();
        }
    }
}
