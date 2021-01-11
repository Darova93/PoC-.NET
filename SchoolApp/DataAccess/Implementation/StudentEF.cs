using System;
using System.Collections.Generic;
using DataAccess.Entities;
using DTO.DTO;
using Interfaces.Interfaces;
using DataAccess.Helpers;

namespace DataAccess.Implementation
{
    public class StudentEF : IStudentRepository
    {
        public void AddStudent(StudentDTO DTOStudent)
        {
            Student student = DataConverter.ConvertStudentDTOtoEntity(DTOStudent);
            using(var context = new DemoContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<StudentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int StudentCount()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(StudentDTO DTOstudent)
        {
            throw new NotImplementedException();
        }
    }
}
