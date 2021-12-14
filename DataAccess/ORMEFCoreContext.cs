using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ORM_EFcore.Models;

#nullable disable

namespace ORM_EFcore.DataAccess
{
    public partial class ORMEFCoreContext : DbContext
    {
        public ORMEFCoreContext()
        {
        }

        public ORMEFCoreContext(DbContextOptions<ORMEFCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasIndex(e => e.ClassId, "IX_Enrollments_ClassId");

                entity.HasIndex(e => e.StudentId, "IX_Enrollments_StudentId");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.ClassId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Enrollments)
                    .HasForeignKey(d => d.StudentId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
