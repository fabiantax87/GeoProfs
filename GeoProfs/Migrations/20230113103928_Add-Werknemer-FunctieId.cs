using Microsoft.EntityFrameworkCore.Migrations;

namespace GeoProfs.Migrations
{
    public partial class AddWerknemerFunctieId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Functie_id",
                table: "Werknemers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Functie_id",
                table: "Werknemers");
        }
    }
}
