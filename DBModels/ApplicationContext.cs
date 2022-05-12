using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CI_CD_App.DBModels
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEmployees> TblEmployees { get; set; }
        public virtual DbSet<TblSkills> TblSkills { get; set; }
        public virtual DbSet<TestTable> TestTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-UM0B5HOM;Database=DemoCICD;MultipleActiveResultSets=true;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblEmployees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__tblEmplo__7AD04FF1C9FBE35E");

                entity.ToTable("tblEmployees");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SkillId).HasColumnName("SkillID");
            });

            modelBuilder.Entity<TblSkills>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__tblSkill__DFA091E788F6B033");

                entity.ToTable("tblSkills");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testTable");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Test)
                    .HasColumnName("test")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
