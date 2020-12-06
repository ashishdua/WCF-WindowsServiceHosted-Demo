﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    [ServiceContract]
    public interface ISampleInterface
    {
        [OperationContract]
        string GetAllEmployees();

        [OperationContract]
        int Subtract(int num1, int num2);

        [OperationContract]
        int Multiply(int num1, int num2);

        [OperationContract]
        double Divide(int num1, int num2);

    }
}
