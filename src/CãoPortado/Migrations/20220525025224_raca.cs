using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHotel.Migrations
{
    public partial class raca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Raca",
                table: "CadPet",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Raca",
                table: "CadPet");
        }
    }
}
