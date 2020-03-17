using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mangas.Migrations
{
    public partial class TitlesTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IdCompany = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    TitleStatus = table.Column<int>(nullable: false),
                    ColectionStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Title_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Volume",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<int>(nullable: false),
                    IdTitle = table.Column<int>(nullable: false),
                    TitleId = table.Column<int>(nullable: true),
                    VolumeStatus = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volume", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volume_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Title_CompanyId",
                table: "Title",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Volume_TitleId",
                table: "Volume",
                column: "TitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volume");

            migrationBuilder.DropTable(
                name: "Title");
        }
    }
}
