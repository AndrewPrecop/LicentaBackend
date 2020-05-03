using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CompletareProprietatiComponenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Components",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Components",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Components",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Components");
        }
    }
}
