using Microsoft.EntityFrameworkCore;
using RSys.Sqlite.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSys.Sqlite
{
    public class QuestionnaireContext : DbContext
    {
        public DbSet<BusinessType> BusinessType { get; set; }
        public DbSet<CountryDTO> Country { get; set; }
        public DbSet<ProfessionDTO> Profession { get; set; }
        public DbSet<TitleDTO> Title { get; set; }
        public DbSet<AddressDTO> Address { get; set; }
        public DbSet<OccupationDTO> Occupation { get; set; }
        public DbSet<PersonalInfoDTO> PersonalInfo { get; set; }
        public DbSet<QuestionnaireDTO> Questionnaire { get; set; }

        public QuestionnaireContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(QuestionnaireDatabase.DataSource());
        }
    }
}
