using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hectre.HarvestManagement.DataPersistence.Migrations
{
    public partial class updateHavestDTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Harvests");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Harvests",
                newName: "PickingDate");

            migrationBuilder.RenameColumn(
                name: "Activity",
                table: "Harvests",
                newName: "Variety");

            migrationBuilder.AddColumn<long>(
                name: "BinCount",
                table: "Harvests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<float>(
                name: "HourlyWageRate",
                table: "Harvests",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "HoursWorked",
                table: "Harvests",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Harvests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BinCount",
                table: "Harvests");

            migrationBuilder.DropColumn(
                name: "HourlyWageRate",
                table: "Harvests");

            migrationBuilder.DropColumn(
                name: "HoursWorked",
                table: "Harvests");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Harvests");

            migrationBuilder.RenameColumn(
                name: "Variety",
                table: "Harvests",
                newName: "Activity");

            migrationBuilder.RenameColumn(
                name: "PickingDate",
                table: "Harvests",
                newName: "StartTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Harvests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
