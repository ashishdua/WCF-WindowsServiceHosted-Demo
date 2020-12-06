using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    public class DBConnection
    {
        public SqlConnection GetDBConnection ()
        {
            SqlConnection dbConn = new SqlConnection();
            dbConn.ConnectionString = "Data Source=localhost;Initial Catalog=Employee;Integrated Security=True";
            dbConn.Open();

            return dbConn;
        }
        
    }
}
