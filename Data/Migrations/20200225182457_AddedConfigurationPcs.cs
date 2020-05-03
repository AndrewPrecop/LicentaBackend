                                                using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedConfigurationPcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigurationPCs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationPCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationComponents",
                columns: table => new
                {
                    ConfigurationPcId = table.Column<Guid>(nullable: false),
                    ComponentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationComponents", x => new { x.ConfigurationPcId, x.ComponentId });
                    table.ForeignKey(
                        name: "FK_ConfigurationComponents_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfigurationComponents_ConfigurationPCs_ConfigurationPcId",
                        column: x => x.ConfigurationPcId,
                        principalTable: "ConfigurationPCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationComponents_ComponentId",
                table: "ConfigurationComponents",
                column: "ComponentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigurationComponents");

            migrationBuilder.DropTable(
                name: "ConfigurationPCs");
        }
    }
}
