﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService.CalculatorSoapClient client = new CalculatorService.CalculatorSoapClient();
            Console.WriteLine(client.Add(4, 5));
        }
    }
}
