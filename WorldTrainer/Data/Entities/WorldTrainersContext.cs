using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Entities
{
    public partial class WorldTrainersContext : DbContext
    {
        public WorldTrainersContext()
        {
        }

        public WorldTrainersContext(DbContextOptions<WorldTrainersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TechSkill> TechSkills { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<TrainerExperience> TrainerExperiences { get; set; }
        public virtual DbSet<TrainerQualification> TrainerQualifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = tcp:adaabeautyserver.database.windows.net,1433; Initial Catalog = WorldTrainers; Persist Security Info=False; User ID = shruti; Password =Myazuregayle28!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TechSkill>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__TechSkil__DFA09187775CA177");

                entity.Property(e => e.TechSkill_1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TechSkill_1");


                entity.Property(e => e.TrainerId).HasColumnName("trainerId");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("Trainer");

                entity.Property(e => e.TrainerId).HasColumnName("trainerId");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrainerAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trainerAddress");

                entity.Property(e => e.TrainerEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trainerEmail");

                entity.Property(e => e.TrainerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trainerName");

                entity.Property(e => e.TrainerPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trainerPassword");

                entity.Property(e => e.TrainerPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trainerPhone");
            });

            modelBuilder.Entity<TrainerExperience>(entity =>
            {
                entity.HasKey(e => e.ExperienceId)
                    .HasName("PK__TrainerE__2F4E344989933463");

                entity.ToTable("TrainerExperience");

                entity.Property(e => e.ExperienceLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExperiencePosition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExperienceTechnology)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrainerId).HasColumnName("trainerId");
            });

            modelBuilder.Entity<TrainerQualification>(entity =>
            {
                entity.HasKey(e => e.QualificationId)
                    .HasName("PK__TrainerQ__C95C12AA774C8A39");

                entity.Property(e => e.ExtraCertifications)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GraduatedIn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GraduatedIN");

                entity.Property(e => e.HighSchoolGrade)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JrcollegeGrade)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("JRcollegeGrade");

                entity.Property(e => e.TrainerId).HasColumnName("trainerId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
