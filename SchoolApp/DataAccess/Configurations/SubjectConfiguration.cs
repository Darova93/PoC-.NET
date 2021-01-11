using System.Data.Entity.ModelConfiguration;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()
        {
            this.ToTable("Subjects");
            this.HasKey(p => p.SubjectId);
            this.Property(p => p.Description).HasMaxLength(50).IsRequired();
            this.Property(p => p.Credits).IsRequired();
            this.Property(p => p.TeacherId).IsRequired();
        }
    }
}
