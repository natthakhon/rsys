using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class CountryDTOModelMapper : BaseMapper<DTO.CountryDTO, Model.Country>
    {
        public CountryDTOModelMapper(DTO.CountryDTO countryDTO) : base(countryDTO) { }

        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.CountryDTO, Model.Country>();
        }
    }
}
