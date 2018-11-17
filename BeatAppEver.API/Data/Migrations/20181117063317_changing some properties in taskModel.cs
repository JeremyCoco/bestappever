using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeatAppEver.API.Data.Migrations
{
    public partial class changingsomepropertiesintaskModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedAt",
                table: "Task",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Task",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ResultGradeByLeader",
                table: "Task",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResultGradeByWorker",
                table: "Task",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedAt",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "ResultGradeByLeader",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "ResultGradeByWorker",
                table: "Task");
        }
    }
}
