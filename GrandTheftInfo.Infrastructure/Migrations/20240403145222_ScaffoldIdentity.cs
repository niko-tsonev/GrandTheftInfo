using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class ScaffoldIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Missions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Cheats",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Cheats");
        }
    }
}
