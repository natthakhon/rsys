using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class QuestionnaireModelDTOMapper : BaseMapper<Model.Questionnaire, DTO.QuestionnaireDTO>
    {
        public QuestionnaireModelDTOMapper(Model.Questionnaire questionnaire) : base(questionnaire) { }

        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<Model.Questionnaire,DTO.QuestionnaireDTO>();
            mapperConfigurationExpression.CreateMap<Model.PersonalInfo, DTO.PersonalInfoDTO>()
                .ForMember(dest => dest.InfoId, act => act.MapFrom(source => this.Source.InfoId));
            mapperConfigurationExpression.CreateMap<Model.Title, DTO.TitleDTO>();
            mapperConfigurationExpression.CreateMap<Model.Country, DTO.CountryDTO>();
            mapperConfigurationExpression.CreateMap<Model.Address, DTO.AddressDTO>()
                .ForMember(dest => dest.InfoId, act => act.MapFrom(source => this.Source.InfoId));
            mapperConfigurationExpression.CreateMap<Model.Occupation, DTO.OccupationDTO>()
                .ForMember(dest => dest.InfoId, act => act.MapFrom(source => this.Source.InfoId));            
            mapperConfigurationExpression.CreateMap<Model.Profession, DTO.ProfessionDTO>();
            mapperConfigurationExpression.CreateMap<Model.BusinessType, DTO.BusinessType>();
        }
    }
}
