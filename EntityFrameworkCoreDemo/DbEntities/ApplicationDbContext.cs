using EntityFrameworkCoreDemo.DataGenerator;
using EntityFrameworkCoreDemo.Helpers;
using EntityFrameworkCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace EntityFrameworkCoreDemo.DbEntities
{
    public partial class ApplicationDbContext : DbContext
    {
        public DbSet<School> School { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Student> Student { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var school = SchoolGenerator.GetSchool();
            var courses = CourseGenerator.GetCourses().AssignSchool(school);
            var subjects = SubjectGenerator.GetSubjects().AssignCourses(courses);
            var students = StudentGenerator.GetStudents().AssignCourses(courses);

            modelBuilder.Entity<School>().HasData(school);
            modelBuilder.Entity<Course>().HasData(courses.ToArray());
            modelBuilder.Entity<Subject>().HasData(subjects.ToArray());
            modelBuilder.Entity<Student>().HasData(students.ToArray());
        }

    }
}
