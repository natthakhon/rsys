using Microsoft.EntityFrameworkCore.Migrations;

namespace RSys.Sqlite.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OccupationDTO_BusinessType_BusinessTypeDTOBusinessTypeId",
                table: "OccupationDTO");

            migrationBuilder.DropForeignKey(
                name: "FK_OccupationDTO_Profession_ProfessionDTOId",
                table: "OccupationDTO");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfoDTO_Country_CountryContryId",
                table: "PersonalInfoDTO");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfoDTO_Title_TitleId",
                table: "PersonalInfoDTO");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_AddressDTO_AddressInfoId",
                table: "Questionnaire");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_OccupationDTO_OccupationInfoId",
                table: "Questionnaire");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_PersonalInfoDTO_PersonalInfoInfoId",
                table: "Questionnaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInfoDTO",
                table: "PersonalInfoDTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OccupationDTO",
                table: "OccupationDTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressDTO",
                table: "AddressDTO");

            migrationBuilder.RenameTable(
                name: "PersonalInfoDTO",
                newName: "PersonalInfo");

            migrationBuilder.RenameTable(
                name: "OccupationDTO",
                newName: "Occupation");

            migrationBuilder.RenameTable(
                name: "AddressDTO",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalInfoDTO_TitleId",
                table: "PersonalInfo",
                newName: "IX_PersonalInfo_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalInfoDTO_CountryContryId",
                table: "PersonalInfo",
                newName: "IX_PersonalInfo_CountryContryId");

            migrationBuilder.RenameIndex(
                name: "IX_OccupationDTO_ProfessionDTOId",
                table: "Occupation",
                newName: "IX_Occupation_ProfessionDTOId");

            migrationBuilder.RenameIndex(
                name: "IX_OccupationDTO_BusinessTypeDTOBusinessTypeId",
                table: "Occupation",
                newName: "IX_Occupation_BusinessTypeDTOBusinessTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInfo",
                table: "PersonalInfo",
                column: "InfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation",
                column: "InfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "InfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_BusinessType_BusinessTypeDTOBusinessTypeId",
                table: "Occupation",
                column: "BusinessTypeDTOBusinessTypeId",
                principalTable: "BusinessType",
                principalColumn: "BusinessTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_Profession_ProfessionDTOId",
                table: "Occupation",
                column: "ProfessionDTOId",
                principalTable: "Profession",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfo_Country_CountryContryId",
                table: "PersonalInfo",
                column: "CountryContryId",
                principalTable: "Country",
                principalColumn: "ContryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfo_Title_TitleId",
                table: "PersonalInfo",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "TitleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_Address_AddressInfoId",
                table: "Questionnaire",
                column: "AddressInfoId",
                principalTable: "Address",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_Occupation_OccupationInfoId",
                table: "Questionnaire",
                column: "OccupationInfoId",
                principalTable: "Occupation",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_PersonalInfo_PersonalInfoInfoId",
                table: "Questionnaire",
                column: "PersonalInfoInfoId",
                principalTable: "PersonalInfo",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_BusinessType_BusinessTypeDTOBusinessTypeId",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Profession_ProfessionDTOId",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfo_Country_CountryContryId",
                table: "PersonalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfo_Title_TitleId",
                table: "PersonalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_Address_AddressInfoId",
                table: "Questionnaire");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_Occupation_OccupationInfoId",
                table: "Questionnaire");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_PersonalInfo_PersonalInfoInfoId",
                table: "Questionnaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInfo",
                table: "PersonalInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "PersonalInfo",
                newName: "PersonalInfoDTO");

            migrationBuilder.RenameTable(
                name: "Occupation",
                newName: "OccupationDTO");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "AddressDTO");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalInfo_TitleId",
                table: "PersonalInfoDTO",
                newName: "IX_PersonalInfoDTO_TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonalInfo_CountryContryId",
                table: "PersonalInfoDTO",
                newName: "IX_PersonalInfoDTO_CountryContryId");

            migrationBuilder.RenameIndex(
                name: "IX_Occupation_ProfessionDTOId",
                table: "OccupationDTO",
                newName: "IX_OccupationDTO_ProfessionDTOId");

            migrationBuilder.RenameIndex(
                name: "IX_Occupation_BusinessTypeDTOBusinessTypeId",
                table: "OccupationDTO",
                newName: "IX_OccupationDTO_BusinessTypeDTOBusinessTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInfoDTO",
                table: "PersonalInfoDTO",
                column: "InfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OccupationDTO",
                table: "OccupationDTO",
                column: "InfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressDTO",
                table: "AddressDTO",
                column: "InfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationDTO_BusinessType_BusinessTypeDTOBusinessTypeId",
                table: "OccupationDTO",
                column: "BusinessTypeDTOBusinessTypeId",
                principalTable: "BusinessType",
                principalColumn: "BusinessTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OccupationDTO_Profession_ProfessionDTOId",
                table: "OccupationDTO",
                column: "ProfessionDTOId",
                principalTable: "Profession",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfoDTO_Country_CountryContryId",
                table: "PersonalInfoDTO",
                column: "CountryContryId",
                principalTable: "Country",
                principalColumn: "ContryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfoDTO_Title_TitleId",
                table: "PersonalInfoDTO",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "TitleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_AddressDTO_AddressInfoId",
                table: "Questionnaire",
                column: "AddressInfoId",
                principalTable: "AddressDTO",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_OccupationDTO_OccupationInfoId",
                table: "Questionnaire",
                column: "OccupationInfoId",
                principalTable: "OccupationDTO",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_PersonalInfoDTO_PersonalInfoInfoId",
                table: "Questionnaire",
                column: "PersonalInfoInfoId",
                principalTable: "PersonalInfoDTO",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
