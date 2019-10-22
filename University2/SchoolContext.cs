using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using University2.Models;

namespace University2
{
    public class SchoolContext : DbContext
    {

        public SchoolContext(): base ("name = MyContextDB"){ }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments  { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        //Este con courses porque tiene relacion con courses
        public DbSet<Instructor> Instructors { get; set; }

        //Este no
        public DbSet<Student> Students { get; set; }

        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Person> People { get; set; }

    }
}