using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace unit5.Migrations
{
    public partial class updatefixcasulity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CasulityProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedValue = table.Column<string>(nullable: true),
                    Assistants = table.Column<string>(nullable: true),
                    ChildState = table.Column<string>(nullable: true),
                    Complications = table.Column<string>(nullable: true),
                    Days = table.Column<int>(nullable: false),
                    Dynamics = table.Column<string>(nullable: true),
                    Intervention = table.Column<string>(nullable: true),
                    Outcome = table.Column<string>(nullable: true),
                    ParityValue = table.Column<string>(nullable: true),
                    Presentation = table.Column<string>(nullable: true),
                    RecDate = table.Column<DateTime>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Supervisors = table.Column<string>(nullable: true),
                    Surgeons = table.Column<string>(nullable: true),
                    Weeks = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasulityProfile", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasulityProfile");
        }
    }
}
