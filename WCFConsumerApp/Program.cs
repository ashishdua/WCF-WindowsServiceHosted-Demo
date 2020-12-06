using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFProxy;

namespace WCFConsumerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServerProxy proxy = new ServerProxy();
            Console.WriteLine(proxy.GetAllEmployees());

            Console.ReadLine();
        }
    }
}

