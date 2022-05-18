using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web2._6.Data.Migrations
{
    public partial class mdaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EditDate",
                table: "Replies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsEdited",
                table: "Replies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditDate",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "IsEdited",
                table: "Replies");
        }
    }
}
