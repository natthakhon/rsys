using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RSys.CQRS.Command;
using RSys.CQRS.Handler;
using RSys.CQRS.Query;
using RSys.Domain.Models;
using RSys.Domain.Validators;
using RSys.Repository;
using RSys.Sqlite.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSys.Api.Api
{
    public static class ServiceExtensions
    {
        public static void Resolve(this IServiceCollection services)
        {
            resolveRepository(services);
            resolveValidator(services);
            resolveRequestHandler(services);
        }
        private static void resolveRepository(IServiceCollection services)
        {
            services.AddScoped<IGetData<List<BusinessType>>, BusinessTypeRepository>();
            services.AddScoped<IGetData<List<Country>>, CountryRepository>();
            services.AddScoped<IGetData<List<Profession>>, ProfessionRepository>();
            services.AddScoped<IGetData<List<Title>>, TitleRepository>();
            services.AddScoped<IGetData<List<Questionnaire>>, QuestionnaireRepository>();
            services.AddScoped<IGenericUpsert<Questionnaire>, QuestionnaireRepository>();            
        }

        private static void resolveValidator(IServiceCollection services)
        {
            services.AddScoped<IValidator<Questionnaire>, InfoValidator>();
            services.AddScoped<IValidator<Occupation>, OccupationValidator>();
            services.AddScoped<IValidator<PersonalInfo>, PersonalInfoValidator>();
            services.AddScoped<IBusinessTypeValidator, BusinessTypeRepository>();
            services.AddScoped<IProfessionValidator, ProfessionRepository>();
            services.AddScoped<ITitleValidator, TitleRepository>();
            services.AddScoped<ICountryValidator, CountryRepository>();
        }

        private static void resolveRequestHandler(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<AllBusinessTypesRequest, List<BusinessType>>, AllBusinessTypesHandler>();
            services.AddScoped<IRequestHandler<AllCountriesRequest, List<Country>>, AllCoutriesHandler>();
            services.AddScoped<IRequestHandler<AllProfessionsRequest, List<Profession>>, AllProfessionsHandler>();
            services.AddScoped<IRequestHandler<AllTitlesRequest, List<Title>>, AllTitlesHandler>();
            services.AddScoped<IRequestHandler<AllQnairesRequest, List<Questionnaire>>, AllQnairesHandler>();
            services.AddScoped<IRequestHandler<InsertQnaireCommand, Questionnaire>, InsertQnaireHandler>();
        }
    }
}
