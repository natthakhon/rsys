using Microsoft.EntityFrameworkCore.Migrations;

namespace RSys.Sqlite.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_BusinessType_BusinessTypeDTOBusinessTypeId",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Profession_ProfessionDTOId",
                table: "Occupation");

            migrationBuilder.RenameColumn(
                name: "ProfessionDTOId",
                table: "Occupation",
                newName: "ProfessionId");

            migrationBuilder.RenameColumn(
                name: "BusinessTypeDTOBusinessTypeId",
                table: "Occupation",
                newName: "BusinessTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Occupation_ProfessionDTOId",
                table: "Occupation",
                newName: "IX_Occupation_ProfessionId");

            migrationBuilder.RenameIndex(
                name: "IX_Occupation_BusinessTypeDTOBusinessTypeId",
                table: "Occupation",
                newName: "IX_Occupation_BusinessTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_BusinessType_BusinessTypeId",
                table: "Occupation",
                column: "BusinessTypeId",
                principalTable: "BusinessType",
                principalColumn: "BusinessTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_Profession_ProfessionId",
                table: "Occupation",
                column: "ProfessionId",
                principalTable: "Profession",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_BusinessType_BusinessTypeId",
                table: "Occupation");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Profession_ProfessionId",
                table: "Occupation");

            migrationBuilder.RenameColumn(
                name: "ProfessionId",
                table: "Occupation",
                newName: "ProfessionDTOId");

            migrationBuilder.RenameColumn(
                name: "BusinessTypeId",
                table: "Occupation",
                newName: "BusinessTypeDTOBusinessTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Occupation_ProfessionId",
                table: "Occupation",
                newName: "IX_Occupation_ProfessionDTOId");

            migrationBuilder.RenameIndex(
                name: "IX_Occupation_BusinessTypeId",
                table: "Occupation",
                newName: "IX_Occupation_BusinessTypeDTOBusinessTypeId");

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
        }
    }
}
