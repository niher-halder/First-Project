using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmissionTestResultCreatingApp.Model;

namespace AdmissionTestResultCreatingApp.DAL
{
    public class StudentGateWay
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VarAdmissionString"].ConnectionString;
       
        public void Save(Student aStudent)
        {
          SqlConnection connection = new SqlConnection();

          string query = "INSERT INTO tbl_PersonalInfo VALUES('" + aStudent.RollNo + "', '" + aStudent.FullName + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }
    }
}
