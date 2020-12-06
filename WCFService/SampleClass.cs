using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    public class SampleClass : ISampleInterface
    {
        public string GetAllEmployees()
        {
            string result = "Error in getting employee info";

            try
            {

                DBConnection objDBConn = new DBConnection();
                var dbConn = objDBConn.GetDBConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM employee_info", dbConn);

                DataSet dsResult = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dsResult);
                }

                if (dsResult != null && dsResult.Tables != null && dsResult.Tables.Count > 0)
                {
                    result = JsonConvert.SerializeObject(dsResult);

                    return JsonConvert.SerializeObject(dsResult);
                }

                
            }
            catch (Exception ex)
            {

                result = ex.ToString();
            }

            return result;
        }
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public double Divide(int num1, int num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                return 0;
        }
    }
}
