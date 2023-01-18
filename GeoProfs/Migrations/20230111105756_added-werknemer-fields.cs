using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeoProfs.Migrations
{
    public partial class addedwerknemerfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Werknemers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BSN = table.Column<int>(type: "int", nullable: false),
                    Telefoonnummer = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contract_uren = table.Column<int>(type: "int", nullable: false),
                    Uurloon = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werknemers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Werknemers");
        }
    }
}
