using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkedList_Web.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Text");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Text");

            migrationBuilder.AddColumn<int>(
                name: "Elementos",
                table: "Text",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Elementos",
                table: "Text");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Text",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Text",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
