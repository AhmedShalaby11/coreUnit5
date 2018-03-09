using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace unit5.Models
{
    public partial class unit5Context : DbContext
    {
        public virtual DbSet<ConfChildPresentation> ConfChildPresentation { get; set; }
        public virtual DbSet<ConfChildState> ConfChildState { get; set; }
        public virtual DbSet<ConfCsIndication> ConfCsIndication { get; set; }
        public virtual DbSet<ConfDegree> ConfDegree { get; set; }
        public virtual DbSet<ConfIntervention> ConfIntervention { get; set; }
        public virtual DbSet<ConfOutcome> ConfOutcome { get; set; }
        public virtual DbSet<ConfOutcomeState> ConfOutcomeState { get; set; }
        public virtual DbSet<ConfTitle> ConfTitle { get; set; }
        public virtual DbSet<DoctorProfile> DoctorProfile { get; set; }
        public virtual DbSet<PatientDiagnose> PatientDiagnose { get; set; }
        public virtual DbSet<PatientProfile> PatientProfile { get; set; }

        public virtual DbSet<ComplicationsModel> Complicaitons { get; set; }
        public virtual DbSet<CasulityDataClass> CasulityProfile { get; set; }
        public virtual DbSet<NeonatalOutcome> NeonatalOutcome { get; set; }
        public unit5Context()
        {

        }

        public unit5Context(DbContextOptions<unit5Context> options)
         : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=unit5;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfChildPresentation>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_child_presentation");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.PresentationName)
                    .HasColumnName("presentation_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConfChildState>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_child_state");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StateName)
                    .HasColumnName("state_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfCsIndication>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_cs_indication");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.name)
                    .HasColumnName("cs_indication_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConfDegree>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_degree");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.DegreeName)
                    .HasColumnName("degree_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConfIntervention>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_Intervention");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.InterventionName)
                    .HasColumnName("intervention_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });


            modelBuilder.Entity<CasulityDataClass>(entity =>
            {
                
                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });



            modelBuilder.Entity<ConfOutcome>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_Outcome");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.OutcomeName)
                    .HasColumnName("Outcome_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConfOutcomeState>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_Outcome_State");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StateName)
                    .HasColumnName("state_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfTitle>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("conf_title");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TitleName)
                    .HasColumnName("title_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DoctorProfile>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("doctor_profile");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.DoctorBachYear)
                    .HasColumnName("doctor_bach_year")
                    .HasColumnType("date");

                entity.Property(e => e.DoctorBirthdate)
                    .HasColumnName("doctor_birthdate")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DoctorDegree)
                    .HasColumnName("doctor_degree")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorImageUrl)
                    .HasColumnName("doctor_image_URL")
                    .IsUnicode(false);

                entity.Property(e => e.DoctorMcsYear)
                    .HasColumnName("doctor_MCS_year")
                    .HasColumnType("date");

                entity.Property(e => e.DoctorName)
                    .HasColumnName("doctor_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorOtherDegrees)
                    .HasColumnName("doctor_other_degrees")
                    .IsUnicode(false);

                entity.Property(e => e.DoctorOtherQualifications)
                    .HasColumnName("doctor_other_qualifications")
                    .IsUnicode(false);

                entity.Property(e => e.DoctorPhdYear)
                    .HasColumnName("doctor_PHD_year")
                    .HasColumnType("date");

                entity.Property(e => e.DoctorPrecense)
                    .HasColumnName("doctor_precense")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorTitle)
                    .HasColumnName("doctor_title")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RecordDate)
                    .HasColumnName("record_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PatientDiagnose>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("patient_diagnose");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.Assistant).IsUnicode(false);

                entity.Property(e => e.ChildPresentation)
                    .HasColumnName("child_Presentation")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ChildState)
                    .HasColumnName("child_state")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Complications).IsUnicode(false);

                entity.Property(e => e.CsIndication)
                    .HasColumnName("cs_indication")
                    .IsUnicode(false);

                entity.Property(e => e.Dynamics).IsUnicode(false);

                entity.Property(e => e.Ga)
                    .HasColumnName("GA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Intervention).IsUnicode(false);

                entity.Property(e => e.Outcome).IsUnicode(false);

                entity.Property(e => e.OutcomeSex)
                    .HasColumnName("Outcome_sex")
                    .IsUnicode(false);

                entity.Property(e => e.OutcomeState)
                    .HasColumnName("Outcome_State")
                    .IsUnicode(false);

                entity.Property(e => e.OutcomeWeight).HasColumnName("Outcome_weight");

                entity.Property(e => e.PositiveDate)
                    .HasColumnName("Positive_date")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Supervisor).IsUnicode(false);

                entity.Property(e => e.Surgeon).IsUnicode(false);
            });

            modelBuilder.Entity<PatientProfile>(entity =>
            {
                entity.HasKey(e => e.Recid);

                entity.ToTable("patient_profile");

                entity.Property(e => e.Recid).HasColumnName("recid");

                entity.Property(e => e.PatientAddress)
                    .HasColumnName("patient_address")
                    .IsUnicode(false);

                entity.Property(e => e.PatientAge).HasColumnName("patient_age");

                entity.Property(e => e.PatientBirthdate)
                    .HasColumnName("patient_birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.PatientContact)
                    .HasColumnName("patient_contact")
                    .IsUnicode(false);

                entity.Property(e => e.PatientEmail)
                    .HasColumnName("patient_email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .IsUnicode(false);

                entity.Property(e => e.PatientImageUrl)
                    .HasColumnName("patient_image_url")
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasColumnName("Patient_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientSex)
                    .HasColumnName("patient_sex")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecDate)
                    .HasColumnName("rec_date")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");
            });
        }
    }
}
