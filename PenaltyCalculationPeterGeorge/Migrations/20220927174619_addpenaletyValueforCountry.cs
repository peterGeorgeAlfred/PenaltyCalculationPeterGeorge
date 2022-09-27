using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PenaltyCalculationPeterGeorge.Migrations
{
    public partial class addpenaletyValueforCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "penaletyValue",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "penaletyValue",
                table: "Countries");
        }
    }
}
