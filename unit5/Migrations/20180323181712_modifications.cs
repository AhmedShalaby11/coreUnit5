using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace unit5.Migrations
{
    public partial class modifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorLocation",
                table: "doctor_profile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorMail",
                table: "doctor_profile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorMobile",
                table: "doctor_profile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ICU",
                table: "CasulityProfile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "patientAge",
                table: "CasulityProfile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "patientName",
                table: "CasulityProfile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ticketId",
                table: "CasulityProfile",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorLocation",
                table: "doctor_profile");

            migrationBuilder.DropColumn(
                name: "DoctorMail",
                table: "doctor_profile");

            migrationBuilder.DropColumn(
                name: "DoctorMobile",
                table: "doctor_profile");

            migrationBuilder.DropColumn(
                name: "ICU",
                table: "CasulityProfile");

            migrationBuilder.DropColumn(
                name: "patientAge",
                table: "CasulityProfile");

            migrationBuilder.DropColumn(
                name: "patientName",
                table: "CasulityProfile");

            migrationBuilder.DropColumn(
                name: "ticketId",
                table: "CasulityProfile");
        }
    }
}
