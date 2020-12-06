using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace WCFProxy
{
    public class ServerProxy : ClientBase<ISampleInterface>, ISampleInterface
    {
        public string GetAllEmployees()
        {
            return base.Channel.GetAllEmployees();
        }

        public double Divide(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}
