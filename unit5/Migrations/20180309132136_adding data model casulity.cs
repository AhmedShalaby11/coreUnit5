using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace unit5.Migrations
{
    public partial class addingdatamodelcasulity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conf_child_presentation",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    presentation_name = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_child_presentation", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "conf_child_state",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())"),
                    state_name = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_child_state", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "conf_cs_indication",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cs_indication_name = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_cs_indication", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "conf_degree",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    degree_name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_degree", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "conf_Intervention",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    intervention_name = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_Intervention", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "conf_Outcome",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Outcome_name = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_Outcome", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "conf_Outcome_State",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())"),
                    state_name = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_Outcome_State", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "conf_title",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())"),
                    title_name = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conf_title", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "doctor_profile",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    doctor_bach_year = table.Column<DateTime>(type: "date", nullable: true),
                    doctor_birthdate = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    doctor_degree = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    doctor_image_URL = table.Column<string>(unicode: false, nullable: true),
                    doctor_MCS_year = table.Column<DateTime>(type: "date", nullable: true),
                    doctor_name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    doctor_other_degrees = table.Column<string>(unicode: false, nullable: true),
                    doctor_other_qualifications = table.Column<string>(unicode: false, nullable: true),
                    doctor_PHD_year = table.Column<DateTime>(type: "date", nullable: true),
                    doctor_precense = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    doctor_title = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    record_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor_profile", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "patient_diagnose",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Assistant = table.Column<string>(unicode: false, nullable: true),
                    child_Presentation = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    child_state = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Complications = table.Column<string>(unicode: false, nullable: true),
                    cs_indication = table.Column<string>(unicode: false, nullable: true),
                    Dynamics = table.Column<string>(unicode: false, nullable: true),
                    GA = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Intervention = table.Column<string>(unicode: false, nullable: true),
                    Outcome = table.Column<string>(unicode: false, nullable: true),
                    Outcome_sex = table.Column<string>(unicode: false, nullable: true),
                    Outcome_State = table.Column<string>(unicode: false, nullable: true),
                    Outcome_weight = table.Column<double>(nullable: true),
                    Positive_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())"),
                    Supervisor = table.Column<string>(unicode: false, nullable: true),
                    Surgeon = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient_diagnose", x => x.recid);
                });

            migrationBuilder.CreateTable(
                name: "patient_profile",
                columns: table => new
                {
                    recid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    patient_address = table.Column<string>(unicode: false, nullable: true),
                    patient_age = table.Column<double>(nullable: true),
                    patient_birthdate = table.Column<DateTime>(type: "date", nullable: true),
                    patient_contact = table.Column<string>(unicode: false, nullable: true),
                    patient_email = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
                    patient_id = table.Column<string>(unicode: false, nullable: true),
                    patient_image_url = table.Column<string>(unicode: false, nullable: true),
                    Patient_name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    patient_sex = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    rec_date = table.Column<DateTime>(type: "datetime2(0)", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient_profile", x => x.recid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conf_child_presentation");

            migrationBuilder.DropTable(
                name: "conf_child_state");

            migrationBuilder.DropTable(
                name: "conf_cs_indication");

            migrationBuilder.DropTable(
                name: "conf_degree");

            migrationBuilder.DropTable(
                name: "conf_Intervention");

            migrationBuilder.DropTable(
                name: "conf_Outcome");

            migrationBuilder.DropTable(
                name: "conf_Outcome_State");

            migrationBuilder.DropTable(
                name: "conf_title");

            migrationBuilder.DropTable(
                name: "doctor_profile");

            migrationBuilder.DropTable(
                name: "patient_diagnose");

            migrationBuilder.DropTable(
                name: "patient_profile");
        }
    }
}
