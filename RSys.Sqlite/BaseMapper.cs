using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Sqlite
{
    public abstract class BaseMapper<TSource, TDestination>
        where TSource : class
        where TDestination : class
    {
        private TSource source;
        private TDestination dest;
        protected IMappingExpression<TSource, TDestination> mappingExpression;
        protected MapperConfiguration config;

        protected BaseMapper(TSource source)
        {
            this.source = source;

            this.config = new MapperConfiguration(this.Reconfig);
            IMapper iMapper = config.CreateMapper();
            this.dest = iMapper.Map<TSource, TDestination>(this.source);
        }

        public TSource Source
        {
            get { return this.source; }
        }

        public TDestination Destination
        {
            get { return this.dest; }
        }

        protected abstract void Reconfig(IMapperConfigurationExpression mapperConfigurationExpression);
    }
}
