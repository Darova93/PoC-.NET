using System.Data.Entity.ModelConfiguration;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            this.ToTable("Teachers");
            this.HasKey(p => p.TeacherId);
            this.Property(p => p.Name).HasMaxLength(50).IsRequired();
            this.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            this.Property(p => p.Telephone).HasMaxLength(10).IsRequired();
            this.Property(p => p.Email).HasMaxLength(50).IsRequired();
            this.HasRequired(p => p.Subjects).WithRequiredPrincipal(p => p)
        }
    }
}
