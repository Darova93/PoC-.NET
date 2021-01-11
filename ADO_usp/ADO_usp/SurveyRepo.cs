using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_usp
{
    public class SurveyRepo
    {
        public List<QuestionResult> Report(int id)
        {
            List<QuestionResult> resultlist = new List<QuestionResult>();
            string connstring = "Server = DAVID; Initial Catalog = Final; Integrated Security = true";


            SqlConnection connstringobj = new SqlConnection(connstring);
            SqlCommand command = new SqlCommand("dbo.usp_SurveyResults", connstringobj);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@surveyId", SqlDbType.Int).Value = id;

            connstringobj.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                resultlist.Add(new QuestionResult
                {
                    Text = reader["Question"].ToString(),
                    Average = (int)reader["Average"]
                });
            }
            connstringobj.Close();

            return resultlist;
        }
    }
}
