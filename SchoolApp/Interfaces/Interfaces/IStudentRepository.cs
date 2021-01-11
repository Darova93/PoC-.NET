using System.Collections.Generic;
using DTO.DTO;

namespace Interfaces.Interfaces
{
    public interface IStudentRepository
    {
        void AddStudent(StudentDTO DTOStudent);
        void DeleteStudent(int id);
        void UpdateStudent(StudentDTO DTOstudent);
        int StudentCount();
        List<StudentDTO> GetAll();
        StudentDTO GetById(int id);
    }
}
