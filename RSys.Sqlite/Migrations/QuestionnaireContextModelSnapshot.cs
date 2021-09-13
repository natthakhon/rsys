﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RSys.Sqlite;

namespace RSys.Sqlite.Migrations
{
    [DbContext(typeof(QuestionnaireContext))]
    partial class QuestionnaireContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("RSys.Sqlite.DTO.AddressDTO", b =>
                {
                    b.Property<string>("InfoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("House")
                        .HasColumnType("TEXT");

                    b.Property<string>("Work")
                        .HasColumnType("TEXT");

                    b.HasKey("InfoId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.BusinessType", b =>
                {
                    b.Property<int>("BusinessTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessTypeDescription")
                        .HasColumnType("TEXT");

                    b.HasKey("BusinessTypeId");

                    b.ToTable("BusinessType");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.CountryDTO", b =>
                {
                    b.Property<int>("ContryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryDescription")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAllowed")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.OccupationDTO", b =>
                {
                    b.Property<string>("InfoId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BusinessTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProfessionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("InfoId");

                    b.HasIndex("BusinessTypeId");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Occupation");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.PersonalInfoDTO", b =>
                {
                    b.Property<string>("InfoId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CountryContryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TitleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("InfoId");

                    b.HasIndex("CountryContryId");

                    b.HasIndex("TitleId");

                    b.ToTable("PersonalInfo");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.ProfessionDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProfessionDescription")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Profession");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.QuestionnaireDTO", b =>
                {
                    b.Property<string>("InfoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressInfoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OccupationInfoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonalInfoInfoId")
                        .HasColumnType("TEXT");

                    b.HasKey("InfoId");

                    b.HasIndex("AddressInfoId");

                    b.HasIndex("OccupationInfoId");

                    b.HasIndex("PersonalInfoInfoId");

                    b.ToTable("Questionnaire");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.TitleDTO", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TitleDescription")
                        .HasColumnType("TEXT");

                    b.HasKey("TitleId");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.OccupationDTO", b =>
                {
                    b.HasOne("RSys.Sqlite.DTO.BusinessType", "BusinessType")
                        .WithMany()
                        .HasForeignKey("BusinessTypeId");

                    b.HasOne("RSys.Sqlite.DTO.ProfessionDTO", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId");

                    b.Navigation("BusinessType");

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.PersonalInfoDTO", b =>
                {
                    b.HasOne("RSys.Sqlite.DTO.CountryDTO", "Country")
                        .WithMany()
                        .HasForeignKey("CountryContryId");

                    b.HasOne("RSys.Sqlite.DTO.TitleDTO", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId");

                    b.Navigation("Country");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("RSys.Sqlite.DTO.QuestionnaireDTO", b =>
                {
                    b.HasOne("RSys.Sqlite.DTO.AddressDTO", "Address")
                        .WithMany()
                        .HasForeignKey("AddressInfoId");

                    b.HasOne("RSys.Sqlite.DTO.OccupationDTO", "Occupation")
                        .WithMany()
                        .HasForeignKey("OccupationInfoId");

                    b.HasOne("RSys.Sqlite.DTO.PersonalInfoDTO", "PersonalInfo")
                        .WithMany()
                        .HasForeignKey("PersonalInfoInfoId");

                    b.Navigation("Address");

                    b.Navigation("Occupation");

                    b.Navigation("PersonalInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
