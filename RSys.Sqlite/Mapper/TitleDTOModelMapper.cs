using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class TitleDTOModelMapper : BaseMapper<DTO.TitleDTO, Model.Title>
    {
        public TitleDTOModelMapper(DTO.TitleDTO title) : base(title) { }

        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.TitleDTO, Model.Title>();
        }
    }
}
