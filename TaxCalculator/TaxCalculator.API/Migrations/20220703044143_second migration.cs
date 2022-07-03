using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxCalculator.API.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_flatValue",
                table: "flatValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_flatRate",
                table: "flatRate");

            migrationBuilder.RenameTable(
                name: "flatValue",
                newName: "FlatValue");

            migrationBuilder.RenameTable(
                name: "flatRate",
                newName: "FlatRate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlatValue",
                table: "FlatValue",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlatRate",
                table: "FlatRate",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlatValue",
                table: "FlatValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlatRate",
                table: "FlatRate");

            migrationBuilder.RenameTable(
                name: "FlatValue",
                newName: "flatValue");

            migrationBuilder.RenameTable(
                name: "FlatRate",
                newName: "flatRate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_flatValue",
                table: "flatValue",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_flatRate",
                table: "flatRate",
                column: "Id");
        }
    }
}
