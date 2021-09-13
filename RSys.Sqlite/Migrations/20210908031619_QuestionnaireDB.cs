using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RSys.Sqlite.Migrations
{
    public partial class QuestionnaireDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressDTO",
                columns: table => new
                {
                    InfoId = table.Column<string>(type: "TEXT", nullable: false),
                    House = table.Column<string>(type: "TEXT", nullable: true),
                    Work = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDTO", x => x.InfoId);
                });

            migrationBuilder.CreateTable(
                name: "BusinessType",
                columns: table => new
                {
                    BusinessTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusinessTypeDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessType", x => x.BusinessTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ContryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryDescription = table.Column<string>(type: "TEXT", nullable: true),
                    IsAllowed = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ContryId);
                });

            migrationBuilder.CreateTable(
                name: "Profession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProfessionDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profession", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitleDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "OccupationDTO",
                columns: table => new
                {
                    InfoId = table.Column<string>(type: "TEXT", nullable: false),
                    ProfessionDTOId = table.Column<int>(type: "INTEGER", nullable: true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    BusinessTypeDTOBusinessTypeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationDTO", x => x.InfoId);
                    table.ForeignKey(
                        name: "FK_OccupationDTO_BusinessType_BusinessTypeDTOBusinessTypeId",
                        column: x => x.BusinessTypeDTOBusinessTypeId,
                        principalTable: "BusinessType",
                        principalColumn: "BusinessTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OccupationDTO_Profession_ProfessionDTOId",
                        column: x => x.ProfessionDTOId,
                        principalTable: "Profession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInfoDTO",
                columns: table => new
                {
                    InfoId = table.Column<string>(type: "TEXT", nullable: false),
                    TitleId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Lastname = table.Column<string>(type: "TEXT", nullable: true),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CountryContryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInfoDTO", x => x.InfoId);
                    table.ForeignKey(
                        name: "FK_PersonalInfoDTO_Country_CountryContryId",
                        column: x => x.CountryContryId,
                        principalTable: "Country",
                        principalColumn: "ContryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalInfoDTO_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaire",
                columns: table => new
                {
                    InfoId = table.Column<string>(type: "TEXT", nullable: false),
                    PersonalInfoInfoId = table.Column<string>(type: "TEXT", nullable: true),
                    AddressInfoId = table.Column<string>(type: "TEXT", nullable: true),
                    OccupationInfoId = table.Column<string>(type: "TEXT", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaire", x => x.InfoId);
                    table.ForeignKey(
                        name: "FK_Questionnaire_AddressDTO_AddressInfoId",
                        column: x => x.AddressInfoId,
                        principalTable: "AddressDTO",
                        principalColumn: "InfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionnaire_OccupationDTO_OccupationInfoId",
                        column: x => x.OccupationInfoId,
                        principalTable: "OccupationDTO",
                        principalColumn: "InfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionnaire_PersonalInfoDTO_PersonalInfoInfoId",
                        column: x => x.PersonalInfoInfoId,
                        principalTable: "PersonalInfoDTO",
                        principalColumn: "InfoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OccupationDTO_BusinessTypeDTOBusinessTypeId",
                table: "OccupationDTO",
                column: "BusinessTypeDTOBusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationDTO_ProfessionDTOId",
                table: "OccupationDTO",
                column: "ProfessionDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfoDTO_CountryContryId",
                table: "PersonalInfoDTO",
                column: "CountryContryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfoDTO_TitleId",
                table: "PersonalInfoDTO",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaire_AddressInfoId",
                table: "Questionnaire",
                column: "AddressInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaire_OccupationInfoId",
                table: "Questionnaire",
                column: "OccupationInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaire_PersonalInfoInfoId",
                table: "Questionnaire",
                column: "PersonalInfoInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questionnaire");

            migrationBuilder.DropTable(
                name: "AddressDTO");

            migrationBuilder.DropTable(
                name: "OccupationDTO");

            migrationBuilder.DropTable(
                name: "PersonalInfoDTO");

            migrationBuilder.DropTable(
                name: "BusinessType");

            migrationBuilder.DropTable(
                name: "Profession");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Title");
        }
    }
}
