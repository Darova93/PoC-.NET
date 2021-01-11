using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_usp
{
    class Program
    {
        static void Main(string[] args)
        {

            int elquequiero = 1;

            var reult = SurveyRepo.Report(elquequiero);

        }
    }
}
