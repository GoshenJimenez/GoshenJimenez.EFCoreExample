using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExample.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abbreviation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[] { new Guid("00965ecf-acae-46fe-8775-d7834b07fd96"), "Stf", "People who work in school but not teaching", "Staff" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[] { new Guid("1fb7085a-762f-440c-87de-59f75f85e935"), "Std", "People who learn in school", "Student" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Abbreviation", "Description", "Name" },
                values: new object[] { new Guid("7ce68d5c-5b65-495a-8a63-14aeb48da87d"), "Fct", "People who teach in school", "Faculty" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
