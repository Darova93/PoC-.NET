using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Class
    {
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public string Schedule { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
