using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Exam
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DepartmentLectures> DepartmentLectures { get; set; }
        public DbSet<StudentLectures> StudentLectures { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=localhost;Database=DbExamLV;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentLectures>()
                .HasKey(dl => new { dl.DepartmentId, dl.LectureId });
            modelBuilder.Entity<StudentLectures>().HasKey(sl => new { sl.StudentId, sl.LectureId });
        }
    }
}
