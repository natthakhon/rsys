using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class PersonnalInfoDTOModelMapper : BaseMapper<DTO.PersonalInfoDTO, Model.PersonalInfo>
    {
        public PersonnalInfoDTOModelMapper(DTO.PersonalInfoDTO personalInfoDTO) : base(personalInfoDTO) { }
        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.PersonalInfoDTO, Model.PersonalInfo>();
            mapperConfigurationExpression.CreateMap<DTO.TitleDTO, Model.Title>();
            mapperConfigurationExpression.CreateMap<DTO.CountryDTO, Model.Country>();
        }
    }
}
