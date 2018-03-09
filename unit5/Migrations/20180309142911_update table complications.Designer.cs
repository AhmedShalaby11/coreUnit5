﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using unit5.Models;

namespace unit5.Migrations
{
    [DbContext(typeof(unit5Context))]
    [Migration("20180309142911_update table complications")]
    partial class updatetablecomplications
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("unit5.Models.CasulityDataClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedValue");

                    b.Property<string>("Assistants");

                    b.Property<string>("ChildState");

                    b.Property<string>("Complications");

                    b.Property<int>("Days");

                    b.Property<string>("Dynamics");

                    b.Property<string>("Intervention");

                    b.Property<string>("Outcome");

                    b.Property<string>("ParityValue");

                    b.Property<string>("Presentation");

                    b.Property<DateTime?>("RecDate");

                    b.Property<string>("Sex");

                    b.Property<string>("State");

                    b.Property<string>("Supervisors");

                    b.Property<string>("Surgeons");

                    b.Property<int>("Weeks");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("CasulityProfile");
                });

            modelBuilder.Entity("unit5.Models.ComplicationsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<DateTime?>("RecDate");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Complicaitons");
                });

            modelBuilder.Entity("unit5.Models.ConfChildPresentation", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<string>("PresentationName")
                        .HasColumnName("presentation_name")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Recid");

                    b.ToTable("conf_child_presentation");
                });

            modelBuilder.Entity("unit5.Models.ConfChildState", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("StateName")
                        .HasColumnName("state_name")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Recid");

                    b.ToTable("conf_child_state");
                });

            modelBuilder.Entity("unit5.Models.ConfCsIndication", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<string>("CsIndicationName")
                        .HasColumnName("cs_indication_name")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Type");

                    b.HasKey("Recid");

                    b.ToTable("conf_cs_indication");
                });

            modelBuilder.Entity("unit5.Models.ConfDegree", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<string>("DegreeName")
                        .HasColumnName("degree_name")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Recid");

                    b.ToTable("conf_degree");
                });

            modelBuilder.Entity("unit5.Models.ConfIntervention", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<string>("InterventionName")
                        .HasColumnName("intervention_name")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Type");

                    b.HasKey("Recid");

                    b.ToTable("conf_Intervention");
                });

            modelBuilder.Entity("unit5.Models.ConfOutcome", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<string>("OutcomeName")
                        .HasColumnName("Outcome_name")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Recid");

                    b.ToTable("conf_Outcome");
                });

            modelBuilder.Entity("unit5.Models.ConfOutcomeState", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("StateName")
                        .HasColumnName("state_name")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Recid");

                    b.ToTable("conf_Outcome_State");
                });

            modelBuilder.Entity("unit5.Models.ConfTitle", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("TitleName")
                        .HasColumnName("title_name")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Recid");

                    b.ToTable("conf_title");
                });

            modelBuilder.Entity("unit5.Models.DoctorProfile", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<DateTime?>("DoctorBachYear")
                        .HasColumnName("doctor_bach_year")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DoctorBirthdate")
                        .HasColumnName("doctor_birthdate")
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("DoctorDegree")
                        .HasColumnName("doctor_degree")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("DoctorImageUrl")
                        .HasColumnName("doctor_image_URL")
                        .IsUnicode(false);

                    b.Property<DateTime?>("DoctorMcsYear")
                        .HasColumnName("doctor_MCS_year")
                        .HasColumnType("date");

                    b.Property<string>("DoctorName")
                        .HasColumnName("doctor_name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("DoctorOtherDegrees")
                        .HasColumnName("doctor_other_degrees")
                        .IsUnicode(false);

                    b.Property<string>("DoctorOtherQualifications")
                        .HasColumnName("doctor_other_qualifications")
                        .IsUnicode(false);

                    b.Property<DateTime?>("DoctorPhdYear")
                        .HasColumnName("doctor_PHD_year")
                        .HasColumnType("date");

                    b.Property<string>("DoctorPrecense")
                        .HasColumnName("doctor_precense")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("DoctorTitle")
                        .HasColumnName("doctor_title")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RecordDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("record_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Recid");

                    b.ToTable("doctor_profile");
                });

            modelBuilder.Entity("unit5.Models.NeonatalOutcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<DateTime?>("Recid");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("NeonatalOutcome");
                });

            modelBuilder.Entity("unit5.Models.PatientDiagnose", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<string>("Assistant")
                        .IsUnicode(false);

                    b.Property<string>("ChildPresentation")
                        .HasColumnName("child_Presentation")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("ChildState")
                        .HasColumnName("child_state")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Complications")
                        .IsUnicode(false);

                    b.Property<string>("CsIndication")
                        .HasColumnName("cs_indication")
                        .IsUnicode(false);

                    b.Property<string>("Dynamics")
                        .IsUnicode(false);

                    b.Property<string>("Ga")
                        .HasColumnName("GA")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Intervention")
                        .IsUnicode(false);

                    b.Property<string>("Outcome")
                        .IsUnicode(false);

                    b.Property<string>("OutcomeSex")
                        .HasColumnName("Outcome_sex")
                        .IsUnicode(false);

                    b.Property<string>("OutcomeState")
                        .HasColumnName("Outcome_State")
                        .IsUnicode(false);

                    b.Property<double?>("OutcomeWeight")
                        .HasColumnName("Outcome_weight");

                    b.Property<DateTime?>("PositiveDate")
                        .HasColumnName("Positive_date")
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Supervisor")
                        .IsUnicode(false);

                    b.Property<string>("Surgeon")
                        .IsUnicode(false);

                    b.HasKey("Recid");

                    b.ToTable("patient_diagnose");
                });

            modelBuilder.Entity("unit5.Models.PatientProfile", b =>
                {
                    b.Property<int>("Recid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recid");

                    b.Property<string>("PatientAddress")
                        .HasColumnName("patient_address")
                        .IsUnicode(false);

                    b.Property<double?>("PatientAge")
                        .HasColumnName("patient_age");

                    b.Property<DateTime?>("PatientBirthdate")
                        .HasColumnName("patient_birthdate")
                        .HasColumnType("date");

                    b.Property<string>("PatientContact")
                        .HasColumnName("patient_contact")
                        .IsUnicode(false);

                    b.Property<string>("PatientEmail")
                        .HasColumnName("patient_email")
                        .HasMaxLength(45)
                        .IsUnicode(false);

                    b.Property<string>("PatientId")
                        .HasColumnName("patient_id")
                        .IsUnicode(false);

                    b.Property<string>("PatientImageUrl")
                        .HasColumnName("patient_image_url")
                        .IsUnicode(false);

                    b.Property<string>("PatientName")
                        .HasColumnName("Patient_name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("PatientSex")
                        .HasColumnName("patient_sex")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime?>("RecDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("rec_date")
                        .HasColumnType("datetime2(0)")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Recid");

                    b.ToTable("patient_profile");
                });
#pragma warning restore 612, 618
        }
    }
}
