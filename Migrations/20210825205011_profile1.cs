using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_vanilla.Migrations
{
    public partial class profile1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Profiles",
                newName: "name");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dob",
                table: "Profiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "dob",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Profiles",
                newName: "FullName");
        }
    }
}
