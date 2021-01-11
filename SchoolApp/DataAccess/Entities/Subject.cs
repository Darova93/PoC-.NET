using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public int TeacherId { get; set; }
    }
}
