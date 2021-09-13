using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class BusinessTypeDTOModelMapper : BaseMapper<DTO.BusinessType, Model.BusinessType>
    {
        public BusinessTypeDTOModelMapper(DTO.BusinessType businessType):base(businessType) { }

        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.BusinessType, Model.BusinessType>();
        }
    }
}
