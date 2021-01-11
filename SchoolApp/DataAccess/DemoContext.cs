using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Configurations;
using DataAccess.Entities;

namespace DataAccess
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("EntityFramework")
        {
            Database.SetInitializer<DemoContext>(new DropCreateDatabaseAlways<DemoContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new TeacherConfiguration());
            modelBuilder.Configurations.Add(new SubjectConfiguration());
            modelBuilder.Configurations.Add(new ClassConfiguration());
        }
    }

    
}
