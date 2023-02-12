using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFoods.DataAccess.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administators",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 12, 12, 55, 53, 509, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 2, 12, 12, 55, 53, 509, DateTimeKind.Utc).AddTicks(6026) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administators",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 10, 9, 56, 23, 354, DateTimeKind.Utc).AddTicks(9759), new DateTime(2023, 2, 10, 9, 56, 23, 354, DateTimeKind.Utc).AddTicks(9760) });
        }
    }
}
