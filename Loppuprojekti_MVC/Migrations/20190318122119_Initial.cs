using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loppuprojekti_MVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommonName = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    Kingdom = table.Column<string>(nullable: true),
                    Phylum = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Order = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Genus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
