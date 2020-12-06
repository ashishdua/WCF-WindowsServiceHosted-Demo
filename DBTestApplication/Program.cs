using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace DBTestApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            var dbConn = GetDBConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM employee_info", dbConn);
            DataSet dsResult = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dsResult);
            }

            using (SqlDataReader reader = command.ExecuteReader())
            {
                dbConn.Close();
                dbConn.Dispose();

                foreach (var read in reader)
                {

                }
            }
        }

        public static SqlConnection GetDBConnection()
        {

            SqlConnection dbConn = new SqlConnection();
   
                dbConn.ConnectionString = "Data Source=localhost;Initial Catalog=Employee;Integrated Security=True";
                dbConn.Open();

                return dbConn;
            
        }
    }
}
