using Microsoft.EntityFrameworkCore.Migrations;

namespace BeatAppEver.API.Data.Migrations
{
    public partial class tasksproperproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActualTimePassed",
                table: "Task",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DificultyGradeByLeader",
                table: "Task",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DificultyGradeByWorker",
                table: "Task",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeEstimatedByWorker",
                table: "Task",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Task",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualTimePassed",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "DificultyGradeByLeader",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "DificultyGradeByWorker",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "TimeEstimatedByWorker",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Task");
        }
    }
}
