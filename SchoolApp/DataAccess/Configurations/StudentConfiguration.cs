using System.Data.Entity.ModelConfiguration;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            this.ToTable("Students");
            this.HasKey(p => p.StudentId);
            this.Property(p => p.Name).HasMaxLength(50).IsRequired();
            this.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            this.Property(p => p.Age).IsRequired();
            this.Property(p => p.Email).HasMaxLength(50).IsRequired();
            this.HasMany<Class>(cl => cl.Classes)
                .WithMany(st => st.Students)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentId");
                    cs.MapRightKey("ClassId");
                    cs.ToTable("Assignations");
                });
        }
    }
}
