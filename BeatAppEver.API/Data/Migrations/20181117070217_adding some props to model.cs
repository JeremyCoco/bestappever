using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeatAppEver.API.Data.Migrations
{
    public partial class addingsomepropstomodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Task",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Task",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Task");
        }
    }
}
