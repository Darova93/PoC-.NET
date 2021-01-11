using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Implementation;
using DTO.DTO;
using Interfaces.Interfaces;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository studentRepository = new StudentEF();

            studentRepository.AddStudent(new StudentDTO { Name = "Pedro", LastName = "Juarez", Age = 20, Email = "pedro@gmail.com" });
        }
    }
}
