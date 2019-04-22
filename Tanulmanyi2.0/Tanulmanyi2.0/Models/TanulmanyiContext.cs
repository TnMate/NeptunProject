using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tanulmanyi2._0.Models
{
    public class TanulmanyiContext : DbContext
    {
        public TanulmanyiContext(DbContextOptions<TanulmanyiContext> options)
            : base(options)
        {

        }

        public DbSet<Training> Trainings { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StCourse> StudentCourses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
