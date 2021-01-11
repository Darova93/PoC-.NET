using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
