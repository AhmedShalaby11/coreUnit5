using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace unit5.Migrations
{
    public partial class fixrecdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecDate",
                table: "CasulityProfile",
                newName: "rec_date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "rec_date",
                table: "CasulityProfile",
                type: "datetime2(0)",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rec_date",
                table: "CasulityProfile",
                newName: "RecDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecDate",
                table: "CasulityProfile",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");
        }
    }
}
