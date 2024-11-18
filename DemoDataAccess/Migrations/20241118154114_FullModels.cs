using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.DataAccess.Migrations
{
    public partial class FullModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "People",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "People",
                newName: "Age");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "People",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "People",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "People",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "People",
                type: "timestamp without time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "People");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "People");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "People");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "People",
                newName: "ShortName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "People",
                newName: "Code");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "People",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
