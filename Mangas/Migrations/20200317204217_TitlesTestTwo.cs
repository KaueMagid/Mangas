using Microsoft.EntityFrameworkCore.Migrations;

namespace Mangas.Migrations
{
    public partial class TitlesTestTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Title_Company_CompanyId",
                table: "Title");

            migrationBuilder.DropForeignKey(
                name: "FK_Volume_Title_TitleId",
                table: "Volume");

            migrationBuilder.DropColumn(
                name: "IdTitle",
                table: "Volume");

            migrationBuilder.DropColumn(
                name: "IdCompany",
                table: "Title");

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Volume",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Title",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Title_Company_CompanyId",
                table: "Title",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Volume_Title_TitleId",
                table: "Volume",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Title_Company_CompanyId",
                table: "Title");

            migrationBuilder.DropForeignKey(
                name: "FK_Volume_Title_TitleId",
                table: "Volume");

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Volume",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdTitle",
                table: "Volume",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Title",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdCompany",
                table: "Title",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Title_Company_CompanyId",
                table: "Title",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Volume_Title_TitleId",
                table: "Volume",
                column: "TitleId",
                principalTable: "Title",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
