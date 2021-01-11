using System.Data.Entity.ModelConfiguration;
using DataAccess.Entities;

namespace DataAccess.Configurations
{
    class ClassConfiguration : EntityTypeConfiguration<Class>
    {
        public ClassConfiguration()
        {
            this.ToTable("Classes");
            this.HasKey(p => p.ClassId);
            this.Property(p => p.SubjectId).IsRequired();
            this.Property(p => p.TeacherId).IsRequired();
            this.Property(p => p.Schedule).IsRequired();
        }
    }
}
