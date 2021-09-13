using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class OccupationDTOModelMapper : BaseMapper<DTO.OccupationDTO, Model.Occupation>
    {
        public OccupationDTOModelMapper(DTO.OccupationDTO occupationDTO) : base(occupationDTO) { }
        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.OccupationDTO, Model.Occupation>();
            mapperConfigurationExpression.CreateMap<DTO.BusinessType, Model.BusinessType>();
            mapperConfigurationExpression.CreateMap<DTO.ProfessionDTO, Model.Profession>();
        }
    }
}
