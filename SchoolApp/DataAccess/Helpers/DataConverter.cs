using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DTO.DTO;

namespace DataAccess.Helpers
{
    public class DataConverter
    {
        public static Student ConvertStudentDTOtoEntity(StudentDTO DTOObject)
        {
            Student EntityObject = new Student
            {
                StudentId = DTOObject.StudentId,
                Name = DTOObject.Name,
                LastName = DTOObject.LastName,
                Age = DTOObject.Age,
                Email = DTOObject.Email
            };
            return EntityObject;
        }
    }
}
