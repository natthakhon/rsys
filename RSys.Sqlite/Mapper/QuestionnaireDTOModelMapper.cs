using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class QuestionnaireDTOModelMapper : BaseMapper<DTO.QuestionnaireDTO, Model.Questionnaire>
    {
        public QuestionnaireDTOModelMapper(DTO.QuestionnaireDTO questionnaireDTO) : base(questionnaireDTO) { }

        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.QuestionnaireDTO, Model.Questionnaire>();
            mapperConfigurationExpression.CreateMap<DTO.PersonalInfoDTO, Model.PersonalInfo>();
            mapperConfigurationExpression.CreateMap<DTO.TitleDTO, Model.Title>();
            mapperConfigurationExpression.CreateMap<DTO.CountryDTO, Model.Country>();
            mapperConfigurationExpression.CreateMap<DTO.AddressDTO, Model.Address>();
            mapperConfigurationExpression.CreateMap<DTO.OccupationDTO, Model.Occupation>();
            mapperConfigurationExpression.CreateMap<DTO.ProfessionDTO, Model.Profession>();
            mapperConfigurationExpression.CreateMap<DTO.BusinessType, Model.BusinessType>();
            
        }
    }
}
