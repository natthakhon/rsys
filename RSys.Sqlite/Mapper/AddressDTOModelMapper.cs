using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO = RSys.Sqlite;
using Model = RSys.Domain.Models;

namespace RSys.Sqlite.Mapper
{
    public class AddressDTOModelMapper : BaseMapper<DTO.AddressDTO, Model.Address>
    {
        public AddressDTOModelMapper(DTO.AddressDTO addressDTO) : base(addressDTO) { }

        protected override void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<DTO.AddressDTO, Model.Address>();
        }
    }
}
